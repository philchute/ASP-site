using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models {
  public class Game {
    public required string GameID { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? EngineID { get; set; }
    public string? ModForGameID { get; set; }
    public string? Developer { get; set; }
    public Genre? Genre { get; set; }
    public int? SteamID { get; set; }
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
    public static Game InitializeYear(Game g) {
      if(g.ReleaseDates.Length > 0) {
        g.Year = g.ReleaseDates.OrderBy(x => x.Year).First().Year;
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
    public static Game InitializeGenre(Game g, List<Game> allGames) {
        if (g.Genre == null && g.ModForGameID != null) {
            var parentGame = allGames.FirstOrDefault(x => x.GameID == g.ModForGameID);
            if (parentGame?.Genre != null) {
                g.Genre = parentGame.Genre;
            }
        }
        return g;
    }
  }

  public enum Genre { FPS, RTS }
  public enum Region { Worldwide, NA, SA, EU, Asia }
  public enum ReleaseVersion { Alpha, Beta, Demo, FullGame, SteamRelease, ReRelease, LatestUpdate }
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