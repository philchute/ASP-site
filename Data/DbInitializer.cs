using ASP_site.Models;

namespace ASP_site.Data {
  public static class DbInitializer {
    public static void Initialize(GameContext context) {
      // Look for any Games, db has been seeded
      if (context.Games.Any()) { return; }
      
      // create engines array
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
        },
        new Engine {
          EngineID = "idtech4",
          Name = "idtech4 (Doom 3 Engine)",
          Description = "idtech4 is a game engine developed by id Software, first used in the 2004 first-person shooter game Doom 3.",
          ParentID = "idtech3", Year = 2004
        },
        new Engine {
          EngineID = "idtech5",
          Name = "idtech5 (Rage Engine)",
          Description = "idtech5 is a game engine developed by id Software, first used in the 2011 first-person shooter game Rage.",
          ParentID = "idtech4", Year = 2011
        },
        new Engine {
          EngineID = "idtech6",
          Name = "idtech6 (Doom 2016 Engine)",
          Description = "idtech6 is a game engine developed by id Software, first used in the 2016 first-person shooter game Doom 2016.",
          ParentID = "idtech5", Year = 2016
        },
        new Engine {
          EngineID = "idtech7",
          Name = "idtech7 (Doom Eternal Engine)",
          Description = "idtech7 is a game engine developed by id Software, first used in the 2020 first-person shooter game Doom Eternal.",
          ParentID = "idtech6", Year = 2020
        },
        new Engine {
          EngineID = "idtech8",
          Name = "idtech8 (Doom Dark Ages Engine)",
          Description = "idtech8 is a game engine developed by id Software, first used in the 2025 first-person shooter game Doom Dark Ages.",
          ParentID = "idtech7", Year = 2025
        },
        new Engine {
          EngineID = "goldsrc",
          Name = "GoldSrc (Half-Life Engine)",
          Description = "GoldSrc is a game engine developed by Valve Software, first used in the 1998 first-person shooter game Half-Life.",
          ParentID = "idtech2", Year = 1998
        },
        new Engine {
          EngineID = "source",
          Name = "Source (Half-Life 2 Engine)",
          Description = "Source Engine is a game engine developed by Valve Software, first used in the 2004 first-person shooter game Half-Life 2.",
          ParentID = "goldsrc", Year = 2004
        },
        new Engine {
          EngineID = "source2",
          Name = "Source 2 (Half-Life: Alyx Engine)",
          Description = "Source 2 is a game engine developed by Valve Software, first used in Dota 2 in 2015.",
          ParentID = "source", Year = 2015
        }
      };
      
      // add engines to context 
      foreach (Engine e in Engines) {
        try {
          context.Engines.Add(e);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add engine {e.EngineID}: {ex.Message}");
        }
      }

