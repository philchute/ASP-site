using ASP_site.Helpers;
using Microsoft.Extensions.Configuration; // Likely needed for file paths
using Microsoft.Extensions.Hosting; // To get ContentRootPath
using Microsoft.Extensions.Logging; // For logging errors
using ASP_site.Data; // Added for GameContext
using Microsoft.EntityFrameworkCore; // Added for ToListAsync and Include
using Microsoft.Extensions.DependencyInjection; // Added for IServiceProvider and CreateScope
using ASP_site.Models;
using ASP_site.Models.ServerBrowser;
using Game = ASP_site.Models.Game;

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
    private List<Game> _games = [];
    private bool _isInitialized = false;
    private readonly IServiceProvider _serviceProvider;

    public GameDataService(ILogger<GameDataService> logger, IHostEnvironment environment, IServiceProvider serviceProvider) // Changed context to serviceProvider
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
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
                
                _games = dbGames.Where(g => g.ServerConfig != null).ToList();

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
         return _games.FirstOrDefault(g => g.GameID == gameId);
    }

    private void EnsureInitialized()
    {
         if (!_isInitialized)
         {
             // This should ideally not happen if InitializeAsync is called correctly at startup
             _logger.LogWarning("GameDataService accessed before initialization.");
              throw new InvalidOperationException("GameDataService is not initialized. Call InitializeAsync first.");
         }
    }
} 