using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using ASP_site.Data;
using ASP_site.GameServerListCommon.Model;
using ASP_site.Helpers;
using ASP_site.GameServerListCommon.Services;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ASP_site.Pages.Servers
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IGameDataService _gameDataService;
        private readonly SteamServerBrowserApiService _serverBrowserService;
        // Optional: Inject player detail service if needed later
        // private readonly SteamPlayerDetailApiService _playerDetailService;

        public IndexModel(
            ILogger<IndexModel> logger,
            IGameDataService gameDataService,
            SteamServerBrowserApiService serverBrowserService
            // SteamPlayerDetailApiService playerDetailService
            )
        {
            _logger = logger;
            _gameDataService = gameDataService;
            _serverBrowserService = serverBrowserService;
            // _playerDetailService = playerDetailService;
            GamesList = new List<ASP_site.GameServerListCommon.Model.Game>(); // Initialize lists
            ServerList = new List<GameServerItem>();
        }

        // Properties to hold data for the view
        public List<ASP_site.GameServerListCommon.Model.Game> GamesList { get; set; }
        public List<GameServerItem> ServerList { get; set; }
        public ASP_site.GameServerListCommon.Model.Game? SelectedGame { get; set; }
        public bool IsLoading { get; set; }
        public string? ErrorMessage { get; set; }

        // Bind properties for Game Selection, Sorting, and Filtering
        [BindProperty(SupportsGet = true)]
        public string? SelectedGameId { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortBy { get; set; } = "players"; // Default sort

        [BindProperty(SupportsGet = true)]
        public string VacFilter { get; set; } = "all"; // all, yes, no

        [BindProperty(SupportsGet = true)]
        public string EmptyFilter { get; set; } = "yes"; // Changed default to yes (show empty)

        [BindProperty(SupportsGet = true)]
        public string PasswordFilter { get; set; } = "all"; // all, yes, no

        public async Task OnGetAsync()
        {
            _logger.LogInformation("Servers page accessed.");
            IsLoading = false;
            ErrorMessage = null;

            try
            {
                ViewData["ActivePage"] = "Servers";

                // Always load the game list for the dropdown
                await _gameDataService.InitializeAsync(); // Ensure games are loaded
                GamesList = _gameDataService.GetGames().OrderBy(g => g.Name).ToList();
                _logger.LogInformation($"Loaded {GamesList.Count} games for display.");

                if (!string.IsNullOrEmpty(SelectedGameId))
                {
                    _logger.LogInformation($"Game ID '{SelectedGameId}' selected. Fetching servers...");
                    IsLoading = true; // Set loading true before fetch
                    SelectedGame = _gameDataService.GetGameById(SelectedGameId);

                    if (SelectedGame != null)
                    {
                        // Fetch the raw server list
                        var rawServerList = await _serverBrowserService.FetchServers(SelectedGame);
                        IsLoading = false; // Set loading false after fetch

                        if (rawServerList == null)
                        {
                            ErrorMessage = $"Could not fetch server list for {SelectedGame.Name}. The game server browser service might be unavailable or the game might not be supported correctly.";
                            ServerList = new List<GameServerItem>();
                        }
                        else
                        {
                            _logger.LogInformation($"Fetched {rawServerList.Count} servers for {SelectedGame.Name}. Applying filters and sorting...");
                            // Apply Filters
                            IEnumerable<GameServerItem> filteredList = rawServerList;

                            if (VacFilter == "yes")
                                filteredList = filteredList.Where(s => s.RequiresVAC);
                            else if (VacFilter == "no")
                                filteredList = filteredList.Where(s => !s.RequiresVAC);

                            if (EmptyFilter == "no") 
                            {
                                filteredList = filteredList.Where(s => s.Players > 0);
                            }

                            if (PasswordFilter == "yes")
                                filteredList = filteredList.Where(s => s.PasswordProtected);
                            else if (PasswordFilter == "no")
                                filteredList = filteredList.Where(s => !s.PasswordProtected);

                            // Apply Sorting
                            switch (SortBy?.ToLowerInvariant())
                            {
                                case "name":
                                    filteredList = filteredList.OrderBy(s => s.Name);
                                    break;
                                case "map":
                                    filteredList = filteredList.OrderBy(s => s.Map).ThenByDescending(s => s.Players);
                                    break;
                                case "players": // Default
                                default:
                                    filteredList = filteredList.OrderByDescending(s => s.Players).ThenBy(s => s.Name);
                                    break;
                            }

                            ServerList = filteredList.ToList();
                            _logger.LogInformation($"Displaying {ServerList.Count} servers after filtering and sorting.");
                        }
                    }
                    else
                    {
                        IsLoading = false; // Also set loading false if game not found
                        ErrorMessage = $"Selected game ID '{SelectedGameId}' not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                IsLoading = false;
                _logger.LogError(ex, "Error loading server page data.");
                ErrorMessage = "An error occurred while trying to load server data. Please try again later.";
                ServerList = new List<GameServerItem>(); // Ensure list is empty on error
            }
        }
    }
}