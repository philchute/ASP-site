using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            GameSelectItems = new List<SelectListItem>();
        }

        public List<Game> GamesList { get; set; }
        public List<SelectListItem> GameSelectItems { get; set; }
        public Game? SelectedGame { get; set; }
        public ServerBrowserColumns Columns { get; set; } = new();
        public bool IsLoading { get; set; }
        public string? ErrorMessage { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? GameId { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortBy { get; set; } = "players";

        [BindProperty(SupportsGet = true)]
        public string VacFilter { get; set; } = "all";

        [BindProperty(SupportsGet = true)]
        public bool HideEmpty { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool HideFull { get; set; }

        [BindProperty(SupportsGet = true)]
        public string PasswordFilter { get; set; } = "all";

        public async Task OnGetAsync()
        {
            ViewData["ActivePage"] = "Servers";
            await _gameDataService.InitializeAsync();
            GamesList = _gameDataService.GetGames().OrderBy(g => g.Name).ToList();
            GameSelectItems = BuildGameSelectItems(GamesList);

            if (!string.IsNullOrEmpty(GameId))
            {
                SelectedGame = _gameDataService.GetGameById(GameId);
                if (SelectedGame == null)
                {
                    ErrorMessage = $"Selected game with ID '{GameId}' not found.";
                }
                else
                {
                    Columns = ServerBrowserUi.Columns(SelectedGame);
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

                var columns = ServerBrowserUi.Columns(game);
                return new JsonResult(new
                {
                    gameName = game.Name,
                    columns,
                    servers = rawServerList.Select(s => ToDto(s, game)).ToList()
                }, new System.Text.Json.JsonSerializerOptions { PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching server list for {GameId}", GameId);
                return JsonError("An error occurred while trying to load server data. Please try again later.");
            }
        }

        public static List<SelectListItem> BuildGameSelectItems(IEnumerable<Game> games)
        {
            return games
                .OrderBy(g => g.Name, StringComparer.OrdinalIgnoreCase)
                .Select(g => new SelectListItem
                {
                    Value = g.GameID,
                    Text = ServerBrowserUi.SelectLabel(g)
                })
                .ToList();
        }

        public static ServerListDto ToDto(GameServerItem s, Game game)
        {
            var ipPort = $"{s.Address}:{s.Port}";
            return new ServerListDto
            {
                Name = s.Name,
                Map = s.Map,
                Players = s.Players,
                MaxPlayers = s.MaxPlayers,
                PlayersStr = s.PlayersStr,
                IpPort = ipPort,
                Environment = s.Environment.ToString(),
                ServerType = s.ServerType.ToString(),
                RequiresVAC = s.RequiresVAC,
                PasswordProtected = s.PasswordProtected,
                GameType = s.GameType,
                Country = s.Country,
                ConnectCommand = ServerBrowserUi.ConnectCommand(game, ipPort),
                SteamConnectUrl = ServerBrowserUi.SteamConnectUrl(game, ipPort)
            };
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
            public int Players { get; set; }
            public int MaxPlayers { get; set; }
            public string PlayersStr { get; set; } = "";
            public string IpPort { get; set; } = "";
            public string Environment { get; set; } = "";
            public string ServerType { get; set; } = "";
            public bool? RequiresVAC { get; set; }
            public bool? PasswordProtected { get; set; }
            public string? GameType { get; set; }
            public string? Country { get; set; }
            public string ConnectCommand { get; set; } = "";
            public string? SteamConnectUrl { get; set; }
        }
    }
}
