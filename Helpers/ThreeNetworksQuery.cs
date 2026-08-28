using ASP_site.Models;
using ASP_site.Models.ServerBrowser;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace ASP_site.Helpers
{
    public class ThreeNetworksServer
    {
        public string? Ip { get; set; }
        public ushort Hostport { get; set; }
        public string? Hostname { get; set; }
        public string? Mapname { get; set; }
        public int Numplayers { get; set; }
        public int Maxplayers { get; set; }
        public string? Gamever { get; set; }
        public string? Gametype { get; set; }
        public string? Country { get; set; }
        public string? Maptitle { get; set; }
    }

    public class ThreeNetworksListResult
    {
        public List<GameServerItem> Servers { get; init; } = [];
        public int Total { get; init; }
    }

    public class ThreeNetworksQuery
    {
        public const int PageSize = 1000;

        private readonly HttpClient _httpClient;
        private readonly ILogger<ThreeNetworksQuery> _logger;

        public ThreeNetworksQuery(IHttpClientFactory httpClientFactory, ILogger<ThreeNetworksQuery> logger)
        {
            _httpClient = httpClientFactory.CreateClient("ThreeNetworks");
            _logger = logger;
        }

        public async Task<List<GameServerItem>> QueryServerList(Game game)
        {
            var slug = game.ServerConfig?.GetMasterGameName(game.GameID) ?? game.GameID;
            var allServers = new List<GameServerItem>();
            var total = int.MaxValue;

            for (var page = 1; allServers.Count < total; page++)
            {
                var requestUrl = $"json/{slug}?r={PageSize}&p={page}";
                try
                {
                    _logger.LogInformation("Querying 333networks API for {Game} page {Page} at {Url}", slug, page, requestUrl);
                    var response = await _httpClient.GetAsync(requestUrl);
                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();
                    var parsed = ParseResponse(content, game);
                    if (parsed.Servers.Count == 0)
                        break;

                    total = parsed.Total > 0 ? parsed.Total : parsed.Servers.Count;
                    allServers.AddRange(parsed.Servers);
                    if (parsed.Servers.Count < PageSize)
                        break;
                }
                catch (HttpRequestException e)
                {
                    _logger.LogError(e, "Error querying 333networks API for {Game}.", slug);
                    break;
                }
                catch (JsonException e)
                {
                    _logger.LogError(e, "Error parsing JSON response from 333networks API for {Game}.", slug);
                    break;
                }
            }

            _logger.LogInformation("Parsed {Count} servers for {Game} from 333networks API.", allServers.Count, slug);
            return allServers;
        }

        public static ThreeNetworksListResult ParseResponse(string json, Game game)
        {
            var jsonArray = JArray.Parse(json);
            if (jsonArray == null || !jsonArray.HasValues)
            {
                return new ThreeNetworksListResult();
            }

            var servers = jsonArray[0].ToObject<List<ThreeNetworksServer>>() ?? [];
            var total = servers.Count;
            if (jsonArray.Count > 1 && jsonArray[1] is JObject meta && meta["total"] != null)
            {
                total = meta.Value<int>("total");
            }

            var serverList = new List<GameServerItem>();
            foreach (var server in servers)
            {
                var mapped = MapServer(server, game);
                if (mapped != null)
                    serverList.Add(mapped);
            }

            return new ThreeNetworksListResult { Servers = serverList, Total = total };
        }

        public static GameServerItem? MapServer(ThreeNetworksServer server, Game game)
        {
            if (server.Ip == null || !IPAddress.TryParse(server.Ip.Replace("::ffff:", ""), out var ipAddress))
                return null;

            var map = server.Mapname ?? "Unknown Map";
            if (!string.IsNullOrWhiteSpace(server.Maptitle) &&
                !string.Equals(server.Maptitle, map, StringComparison.OrdinalIgnoreCase))
            {
                map = $"{map} ({server.Maptitle})";
            }

            return new GameServerItem(ipAddress, server.Hostport, game)
            {
                Name = server.Hostname ?? "Unknown Server",
                Map = map,
                Players = server.Numplayers,
                MaxPlayers = server.Maxplayers,
                Version = server.Gamever ?? "Unknown",
                GameType = server.Gametype,
                Country = server.Country
            };
        }
    }
}