      // create games array
      var Games = new Game[] {
        new Game {
          GameID = "Doom",
          Name = "Doom and Doom 2",
          Description = "Doom and Doom 2 are now sold as a combined package on Steam including the original expansions and new episodes.",
          EngineID = "idtech1",
          Developer = "id Software",
          SteamID = 2280,
          IsFree = true,
          IsPaid = true,
          IsOpenSource = true,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 1993, Month = 12, Day = 10, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Year = 2024, Month = 8, Day = 8, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2025, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "Doom3",
          Name = "Doom 3",
          Description = "2004's Doom 3, the Resurrection of Evil expansion, and the 2012 remaster Doom 3: BFG Edition are now sold as a combined package" +
                        " on Steam. This game holds up well as a horror FPS classic and is playable on VR headsets.",
          EngineID = "idtech4",
          Developer = "id Software",
          SteamID = 208200,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = true,
          IsDeveloperMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2004, Month = 9, Day = 30, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Year = 2012, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2025, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "Doom2016",
          Name = "Doom 2016",
          Description = "Doom 2016 is a first-person shooter game developed by id Software.",
          EngineID = "idtech6",
          Developer = "id Software",
          SteamID = 379720,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2016, Month = 5, Day = 13, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
          ]
        },
        new Game {
          GameID = "DoomEternal",
          Name = "Doom Eternal",
          Description = "Doom Eternal is a first-person shooter game developed by id Software.",
          EngineID = "idtech7",
          Developer = "id Software",
          SteamID = 782330,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 3, Day = 20, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
          ]
        },
        new Game {
          GameID = "DoomDarkAges",
          Name = "Doom Dark Ages",
          Description = "Doom Dark Ages is a first-person shooter game developed by id Software.",
          EngineID = "idtech8",
          Developer = "id Software",
          SteamID = 3017860,
          IsReleased = false,
          IsPlayable = false,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2025, Month = 5, Day = 15, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
          ]
        },
        new Game {
          GameID = "Quake1",
          Name = "Quake",
          Description = "Quake remaster is available on Steam which includes the original game, original expansions and new content, along with the Trent Reznor soundtrack. " +
                        "Free open source versions of the game are also available. Community source ports are used for speed running and competitive deathmatching.",
          EngineID = "idtech2",
          Developer = "id Software",
          SteamID = 2310,
          IsFree = true,
          IsPaid = true,
          IsOpenSource = true,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 1996, Month = 6, Day = 22, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Year = 2007, Month = 8, Day = 3, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
            new ReleaseDate{Year = 2021, Month = 8, Day = 19, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2025, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "Quake2",
          Name = "Quake 2",
          Description = "Quake 2 remaster is available on Steam which includes the original game, original expansions and new content.",
          EngineID = "idtech2",
          Developer = "id Software",
          SteamID = 2320,
          IsPaid = true,
          IsOpenSource = true,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 1997, Month = 12, Day = 9, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Year = 2007, Month = 8, Day = 3, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
            new ReleaseDate{Year = 2023, Month = 8, Day = 10, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2023, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "Quake3",
          Name = "Quake 3 Arena",
          Description = "Quake 3 Arena has largely been replaced by the Quake Live Remake but maintains a small player base, particularly in DeFrag movement servers.",
          EngineID = "idtech3",
          Developer = "id Software",
          SteamID = 2220,
          IsFree = true,
          IsPaid = true,
          IsOpenSource = true,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 12, Day = 2, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
          ] 
        },
        new Game {
          GameID = "QuakeLive",
          Name = "Quake Live",
          Description = "Quake Live is a first-person shooter game developed by id Software. It was originally a free to play game but converted to a paid title in 2015.",
          EngineID = "idtech3",
          Developer = "id Software",
          SteamID = 282440,
          IsFree = false, 
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2010, Month = 8, Day = 6, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Year = 2014, Month = 9, Day = 14, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
          ]
        },
        new Game {
          GameID = "Quake4",
          Name = "Quake 4",
          Description = "Quake 4 is a first-person shooter game developed by id Software.",
          EngineID = "idtech4",
          Developer = "id Software",
          SteamID = 2210,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = true,
          IsDeveloperMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2005, Month = 10, Day = 18, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
          ]
        },
        new Game {
          GameID = "Rage",
          Name = "Rage",
          Description = "Rage is a first-person shooter game developed by id Software.",
          EngineID = "idtech5",
          Developer = "id Software",
          SteamID = 9200,
          IsFree = false,
          IsPaid = true,
          ReleaseDates = [
            new ReleaseDate{Year = 2011, Month = 10, Day = 4, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
          ]
        },
        new Game {
          GameID = "FortressOne",
          Name = "FortressOne",
          Description = "FortressOne is a free and open source mod for QuakeWorld that brings Team Fortress to the modern era.",
          ModForGameID = "Quake1",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          ReleaseDates = [
            new ReleaseDate{Year = 2019, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Year = 2024, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "HalfLife",
          Name = "Half-Life",
          Description = "Half-Life set the bar for action adventure first person shooters.",
          EngineID = "goldsrc",
          Developer = "Valve Software",
          SteamID = 70,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 1998, Month = 11, Day = 19, Region = Region.NA, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Year = 1998, Month = 11, Day = 27, Region = Region.EU, ReleaseVersion = ReleaseVersion.FullGame}, 
            new ReleaseDate{Year = 2000, Month = 7, Day = 14, Region = Region.Asia, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Year = 2024, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "HalfLife2",
          Name = "Half-Life 2",
          Description = "Half-Life 2 is a first-person shooter game developed by Valve Software.",
          EngineID = "source",
          Developer = "Valve Software",
          SteamID = 220,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2004, Month = 11, Day = 16, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.FullGame},
          ]
        }
      };

      // Add games to context
      foreach (Game g in Games) {
        try {
          Game h = Game.InitializeYear(g);
          context.Games.Add(h);
        }
        catch (Exception ex) {
          Console.WriteLine($"Failed to add game {g.GameID}: {ex.Message}");
        }
      }

      // Create a separate Links collection
      var Links = new Link[] {
        new Link {
          Url = "https://www.fortressone.org/",
          Label = "FortressOne",
          LinkType = LinkType.OfficialSite,
          Description = "FortressOne Official Site",
          GameID = "FortressOne"
        },
        new Link {
          Url = "http://www.ezquake.com/",
          Label = "EzQuake",
          LinkType = LinkType.CommunityPort,
          Description = "EzQuake Multiplayer Client",
          GameID = "Quake1"
        },
        new Link {
          Url = "https://nquake.com/",
          Label = "NQuake",
          LinkType = LinkType.CommunityPort,
          Description = "NQuake (EzQuake Installer)",
          GameID = "Quake1"
        },
        new Link {
          Url = "https://www.youtube.com/watch?v=_vHnHSEf_Q0",
          Label = "Half-Life Fan Trailer",
          LinkType = LinkType.Trailer,
          Description = "Half-Life Fan Trailer",
          GameID = "HalfLife"
        },
        new Link {
          Url = "https://www.youtube.com/watch?v=ID1dWN3n7q4",
          Label = "Half-Life 2 Fan Trailer",
          LinkType = LinkType.Trailer,
          Description = "Half-Life 2 Fan Trailer",
          GameID = "HalfLife2"
        }
      };

      // Add Steam links for games with SteamIDs
      foreach (Game g in Games) {
        if (g.SteamID != null) {
          var steamLinks = new Link[] {
            new Link {
              Url = $"https://store.steampowered.com/app/{g.SteamID}/",
              Label = "Steam Store Link",
              LinkType = LinkType.StoreLink,
              Description = $"{g.Name} on Steam",
              GameID = g.GameID
            },
            new Link {
              Url = $"https://steamdb.info/app/{g.SteamID}/",
              Label = "SteamDB Link",
              LinkType = LinkType.SteamDB,
              Description = $"{g.Name} on SteamDB",
              GameID = g.GameID
            }
          };
          context.Links.AddRange(steamLinks);
        }
      }

      // Add links to context
      foreach (Link link in Links)
      {
        context.Links.Add(link);
      }

      // Save changes to db
      context.SaveChanges();  
    }
  }
}