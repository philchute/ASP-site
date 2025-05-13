using ASP_site.Models;
using ASP_site.Data.Initializers;

namespace ASP_site.Data {
  public static class DbInitializer {
    public static void Initialize(GameContext context) {
      // Clear all tables
      context.Maps.RemoveRange(context.Maps);
      context.Links.RemoveRange(context.Links);
      context.Servers.RemoveRange(context.Servers);
      context.Games.RemoveRange(context.Games);
      context.Engines.RemoveRange(context.Engines);
      context.YearEntries.RemoveRange(context.YearEntries);
      context.SaveChanges();
      
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
      
      // Initialize CS maps
      var csmaps = CSMapInitializer.GetMaps();
      foreach (var map in csmaps) {
        try {
          context.Maps.Add(map);
          context.Links.Add(CSLinkInitializer.GetWikiLink(map.MapID));
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add map {map.MapID}: {ex.Message}");
        }
      }

      // Initialize TF maps
      var tfmaps = TFMapInitializer.GetMaps();
      foreach (var map in tfmaps) {
        try {
          context.Maps.Add(map);
          // Add wiki link for TF2 maps
          if (map.GameInfo.Any(g => g.GameID == "TF2")) {
            context.Links.Add(TFLinkInitializer.GetWikiLink(map.MapID));
          }
          // Only add wiki link if the TFC version has Valve Corporation as author
          var tfcVersion = map.GameInfo.FirstOrDefault(g => g.GameID == "TFC");
          if (tfcVersion?.Author == "Valve Corporation") {
            context.Links.Add(TFLinkInitializer.GetWikiLinkClassic(map.MapID));
          }
          // Add map repo link for QWTF maps
          if (map.GameInfo.Any(g => g.GameID == "QWTF")) {
            context.Links.Add(TFLinkInitializer.GetRepoLink(map.MapID));
          }
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add map {map.MapID}: {ex.Message}");
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
      
      // Add TF links
      var tfLinks = TFLinkInitializer.GetLinks();
      foreach (var link in tfLinks) {
        try {
          context.Links.Add(link);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add TF link {link.Url}: {ex.Message}");
        }
      }
      
      // Add CS links
      var csLinks = CSLinkInitializer.GetLinks();
      foreach (var link in csLinks) {
        try {
          context.Links.Add(link);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add CS link {link.Url}: {ex.Message}");
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

      // Initialize Year Entries
      var yearEntries = YearEntryInitializer.GetYearEntries();
      foreach (var entry in yearEntries) {
        try {
          context.YearEntries.Add(entry);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add year entry (ID: {entry.ID}, Title: {entry.Title}): {ex.Message}");
        }
      }
      
      context.SaveChanges();
    }
  }
}