using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASP_site.Models {
  public class Game {
    public required string GameID { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? EngineID { get; set; }
    public Genre? Genre { get; set; }
    public int? SteamID { get; set; } // used to generate steam store and steamdb links. epic storeID? 
    public int? Year { get; set; } // can be used for sorting. auto populate from release dates
    public ReleaseDate[] ReleaseDates { get; set; } = [];
    public Link[] Links { get; set; } = [];
    public bool IsReleased { get; set; } = true;
    public bool IsPlayable { get; set; } = true;
    public bool? IsFree { get; set; }
    public bool? IsPaid { get; set; }
    public bool? IsOpenSource { get; set; }
    public bool? IsDeveloperMaintained { get; set; }
    public bool? IsCommunityMaintained { get; set; }
    public bool RequiresCommunityPatch { get; set; } = false;
    public string ModForGameID { get; set; } = "";
    public static Game InitializeLinks(Game g) {
      if(g.SteamID != null) {
        g.Links.Append(
          new Link(){
            Url = $"https://store.steampowered.com/app/{g.SteamID}/",
            Label = "Steam Store Link",
            LinkType = LinkType.StoreLink,
            Description = $"{g.Name} on Steam" 
          }
        );
        g.Links.Append(
          new Link(){
            Url = $"https://steamdb.info/app/{g.SteamID}/",
            Label = "SteamDB Link",
            LinkType = LinkType.SteamDB,
            Description = $"{g.Name} on SteamDB" 
          }
        );
      }
      return g;
    }
    public static Game InitializeYear(Game g) {
      if(g.ReleaseDates.Length > 0) {
        g.Year = g.ReleaseDates.Min(x => x.Date.Year);
      }
      return g;
    }
    public static int CalculateYear(ReleaseDate[] dates) {
      if(dates.Length > 0) {
        return dates.Min(x => x.Date.Year);
      }
      return 0;
    }
    public void CalculateYear() {
      if(ReleaseDates.Length > 0) {
        Year = ReleaseDates.Min(x => x.Date.Year);
      } else {
      Year = 0;
      }
    }
        public void CalculateYear2() {
      if(ReleaseDates.Length > 0) {
        Year = ReleaseDates[1].Date.Year;
      } else {
      Year = 0;
      }
    }
  }

  public enum Genre { FPS, RTS }
  public enum LinkType { OfficialSite, CommunitySite, OfficialDiscord, CommunityDiscord, PickupDiscord, GameplayGuide, GameplayVideo, StoreLink, StatsLink, CommunityPort, SteamDB }
  public enum Region { Worldwide, NA, SA, EU, Asia }
  public enum ReleaseVersion { Alpha, Beta, Demo, FullGame, SteamRelease, ReRelease, LatestUpdate }
  [Keyless] [NotMapped] public class Link {
    public required string Url { get; set; }
    public string Label { get; set; } = "Link";
    public LinkType LinkType { get; set; } = LinkType.CommunitySite;
    public string Description { get; set; } = "";
  }
  [Keyless] [NotMapped]  public class ReleaseDate {
    public DateTime Date { get; set; }
    public Region Region { get; set; } = Region.Worldwide;
    public ReleaseVersion ReleaseVersion { get; set; } = ReleaseVersion.FullGame;
  }
}