using ASP_site.Models;
using ASP_site.Models.ServerBrowser;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

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
    }

    public class ThreeNetworksQuery
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ThreeNetworksQuery> _logger;

        public ThreeNetworksQuery(IHttpClientFactory httpClientFactory, ILogger<ThreeNetworksQuery> logger)
        {
            _httpClient = httpClientFactory.CreateClient("ThreeNetworks");
            _logger = logger;
        }

        public async Task<List<GameServerItem>> QueryServerList(Game game)
        {
            var serverList = new List<GameServerItem>();
            var gameName = game.GameID;
            var requestUrl = $"https://master.333networks.com/json/{gameName}?r=1000";

            try
            {
                _logger.LogInformation($"Querying 333networks API for {gameName} at {requestUrl}");
                var response = await _httpClient.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                
                var jsonArray = JArray.Parse(content);
                if (jsonArray == null || !jsonArray.HasValues)
                {
                    _logger.LogWarning($"333networks API returned no data for {gameName}.");
                    return serverList;
                }
                
                var servers = jsonArray[0].ToObject<List<ThreeNetworksServer>>();

                if (servers != null)
                {
                    foreach (var server in servers)
                    {
                        if (IPAddress.TryParse(server.Ip.Replace("::ffff:", ""), out var ipAddress))
                        {
                            serverList.Add(new GameServerItem(ipAddress, server.Hostport, game)
                            {
                                Name = server.Hostname,
                                Map = server.Mapname,
                                Players = server.Numplayers,
                                MaxPlayers = server.Maxplayers,
                                Version = server.Gamever
                            });
                        }
                    }
                }
                _logger.LogInformation($"Successfully parsed {serverList.Count} servers for {gameName} from 333networks API.");
            }
            catch (HttpRequestException e)
            {
                _logger.LogError(e, $"Error querying 333networks API for {gameName}.");
            }
            catch (JsonException e)
            {
                _logger.LogError(e, $"Error parsing JSON response from 333networks API for {gameName}.");
            }

            return serverList;
        }
    }
} 