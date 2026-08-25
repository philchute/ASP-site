using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASP_site.Models;
using ASP_site.Helpers;
using ASP_site.Services;
using ASP_site.Models.ServerBrowser;
using Microsoft.Extensions.Logging;

namespace ASP_site.Pages.Servers
{
    public class IndexModel : PageModel
    {
        private readonly ServerBrowserService _serverBrowserService;
        private readonly IGameDataService _gameDataService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            ServerBrowserService serverBrowserService,
            IGameDataService gameDataService,
            ILogger<IndexModel> logger
            )
        {
            _serverBrowserService = serverBrowserService;
            _gameDataService = gameDataService;
            _logger = logger;
            GamesList = new List<Game>();
        }

        public List<Game> GamesList { get; set; }
        public Game? SelectedGame { get; set; }
        public bool IsLoading { get; set; }
        public string? ErrorMessage { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? GameId { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortBy { get; set; } = "players";

        [BindProperty(SupportsGet = true)]
        public string VacFilter { get; set; } = "all";

        [BindProperty(SupportsGet = true)]
        public string PopulationFilter { get; set; } = "all";

        [BindProperty(SupportsGet = true)]
        public string PasswordFilter { get; set; } = "all";

        public async Task OnGetAsync()
        {
            ViewData["ActivePage"] = "Servers";
            await _gameDataService.InitializeAsync();
            GamesList = _gameDataService.GetGames().OrderBy(g => g.Name).ToList();

            if (!string.IsNullOrEmpty(GameId))
            {
                SelectedGame = _gameDataService.GetGameById(GameId);
                if (SelectedGame == null)
                {
                    ErrorMessage = $"Selected game with ID '{GameId}' not found.";
                }
                else
                {
                    IsLoading = true;
                }
            }
        }

        public async Task<IActionResult> OnGetListAsync()
        {
            await _gameDataService.InitializeAsync();
            if (string.IsNullOrEmpty(GameId))
            {
                return JsonError("No game selected.");
            }

            var game = _gameDataService.GetGameById(GameId);
            if (game == null)
            {
                return JsonError($"Selected game with ID '{GameId}' not found.");
            }

            try
            {
                var rawServerList = await _serverBrowserService.FetchServers(game);
                if (rawServerList == null)
                {
                    return JsonError($"Could not fetch server list for {game.Name}. The game server browser service might be unavailable or the game might not be supported correctly.");
                }

                var filtered = ApplyFiltersAndSort(rawServerList);
                return new JsonResult(new
                {
                    gameName = game.Name,
                    servers = filtered.Select(s => new ServerListDto
                    {
                        Name = s.Name,
                        Map = s.Map,
                        PlayersStr = s.PlayersStr,
                        IpPort = $"{s.Address}:{s.Port}",
                        Environment = s.Environment.ToString(),
                        ServerType = s.ServerType.ToString(),
                        RequiresVAC = s.RequiresVAC,
                        PasswordProtected = s.PasswordProtected
                    }).ToList()
                }, new System.Text.Json.JsonSerializerOptions { PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching server list for {GameId}", GameId);
                return JsonError("An error occurred while trying to load server data. Please try again later.");
            }
        }

        private List<GameServerItem> ApplyFiltersAndSort(IEnumerable<GameServerItem> rawServerList)
        {
            IEnumerable<GameServerItem> filteredList = rawServerList;

            if (VacFilter == "yes")
                filteredList = filteredList.Where(s => s.RequiresVAC == true);
            else if (VacFilter == "no")
                filteredList = filteredList.Where(s => s.RequiresVAC == false);

            if (PopulationFilter == "hide_empty")
                filteredList = filteredList.Where(s => s.Players > 0);
            else if (PopulationFilter == "hide_full")
                filteredList = filteredList.Where(s => s.Players < s.MaxPlayers);

            if (PasswordFilter == "yes")
                filteredList = filteredList.Where(s => s.PasswordProtected == true);
            else if (PasswordFilter == "no")
                filteredList = filteredList.Where(s => s.PasswordProtected == false);

            filteredList = SortBy?.ToLowerInvariant() switch
            {
                "name" => filteredList.OrderBy(s => s.Name),
                "map" => filteredList.OrderBy(s => s.Map).ThenByDescending(s => s.Players),
                _ => filteredList.OrderByDescending(s => s.Players).ThenBy(s => s.Name)
            };

            return filteredList.ToList();
        }

        private JsonResult JsonError(string message)
        {
            return new JsonResult(new { error = message, servers = Array.Empty<ServerListDto>() },
                new System.Text.Json.JsonSerializerOptions { PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase });
        }

        public class ServerListDto
        {
            public string Name { get; set; } = "";
            public string Map { get; set; } = "";
            public string PlayersStr { get; set; } = "";
            public string IpPort { get; set; } = "";
            public string Environment { get; set; } = "";
            public string ServerType { get; set; } = "";
            public bool? RequiresVAC { get; set; }
            public bool? PasswordProtected { get; set; }
        }
    }
}
