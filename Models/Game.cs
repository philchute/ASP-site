using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ASP_site.Models {
  [JsonConverter(typeof(JsonStringEnumConverter<MasterServerType>))]
  public enum MasterServerType
  {
    GoldSource = 0,
    Source = 1,
    DarkMessiah = 2
  }

  public class Game {
    public required string GameID { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? EngineID { get; set; }
    public string? ModForGameID { get; set; }
    public string? Developer { get; set; }
    public Genre? Genre { get; set; }
    public int? SteamID { get; set; }
    public ServerBrowserConfig? ServerConfig { get; set; }
    public int? Year { get; set; }
    public ReleaseDate[] ReleaseDates { get; set; } = [];
    public bool IsReleased { get; set; } = true;
    public bool IsPlayable { get; set; } = true;
    public bool? IsFree { get; set; }
    public bool? IsPaid { get; set; }
    public bool IsOpenSource { get; set; } = false;
    public bool? IsDeveloperMaintained { get; set; }
    public bool? IsCommunityMaintained { get; set; }
    public bool RequiresCommunityPatch { get; set; } = false;
    public List<Game> Mods { get; set; } = new List<Game>();
    public List<Server> Servers { get; set; } = new List<Server>();
    public List<int> PlayWith { get; set; } = [];
    
    public static Game InitializeYear(Game g, List<Game> allGames) {
      if(g.ReleaseDates.Length > 0) {
        g.Year = g.ReleaseDates.OrderBy(x => x.Year).First().Year;
      } else if (!string.IsNullOrEmpty(g.ModForGameID)) {
        var parentGame = allGames.FirstOrDefault(x => x.GameID == g.ModForGameID);
        if (parentGame?.Year != null) {
          g.Year = parentGame.Year;
        }
      }
      return g;
    }
    
    public static List<Game> AddMods(Game g, List<Game> allGames) {
        g.Mods = allGames.Where(x => x.ModForGameID == g.GameID).ToList();
        return g.Mods;
    }
    
    public static List<Link> GetLinks(Game g, List<Link> allLinks) {
        return allLinks.Where(l => l.GameID == g.GameID).ToList();
    }
    
    public static List<Server> GetServers(Game g, List<Server> allServers) {
        return allServers.Where(s => s.GameID == g.GameID).ToList();
    }
    
    public static Game InitializeGenre(Game g, List<Game> allGames) {
        if (g.Genre == null && g.ModForGameID != null) {
            var parentGame = allGames.FirstOrDefault(x => x.GameID == g.ModForGameID);
            if (parentGame?.Genre != null) {
                g.Genre = parentGame.Genre;
            }
        }
        return g;
    }

    public static Game InitializeEngine(Game g, List<Game> allGames) {
        if (string.IsNullOrEmpty(g.EngineID) && !string.IsNullOrEmpty(g.ModForGameID)) {
            g.EngineID = allGames.FirstOrDefault(x => x.GameID == g.ModForGameID)?.EngineID;
        }
        return g;
    }
  }

  public enum Genre { FPS, RTS, TBS, MOBA, Sports, Fighting, Adventure, Lightgun, Puzzle }
  public enum Region { Worldwide, NA, SA, EU, UK, JP, AU, Asia }
  public enum ReleaseVersion { Alpha, Beta, Demo, FullGame, SteamRelease, ReRelease, LatestUpdate, Arcade, Dreamcast, GameCube, Xbox, PSP, PS1, PS2, PS3, PS4, PS5, Xbox360, Wii, WiiU, Switch, Mobile, VR }
  
  public class ReleaseDate {
    public required int Year { get; set; }
    public int? Month { get; set; }
    public int? Day { get; set; }
    public Region Region { get; set; } = Region.Worldwide;
    public ReleaseVersion ReleaseVersion { get; set; } = ReleaseVersion.FullGame;

    public static string FormatReleaseType(ReleaseVersion version) => version.ToString()
        .Replace("FullGame", "Full Game")
        .Replace("SteamRelease", "Steam Release")
        .Replace("ReRelease", "Re-Release")
        .Replace("LatestUpdate", "Latest Update");
        
    public static string FormatRegion(Region region) => region.ToString()
        .Replace("NA", "North America")
        .Replace("SA", "South America")
        .Replace("EU", "Europe");

    public DateTime GetDate() {
        return new DateTime(
            Year,
            Month ?? 1,
            Day ?? 1
        );
    }
  }
}