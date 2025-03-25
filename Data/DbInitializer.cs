using ASP_site.Models;

namespace ASP_site.Data {
  public static class DbInitializer {
    public static void Initialize(GameContext context) {
      context.Database.EnsureCreated();

      // Look for any Games, db has been seeded
      if (context.Games.Any()) { return; }

      // Create Engines
      var Engines = new Engine[] {
        new Engine {
          EngineID = "idtech1",
          Name = "idtech1 (Doom Engine)",
          Description = "idtech1 is a game engine developed by id Software, first used in the 1993 first-person shooter game Doom.",
          ParentID = "", Year = 1993
        },
        new Engine {
          EngineID = "idtech2",
          Name = "idtech2 (Quake 1 Engine)",
          Description = "idtech2 is a game engine developed by id Software, first used in the 1996 first-person shooter game Quake.",
          ParentID = "idtech1", Year = 1996
        },
        new Engine {
          EngineID = "idtech3",
          Name = "idtech3 (Quake 3 Engine)",
          Description = "idtech3 is a game engine developed by id Software, first used in the 1998 first-person shooter game Quake III Arena.",
          ParentID = "idtech2", Year = 1998
        }
      };

      foreach (Engine e in Engines) { 
        Engine f = e;
        f = Engine.AddChildren(f, Engines.ToList());
        f = Engine.AddGames(f, context.Games.ToList());
        context.Engines.Add(f); 
        }
      context.SaveChanges(); // write changes to the database

      // add games to db
      var Games = new Game[] {
        new Game {
          GameID = "Quake1",
          Name = "Quake",
          Description = "Quake remaster is available on Steam which includes the original game, original expansions and new content, along with the Trent Reznor soundtrack. " +
                        "Free open source versions of the game are also available. Community source ports are used for speed running and competitive deathmatching.",
          EngineID = "idtech2",
          SteamID = 2310,
          IsFree = true,
          IsPaid = true,
          IsOpenSource = true,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          Links = [new Link{Url="http://www.ezquake.com/", Label="EzQuake", LinkType=LinkType.CommunityPort, Description="EzQuake Multiplayer Client"},
                    new Link{Url="https://nquake.com/", Label="NQuake", LinkType=LinkType.CommunityPort, Description="NQuake (EzQuake Installer)"}],
          ReleaseDates = [
            new ReleaseDate{Date = new DateTime(1996, 06, 22), Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Date = new DateTime(2007, 08, 03), Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
            new ReleaseDate{Date = new DateTime(2021, 08, 19), Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Date = new DateTime(2025), Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "Quake2",
          Name = "Quake 2",
          Description = "Quake 2 remaster is available on Steam which includes the original game, original expansions and new content.",
          EngineID = "idtech2",
          IsPaid = true,
          IsOpenSource = true,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          Links = [],
          ReleaseDates = [
            new ReleaseDate{Date = new DateTime(1997, 12, 09), Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Date = new DateTime(2007, 08, 03), Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
            new ReleaseDate{Date = new DateTime(2023, 08, 10), Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Date = new DateTime(2025), Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "FortressOne",
          Name = "FortressOne",
          Description = "FortressOne is a free and open source mod for QuakeWorld that brings Team Fortress to the modern era.",
          ModForGameID = "Quake1",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Links = [new Link{Url="https://www.fortressone.org/", Label="FortressOne", LinkType=LinkType.OfficialSite, Description="FortressOne Official Site"}],
          ReleaseDates = [
            new ReleaseDate{Date = new DateTime(2019), Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Date = new DateTime(2024), Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        }

      };

      foreach (Game g in Games) {
        try {
          //g.Year = Game.CalculateYear(g.ReleaseDates);
          Game h = g;
          h = Game.InitializeLinks(h);
          //h = Game.InitializeYear(h);
          //h.Year = Game.CalculateYear(h.ReleaseDates);
          h.CalculateYear2();
          context.Games.Add(h);
          context.SaveChanges();
          Console.WriteLine(h.GameID);
        }
        catch (Exception ex) {
          Console.WriteLine(ex.Message);
          break;
        }
      }
    }
  }
}