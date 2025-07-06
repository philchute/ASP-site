using ASP_site.Models;
using ASP_site.Services;
using Microsoft.Extensions.DependencyInjection; // For DI
using Microsoft.Extensions.Hosting; // For BackgroundService
using Microsoft.Extensions.Logging; // For Logging

namespace ASP_site.Helpers; // Adjusted namespace

public class GameServerWorker : BackgroundService
{
    private readonly ILogger<GameServerWorker> _logger;
    private readonly IServiceProvider _serviceProvider; // Inject service provider to resolve scoped services

    public GameServerWorker(ILogger<GameServerWorker> logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("GameServerWorker starting.");

        // Initial delay before first run
        await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);

        var nextUpdateAt = DateTime.MinValue;

        while (!stoppingToken.IsCancellationRequested)
        {
            if (DateTime.UtcNow < nextUpdateAt)
            {
                await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken); // Check more frequently than original
                continue;
            }

            _logger.LogInformation("GameServerWorker running update cycle...");

            try
            {
                 // Create a scope to resolve scoped services like potentially DbContext or other services
                 using (var scope = _serviceProvider.CreateScope())
                 {
                     var gameDataService = scope.ServiceProvider.GetRequiredService<IGameDataService>();
                     // SteamServerBrowserApiService might need IHttpClientFactory, etc., injected
                     var serverBrowserService = scope.ServiceProvider.GetRequiredService<ServerBrowserService>();

                     // Ensure game data is loaded before proceeding
                     await gameDataService.InitializeAsync(); // Ensure initialized (safe to call multiple times)

                     /*  DISABLE BACKGROUND FETCHING FOR NOW
                     var gamesToUpdate = gameDataService.GetGames()
                         .Where(g => g.UsesBackgroundService())
                         .ToList();

                     _logger.LogInformation($"Found {gamesToUpdate.Count} games configured for background updates.");

                     foreach (var game in gamesToUpdate)
                     {
                         if (stoppingToken.IsCancellationRequested) break;

                         try
                         {
                             _logger.LogDebug($"Updating servers for game: {game.Name}");
                             // Use the instance method from the resolved service
                             // Assuming the Query method in the service is suitable or needs adjustment
                             // Note: The static Query method used previously required List<string> servers
                             // The FetchServers method might be more appropriate if it handles the logic based on UsesBackgroundService flag
                             // We need to ensure the service method called here correctly handles A2S queries for background updates.

                             // Placeholder: Calling FetchServers, assuming it handles the logic correctly
                             // If a different method is needed for the worker, it should be added to the service.
                             var servers = await serverBrowserService.FetchServers(game); // Timeout defaults inside FetchServers?
                             game.GameServers = servers; // Update the cached list on the Game object

                             if (servers != null)
                             {
                                 _logger.LogDebug($"Successfully updated {servers.Count} servers for game: {game.Name}");
                             }
                         }
                         catch (Exception gameEx)
                         {
                             _logger.LogError(gameEx, $"Error updating servers for game: {game.Name}");
                             // Decide if we should clear game.GameServers or leave stale data
                             // game.GameServers = null; // Example: clear on error
                         }
                     }
                     */
                 }

                 _logger.LogInformation("GameServerWorker update cycle finished.");
                 nextUpdateAt = DateTime.UtcNow.AddMinutes(30); // Schedule next update
            }
            catch (Exception ex)
            {
                 _logger.LogError(ex, "Error during GameServerWorker update cycle.");
                 // Wait before retrying after a major error
                 nextUpdateAt = DateTime.UtcNow.AddMinutes(5);
            }
        }

         _logger.LogInformation("GameServerWorker stopping.");
    }
} 