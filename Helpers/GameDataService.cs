using ASP_site.GameServerListCommon.Model;
using ASP_site.GameServerListCommon.Utils;
using Microsoft.Extensions.Configuration; // Likely needed for file paths
using Microsoft.Extensions.Hosting; // To get ContentRootPath
using Microsoft.Extensions.Logging; // For logging errors
using ASP_site.Data; // Added for GameContext
using Microsoft.EntityFrameworkCore; // Added for ToListAsync and Include
using Microsoft.Extensions.DependencyInjection; // Added for IServiceProvider and CreateScope

namespace ASP_site.Helpers;

public interface IGameDataService
{
    Task InitializeAsync(); // Method to load data
    IEnumerable<Game> GetGames();
    Game? GetGameByIndex(int index);
    Game? GetGameById(string gameId);
}

public class GameDataService : IGameDataService
{
    private readonly ILogger<GameDataService> _logger;
    private readonly string _dataFolderPath;
    private List<Game> _games = [];
    private bool _isInitialized = false;
    private readonly IServiceProvider _serviceProvider; // Added

    public GameDataService(ILogger<GameDataService> logger, IHostEnvironment environment, IServiceProvider serviceProvider) // Changed context to serviceProvider
    {
        _logger = logger;
        _serviceProvider = serviceProvider; // Added
        // Construct the absolute path to the Data directory
        _dataFolderPath = Path.Combine(environment.ContentRootPath, "Data");
    }

    public async Task InitializeAsync()
    {
        if (_isInitialized) return;

        _logger.LogInformation("Initializing GameDataService from database...");
        try
        {
            // Create a scope to resolve GameContext
            using (var scope = _serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<GameContext>();

                _logger.LogInformation("Attempting to fetch games from database...");
                var dbGames = await context.Games
                                            .OrderBy(g => g.Name)
                                            .ToListAsync();

                if (dbGames == null || !dbGames.Any())
                {
                    _logger.LogWarning("No games found in the database for server browser configuration.");
                    _games = [];
                    _isInitialized = true;
                    return;
                }

                var browserGames = new List<Game>();
                // int currentBrowserGameIndex = 0; // For assigning a dense index

                foreach (var dbGame in dbGames) // Changed loop variable name for clarity
                {
                    if (dbGame.ServerConfig != null)
                    {
                        var browserGame = new Game
                        {
                            Name = dbGame.Name,
                            AppId = dbGame.SteamID,
                            Icon = dbGame.ServerConfig.IconPath ?? string.Empty,
                            Gamedir = dbGame.ServerConfig.GameDirectory,
                            MasterServer = (ASP_site.GameServerListCommon.Model.MasterServerType?)dbGame.ServerConfig.MasterServer,
                            NoBackgroundService = dbGame.ServerConfig.NoBackgroundService,
                            UseDefinedServerList = dbGame.ServerConfig.UseDefinedServerList,
                            Filters = dbGame.ServerConfig.ApiFilters
                        };

                        browserGames.Add(browserGame);
                    }
                    // Games without ServerConfig are intentionally skipped for the server browser list
                }
                
                // Assign dense, sequential Index to the filtered list of browser games
                for (int idx = 0; idx < browserGames.Count; idx++)
                {
                    browserGames[idx].Index = idx;
                }

                _games = browserGames;
                _logger.LogInformation($"Loaded {_games.Count} games for server browser.");

                _isInitialized = true;
                _logger.LogInformation("GameDataService initialization complete.");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Fatal error during GameDataService initialization.");
            _games = []; // Ensure games list is empty on error
            _isInitialized = true; // Mark as initialized to prevent retries
        }
    }

    public IEnumerable<Game> GetGames()
    {
        EnsureInitialized();
        return _games;
    }

    public Game? GetGameByIndex(int index)
    {
        EnsureInitialized();
        if (index < 0 || index >= _games.Count)
            return null;
        return _games[index];
    }

    public Game? GetGameById(string gameId)
    {
         EnsureInitialized();
         // Find by the compound GameId property (e.g., AppId or Gamedir)
         // The GameId property in GameServerListCommon.Model.Game is AppId?.ToString() ?? Gamedir
         // So, we search based on that logic.
         return _games.FirstOrDefault(g => 
            (g.AppId.HasValue && g.AppId.ToString() == gameId) || 
            (!g.AppId.HasValue && !string.IsNullOrEmpty(g.Gamedir) && g.Gamedir == gameId) ||
            (g.Name == gameId) // Fallback to name if gameId might be the name, though less reliable
         );
    }

    private void EnsureInitialized()
    {
         if (!_isInitialized)
         {
             // This should ideally not happen if InitializeAsync is called correctly at startup
             _logger.LogWarning("GameDataService accessed before initialization.");
             // Optionally, trigger initialization synchronously (might block)
             // InitializeAsync().GetAwaiter().GetResult();
             // Or throw an exception:
              throw new InvalidOperationException("GameDataService is not initialized. Call InitializeAsync first.");
         }
    }
} 