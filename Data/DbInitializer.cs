using ASP_site.Models;
using ASP_site.Data.Initializers;

namespace ASP_site.Data {
  public static class DbInitializer {
    public static void Initialize(GameContext context) {
      if (context.Games.Any()) { return; }
      
      // Initialize engines
      var engines = EngineInitializer.GetEngines();
      foreach (var engine in engines) {
        try {
          context.Engines.Add(engine);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add engine {engine.EngineID}: {ex.Message}");
        }
      }
      
      // Initialize games
      var games = GameInitializer.GetGames();
      foreach (var game in games) {
        try {
          Game h = Game.InitializeYear(game, games.ToList());
          h = Game.InitializeEngine(h, games.ToList());
          context.Games.Add(h);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add game {game.GameID}: {ex.Message}");
        }
      }
      
      // Initialize links
      var links = LinkInitializer.GetLinks();
      foreach (var link in links) {
        try {
          context.Links.Add(link);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add link {link.Url}: {ex.Message}");
        }
      }
      
      // Add Steam links
      foreach (var game in games.Where(g => g.SteamID.HasValue)) {
        var steamLinks = LinkInitializer.GetSteamLinks(game);
        try {
          context.Links.AddRange(steamLinks);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add Steam links for game {game.GameID}: {ex.Message}");
        }
      }
      
      // Initialize servers
      var servers = ServerInitializer.GetServers();
      foreach (var server in servers) {
        try {
          context.Servers.Add(server);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add server {server.Name}: {ex.Message}");
        }
      }
      
      context.SaveChanges();
    }
  }
}