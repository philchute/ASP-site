// using ASP_site.GameServerListCommon.External; // Removed - Namespace no longer exists
using ASP_site.GameServerListCommon.Model;
using ASP_site.GameServerListCommon.Model.A2S;
using ASP_site.GameServerListCommon.Model.Steam;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Concurrent;
using System.Net;
using ASP_site.Helpers;
using Microsoft.Extensions.Logging;
using System.Net.Http;
// using System.Text.Json; // Removed - Causes ambiguity

namespace ASP_site.GameServerListCommon.Services;

public class SteamServerBrowserApiService
{
    private readonly HttpClient _httpClient;
    private readonly IMemoryCache _cache;
    private readonly IConfiguration _config;
    private readonly ILogger<SteamServerBrowserApiService> _logger;
    private readonly IServerBlacklistService _blacklistService;
    private readonly string _apiKey;
    private readonly int _querySize;
    private readonly TimeSpan _serverListCacheDuration;
    private readonly JsonSerializerSettings _jsonSerializerSettings;

    public SteamServerBrowserApiService(IConfiguration config, IMemoryCache memoryCache, IHttpClientFactory httpClientFactory, ILogger<SteamServerBrowserApiService> logger, IServerBlacklistService blacklistService)
    {
        _config = config;
        _cache = memoryCache;
        _logger = logger;
        _blacklistService = blacklistService;

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

        // Read cache duration from config, default to 2 minutes
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
        if (game is null)
            return [];

        var key = $"Servers-{game.AppId}-{game.Name}".ToUpper();

        return await _cache.GetOrCreateAsync(key, async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = _serverListCacheDuration;
            _logger.LogDebug($"Cache miss for {key}. Fetching servers with cache duration: {_serverListCacheDuration.TotalMinutes} mins.");

            List<GameServerItem> servers = [];
            try
            {
                if (game.UseDefinedServerList ?? false)
                {
                    _logger.LogInformation($"Game {game.Name} uses defined server list. Querying via A2S...");
                    servers = await QueryServerListByAddress(game, game.Servers ?? [], 1500);
                }
                else if (game.MasterServer.HasValue)
                {
                    _logger.LogInformation($"Game {game.Name} uses master server {game.MasterServer}. Querying master list via A2S...");
                    var masterList = await A2SQuery.QueryServerList(game.MasterServer.Value, game);
                    var addresses = masterList.Select(s => $"{s.Address}:{s.Port}").ToList();
                    servers = await QueryServerListByAddress(game, addresses, 1500);
                }
                else
                {
                    _logger.LogInformation($"Game {game.Name} uses Steam Web API. Fetching...");
                    var gamedirFilter = string.IsNullOrEmpty(game.Gamedir) ? string.Empty : $"\\gamedir\\{game.Gamedir}";
                    var filters = $"\\appid\\{game.AppId}{gamedirFilter}{game.Filters ?? string.Empty}";
                    var apiUrl = $"IGameServersService/GetServerList/v1/?key={_apiKey}&limit={_querySize}&filter={filters}";

                    servers = await FetchAndMapSteamApiServers(apiUrl, game);
                }

                // Apply blacklist filtering before caching
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

                    // Apply game-specific filtering rules
                    int countBeforeGameSpecificFilter = servers.Count;
                    // Check for GoldSrc games (either by MasterServerType or specific AppId for CS 1.6)
                    if (game.MasterServer == MasterServerType.GoldSource || game.AppId == 10) // CS 1.6 AppId is 10
                    {
                        // GoldSrc: MaxPlayers cannot exceed 32
                        servers = servers.Where(s => s.MaxPlayers <= 32).ToList();
                        _logger.LogDebug($"Applied GoldSrc MaxPlayers filter for {game.Name}.");
                    }
                    // Check for CS2 (ensure it's not also caught by a potential GoldSource designation if AppId 730 were ever miscategorized)
                    // Using else if ensures these conditions are mutually exclusive for a single server list processing pass if a game somehow matched both.
                    else if (game.AppId == 730) // CS2 AppId
                    {
                        // CS2: Filter out servers with "graphics_settings" map
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
                    ServerType = apiServer.Dedicated ? Model.A2S.ServerType.Dedicated : Model.A2S.ServerType.Listen,
                    Environment = apiServer.OS.ToLowerInvariant() switch
                    {
                        "w" => Model.A2S.Environment.Windows,
                        "l" => Model.A2S.Environment.Linux,
                        "m" or "o" => Model.A2S.Environment.Mac,
                        _ => Model.A2S.Environment.Linux
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
        catch (Newtonsoft.Json.JsonException ex)
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
        if (server is null)
            return false;

        if (server.MaxPlayers > 128 || server.MaxPlayers <= 1 || server.Players > server.MaxPlayers)
            return false;

        if (game.MasterServer.HasValue && game.MasterServer.Value == MasterServerType.GoldSource && (server.Version == null || !server.Version.EndsWith("/Stdio")))
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

                ServerInfo? serverInfo = await A2SQuery.QueryServerInfo(address, timeout);

                if (IsServerValid(game, serverInfo))
                {
                    items.Add(serverInfo!.MapToGameServerItem(game, ip, port));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error querying individual A2S server: {address}");
            }
        });
        return items.ToList();
    }
} 