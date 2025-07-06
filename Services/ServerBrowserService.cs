using ASP_site.Helpers;
using ASP_site.Models;
using ASP_site.Models.ServerBrowser;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Http;

namespace ASP_site.Services
{
    public class ServerBrowserService
    {
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _cache;
        private readonly IConfiguration _config;
        private readonly ILogger<ServerBrowserService> _logger;
        private readonly IServerBlacklistService _blacklistService;
        private readonly MasterServerSettings _masterServerSettings;
        private readonly ThreeNetworksQuery _threeNetworksQuery;
        private readonly string _apiKey;
        private readonly int _querySize;
        private readonly TimeSpan _serverListCacheDuration;
        private readonly JsonSerializerSettings _jsonSerializerSettings;

        public ServerBrowserService(IConfiguration config, IMemoryCache memoryCache, IHttpClientFactory httpClientFactory, ILogger<ServerBrowserService> logger, IServerBlacklistService blacklistService, IOptions<MasterServerSettings> masterServerSettings, ThreeNetworksQuery threeNetworksQuery)
        {
            _config = config;
            _cache = memoryCache;
            _logger = logger;
            _blacklistService = blacklistService;
            _masterServerSettings = masterServerSettings.Value;
            _threeNetworksQuery = threeNetworksQuery;

            _httpClient = httpClientFactory.CreateClient();
            var steamApiUrl = _config["SteamSettings:Url"];
            if (!string.IsNullOrEmpty(steamApiUrl))
            {
                _httpClient.BaseAddress = new Uri(steamApiUrl);
            }

            _apiKey = _config["SteamSettings:ApiKey"] ?? throw new InvalidOperationException("Steam API Key not configured in SteamSettings:ApiKey");
            if (_apiKey == "YOUR_API_KEY" || string.IsNullOrWhiteSpace(_apiKey))
            {
                _logger.LogWarning("Steam API Key is not set or is using the default placeholder. Steam Web API calls will fail.");
            }
            _querySize = int.TryParse(_config["QuerySize"], out var size) ? size : 5000;

            _serverListCacheDuration = TimeSpan.FromMinutes(int.TryParse(_config["SteamListCacheMinutes"], out var minutes) && minutes > 0 ? minutes : 2);
            _logger.LogInformation($"Server list cache duration set to: {_serverListCacheDuration.TotalMinutes} minutes.");

            _jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
            };
        }

