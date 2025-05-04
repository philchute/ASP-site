using ASP_site.Models;

namespace ASP_site.Data.Initializers {
  public static class GameInitializer {
    public static Game[] GetGames() {
      return new Game[] {
        new Game {
          GameID = "ActionHalfLife",
          Name = "Action Half-Life",
          Description = "A fast-paced action mod for Half-Life featuring new weapons and gameplay mechanics.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2000}
          ]
        },
        new Game {
          GameID = "AoE2",
          Name = "Age of Empires II",
          Description = "A classic real-time strategy game set in the Middle Ages. The Definitive Edition is available on Steam.",
          Developer = "Ensemble Studios",
          SteamID = 813780,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.RTS,
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 9, Day = 30},
            new ReleaseDate{Year = 2019, Month = 11, Day = 14, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease}
          ]
        },
        new Game {
          GameID = "AoE4",
          Name = "Age of Empires IV",
          Description = "The latest entry in the Age of Empires series, featuring improved graphics and new civilizations.",
          Developer = "Relic Entertainment",
          SteamID = 6866860,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.RTS,
          ReleaseDates = [
            new ReleaseDate{Year = 2021, Month = 10, Day = 28}
          ]
        },
        new Game {
          GameID = "AttackersGoRed",
          Name = "Attackers Go Red",
          Description = "A team-based multiplayer mod for Quake.",
          ModForGameID = "Quake",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2000}
          ]
        },
        new Game {
          GameID = "BattleGrounds",
          Name = "Battle Grounds",
          Description = "A multiplayer mod for Half-Life featuring muskets and other early firearms.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2000}
          ]
        },
        new Game {
          GameID = "Battlebit",
          Name = "BattleBit Remastered",
          Description = "A low-poly multiplayer FPS featuring large-scale battles and modern combat mechanics.",
          Developer = "SgtOkiDoki",
          SteamID = 671860,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2023, Month = 6, Day = 15}
          ]
        },
        new Game {
          GameID = "BlackMesa",
          Name = "Black Mesa",
          Description = "A fan-made remake of the original Half-Life using the Source engine, featuring updated graphics and some new music and game mechanics.",
          ModForGameID = "HalfLife2",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 3, Day = 6},
          ]
        },
        new Game {
          GameID = "Bumpercars",
          Name = "Bumpercars",
          Description = "A multiplayer mod for Half-Life featuring vehicle-based combat.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2000}
          ]
        },
        new Game {
          GameID = "Chess",
          Name = "Chess",
          Description = "A classic board game available on various platforms.",
          Developer = "Various",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = true,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.TBS,
          ReleaseDates = [
            new ReleaseDate{Year = 600}
          ]
        },
        new Game {
          GameID = "Civ6",
          Name = "Civilization VI",
          Description = "The latest entry in the Civilization series, featuring turn-based strategy gameplay.",
          Developer = "Firaxis Games",
          SteamID = 289070,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.TBS,
          ReleaseDates = [
            new ReleaseDate{Year = 2016, Month = 10, Day = 21}
          ]
        },
        new Game {
          GameID = "ClassicFortress2",
          Name = "Classic Fortress 2",
          Description = "A Source engine mod that brings Team Fortress Classic gameplay to the Source engine.",
          ModForGameID = "TF2",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2007},
          ]
        },
        new Game {
          GameID = "CnC",
          Name = "Command & Conquer: Tiberian Dawn",
          Description = "The original Command & Conquer game, a groundbreaking real-time strategy title.",
          Developer = "Westwood Studios",
          SteamID = 2229830,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.RTS,
          ReleaseDates = [
            new ReleaseDate{Year = 1995, Month = 8, Day = 31}
          ]
        },
        new Game {
          GameID = "CnCGenerals",
          Name = "Command & Conquer: Generals",
          Description = "A modern take on the Command & Conquer series featuring contemporary warfare.",
          Developer = "EA Pacific",
          SteamID = 2229870,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.RTS,
          ReleaseDates = [
            new ReleaseDate{Year = 2003, Month = 2, Day = 11}
          ]
        },
        new Game {
          GameID = "CnCRA2",
          Name = "Command & Conquer: Red Alert 2",
          Description = "A classic entry in the Red Alert series featuring alternate history and unique factions.",
          Developer = "Westwood Studios",
          SteamID = 2229850,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.RTS,
          ReleaseDates = [
            new ReleaseDate{Year = 2000, Month = 10, Day = 23}
          ]
        },
        new Game {
          GameID = "CnCRenegade",
          Name = "Command & Conquer: Renegade",
          Description = "A first-person shooter spin-off of the Command & Conquer series.",
          Developer = "Westwood Studios",
          SteamID = 2229890,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 2, Day = 26}
          ]
        },
        new Game {
          GameID = "CnCTS",
          Name = "Command & Conquer: Tiberian Sun",
          Description = "A sequel to Tiberian Dawn, featuring new factions and improved graphics.",
          Developer = "Westwood Studios",
          SteamID = 2229880,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.RTS,
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 8, Day = 27}
          ]
        },
        new Game {
          GameID = "COD1",
          Name = "Call of Duty",
          Description = "The original Call of Duty, set during World War II, featuring campaigns from American, British, and Soviet perspectives.",
          EngineID = "idtech3",
          Developer = "Infinity Ward",
          SteamID = 2620,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2003, Month = 10, Day = 29},
          ]
        },
        new Game {
          GameID = "COD2",
          Name = "Call of Duty 2",
          Description = "The sequel to Call of Duty, featuring improved graphics and gameplay mechanics while maintaining the World War II setting."
            + " There was a standalone expansion called Call of Duty: United Offensive, which was released in 2004."
            + " Call of Duty 3 was not released on the PC.",
          EngineID = "iw2",
          Developer = "Infinity Ward",
          SteamID = 2630,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2005, Month = 10, Day = 25},
          ]
        },
        new Game {
          GameID = "COD4",
          Name = "Call of Duty 4: Modern Warfare",
          Description = "A groundbreaking entry that moved the series to modern combat, introducing iconic characters and multiplayer features.",
          EngineID = "iw3",
          Developer = "Infinity Ward",
          SteamID = 7940,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2007, Month = 11, Day = 5},
          ]
        },
        new Game {
          GameID = "CODAW",
          Name = "Call of Duty: Advanced Warfare",
          Description = "A futuristic entry introducing exoskeleton movement and advanced technology.",
          EngineID = "sledgehammer",
          Developer = "Sledgehammer Games",
          SteamID = 209660,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2014, Month = 11, Day = 4},
          ]
        },
        new Game {
          GameID = "CODBO1",
          Name = "Call of Duty: Black Ops",
          Description = "The first Black Ops game, featuring a Cold War-era campaign and expanding the Zombies mode.",
          EngineID = "treyarch",
          Developer = "Treyarch",
          SteamID = 42700,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2010, Month = 11, Day = 9},
          ]
        },
        new Game {
          GameID = "CODBO2",
          Name = "Call of Duty: Black Ops II",
          Description = "A futuristic entry in the Black Ops series, featuring branching storylines and new multiplayer features.",
          EngineID = "treyarch",
          Developer = "Treyarch",
          SteamID = 202970,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2012, Month = 11, Day = 13},
          ]
        },
        new Game {
          GameID = "CODBO3",
          Name = "Call of Duty: Black Ops III",
          Description = "A far-future entry featuring advanced movement systems and a complex campaign.",
          EngineID = "treyarch2",
          Developer = "Treyarch",
          SteamID = 311210,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2015, Month = 11, Day = 6},
          ]
        },
        new Game {
          GameID = "CODBO4",
          Name = "Call of Duty: Black Ops 4",
          Description = "The first main series entry without a traditional campaign, focusing on multiplayer and battle royale.",
          EngineID = "treyarch2",
          Developer = "Treyarch",
          SteamID = 581320,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2018, Month = 10, Day = 12},
          ]
        },
        new Game {
          GameID = "CODBO6",
          Name = "Call of Duty: Black Ops 6",
          Description = "The sixth entry in the Black Ops series, featuring a new story and characters.",
          EngineID = "iw9",
          Developer = "Treyarch",
          SteamID = 2933620,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2024, Month = 10, Day = 25},
          ]
        },
        new Game {
          GameID = "CODBOCW",
          Name = "Call of Duty: Black Ops Cold War",
          Description = "A return to the Cold War era, featuring a campaign that connects to the original Black Ops.",
          EngineID = "treyarch2",
          Developer = "Treyarch",
          SteamID = 1985810,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 11, Day = 13},
          ]
        },
        new Game {
          GameID = "CODGHOSTS",
          Name = "Call of Duty: Ghosts",
          Description = "A standalone entry featuring a new story and characters, introducing dynamic map events.",
          EngineID = "iw6",
          Developer = "Infinity Ward",
          SteamID = 209160,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2013, Month = 11, Day = 5},
          ]
        },
        new Game {
          GameID = "CODIW",
          Name = "Call of Duty: Infinite Warfare",
          Description = "A space combat entry featuring space battles and zero-gravity combat.",
          EngineID = "iw7",
          Developer = "Infinity Ward",
          SteamID = 292730,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2016, Month = 11, Day = 4},
          ]
        },
        new Game {
          GameID = "CODMW2",
          Name = "Call of Duty: Modern Warfare 2",
          Description = "The sequel to Modern Warfare, featuring an intense campaign and revolutionary multiplayer mechanics.",
          EngineID = "iw4",
          Developer = "Infinity Ward",
          SteamID = 10180,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2009, Month = 11, Day = 10},
          ]
        },
        new Game {
          GameID = "CODMW2019",
          Name = "Call of Duty: Modern Warfare",
          Description = "A reboot of the Modern Warfare series, featuring realistic combat and a new engine.",
          EngineID = "iw8",
          Developer = "Infinity Ward",
          SteamID = 2000950,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2019, Month = 10, Day = 25},
          ]
        },
        new Game {
          GameID = "CODMW2R",
          Name = "Call of Duty: Modern Warfare II",
          Description = "The sequel to the Modern Warfare reboot, featuring new multiplayer mechanics and a continuation of the story.",
          EngineID = "iw9",
          Developer = "Infinity Ward",
          SteamID = 1938090,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 10, Day = 28},
          ]
        },
        new Game {
          GameID = "CODMW3",
          Name = "Call of Duty: Modern Warfare 3",
          Description = "The conclusion to the Modern Warfare trilogy, featuring the final confrontation between Task Force 141 and Makarov.",
          EngineID = "iw5",
          Developer = "Infinity Ward",
          SteamID = 42690,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2011, Month = 11, Day = 8},
          ]
        },
        new Game {
          GameID = "CODMW3R",
          Name = "Call of Duty: Modern Warfare III",
          Description = "The latest entry in the Modern Warfare series, featuring a continuation of the reboot storyline.",
          EngineID = "iw9",
          Developer = "Sledgehammer Games",
          SteamID = 2018100,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2023, Month = 11, Day = 10},
          ]
        },
        new Game {
          GameID = "CODV",
          Name = "Call of Duty: Vanguard",
          Description = "Another World War II entry, focusing on special forces operations across different theaters of war.",
          EngineID = "iw8",
          Developer = "Sledgehammer Games",
          SteamID = 1985820,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2021, Month = 11, Day = 5},
          ]
        },
        new Game {
          GameID = "CODWAW",
          Name = "Call of Duty: World at War",
          Description = "A return to World War II, featuring the Pacific Theater and the introduction of the Zombies mode.",
          EngineID = "treyarch",
          Developer = "Treyarch",
          SteamID = 10090,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2008, Month = 11, Day = 11},
          ]
        },
        new Game {
          GameID = "CODWWII",
          Name = "Call of Duty: WWII",
          Description = "A return to World War II, featuring the European Theater and a new social space called Headquarters.",
          EngineID = "sledgehammer",
          Developer = "Sledgehammer Games",
          SteamID = 476600,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2017, Month = 11, Day = 3},
          ]
        },
        new Game {
          GameID = "CODWZ",
          Name = "Call of Duty: Warzone",
          Description = "A battle royale game that was released in 2020, replaced by Call of Duty: Warzone 2.",
          EngineID = "iw8",
          Developer = "Sledgehammer Games",
          SteamID = 1128920,
          IsFree = true,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsReleased = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 3, Day = 10},
          ]
        },
        new Game {
          GameID = "CODWZ2",
          Name = "Call of Duty: Warzone 2",
          Description = "The sequel to Call of Duty: Warzone, released in 2022.",
          EngineID = "iw9",
          Developer = "Sledgehammer Games",
          SteamID = 1966263,
          IsFree = true,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          Genre = Genre.FPS,  
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 11, Day = 16},
          ]
        },
        new Game {
          GameID = "ColdIce",
          Name = "Cold Ice Remastered",
          Description = "A remastered version of the Cold Ice mod for Half-Life.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2020}
          ]
        },
        new Game {
          GameID = "CryOfFear",
          Name = "Cry of Fear",
          Description = "A psychological horror game that puts the player in the shoes of Simon, a paraplegic who writes a book for therapy, and in the process faces the inner demons that plague his thoughts. Features a co-op mode.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2013, Month = 4, Day = 25, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
          ]
        },
        new Game {
          GameID = "CS16",
          Name = "Counter-Strike 1.6",
          Description = "The classic version of Counter-Strike that defined competitive FPS gaming. Features tactical gameplay between terrorists and counter-terrorists.",
          ModForGameID = "HalfLife",
          Developer = "Valve Software",
          SteamID = 10,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2000, Month = 11, Day = 8},
            new ReleaseDate{Year = 2003, Month = 9, Day = 12, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
          ]
        },
        new Game {
          GameID = "CSX",
          Name = "Counter-Strike: Xbox",
          Description = "Counter-Strike was released on Xbox in 2005.",
          EngineID = "source",
          Developer = "Valve Software",
          IsPlayable = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2005, Month = 11, Day = 15},
          ]
        },
        new Game {
          GameID = "CSCZ",
          Name = "Counter-Strike: Condition Zero",
          Description = "A spin-off of Counter-Strike featuring single-player missions and additional multiplayer content.",
          ModForGameID = "HalfLife",
          Developer = "Valve Software",
          SteamID = 80,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2004, Month = 3, Day = 23},
          ]
        },
        new Game {
          GameID = "CSS",
          Name = "Counter-Strike: Source",
          Description = "Counter-Strike: Source was released in 2004 as a paid title and converted to free to play, then replaced by CS2.",
          EngineID = "source",
          Developer = "Valve Software",
          IsPlayable = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2004, Month = 11, Day = 18},
          ]
        },
        new Game {
          GameID = "CSGO",
          Name = "Counter-Strike: Global Offensive",
          Description = "Counter-Strike: Global Offensive was released in 2012 as a paid title and converted to free to play, then replaced by CS2.", 
          EngineID = "source",
          Developer = "Valve Software",
          IsPlayable = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2012, Month = 8, Day = 21},
          ]
        },
                new Game {
          GameID = "CS2",
          Name = "Counter-Strike 2",
          Description = "Counter-Strike: Global Offensive was released in 2012 as a paid title and converted to free to play, then replaced by CS2." + 
            " Counter-Strike 2 is the latest iteration of the Counter-Strike series, built on the Source 2 engine.",
          EngineID = "source2",
          Developer = "Valve Software",
          SteamID = 730,
          IsFree = true,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2012, Month = 8, Day = 21},
            new ReleaseDate{Year = 2023, Month = 9, Day = 27, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2025, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "CustomTF",
          Name = "CustomTF",
          Description = "CustomTF allows for co-op and pub gameplay with customizable classes which you choose within a budget of money for equipment. CustomTF is played in a weekly pub game every Saturday at 7 pm EST on gamehost2.tastyspleen.net:27507",
          ModForGameID = "Quake1",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 1996},
          ]
        },
        new Game {
          GameID = "Deadlock",
          Name = "Deadlock",
          Description = "A multiplayer mod for Half-Life featuring unique gameplay mechanics.",
          ModForGameID = "HalfLife",
          SteamID = 1422450,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          IsReleased = false,
          Genre = Genre.FPS,
          ReleaseDates = []
        },
        new Game {
          GameID = "Diabotical",
          Name = "Diabotical",
          Description = "",
          Developer = "The GD Studio",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 9, Day = 3}
          ]
        },
        new Game {
          GameID = "DirtyBomb",
          Name = "Dirty Bomb",
          Description = "Dirty Bomb is an original IP from Splash Damage Studios, the creators of Enemy Territory."
            + " The game features modern class-based gameplay on progressive mixed-objective maps with 23 playable 'mercs' filling five roles: medic, engineer, assault, fire support, and recon."
            + " No longer actively developed, the game is now completely free on Steam and as of 2025 still has consistently full 8v8 pubs.",
          Developer = "Splash Damage",
          SteamID = 333930,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2015, Month = 6, Day = 1},
            new ReleaseDate{Year = 2022, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "DMCR",
          Name = "DMC:R",
          Description = "Deathmatch Classic was Valve's port of Quakeworld Deathmatch to the goldsrc engine."
            + "DMC:R is a source mod which extends this legacy to the the Half-Life 2 engine.",
          ModForGameID = "HalfLife2",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = true,
          IsReleased = false,
          Genre = Genre.FPS,
          ReleaseDates = []
        },
        new Game {
          GameID = "DoD",
          Name = "Day of Defeat",
          Description = "A World War II first-person shooter that was originally a mod and later became a commercially released game.",
          ModForGameID = "HalfLife",
          Developer = "Valve Software",
          SteamID = 300,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2003, Month = 5, Day = 1, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
          ]
        },
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
            new ReleaseDate{Year = 1993, Month = 12, Day = 10},
            new ReleaseDate{Year = 2024, Month = 8, Day = 8, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
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
            new ReleaseDate{Year = 2016, Month = 5, Day = 13},
          ]
        },
        new Game {
          GameID = "Doom3",
          Name = "Doom 3",
          Description = "2004's Doom 3, the Resurrection of Evil expansion, and the 2012 remaster Doom 3: BFG Edition are now sold as a combined package"
            + " on Steam. This game holds up well as a horror FPS classic and is playable on VR headsets.",
          EngineID = "idtech4",
          Developer = "id Software",
          SteamID = 208200,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = true,
          IsDeveloperMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2004, Month = 9, Day = 30},
            new ReleaseDate{Year = 2012, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2025, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
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
            new ReleaseDate{Year = 2025, Month = 5, Day = 15},
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
            new ReleaseDate{Year = 2020, Month = 3, Day = 20},
          ]
        },
        new Game {
          GameID = "Dota2",
          Name = "Dota 2",
          Description = "Dota 2 is a free-to-play multiplayer online battle arena (MOBA) game that evolved from the Warcraft III mod Defense of the Ancients.",
          EngineID = "source2",
          Developer = "Valve Software",
          SteamID = 570,
          IsFree = true,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.MOBA,
          ReleaseDates = [
            new ReleaseDate{Year = 2013, Month = 7, Day = 9},
          ]
        },
        new Game {
          GameID = "Eleven",
          Name = "Eleven",
          Description = "Eleven is an accurate and competitive table tennis game for VR hardware.",
          IsFree = true,
          IsPaid = false,
          SteamID = 488310,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.Sports,
          ReleaseDates = [
            new ReleaseDate{Year = 2016, Month = 6, Day = 20},
          ]
        },
        new Game {
          GameID = "ESF",
          Name = "Earth's Special Forces",
          Description = "A Dragon Ball Z mod for Half-Life featuring unique combat mechanics.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2000}
          ]
        },
        new Game {
          GameID = "ET",
          Name = "Enemy Territory",
          Description = "Wolfenstein: Enemy Territory is a free multiplayer first-person shooter game developed by Splash Damage and"
            + " published by Activision. Originally intended as an expansion pack for Return to Castle Wolfenstein, it was released as a standalone game"
            + " in 2003. The game features objective-based gameplay with two teams: Axis and Allies, each with unique classes and abilities."
            + " The game is now open source and maintained by the community through ET: Legacy.",
          EngineID = "idtech3",
          Developer = "Splash Damage",
          SteamID = 1873030,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = true,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2003, Month = 5, Day = 29},
            new ReleaseDate{Year = 2022, Month = 5, Day = 19, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease}
          ]
        },
        new Game {
          GameID = "ETF",
          Name = "Enemy Territory Fortress",
          Description = "ETF is a port of Q3F to Enemy Territory. This game is currently playable though no one is playing that I know of.",
          ModForGameID = "ET",
          IsOpenSource = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2003},
          ]
        },
        new Game {
          GameID = "FF",
          Name = "Fortress Forever",
          Description = "Fortress Forever is a mod for the Source engine that iterated the Team Fortress Classic style gameplay.",
          ModForGameID = "HalfLife2",
          Developer = "Fortress Forever Team",
          SteamID = 253530,
          IsOpenSource = true,
          IsFree = true,
          IsPaid = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2007},
          ]
        },
        new Game {
          GameID = "FLF",
          Name = "FLF",
          Description = "A multiplayer mod for Half-Life featuring unique gameplay mechanics.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2000}
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
            new ReleaseDate{Year = 2019},
            new ReleaseDate{Year = 2024, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "FrontlineForce",
          Name = "Frontline Force",
          Description = "A team-oriented first person shooter mod in which players are divided into 2 teams: Attackers and Defenders.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2001},
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
          Description = "Half-Life 2 raised the bar for action adventure first person shooters. At the time of its release it was considered"
            + " one of the best games ever made. It still holds up well today although the remaster 'Black Mesa' offers a more modern experience."
            + " Half-life 2 on Steam now includes the original expansions Episode 1 and Episode 2, as well as the deleted scene 'Lost Coast'."
            + " This is an absolute must play title and can be purchased as a standalone title, part of the Orange Box, The Half-Life Collection,"
            + " or as part of the Valve Complete Pack, which includes all of Valve's early titles. These bundles go on sale during most Steam sales."
            + " Watch steamDB for sales.",
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
            new ReleaseDate{Year = 2004, Month = 11, Day = 16},
          ]
        },
        new Game {
          GameID = "HalfLifeAlyx",
          Name = "Half-Life: Alyx",
          Description = "Half-Life: Alyx is a virtual reality first-person shooter set between Half-Life and Half-Life 2.",
          EngineID = "source2",
          Developer = "Valve Software",
          SteamID = 546560,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 3, Day = 23},
          ]
        },
        new Game {
          GameID = "HellLetLoose",
          Name = "Hell Let Loose",
          Description = "A realistic World War II first-person shooter featuring large-scale battles.",
          Developer = "Black Matter",
          SteamID = 686810,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2021, Month = 7, Day = 27}
          ]
        },
        new Game {
          GameID = "Holdfast",
          Name = "Holdfast: Nations at War",
          Description = "A multiplayer first-person shooter set during the Napoleonic Wars.",
          Developer = "Anvil Game Studios",
          SteamID = 589290,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2017, Month = 12, Day = 19}
          ]
        },
        new Game {
          GameID = "Homefront",
          Name = "Homefront",
          Description = "A first-person shooter set in an alternate history where North Korea invades the United States.",
          Developer = "Kaos Studios",
          SteamID = 55100,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2011, Month = 3, Day = 15}
          ]
        },
        new Game {
          GameID = "HostileIntent",
          Name = "Hostile Intent",
          Description = "Hostile Intent is a goldsrc mod featuring tactical round based gameplay similar to Counterstrike with some hardcore mechanics.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS          
        },
        new Game {
          GameID = "Go",
          Name = "Go",
          Description = "Go is a board game for two players.",
          IsFree = true,
          IsPaid = false,
          Genre = Genre.TBS,
          ReleaseDates = [
            new ReleaseDate{Year = -548}
          ]
        },
        new Game {
          GameID = "Isonzo",
          Name = "Isonzo",
          Description = "A World War I first-person shooter focusing on the Italian Front.",
          Developer = "BlackMill Games",
          SteamID = 1556790,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 9, Day = 13}
          ]
        },
        new Game {
          GameID = "LambdaFortress",
          Name = "Lambda Fortress",
          Description = "A Source 2 engine mod that brings co-op gameplay to the Team Fortress universe.",
          ModForGameID = "TF2",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2020},
          ]
        },
        new Game {
          GameID = "Left4Dead",
          Name = "Left 4 Dead",
          Description = "Left 4 Dead is a 4 player cooperative first-person shooter where players work together to survive against hordes of zombies."
            + " Valve invented the co-op zombie survival genre with this title, and it's still a lot of fun to play today. Left 4 Dead can be purchased as a standalone title,"
            + " part of the Valve Complete Pack, which includes all of Valve's early titles. Watch steamDB for sales.",
          EngineID = "source",
          Developer = "Valve Software",
          SteamID = 500,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2008, Month = 11, Day = 17},
          ]
        },
        new Game {
          GameID = "Left4Dead2",
          Name = "Left 4 Dead 2",
          Description = "Left 4 Dead 2 is a cooperative first-person shooter that expands on the original with new weapons, enemies, and campaigns."
          + " Left 4 Dead 2 is still played 4v4 online, and is a great 4 player survival game. This is available as part of the Valve Complete Pack,"
          + " which includes all of Valve's early titles. Watch steamDB for sales.",
          EngineID = "source",
          Developer = "Valve Software",
          SteamID = 550,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2009, Month = 11, Day = 17},
          ]
        },
        new Game {
          GameID = "MegaTF",
          Name = "Mega Team Fortress",
          Description = "Mega Team Fortress features expanded and extended abilities for the nine classes, and was the most widely played form of QWTF until replaced by the streamlined FortressOne. MegaTF is still played on a weekly Friday night game at 7pm EST on gamehost2.tastyspleen.net:27502",
          ModForGameID = "Quake1",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 1996},
          ]
        },
        new Game {
          GameID = "Midair2",
          Name = "Midair 2",
          Description = "A modern arena shooter featuring jetpack-based combat.",
          Developer = "Archetype Studios",
          SteamID = 1234567,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2023}
          ]
        },
        new Game {
          GameID = "MCVietnam",
          Name = "Military Conflict: Vietnam",
          Description = "A first-person shooter set during the Vietnam War.",
          Developer = "Antimatter Games",
          SteamID = 1234568,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2023}
          ]
        },
        new Game {
          GameID = "NaturalSelection",
          Name = "Natural Selection",
          Description = "A unique blend of first-person shooter and real-time strategy where two teams (humans and aliens) fight against each other.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2002},
          ]
        },
        new Game {
          GameID = "PavlovVR",
          Name = "Pavlov VR",
          Description = "A virtual reality first-person shooter featuring realistic weapon handling and multiplayer modes.",
          Developer = "Vankrupt Games",
          SteamID = 622970,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2017, Month = 2, Day = 27}
          ]
        },
        new Game {
          GameID = "Portal",
          Name = "Portal",
          Description = "Portal is a puzzle-platform game that introduced innovative gameplay mechanics and dark humor."
            + " Portal can be purchased as a standalone title, part of the Orange Box, or as part of the Valve Complete Pack,"
            + " which includes all of Valve's early titles. These bundles go on sale during most Steam sales. Watch steamDB for sales.",
          EngineID = "source",
          Developer = "Valve Software",
          SteamID = 400,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2007, Month = 10, Day = 10},
          ]
        },
        new Game {
          GameID = "Portal2",
          Name = "Portal 2",
          Description = "Portal 2 is a puzzle-platform game that expanded on the original Portal's mechanics with new features and a longer campaign."
            + " Portal 2 is one of Valve's best titles, and one of the best games of all time. It can be purchased as a standalone title,"
            + " part of the Orange Box, or as part of the Valve Complete Pack, which includes all of Valve's early titles."
            + " These bundles go on sale during most Steam sales. Watch steamDB for sales.",
          EngineID = "source",
          Developer = "Valve Software",
          SteamID = 620,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2011, Month = 4, Day = 19},
          ]
        },
        new Game {
          GameID = "PreFortress2",
          Name = "Pre-Fortress 2",
          Description = "A Source engine mod that recreates the beta era of Team Fortress 2.",
          ModForGameID = "TF2",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2007},
          ]
        },
        new Game {
          GameID = "PVK",
          Name = "Pirates, Vikings and Knights",
          Description = "A unique team-based combat game where three factions battle each other with period-appropriate weapons and abilities.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2003},
          ]
        },
        new Game {
          GameID = "Q3F",
          Name = "Quake 3 Fortress",
          Description = "Q3F was created in 2000 by the team that would become Splash Damage Studios. It was last updated in 2003 and to my knowledge there are no servers and the mod is not currently playable.",
          ModForGameID = "Quake3",
          IsOpenSource = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2000},
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
            new ReleaseDate{Year = 1996, Month = 6, Day = 22},
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
            new ReleaseDate{Year = 1997, Month = 12, Day = 9},
            new ReleaseDate{Year = 2007, Month = 8, Day = 3, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
            new ReleaseDate{Year = 2023, Month = 8, Day = 10, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2023, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "Quake3",
          Name = "Quake 3 Arena",
          Description = "Quake 3 Arena was released in 1999 and the expansion Quake 3: Team Arena was released in 2000. "
            + "Quake 3 Arena has largely been replaced by the Quake Live Remake but maintains a small player base, particularly in DeFrag movement servers.",
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
            new ReleaseDate{Year = 1999, Month = 12, Day = 2},
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
            new ReleaseDate{Year = 2005, Month = 10, Day = 18},
          ]
        },
        new Game {
          GameID = "QuakeChampions",
          Name = "Quake Champions",
          Description = "A free-to-play arena shooter that brings the classic Quake gameplay to the modern era with unique champion abilities.",
          EngineID = "idtech6",
          Developer = "id Software",
          SteamID = 611500,
          IsFree = true,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2017, Month = 8, Day = 22},
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
            new ReleaseDate{Year = 2010, Month = 8, Day = 6},
            new ReleaseDate{Year = 2014, Month = 9, Day = 14, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
          ]
        },
        new Game {
          GameID = "QWTF",
          Name = "QuakeWorld Team Fortress",
          Description = "The original Team Fortress, released as a mod in 1996. This team was hired by Valve to make TFC.",
          ModForGameID = "Quake1",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 1996},
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
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2011, Month = 10, Day = 4},
          ]
        },
        new Game {
          GameID = "Ricochet",
          Name = "Ricochet",
          Description = "Ricochet is a fast-paced first-person shooter with a unique focus on precision and accuracy.",
          EngineID = "source",
          Developer = "Valve Software",
          SteamID = 60,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2000},
          ]
        },
        new Game {
          GameID = "RTCW",
          Name = "Return to Castle Wolfenstein",
          Description = "A World War II first-person shooter featuring supernatural elements.",
          Developer = "id Software",
          EngineID = "idtech3",
          SteamID = 9010,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2001, Month = 11, Day = 20}
          ]
        },
        new Game {
          GameID = "SAndI",
          Name = "Science and Industry",
          Description = "A team-based multiplayer mod in which players take the roles of security guards at two competing research firms. Features a weapons research system.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2002},
          ]
        },
        new Game {
          GameID = "SvenCoop",
          Name = "Sven Co-op",
          Description = "A cooperative mod that allows players to fight against computer-controlled enemies together. Can play through the original Half-Life game and its expansions in co-op mode.",
          ModForGameID = "HalfLife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2016, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
            new ReleaseDate{Year = 1999, Month =1},
          ]
        },
        new Game {
          GameID = "TF2",
          Name = "Team Fortress 2",
          Description = "Team Fortress 2 is a team-based first-person shooter with unique character classes and cartoon-style graphics."
            + " TF2 was originally released as part of the Orange Box and as a standalone title, but it was converted to free to play."
            + " TF2 developed a massive playerbase and has had huge influcence on more recent class and hero based shooters.",
          EngineID = "source",
          Developer = "Valve Software",
          SteamID = 440,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2007, Month = 10, Day = 10},
          ]
        },
        new Game {
          GameID = "TF2Classic",
          Name = "Team Fortress 2 Classic",
          Description = "A Source engine mod that recreates the 2008 era of Team Fortress 2.",
          ModForGameID = "TF2",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2008},
          ]
        },
        new Game {
          GameID = "TF2Source",
          Name = "Team Fortress 2: Source",
          Description = "A Source 2 engine mod that recreates the early era of Team Fortress 2.",
          ModForGameID = "TF2",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2007},
          ]
        },
        new Game {
          GameID = "TF2Vintage",
          Name = "Team Fortress 2: Vintage",
          Description = "A Source engine mod that recreates the 2010 era of Team Fortress 2.",
          ModForGameID = "TF2",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2010},
          ]
        },
        new Game {
          GameID = "TFC",
          Name = "Team Fortress Classic",
          Description = "Team Fortress Classic is a mod for Half-Life that ported QWTF to the goldsrc engine.",
          ModForGameID = "HalfLife",
          Developer = "Valve Software",
          SteamID = 20,
          IsOpenSource = false,
          IsFree = false,
          IsPaid = true,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 1999},
          ]
        },
        new Game {
          GameID = "TheFinals",
          Name = "The Finals",
          Description = "A free-to-play first-person shooter featuring destructible environments and unique gameplay mechanics.",
          Developer = "Embark Studios",
          EngineID = "unreal5",
          SteamID = 2073850,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2023, Month = 12, Day = 8}
          ]
        },
        new Game {
          GameID = "Tribes1",
          Name = "Starsiege: Tribes",
          Description = "A groundbreaking multiplayer first-person shooter featuring jetpack-based combat.",
          Developer = "Dynamix",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = true,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 1998, Month = 12, Day = 1}
          ]
        },
        new Game {
          GameID = "Tribes3",
          Name = "Tribes 3: Rivals",
          Description = "A modern take on the classic Tribes series featuring jetpack-based combat.",
          Developer = "Prophecy Games",
          SteamID = 1234570,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 2024}
          ]
        },
        new Game {
          GameID = "UT2k",
          Name = "Unreal Tournament 2003 and 2004",
          Description = "Unreal Tournament 2003 and 2004.",
          EngineID = "unreal2",
          Developer = "Epic Games",
          RequiresCommunityPatch = true,
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 9, Day = 30, Region = Region.NA}
          ]
        },
        new Game {
          GameID = "UT3",
          Name = "Unreal Tournament 3",
          Description = "Unreal Tournament 3.",
          EngineID = "unreal3",
          Developer = "Epic Games",
          RequiresCommunityPatch = true,
          ReleaseDates = [
            new ReleaseDate{Year = 2007, Month = 11, Day = 19, Region = Region.NA}
          ]
        },
        new Game {
          GameID = "UT4",
          Name = "Unreal Tournament 4",
          Description = "",
          Developer = "Epic Games",
          EngineID = "unreal4",
          IsFree = false,
          IsPaid = false,
          IsOpenSource = true,
          IsReleased = false,
          IsDeveloperMaintained = false,
          RequiresCommunityPatch = true,
          Genre = Genre.FPS,
          ReleaseDates = []
        },
        new Game {
          GameID = "UT99",
          Name = "Unreal Tournament 99",
          Description = "Unreal Tournament 99 is a free-to-play arena shooter that brings the classic Quake gameplay to the modern era with unique champion abilities.",
          EngineID = "unreal",
          Developer = "Epic Games",
          RequiresCommunityPatch = true,
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 11, Day = 22},
          ]
        }
      };
    }
  }
}