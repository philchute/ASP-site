using ASP_site.GameServerListCommon.Model;
using ASP_site.GameServerListCommon.Utils;
using Microsoft.Extensions.Configuration; // Likely needed for file paths
using Microsoft.Extensions.Hosting; // To get ContentRootPath
using Microsoft.Extensions.Logging; // For logging errors

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

    public GameDataService(ILogger<GameDataService> logger, IHostEnvironment environment)
    {
        _logger = logger;
        // Construct the absolute path to the Data directory
        _dataFolderPath = Path.Combine(environment.ContentRootPath, "Data");
    }

    public async Task InitializeAsync()
    {
        if (_isInitialized) return;

        _logger.LogInformation("Initializing GameDataService...");
        try
        {
            var gamesFilePath = Path.Combine(_dataFolderPath, "games.json");
            var gameData = await FileUtils.ReadJsonFileAsync<List<Game>>(gamesFilePath);

            if (gameData == null || !gameData.Any())
            {
                _logger.LogWarning("games.json could not be loaded or is empty.");
                _games = [];
                _isInitialized = true;
                return;
            }

            _games = gameData.OrderBy(g => g.Name).ToList();
            _logger.LogInformation($"Loaded {_games.Count} games from games.json.");

            // Assign index and attempt to load specific server lists
            for (int i = 0; i < _games.Count; i++)
            {
                 var game = _games[i];
                 game.Index = i;

                 // Check if a specific address file exists for this game
                 if (game.AppId.HasValue)
                 {
                     var addressFilePath = Path.Combine(_dataFolderPath, $"{game.AppId}_addresses.json");
                     if (File.Exists(addressFilePath))
                     {
                         _logger.LogInformation($"Found address file for {game.Name} ({game.AppId}). Loading...");
                         try
                         {
                              var serverListData = await FileUtils.ReadJsonFileAsync<List<string>>(addressFilePath);
                              if (serverListData != null)
                              {
                                  game.Servers = serverListData;
                                  game.UseDefinedServerList = true;
                                  _logger.LogInformation($"Loaded {serverListData.Count} defined servers for {game.Name}.");
                              }
                              else
                              {
                                   _logger.LogWarning($"Address file {addressFilePath} for {game.Name} was empty or invalid.");
                                   game.UseDefinedServerList = false;
                              }
                         }
                         catch (Exception ex)
                         {
                              _logger.LogError(ex, $"Error loading address file {addressFilePath} for {game.Name}.");
                              game.UseDefinedServerList = false;
                         }
                     }
                     else
                     {
                         game.UseDefinedServerList = false;
                     }
                 }
                 else
                 {
                     game.UseDefinedServerList = false; // Cannot load addresses without AppId
                 }
            }

            _isInitialized = true;
            _logger.LogInformation("GameDataService initialization complete.");
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
         // Find by AppId (as string) or Gamedir
         return _games.FirstOrDefault(g => (g.AppId?.ToString() == gameId) || (g.Gamedir == gameId));
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