        public async Task<List<GameServerItem>> FetchServers(Game? game)
        {
            if (game?.ServerConfig is null)
                return [];

            var key = $"Servers-{game.SteamID}-{game.Name}".ToUpper();

            return await _cache.GetOrCreateAsync(key, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = _serverListCacheDuration;
                _logger.LogDebug($"Cache miss for {key}. Fetching servers with cache duration: {_serverListCacheDuration.TotalMinutes} mins.");

                List<GameServerItem> servers = [];
                try
                {
                    if ((game.ServerConfig.UseDefinedServerList ?? false) && game.Servers != null && game.Servers.Any())
                    {
                        _logger.LogInformation($"Game {game.Name} uses defined server list...");
                        var serverAddresses = (game.Servers ?? []).Select(s => s.IPAddress).ToList();
                        servers = await QueryServerListByAddress(game, serverAddresses, 1500);
                    }
                    else if (!string.IsNullOrEmpty(game.ServerConfig.MasterServerKey) && _masterServerSettings.Servers.TryGetValue(game.ServerConfig.MasterServerKey, out var masterServer))
                    {
                        _logger.LogInformation($"Game '{game.Name}' uses master server key '{game.ServerConfig.MasterServerKey}' -> {masterServer.Address} ({masterServer.Protocol})");

                        if (masterServer.Protocol == "A2S")
                        {
                            var masterEndpoint = GetIPEndPoint(masterServer.Address);
                            if (masterEndpoint is not null)
                            {
                                var masterList = await A2SQuery.QueryServerList(masterEndpoint, game);
                                var addresses = masterList.Select(s => $"{s.Address}:{s.Port}").ToList();
                                servers = await QueryServerListByAddress(game, addresses, 1500);
                            }
                        }
                        else if (masterServer.Protocol == "ThreeNetworksAPI")
                        {
                            servers = await _threeNetworksQuery.QueryServerList(game);
                        }
                    }
                    else
                    {
                        _logger.LogInformation($"Game {game.Name} uses Steam Web API. Fetching...");
                        var gamedirFilter = string.IsNullOrEmpty(game.ServerConfig.GameDirectory) ? string.Empty : $"\\gamedir\\{game.ServerConfig.GameDirectory}";
                        var filters = $"\\appid\\{game.SteamID}{gamedirFilter}{game.ServerConfig.ApiFilters ?? string.Empty}";
                        var apiUrl = $"IGameServersService/GetServerList/v1/?key={_apiKey}&limit={_querySize}&filter={filters}";

                        servers = await FetchAndMapSteamApiServers(apiUrl, game);
                    }

                    if (servers.Any())
                    {
                        var blacklistedIps = await _blacklistService.GetBlacklistedIpsAsync();
                        if (blacklistedIps.Any())
                        {
                            int originalCount = servers.Count;
                            servers = servers.Where(s => s.Address != null && !blacklistedIps.Contains(s.Address.ToString())).ToList();
                            int removedCount = originalCount - servers.Count;
                            if (removedCount > 0)
                            {
                                _logger.LogInformation($"Filtered out {removedCount} servers based on IP blacklist for game {game.Name}.");
                            }
                        }

                        int countBeforeGameSpecificFilter = servers.Count;
                        if ((!string.IsNullOrEmpty(game.ServerConfig.MasterServerKey) && game.ServerConfig.MasterServerKey == "GoldSource") || game.SteamID == 10)
                        {
                            servers = servers.Where(s => s.MaxPlayers <= 32).ToList();
                            _logger.LogDebug($"Applied GoldSrc MaxPlayers filter for {game.Name}.");
                        }
                        else if (game.SteamID == 730)
                        {
                            servers = servers.Where(s => !string.Equals(s.Map, "graphics_settings", StringComparison.OrdinalIgnoreCase)).ToList();
                            _logger.LogDebug($"Applied CS2 map filter for {game.Name}.");
                        }
                        int removedByGameSpecificFilter = countBeforeGameSpecificFilter - servers.Count;
                        if (removedByGameSpecificFilter > 0)
                        {
                            _logger.LogInformation($"Filtered out {removedByGameSpecificFilter} servers based on game-specific rules for {game.Name}.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Failed to fetch servers for game {game.Name} ({key})");
                    entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(15);
                    return [];
                }

                _logger.LogDebug($"Successfully fetched {servers.Count} servers for {key}.");
                return servers;
            }) ?? [];
        }

        private async Task<List<GameServerItem>> FetchAndMapSteamApiServers(string url, Game gameContext)
        {
            try
            {
                _logger.LogDebug($"Fetching Steam API URL: {url}");
                if (_httpClient.BaseAddress == null && !Uri.TryCreate(url, UriKind.Absolute, out _))
                {
                    throw new InvalidOperationException("HttpClient BaseAddress is not set and URL is relative.");
                }

                using var request = new HttpRequestMessage(HttpMethod.Get, url);
                using var response = await _httpClient.SendAsync(request);

                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();

                var apiResponse = JsonConvert.DeserializeObject<SteamApiServerListResponse>(jsonResponse, _jsonSerializerSettings);

                if (apiResponse?.Response?.Servers == null)
                {
                    _logger.LogWarning($"Steam API response for {url} did not contain a server list.");
                    return [];
                }

                var mappedServers = new List<GameServerItem>();
                foreach (var apiServer in apiResponse.Response.Servers)
                {
                    var ip = apiServer.GetIPAddress();
                    if (ip == null) continue;

                    var gameServer = new GameServerItem(ip, apiServer.GamePort, gameContext)
                    {
                        Name = apiServer.Name,
                        Map = apiServer.Map,
                        Players = apiServer.Players,
                        MaxPlayers = apiServer.MaxPlayers,
                        Bots = apiServer.Bots,
                        RequiresVAC = apiServer.Secure,
                        PasswordProtected = !apiServer.Dedicated,
                        Version = apiServer.Version,
                        ServerType = apiServer.Dedicated ? Models.ServerBrowser.ServerType.Dedicated : Models.ServerBrowser.ServerType.Listen,
                        Environment = apiServer.OS.ToLowerInvariant() switch
                        {
                            "w" => Models.ServerBrowser.Environment.Windows,
                            "l" => Models.ServerBrowser.Environment.Linux,
                            "m" or "o" => Models.ServerBrowser.Environment.Mac,
                            _ => Models.ServerBrowser.Environment.Linux
                        }
                    };
                    mappedServers.Add(gameServer);
                }
                _logger.LogDebug($"Mapped {mappedServers.Count} servers from Steam API response for {url}.");
                return mappedServers;
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, $"HTTP error fetching from Steam API ({url})");
                return [];
            }
            catch (JsonException ex)
            {
                _logger.LogError(ex, $"JSON error parsing Steam API response ({url})");
                return [];
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Generic error fetching/mapping Steam API servers ({url})");
                return [];
            }
        }

        private static bool IsServerValid(Game game, ServerInfo? server)
        {
            if (server is null || game.ServerConfig is null)
                return false;

            if (server.MaxPlayers > 128 || server.MaxPlayers <= 1 || server.Players > server.MaxPlayers)
                return false;

            if ((!string.IsNullOrEmpty(game.ServerConfig?.MasterServerKey) && game.ServerConfig.MasterServerKey == "GoldSource") && (server.Version == null || !server.Version.EndsWith("/Stdio")))
                return false;

            return true;
        }

        private async Task<List<GameServerItem>> QueryServerListByAddress(Game game, List<string> addresses, int timeout = 1500)
        {
            var items = new ConcurrentBag<GameServerItem>();
            var options = new ParallelOptions { MaxDegreeOfParallelism = System.Environment.ProcessorCount };

            await Parallel.ForEachAsync(addresses, options, async (address, cancellationToken) =>
            {
                try
                {
                    var parts = address.Split(':');
                    if (parts.Length != 2 || !IPAddress.TryParse(parts[0], out var ip) || !ushort.TryParse(parts[1], out var port))
                    {
                        _logger.LogWarning($"Skipping invalid address format in list: {address}");
                        return;
                    }

                    GameServerItem? serverItem = null;

                    switch (game.ServerConfig.QueryProtocol)
                    {
                        case "A2S":
                            var a2sServerInfo = await A2SQuery.QueryServerInfo(address, timeout);
                            if (IsServerValid(game, a2sServerInfo))
                            {
                                serverItem = a2sServerInfo!.MapToGameServerItem(game, ip, port);
                            }
                            break;
                    }

                    if (serverItem != null)
                    {
                        items.Add(serverItem);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Error querying individual server: {address}");
                }
            });
            return items.ToList();
        }

        private static IPEndPoint? GetIPEndPoint(string address)
        {
            var items = address.Split(':');
            if (items.Length != 2)
            {
                return null;
            }

            if (!IPAddress.TryParse(items[0], out var ip) || !ushort.TryParse(items[1], out var port))
            {
                return null;
            }

            return new IPEndPoint(ip, port);
        }
    }
}