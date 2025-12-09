using ASP_site.Models;

namespace ASP_site.Data.Initializers {
  public static class GameInitializer {
    public static Game[] GetGames() {
      return new Game[] {
        new Game {
          GameID = "0ad",
          Name = "0 A.D.",
          Description = "Free Open Source Real Time Strategy Game set between 500 BC and 500 AD.",
          EngineID = "Pyrogenesis",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.RTS,
          PlayWith = new List<int> { 0 , 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2010}
          ]
        },
        new Game {
          GameID = "3wavectf",
          Name = "3 Wave CTF",
          Description = "A remake of the Quake 1 CTF mod 3wave in the GoldSource engine.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          SteamID = 70,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "3wave",
            MasterServerKey = "GoldSource"
          }
        },
        new Game {
          GameID = "actionhalflife",
          Name = "Action Half-Life",
          Description = "A fast-paced action mod for Half-Life featuring new weapons and gameplay mechanics.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          SteamID = 70,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "action",
            MasterServerKey = "GoldSource"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2000}
          ]
        },
        new Game {
          GameID = "actionhalflifesource",
          Name = "Action Half-Life: Source",
          Description = "A fast-paced action mod for Half-Life: Source featuring new weapons and gameplay mechanics.",
          ModForGameID = "halflife2",
          EngineID = "source",
          SteamID = 977050,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/actionhls",
            GameDirectory = "action"
          }
        },
        new Game {
          GameID = "aoc",
          Name = "Age of Chivalry",
          Description = "A fast-paced action mod for Half-Life featuring new weapons and gameplay mechanics.",
          ModForGameID = "halflife",  
          EngineID = "goldsrc",
          SteamID = 17510,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/aoc",
            GameDirectory = "aoc"
          }
        },
        new Game {
          GameID = "aoe",
          Name = "Age of Empires",
          Description = "The original title in the Age of Empires series. The original title maintains a competitive scene in Vietnam, but most " +
            "players switched to AoE2. A Definitive Edition is available on Steam, but it does not receive regular updates anymore. " +
            "The AoE2:DE expansion \"Rise of Rome\" is a remake of AoE1 in the AoE2 engine, which received some additional balance updates.",
          Developer = "Ensemble Studios",
          EngineID = "genie",
          SteamID = 878380,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.RTS,
          PlayWith = new List<int> { 0, 1, 2, 3, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 1997, Month = 11, Day = 19},
            new ReleaseDate{Year = 2019, Month = 8, Day = 19, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease}
          ]
        },
        new Game {
          GameID = "aoe2",
          Name = "Age of Empires II",
          Description = "A classic real-time strategy game set in the Middle Ages. The Definitive Edition is available on Steam.",
          Developer = "Ensemble Studios",
          EngineID = "genie",
          SteamID = 813780,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.RTS,
          PlayWith = new List<int> { 0, 1, 2, 3, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 9, Day = 30},
            new ReleaseDate{Year = 2019, Month = 11, Day = 14, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease}
          ]
        },
        new Game {
          GameID = "aoe3",
          Name = "Age of Empires III",
          Description = "The third entry in the Age of Empires series, which also received a Definitive Edition on Steam.",
          Developer = "Ensemble Studios",
          SteamID = 813780,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.RTS,
          PlayWith = new List<int> { 0, 1, 2, 3, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 2005, Month = 10, Day = 25},
            new ReleaseDate{Year = 2020, Month = 10, Day = 15, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease}
          ]
        },
        new Game {
          GameID = "aoe4",
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
          PlayWith = new List<int> { 0, 1, 2, 3, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 2021, Month = 10, Day = 28}
          ]
        },
        new Game {
          GameID = "aom",
          Name = "Age of Mythology",
          Description = "A spin-off of the Age of Empires series, which received a \"Retold\" edition on Steam.",
          Developer = "Ensemble Studios",
          SteamID = 813780,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.RTS,
          PlayWith = new List<int> { 0, 1, 2, 3, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 10, Day = 31, Region = Region.NA},
            new ReleaseDate{Year = 2002, Month = 11, Day = 14, Region = Region.EU},
            new ReleaseDate{Year = 2024, Month = 9, Day = 4, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease}
          ]
        },
        new Game {
          GameID = "attackersgored",
          Name = "Attackers Go Red",
          Description = "A team-based multiplayer mod for Quake.",
          ModForGameID = "quake1",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2000}
          ]
        },
        new Game {
          GameID = "bangbangpewpew",
          Name = "Bang Bang Pew Pew",
          Description = "Bang Bang Pew Pew is a lightgun game available on Steam featuring online multiplayer minigames.",
          SteamID = 1818880,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 4, Day = 8}
          ]
        },
        new Game {
          GameID = "basedefense",
          Name = "Base Defense",
          Description = "",
          SteamID = 632730,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/bd"
          }
        },
        new Game {
          GameID = "battlebit",
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
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2023, Month = 6, Day = 15}
          ]
        },
        new Game {
          GameID = "bfield1942",
          Name = "Battlefield 1942",
          Description = "A first-person shooter game set during World War II.",
          Developer = "Electronic Arts",
          EngineID = "refractor1",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 9, Day = 10, Region = Region.NA},
            new ReleaseDate{Year = 2002, Month = 9, Day = 20, Region = Region.EU}
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "bfvietnam",
          Name = "Battlefield Vietnam",
          Description = "A first-person shooter game set during the Vietnam War.",
          Developer = "Electronic Arts",
          EngineID = "refractor1",
          IsFree = false,
          IsPaid = true,  
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [  
            new ReleaseDate{Year = 2004 }
          ]
        },
        new Game {
          GameID = "battlefield2",
          Name = "Battlefield 2",
          Description = "A first-person shooter game set during the Vietnam War.",
          Developer = "Electronic Arts",
          EngineID = "refractor2",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2005}
          ]
        },
        new Game {
          GameID = "bf2142",
          Name = "Battlefield 2142",
          Description = "A first-person shooter game set during the Vietnam War.",
          Developer = "Electronic Arts",
          EngineID = "refractor2",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 }, 
          ReleaseDates = [
            new ReleaseDate{Year = 2006}
          ]
        },
        new Game {
          GameID = "battlefieldbadcompany", 
          Name = "Battlefield: Bad Company",
          Description = "A first-person shooter game set during the Vietnam War.",
          Developer = "Electronic Arts",
          EngineID = "frostbite1",
          IsFree = false,
          IsPaid = true,  
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [  
            new ReleaseDate{Year = 2008}
          ]
        },
        new Game {
          GameID = "battlefieldheroes",
          Name = "Battlefield Heroes",  
          Description = "A first-person shooter game set during the Vietnam War.",
          Developer = "Electronic Arts",
          EngineID = "refractor2",
          IsFree = false,
          IsPaid = true,  
          IsOpenSource = false, 
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2009}
          ]
        },
        new Game {
          GameID = "battlefield1943",
          Name = "Battlefield 1943",
          Description = "A first-person shooter game set during World War II.",
          Developer = "Electronic Arts",
          EngineID = "frostbite15",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2009}
          ]
        },
        new Game {
          GameID = "battlefieldbadcompany2",
          Name = "Battlefield: Bad Company 2",
          Description = "A first-person shooter game set during the Vietnam War.",
          Developer = "Electronic Arts",
          EngineID = "frostbite15",
          IsFree = false,
          IsPaid = true,  
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2010}
          ]
        },
        new Game {
          GameID = "battlefieldonline",
          Name = "Battlefield Online",
          Description = "A first-person shooter game set during the Vietnam War.",
          Developer = "Electronic Arts",
          EngineID = "refractor2",
          IsFree = false,
          IsPaid = true,  
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2010}
          ]
        },
        new Game {
          GameID = "battlefieldplay4free",
          Name = "Battlefield Play4Free",
          Description = "A first-person shooter game set during the Vietnam War.",
          Developer = "Electronic Arts",
          EngineID = "refractor2",
          IsFree = true,
          IsPaid = false,  
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2011}
          ]
        },
        new Game {
          GameID = "battlefield3",
          Name = "Battlefield 3",
          Description = "A first-person shooter game set during the Vietnam War.",
          Developer = "Electronic Arts",
          EngineID = "frostbite2",
          IsFree = false,
          IsPaid = true,  
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2011}
          ]
        },
        new Game {
          GameID = "battlefield4",
          Name = "Battlefield 4",
          Description = "A first-person shooter game set during the Vietnam War.",
          Developer = "Electronic Arts",
          EngineID = "frostbite3",
          IsFree = false,
          IsPaid = true,  
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2013}
          ]
        },
        new Game {
          GameID = "battlefieldhardline",
          Name = "Battlefield Hardline",
          Description = "A first-person shooter game set during the Vietnam War.",
          Developer = "Electronic Arts",
          EngineID = "frostbite3",
          IsFree = false,
          IsPaid = true,  
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2013}
          ]
        },
        new Game {
          GameID = "battlefield1",
          Name = "Battlefield 1",
          Description = "A first-person shooter game set during World War I.",
          Developer = "Electronic Arts",
          EngineID = "frostbite3",
          IsFree = false,
          IsPaid = true,  
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2016}    
          ]
        },
        new Game {
          GameID = "battlefieldv",
          Name = "Battlefield V",
          Description = "A first-person shooter game set during World War II.", 
          Developer = "Electronic Arts",
          EngineID = "frostbite3",
          IsFree = false,
          IsPaid = true,  
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2018}
          ]
        },
        new Game {
          GameID = "battlefield2042",
          Name = "Battlefield 2042",
          Description = "A first-person shooter game set during the future.",
          Developer = "Electronic Arts",
          EngineID = "frostbite3",
          IsFree = false,
          IsPaid = true,  
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2021}
          ]
        },
        new Game {
          GameID = "battlegrounds",
          Name = "Battle Grounds",
          Description = "A multiplayer mod for Half-Life featuring muskets and other early firearms.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          SteamID = 70,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "bg",
            MasterServerKey = "GoldSource"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2000}
          ]
        },
        new Game {
          GameID = "battlegrounds2",
          Name = "Battle Grounds II",
          Description = "",
          EngineID = "source", 
          SteamID = 218,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/bg2"
          }
        },
        new Game {
          GameID = "battlegrounds3",
          Name = "Battle Grounds III",
          Description = "", 
          EngineID = "source",
          SteamID = 1057700,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/bg3"
          }
        },
        new Game {
          GameID = "bigbuckhunter",
          Name = "Big Buck Hunter Arcade",
          Description = "Big Buck Hunter Arcade is a lightgun hunting game available on Steam.",
          SteamID = 455700,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2008, Month = 10, Day = 25}
          ]
        },
        new Game {
          GameID = "biocrisis",
          Name = "BioCrisis",
          Description = "BioCrisis is a retro lightgun game available on Steam.",
          SteamID = 1448800,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 11, Day = 9}
          ]
        },
        new Game {
          GameID = "biocrisisreturn2thelab",
          Name = "BioCrisis: Return 2 the Lab",
          Description = "BioCrisis: Return 2 the Lab is a lightgun game to be released on Steam.",
          SteamID = 1835570,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1 },
          IsPlayable = false,
          ReleaseDates = [
            new ReleaseDate{Year = 2025}
          ]
        },
          new Game {
          GameID = "blackmesa",
          Name = "Black Mesa",
          Description = "A fan-made remake of the original Half-Life using the Source engine, featuring updated graphics and some new music and game mechanics.",
          ModForGameID = "halflife2",
          EngineID = "source",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          SteamID = 362890,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/bms"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 3, Day = 6},
          ]
        },
        new Game {
          GameID = "blueestate",
          Name = "Blue Estate The Game",
          Description = "Blue Estate is a rail shooter available on Steam.",
          SteamID = 305380,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2015, Month = 4, Day = 8}
          ]
        },
        new Game {
          GameID = "brainbread",
          Name = "BrainBread",
          Description = "A multiplayer mod for Half-Life featuring zombies and other horror elements.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/bb",
            GameDirectory = "brainbread",
            MasterServerKey = "GoldSource"
          }
        },
        new Game {
          GameID = "brainbread2",
          Name = "BrainBread 2",
          Description = "A multiplayer mod for Half-Life 2 featuring zombies and other horror elements.",
          ModForGameID = "sdk2013",
          EngineID = "source",
          SteamID = 346330,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/bb2"
          }
        },
        new Game {
          GameID = "bridge",
          Name = "Bridge",
          Description = "Bridge is a card game that is played by four players in partners of two, although varients exist for 3 or 5 players.",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.TBS,
          PlayWith = new List<int> { 2, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 1925}
          ]
        },
        new Game {
          GameID = "bumpercars",
          Name = "Bumpercars",
          Description = "A multiplayer mod for Half-Life featuring vehicle-based combat.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "BumperCars",
            MasterServerKey = "GoldSource"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2000}
          ]
        },
        new Game {
          GameID = "buzzybots",
          Name = "BuzzyBots",
          Description = "",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          SteamID = 70,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/buzzybots",
            GameDirectory = "buzzybots"
          }
        },
        new Game {
          GameID = "chess",
          Name = "Chess",
          Description = "A classic board game available on various platforms.",
          Developer = "Various",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = true,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.TBS,
          PlayWith = new List<int> { 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 600}
          ]
        },
        new Game {
          GameID = "civ6",
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
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2016, Month = 10, Day = 21}
          ]
        },
        new Game {
          GameID = "classicfortress2",
          Name = "Classic Fortress 2",
          Description = "A Source engine mod that brings Team Fortress Classic gameplay to the Source engine.",
          ModForGameID = "tf2",
          EngineID = "source",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2007},
          ]
        },
        new Game {
          GameID = "cnc",
          Name = "C&C: Tiberian Dawn",
          Description = "The original Command & Conquer game, a groundbreaking real-time strategy title.",
          Developer = "Westwood Studios",
          SteamID = 2229830,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.RTS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1995, Month = 8, Day = 31}
          ]
        },
        new Game {
          GameID = "cncgenerals",
          Name = "C&C: Generals",
          Description = "A modern take on the Command & Conquer series featuring contemporary warfare.",
          Developer = "EA Pacific",
          SteamID = 2229870,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.RTS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2003, Month = 2, Day = 11}
          ]
        },
        new Game {
          GameID = "cncra2",
          Name = "C&C: Red Alert 2",
          Description = "A classic entry in the Red Alert series featuring alternate history and unique factions.",
          Developer = "Westwood Studios",
          SteamID = 2229850,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.RTS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2000, Month = 10, Day = 23}
          ]
        },
        new Game {
          GameID = "cncrenegade",
          Name = "C&C: Renegade",
          Description = "A first-person shooter spin-off of the Command & Conquer series.",
          Developer = "Westwood Studios",
          SteamID = 2229890,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 2, Day = 26}
          ]
        },
        new Game {
          GameID = "cncts",
          Name = "C&C: Tiberian Sun",
          Description = "A sequel to Tiberian Dawn, featuring new factions and improved graphics.",
          Developer = "Westwood Studios",
          SteamID = 2229880,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.RTS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 8, Day = 27}
          ]
        },
        new Game {
          GameID = "callofduty",
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
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2003, Month = 10, Day = 29},
          ],
          //ServerConfig = new ServerBrowserConfig {
          //  QueryProtocol = "GameSpy",
          //  MasterServerKey = "CallOfDuty"
          //}
        },
        new Game {
          GameID = "cod2",
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
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2005, Month = 10, Day = 25},
          ]
        },
        new Game {
          GameID = "cod4",
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
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2007, Month = 11, Day = 5},
          ]
        },
        new Game {
          GameID = "codaw",
          Name = "Call of Duty: Advanced Warfare",
          Description = "A futuristic entry introducing exoskeleton movement and advanced technology.",
          EngineID = "sledgehammer",
          Developer = "Sledgehammer Games",
          SteamID = 209660,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2014, Month = 11, Day = 4},
          ]
        },
        new Game {
          GameID = "codbo1",
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
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2010, Month = 11, Day = 9},
          ]
        },
        new Game {
          GameID = "codbo2",
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
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2012, Month = 11, Day = 13},
          ]
        },
        new Game {
          GameID = "codbo3",
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
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2015, Month = 11, Day = 6},
          ]
        },
        new Game {
          GameID = "codbo4",
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
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2018, Month = 10, Day = 12},
          ]
        },
        new Game {
          GameID = "codbo6",
          Name = "Call of Duty: Black Ops 6",
          Description = "The sixth entry in the Black Ops series, featuring a new story and characters.",
          EngineID = "iw9",
          Developer = "Treyarch",
          SteamID = 2933620,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2024, Month = 10, Day = 25},
          ]
        },
        new Game {
          GameID = "codbocw",
          Name = "Call of Duty: Black Ops Cold War",
          Description = "A return to the Cold War era, featuring a campaign that connects to the original Black Ops.",
          EngineID = "treyarch2",
          Developer = "Treyarch",
          SteamID = 1985810,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 11, Day = 13},
          ]
        },
        new Game {
          GameID = "codghosts",
          Name = "Call of Duty: Ghosts",
          Description = "A standalone entry featuring a new story and characters, introducing dynamic map events.",
          EngineID = "iw6",
          Developer = "Infinity Ward",
          SteamID = 209160,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2013, Month = 11, Day = 5},
          ]
        },
        new Game {
          GameID = "codiw",
          Name = "Call of Duty: Infinite Warfare",
          Description = "A space combat entry featuring space battles and zero-gravity combat.",
          EngineID = "iw7",
          Developer = "Infinity Ward",
          SteamID = 292730,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2016, Month = 11, Day = 4},
          ]
        },
        new Game {
          GameID = "codmw2",
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
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2009, Month = 11, Day = 10},
          ]
        },
        new Game {
          GameID = "codmw2019",
          Name = "Call of Duty: Modern Warfare",
          Description = "A reboot of the Modern Warfare series, featuring realistic combat and a new engine.",
          EngineID = "iw8",
          Developer = "Infinity Ward",
          SteamID = 2000950,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2019, Month = 10, Day = 25},
          ]
        },
        new Game {
          GameID = "codmw2r",
          Name = "Call of Duty: Modern Warfare II",
          Description = "The sequel to the Modern Warfare reboot, featuring new multiplayer mechanics and a continuation of the story.",
          EngineID = "iw9",
          Developer = "Infinity Ward",
          SteamID = 1938090,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 10, Day = 28},
          ]
        },
        new Game {
          GameID = "codmw3",
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
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2011, Month = 11, Day = 8},
          ]
        },
        new Game {
          GameID = "codmw3r",
          Name = "Call of Duty: Modern Warfare III",
          Description = "The latest entry in the Modern Warfare series, featuring a continuation of the reboot storyline.",
          EngineID = "iw9",
          Developer = "Sledgehammer Games",
          SteamID = 2018100,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2023, Month = 11, Day = 10},
          ]
        },
        new Game {
          GameID = "codv",
          Name = "Call of Duty: Vanguard",
          Description = "Another World War II entry, focusing on special forces operations across different theaters of war.",
          EngineID = "iw8",
          Developer = "Sledgehammer Games",
          SteamID = 1985820,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2021, Month = 11, Day = 5},
          ]
        },
        new Game {
          GameID = "codwaw",
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
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2008, Month = 11, Day = 11},
          ]
        },
        new Game {
          GameID = "codwwii",
          Name = "Call of Duty: WWII",
          Description = "A return to World War II, featuring the European Theater and a new social space called Headquarters.",
          EngineID = "sledgehammer",
          Developer = "Sledgehammer Games",
          SteamID = 476600,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2017, Month = 11, Day = 3},
          ]
        },
        new Game {
          GameID = "codwz",
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
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 3, Day = 10},
          ]
        },
        new Game {
          GameID = "codwz2",
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
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 11, Day = 16},
          ]
        },
        new Game {
          GameID = "codenamecure",
          Name = "Codename CURE",
          Description = "A psychological horror game that puts the player in the shoes of Simon, a paraplegic who writes a book for therapy, and in the process faces the inner demons that plague his thoughts. Features a co-op mode.",
          EngineID = "source",
          SteamID = 355180,
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/cure"
          }
        },
        new Game {
          GameID = "coldice",
          Name = "Cold Ice Remastered (beta 5)",
          Description = "A remastered version of the Cold Ice mod for Half-Life.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "ice_beta5",
            MasterServerKey = "GoldSource"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2020}
          ]
        },
        new Game {
          GameID = "contagion",
          Name = "Contagion",
          Description = "A horror game that puts the player in the shoes of a survivor of a zombie apocalypse.",
          SteamID = 238430,
          EngineID = "source",
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/contagion"
          }
        },
        new Game {
          GameID = "corpsekiller",
          Name = "Corpse Killer",
          Description = "Corpse Killer is a full motion video lightgun game now available on Steam.",
          SteamID = 1087700,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2019, Month = 7, Day = 30}
          ]
        },
          new Game {
          GameID = "cryoffearmod",
          Name = "Cry of Fear (Mod Version)",
          Description = "A psychological horror game that puts the player in the shoes of Simon, a paraplegic who writes a book for therapy, and in the process faces the inner demons that plague his thoughts. Features a co-op mode.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          SteamID = 70,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/cof",
            GameDirectory = "cof",
            MasterServerKey = "GoldSource"
          }
        },
        new Game {
          GameID = "cs16",
          Name = "Counter-Strike 1.6",
          Description = "The classic version of Counter-Strike that defined competitive FPS gaming. Features tactical gameplay between terrorists and counter-terrorists.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          Developer = "Valve Software",
          SteamID = 10,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 5 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/cs",
            GameDirectory = "cstrike"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2000, Month = 11, Day = 8},
            new ReleaseDate{Year = 2003, Month = 9, Day = 12, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
          ]
        },
        new Game {
          GameID = "csx",
          Name = "Counter-Strike: Xbox",
          Description = "Counter-Strike was released on Xbox in 2005.",
          EngineID = "goldsrc",
          Developer = "Valve Software",
          IsPlayable = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1, 5 },
          ReleaseDates = [
            new ReleaseDate{Year = 2003, Month = 11, Day = 18, Region = Region.NA},
            new ReleaseDate{Year = 2003, Month = 12, Day = 5, Region = Region.EU},
          ]
        },
        new Game {
          GameID = "cscz",
          Name = "Counter-Strike: Condition Zero",
          Description = "A spin-off of Counter-Strike featuring single-player missions and additional multiplayer content.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          Developer = "Valve Software",
          SteamID = 80,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1, 5 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/cscz",
            GameDirectory = "czero"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2004, Month = 3, Day = 23},
          ]
        },
        new Game {
          GameID = "css",
          Name = "Counter-Strike: Source",
          Description = "Counter-Strike: Source was released in 2004 as a paid title and converted to free to play, then replaced by CS2.",
          EngineID = "source",
          Developer = "Valve Software",
          IsPlayable = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 5 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/css",
            GameDirectory = "cstrike"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2004, Month = 11, Day = 18},
          ]
        },
        new Game {
          GameID = "csgo",
          Name = "CS:GO",
          Description = "Counter-Strike: Global Offensive was released in 2012 as a paid title and converted to free to play, then replaced by CS2.", 
          EngineID = "source",
          Developer = "Valve Software",
          IsPlayable = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 2, 5 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/csgo",
            GameDirectory = "csgo"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2012, Month = 8, Day = 21},
          ]
        },
        new Game {
          GameID = "cs2",
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
          PlayWith = new List<int> { 2, 5 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/cs2"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2023, Month = 9, Day = 27, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2025, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "crazytaxi",
          Name = "Crazy Taxi",
          Description = "Crazy Taxi is a racing game developed by Sega.",
          EngineID = "NAOMI",
          PlayWith = new List<int> { 1 },
          Genre = Genre.Racing,
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 2, ReleaseVersion = ReleaseVersion.Dreamcast, Region = Region.Worldwide},
          ]
        },
        new Game {
          GameID = "customtf",
          Name = "CustomTF",
          Description = "CustomTF allows for co-op and pub gameplay with customizable classes which you choose within a budget of money for equipment. CustomTF is played in a weekly pub game every Saturday at 7 pm EST on gamehost2.tastyspleen.net:27507",
          ModForGameID = "quake1",
          EngineID = "idtech2",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 1996},
          ]
        },
        new Game {
          GameID = "darkmessiah",
          Name = "Dark Messiah of Might & Magic",
          Description = "A fantasy action-RPG, the Xbox version used SDK2007.",
          SteamID = 2130,
          ModForGameID = "sdk2006",
          EngineID = "source",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/messiah",
            GameDirectory = "mm",
            MasterServerKey = "DarkMessiah",
            NoBackgroundService = true
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2006, Month = 10, Day = 25}
          ]
        },
        new Game {
          GameID = "ds",
          Name = "Darkstalkers",
          Description = "Darkstalkers is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1994, Month = 7, Day = 5}
          ]
        },
        new Game {
          GameID = "deadlock",
          Name = "Deadlock",
          Description = "Valve's latest title, still in development, is a MOBA with hero shooter mechanics.",
          SteamID = 1422450,
          EngineID = "source2",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          IsReleased = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 6 },
          ReleaseDates = []
        },
        new Game {
          GameID = "deusex",
          Name = "Deus Ex",
          Description = "Deus Ex is a first-person shooter game developed by Ion Storm.",
          EngineID = "unreal",
          Developer = "Ion Storm",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2000, Month = 6, Day = 23, Region = Region.Worldwide}
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "deusexinvisiblewar",
          Name = "Deus Ex: Invisible War",
          Description = "Deus Ex: Invisible War is a first-person shooter game developed by Ion Storm.",
          EngineID = "unreal2",
          Developer = "Ion Storm",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2003, Month = 12, Day = 2, Region = Region.NA},
            new ReleaseDate{Year = 2004, Month = 3, Day = 5, Region = Region.EU},
          ]
        },
        new Game {
          GameID = "diabotical",
          Name = "Diabotical",
          Description = "Diabotical is an original arena shooter using mechanics from Quake 3 and Unreal Tournament.",
          Developer = "The GD Studio",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 9, Day = 3}
          ]
        },
        new Game {
          GameID = "diprip",
          Name = "D.I.P.R.I.P. Warm Up",
          Description = "",
          SteamID = 17530,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/diprip"
          }
        },
        new Game {
          GameID = "dirtybomb",
          Name = "Dirty Bomb",
          Description = "Dirty Bomb is an original IP from Splash Damage Studios, the creators of Enemy Territory."
            + " The game features modern class-based gameplay on progressive mixed-objective maps with 23 playable 'mercs' filling five roles: medic, engineer, assault, fire support, and recon."
            + " No longer actively developed, the game is now completely free on Steam and as of 2025 still has consistently full 8v8 pubs.",
          Developer = "Splash Damage",
          EngineID = "unreal3",
          SteamID = 333930,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2015, Month = 6, Day = 1},
            new ReleaseDate{Year = 2022, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "dmc",
          Name = "Deathmatch Classic",
          Description = "Deathmatch Classic was Valve's port of QuakeWorld Deathmatch to the goldsrc engine.",
          SteamID = 40,
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/dmc",
            GameDirectory = "dmc"
          }
        },
        new Game {
          GameID = "dmcr",
          Name = "DMC:R",
          Description = "Deathmatch Classic was Valve's port of QuakeWorld Deathmatch to the goldsrc engine."
            + "DMC:R is a source mod which extends this legacy to the the Half-Life 2 engine.",
          ModForGameID = "halflife2",
          EngineID = "source",
          Developer = "CoaXioN",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsReleased = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = []
        },
        new Game {
          GameID = "dod",
          Name = "Day of Defeat",
          Description = "A World War II first-person shooter that was originally a mod and later became a commercially released game.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          Developer = "Valve Software",
          SteamID = 30,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 6 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/dod",
            GameDirectory = "dod"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2003, Month = 5, Day = 1, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
          ]
        },
        new Game {
          GameID = "dods",
          Name = "Day of Defeat: Source",
          Description = "Day of Defeat: Source is a source mod which extends the legacy of Day of Defeat to the Half-Life 2 engine.",
          ModForGameID = "halflife2",
          EngineID = "source",
          Developer = "Valve Software",
          SteamID = 300,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 6 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/dods",
            GameDirectory = "dod"
          }
        },
        new Game {
          GameID = "dcop",
          Name = "DCOP",
          Description = "DCOP is a full motion video lightgun game available on Steam.",
          SteamID = 2542320,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2023, Month = 10, Day = 20}
          ]
        },
        new Game {
          GameID = "deadcontainment",
          Name = "Dead Containment",
          Description = "Dead Containment is an on-rails lightgun game available on Steam with online play.",
          SteamID = 1302230,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 10, Day = 21}
          ]
        },
        new Game {
          GameID = "dinod-day",
          Name = "Dino D-Day",
          Description = "",
          EngineID = "source",
          SteamID = 70000,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/dino"
          }
        },
        new Game {
          GameID = "doom",
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
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1993, Month = 12, Day = 10},
            new ReleaseDate{Year = 2024, Month = 8, Day = 8, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2025, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "doom2016",
          Name = "Doom 2016",
          Description = "Doom 2016 is a first-person shooter game developed by id Software.",
          EngineID = "idtech6",
          Developer = "id Software",
          SteamID = 379720,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2016, Month = 5, Day = 13},
          ]
        },
        new Game {
          GameID = "doom3",
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
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2004, Month = 9, Day = 30},
            new ReleaseDate{Year = 2012, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2025, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "doomdarkages",
          Name = "Doom: The Dark Ages",
          Description = "Doom: The Dark Ages is a first-person shooter game developed by id Software and is the most recent installment in the Doom series.",
          EngineID = "idtech8",
          Developer = "id Software",
          SteamID = 3017860,
          IsReleased = false,
          IsPlayable = true,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2025, Month = 5, Day = 15},
          ]
        },
        new Game {
          GameID = "doometernal",
          Name = "Doom Eternal",
          Description = "Doom Eternal is a first-person shooter game developed by id Software.",
          EngineID = "idtech7",
          Developer = "id Software",
          SteamID = 782330,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 3, Day = 20},
          ]
        },
        new Game {
          GameID = "dab",
          Name = "Double Action: Boogaloo",
          Description = "",
          EngineID = "source",
          SteamID = 317360,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/dab",
            GameDirectory = "dab"
          }
        },
        new Game {
          GameID = "duke3d",
          Name = "Duke Nukem 3D",
          Description = "Duke Nukem 3D is a first-person shooter game developed by Apogee Software.",
          EngineID = "build",
          Developer = "Apogee Software",
          IsFree = true,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1996, Month = 1, Day = 29}
          ]
        },
        new Game {
          GameID = "dnf",
          Name = "Duke Nukem Forever",
          Description = "Duke Nukem Forever is a first-person shooter game developed by 3D Realms.",
          EngineID = "unreal",
          Developer = "3D Realms",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2011, Month = 6, Day = 10, Region = Region.EU},
            new ReleaseDate{Year = 2011, Month = 6, Day = 14, Region = Region.NA},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "dystopia",
          Name = "Dystopia",
          Description = "",
          EngineID = "source",
          SteamID = 17580,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/dys",
            GameDirectory = "dys"
          }
        },
       new Game {
          GameID = "dota2",
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
          PlayWith = new List<int> { 0,5 },
          ReleaseDates = [
            new ReleaseDate{Year = 2013, Month = 7, Day = 9},
          ]
        },
        new Game {
          GameID = "eleven",
          Name = "Eleven",
          Description = "Eleven is an accurate and competitive table tennis game for VR hardware.",
          IsFree = false,
          IsPaid = true,
          SteamID = 488310,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.Sports,
          PlayWith = new List<int> { 0, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2016, Month = 6, Day = 20},
          ]
        },
        new Game {
          GameID = "esf",
          Name = "Earth's Special Forces",
          Description = "A Dragon Ball Z mod for Half-Life featuring unique combat mechanics.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          SteamID = 70,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/esf",
            GameDirectory = "esf",
            MasterServerKey = "GoldSource"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2000}
          ]
        },
        new Game {
          GameID = "empires",
          Name = "Empires",
          Description = "FPS and RTS hybrid source mod.",
          ModForGameID = "sdk2013",
          EngineID = "source",
          SteamID = 17740,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/empires"
          }
        },
        new Game {
          GameID = "et",
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
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2003, Month = 5, Day = 29},
            new ReleaseDate{Year = 2022, Month = 5, Day = 19, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease}
          ]
        },
        new Game {
          GameID = "etf",
          Name = "Enemy Territory Fortress",
          Description = "ETF is a port of Q3F to Enemy Territory. This game is currently playable though no one is playing that I know of.",
          ModForGameID = "et",
          EngineID = "idtech3",
          IsOpenSource = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2003},
          ]
        },
        new Game {
          GameID = "epoch",
          Name = "Epoch",
          Description = "Epoch is a cover-based lightgun game developed by Epoch Games.",
          SteamID = 270510,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2014, Month = 6, Day = 5}
          ]
        },
        new Game {
          GameID = "eternalsilence",
          Name = "Eternal Silence",
          Description = "FPS and space combat mod for Half-Life 2.",
          ModForGameID = "sdk2006",
          EngineID = "source",
          SteamID = 215,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/es",
            GameDirectory = "Eternal-Silence"
          }
        },
        new Game {
          GameID = "eye",
          Name = "E.Y.E: Divine Cybermancy",
          Description = "",
          EngineID = "source",
          SteamID = 91700,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/eye"
          }
        },
        new Game {
          GameID = "firearms",
          Name = "Firearms",
          ModForGameID = "halflife",
          Description = "Western-themed half-life mod.",
          EngineID = "goldsrc",
          SteamID = 70,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "firearms"
          }
        },
        new Game {
          GameID = "firearmssource",
          Name = "Firearms: Source",
          Description = "Source engine sequel to Firearms.",
          ModForGameID = "halflife2",
          EngineID = "source",
          SteamID = 218,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/fas",
            GameDirectory = "fas"
          }
        },
        new Game {
          GameID = "fistfuloffrags",
          Name = "Fistful of Frags",
          Description = "",
          ModForGameID = "sdk2013",
          EngineID = "source",
          SteamID = 265630,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/fof"
          }
        },
        new Game {
          GameID = "ff",
          Name = "Fortress Forever",
          Description = "Fortress Forever is a mod for the Source engine that iterated the Team Fortress Classic style gameplay.",
          ModForGameID = "sdk2006",
          EngineID = "source",
          Developer = "Fortress Forever Team",
          SteamID = 253530,
          IsOpenSource = true,
          IsFree = true,
          IsPaid = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 4 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/ff"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2007}
          ]
        },
        new Game {
          GameID = "fortressone",
          Name = "FortressOne",
          Description = "FortressOne is a free and open source mod for QuakeWorld that brings Team Fortress to the modern era.",
          ModForGameID = "quake1",
          EngineID = "idtech2",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 2019},
            new ReleaseDate{Year = 2024, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "flf",
          Name = "Frontline Force",
          Description = "A team-oriented first person shooter mod in which players are divided into 2 teams: Attackers and Defenders.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/flf",
            GameDirectory = "frontline",
            MasterServerKey = "GoldSource"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2001}
          ]
        },
        new Game {
          GameID = "gmod",
          Name = "Garry's Mod",
          Description = "Source engine sandbox game.",
          EngineID = "source",
          IsFree = false,
          IsPaid = true,
          SteamID = 4000,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/gmod",
            GameDirectory = "garrysmod"
          }
        },
        new Game {
          GameID = "gmod9",
          Name = "Garry's Mod v9",
          Description = "",
          ModForGameID = "halflife2",
          EngineID = "source",
          SteamID = 215,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/gmod",
            GameDirectory = "gmod9",
            MasterServerKey = "Source",
            NoBackgroundService = true
          }
        },
        new Game {
          GameID = "globalops",
          Name = "Global Operations",
          Description = "Global Operations is a first-person shooter game developed by Barking Dog Studios.",
          EngineID = "unreal",
          Developer = "Barking Dog Studios",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 3, Day = 25, Region = Region.NA},
            new ReleaseDate{Year = 2002, Month = 5, Day = 10, Region = Region.EU},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "goldeneyesource",
          Name = "Golden Eye: Source",
          Description = "A source mod that recreates the original GoldenEye 007 game.",
          SteamID = 218,
          ModForGameID = "sdk2007",
          EngineID = "source",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/ges",
            GameDirectory = "gesource"
          }
        },
        new Game {
          GameID = "gunmanchronicles",
          Name = "Gunman Chronicles",
          Description = "",
          ModForGameID = "halflife2",
          EngineID = "source",
          Genre = Genre.FPS,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/gunman"
          }
        },
        new Game {
          GameID = "halflife",
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
          PlayWith = new List<int> { 0, 1 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "valve",
            MasterServerKey = "GoldSource"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 1998, Month = 11, Day = 19, Region = Region.NA, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Year = 1998, Month = 11, Day = 27, Region = Region.EU, ReleaseVersion = ReleaseVersion.FullGame}, 
            new ReleaseDate{Year = 2000, Month = 7, Day = 14, Region = Region.Asia, ReleaseVersion = ReleaseVersion.FullGame},
            new ReleaseDate{Year = 2024, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "halflife2",
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
          PlayWith = new List<int> { 0, 1 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl2",
            GameDirectory = "hl2"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2004, Month = 11, Day = 16},
          ]
        },
        new Game {
          GameID = "halflife2deathmatch",
          Name = "Half-Life 2: Deathmatch",
          Description = "The multiplayer mode of Half-Life 2 has always been a separate title on Steam and is included with the purchase of Half-Life 2.",
          SteamID = 320,
          ModForGameID = "halflife2",
          EngineID = "source",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl2"
          }
        },
        new Game {
          GameID = "halflifeadrenalinegamer",
          Name = "Half-Life: Adrenaline Gamer",
          Description = "Fan made pro-mod for Half-Life deathmatch.",
          SteamID = 70,
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/ag"
          }
        },
        new Game {
          GameID = "halflifeopposingforce",
          Name = "Half-Life: Opposing Force",
          Description = "Multiplayer deathmatch component of the Half-Life expansion pack Opposing Force.",
          SteamID = 50,
          ModForGameID = "halflife",
          EngineID = "goldsrc", 
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/op4",
            GameDirectory = "gearbox"
          }
        },
        new Game {
          GameID = "halflifeopposingforcectf",
          Name = "Half-Life: Opposing Force CTF",
          Description = "The CTF mode of Half-Life: Opposing Force expansion.",
          SteamID = 70,
          ModForGameID = "halflife",  
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/op4ctf",
            GameDirectory = "OpForCTF"
          }
        },
        new Game {
          GameID = "halfliferally",
          Name = "Half-Life: Rally",
          Description = "Half-Life: Rally is a first-person shooter game developed by Valve Software.",
          EngineID = "goldsrc",
          ModForGameID = "halflife",
          IsOpenSource = true,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Sports,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "hlrally",
            MasterServerKey = "GoldSource"
          }
        },
        new Game {
          GameID = "halflifealyx",
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
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 3, Day = 23},
          ]
        },
        new Game {
          GameID = "halogoldsrc",
          Name = "Halo: GoldSrc",
          Description = "Halo themed mod for Half-Life.",
          SteamID = 70,
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          Genre = Genre.FPS,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/halogs",
            GameDirectory = "halogs",
            MasterServerKey = "GoldSource"
          }
        },
        new Game {
          GameID = "hatintime",
          Name = "Hat in Time",
          Description = "Hat in Time is a 3D platformer with a unique hat-wearing mechanic.",
          Genre = Genre.Adventure,
          PlayWith = new List<int> { 1 , 2 },
          EngineID = "unreal3",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = true,
          ReleaseDates = [
            new ReleaseDate{Year = 2017, Month = 10, Day = 5}
          ]
        },
        new Game {
          GameID = "heavyfireafghanistan",
          Name = "Heavy Fire: Afghanistan",
          Description = "Heavy Fire: Afghanistan is a lightgun game available on Steam.",
          SteamID = 305980,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1, 2, 3, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 2014, Month = 8, Day = 15}
          ]
        },
        new Game {
          GameID = "heavyfireshatteredspear",
          Name = "Heavy Fire: Shattered Spear",
          Description = "Heavy Fire: Shattered Spear is a lightgun game available on Steam. It is a sequel to Heavy Fire: Afghanistan.",
          SteamID = 385600,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1, 2, 3, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 2015, Month = 10, Day = 23}
          ]
        },
        new Game {
          GameID = "hellletloose",
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
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2021, Month = 7, Day = 27}
          ]
        },
        new Game {
          GameID = "heretic",
          Name = "Heretic",
          Description = "Heretic is a first-person shooter game developed by Raven Software.",
          EngineID = "idtech1",
          Developer = "Raven Software",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1994, Month = 12, Day = 29, Region = Region.NA},
            new ReleaseDate{Year = 1996, Month = 3, Day = 22, Region = Region.NA},
            new ReleaseDate{Year = 1996, Month = 3, Day = 31, Region = Region.EU},
          ]
        },
        new Game {
          GameID = "heretic2",
          Name = "Heretic 2",
          Description = "Heretic 2 is a first-person shooter game developed by Raven Software.",
          EngineID = "idtech3",
          Developer = "Raven Software",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1998, Month = 11, Day = 24, Region = Region.NA},
            new ReleaseDate{Year = 1998, Month = 12, Day = 4, Region = Region.EU},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "hexen",
          Name = "Hexen",
          Description = "Hexen is a first-person shooter game developed by Raven Software.",
          EngineID = "idtech1",
          Developer = "Raven Software",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1995, Month = 10, Day = 30, Region = Region.NA},
            new ReleaseDate{Year = 1996, Month = 3, Day = 22, Region = Region.EU},
          ]
        },
        new Game {
          GameID = "hiddensource",
          Name = "Hidden: Source",
          Description = "",
          ModForGameID = "halflife2",
          EngineID = "source",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          SteamID = 215,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hidden",
            GameDirectory = "hidden",
            MasterServerKey = "Source",
            NoBackgroundService = true
          }
        },
        new Game {
          GameID = "holdfast",
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
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2017, Month = 12, Day = 19}
          ]
        },
        new Game {
          GameID = "homefront",
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
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2011, Month = 3, Day = 15}
          ]
        },
        new Game {
          GameID = "hostileintent",
          Name = "Hostile Intent",
          Description = "Hostile Intent is a goldsrc mod featuring tactical round based gameplay similar to Counterstrike with some hardcore mechanics.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,  
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "hi",
            MasterServerKey = "GoldSource"
          }
        },
        new Game {
          GameID = "houseofthedeadremake",
          Name = "The House of the Dead Remake",
          Description = "The House of the Dead Remake is a lightgun game available on Steam.",
          SteamID = 1694600,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 4, Day = 28}
          ]
        },
        new Game {
          GameID = "houseofthedead2",
          Name = "House of the Dead 2",
          Description = "House of the Dead 2 is a shooting game developed by Sega.",
          Genre = Genre.Lightgun,
          EngineID = "NAOMI",
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1998, Month = 11, Day = 20, ReleaseVersion = ReleaseVersion.Arcade, Region = Region.JP},
            new ReleaseDate{Year = 1998, Month = 12, Day = 19, ReleaseVersion = ReleaseVersion.Arcade, Region = Region.NA},
            new ReleaseDate{Year = 1999, Month = 3, Day = 25, ReleaseVersion = ReleaseVersion.Dreamcast, Region = Region.JP},
            new ReleaseDate{Year = 1999, Month = 9, Day = 9, ReleaseVersion = ReleaseVersion.Dreamcast, Region = Region.NA},
            new ReleaseDate{Year = 1999, Month = 11, Day = 5, ReleaseVersion = ReleaseVersion.Dreamcast, Region = Region.EU},
            new ReleaseDate{Year = 2001, Month = 7, Day = 6, ReleaseVersion = ReleaseVersion.FullGame, Region = Region.NA},
            new ReleaseDate{Year = 2008, Month = 3, Day = 27, ReleaseVersion = ReleaseVersion.Wii, Region = Region.AU},
            new ReleaseDate{Year = 2008, Month = 3, Day = 28, ReleaseVersion = ReleaseVersion.Wii, Region = Region.EU},
          ]
        },
        new Game {
          GameID = "houseofthedead3",
          Name = "House of the Dead 3",
          Description = "House of the Dead 3 is abandonware and playable with a lightgun with community patches.",
          SteamID = 1087700,
          IsFree = false,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002}
          ]
        },
        new Game {
          GameID = "go",
          Name = "Go",
          Description = "Go is a board game for two players.",
          IsFree = true,
          IsPaid = false,
          Genre = Genre.TBS,
          PlayWith = new List<int> { 2 },
          ReleaseDates = [
            new ReleaseDate{Year = -548}
          ]
        },
        new Game {
          GameID = "infestus",
          Name = "Infestus",
          Description = "",
          EngineID = "source",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          SteamID = 656800,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/infestus"
          }
        },
        new Game {
          GameID = "insurgency",
          Name = "Insurgency",
          Description = "",
          EngineID = "source",
          SteamID = 222880,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/ins2"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2014, Month = 1, Day = 22}
          ]
        },
        new Game {
          GameID = "insurgencymoderninfantrycombat",
          Name = "Insurgency: Modern Infantry Combat",
          Description = "Insurgency: Modern Infantry Combat is a source mod that features modern warfare.",
          ModForGameID = "sdk2006",
          EngineID = "source",
          IsFree = true,  
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          SteamID = 17700,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/ins",
            MasterServerKey = "Source",
            NoBackgroundService = true
          }
        },
        new Game {
          GameID = "intake",
          Name = "Intake",
          Description = "Intake is a lightgun game available on Steam inspired by Dr. Mario.",
          SteamID = 237760,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2013, Month = 11, Day = 5}
          ]
        },
          new Game {
          GameID = "iosoccer",
          Name = "IOSoccer",
          Description = "",
          EngineID = "source",
          Genre = Genre.Sports,
          PlayWith = new List<int> { 0 },
          SteamID = 673560,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/soccer"
          }
        },
        new Game {
          GameID = "isonzo",
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
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 9, Day = 13}
          ]
        },
        new Game {
          GameID = "jabronibrawlepisode3",
          Name = "Jabroni Brawl: Episode 3",
          Description = "The modern complete instanity that is Jabroni Brawl.",
          EngineID = "source",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          SteamID = 869480,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/jb3"
          }
        },
        new Game {
          GameID = "jbmod",
          Name = "JBMod",
          Description = "The original Jabroni Brawl mod.",
          EngineID = "source",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          SteamID = 2158860,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/jbmod"
          }
        },
        new Game {
          GameID = "jojo",
          Name = "JoJo's Bizarre Adventure",
          Description = "JoJo's Bizarre Adventure (ジョジョの奇妙な冒険) is a fighting game developed by Capcom.",
          EngineID = "CPS-3",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1998, Month = 12, Day = 2}
          ]
        },  
        new Game {
          GameID = "jojo:heritage",
          Name = "JoJo's Bizarre Adventure: Heritage for the Future",
          Description = "JoJo's Bizarre Adventure: Heritage for the Future (ジョジョの奇妙な冒険 未来への遺産) is a fighting game developed by Capcom.",
          EngineID = "CPS-3",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 9, Day = 13}
          ]
        },
        new Game {
          GameID = "kingdomscollide",
          Name = "Kingdoms Collide",
          Description = "",
          SteamID = 218,
          EngineID = "source",
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/kc",
            GameDirectory = "KingdomsCollide"
          }
        },
        new Game {
          GameID = "kingpin",
          Name = "Kingpin: Life of Crime",
          Description = "Kingpin: Life of Crime is a first-person shooter game developed by Xatrix Entertainment.",
          EngineID = "idtech3",
          Developer = "Xatrix Entertainment",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 6, Day = 28, Region = Region.NA},
            new ReleaseDate{Year = 1999, Month = 7, Day = 9, Region = Region.EU},
            new ReleaseDate{Year = 1999, Month = 1, Day = 1, Region = Region.AU},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "lambdafortress",
          Name = "Lambda Fortress",
          Description = "A Source 2 engine mod that brings co-op gameplay to the Team Fortress universe.",
          ModForGameID = "tf2",
          EngineID = "source2",
          Developer = "CoaXioN",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2025},
          ]
        },
        new Game {
          GameID = "left4dead",
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
          PlayWith = new List<int> { 1, 4 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/l4d",
            GameDirectory = "left4dead",
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2008, Month = 11, Day = 17},
          ]
        },
        new Game {
          GameID = "left4dead2",
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
          PlayWith = new List<int> { 1, 4 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/l4d2",
            GameDirectory = "left4dead2"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2009, Month = 11, Day = 17},
          ]
        },
        new Game {  
          GameID = "madbullets",
          Name = "Mad Bullets",
          Description = "Mad Bullets is a lightgun game available on Steam, inspired by classic range games like Hogan's Alley.",
          SteamID = 452860,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2016, Month = 6, Day = 10}
          ]
        },
        new Game {
          GameID = "majormayhem",
          Name = "Major Mayhem",
          Description = "Major Mayhem is a cover-based lightgun game available on Steam, inspired by classic arcade games like Time Crisis.",
          SteamID = 264340,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2014, Month = 2, Day = 24}
          ]
        },
        new Game {
          GameID = "mvsf",
          Name = "Marvel vs. Street Fighter",
          Description = "Marvel vs. Street Fighter is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1997, Month = 6, Day = 20}
          ]
        },
        new Game {  
          GameID = "mvc",
          Name = "Marvel vs. Capcom",
          Description = "Marvel vs. Capcom is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1998, Month = 1, Day = 12}
          ]
        },
        new Game {
          GameID = "mvc2",
          Name = "Marvel vs. Capcom 2",
          Description = "Marvel vs. Capcom 2: New Age of Heroes is a crossover fighting game developed and published by Capcom.",
          EngineID = "NAOMI",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2000, Month = 3, Day = 23}
          ]
        },
        new Game {
          GameID = "masterswordcontinued",
          Name = "Master Sword: Continued",
          Description = "Master Sword: Continued is a mod for Half-Life that adds a new campaign and new weapons.",
          SteamID = 70,
          EngineID = "goldsrc",
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/msr",
            GameDirectory = "msc",
            MasterServerKey = "GoldSource"
          }
        },
        new Game {
          GameID = "masterswordrebirth",
          Name = "Master Sword: Rebirth",
          Genre = Genre.FPS,
          EngineID = "source",
          Description = "",
          SteamID = 1961680,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/msr",
            GameDirectory = "msc"
          }
        },
        new Game {
          GameID = "megatf",
          Name = "Mega Team Fortress",
          Description = "Mega Team Fortress features expanded and extended abilities for the nine classes, and was the most widely played form of QWTF until replaced by the streamlined FortressOne. MegaTF is still played on a weekly Friday night game at 7pm EST on gamehost2.tastyspleen.net:27502",
          ModForGameID = "quake1",
          EngineID = "idtech2",
          Genre = Genre.FPS,
          IsOpenSource = true,
          IsCommunityMaintained = true,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 1996},
          ]
        },
        new Game {
          GameID = "midair2",
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
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2023}
          ]
        },
        new Game {
          GameID = "mcvietnam",
          Name = "Military Conflict: Vietnam",
          Description = "A first-person shooter set during the Vietnam War, featuring arcade-style deathmatch, gun game, and other modes.",
          Developer = "Antimatter Games",
          EngineID = "source",
          SteamID = 1234568,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/mcv",
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2023}
          ]
        },
        new Game {
          GameID = "mohaa",
          Name = "Medal of Honor: Allied Assault",
          Description = "Developed by 2015 Inc and published by Electronic Arts, Medal of Honor: Allied Assault was the first Medal of Honor title available on PC. Two Expansion Packs were released, Spearhead and Breakthrough. Default game port is 12203.",
          EngineID = "idtech3",
          Developer = "EA Los Angeles",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 1, Day = 22, Region = Region.NA},
            new ReleaseDate{Year = 2002, Month = 2, Day = 15, Region = Region.EU},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "mohaas",
          Name = "Medal of Honor: Allied Assault Spearhead",
          Description = "Standalone expansion pack for Medal of Honor: Allied Assault.",
          EngineID = "idtech3",
          Developer = "EA Los Angeles",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 1, Day = 22, Region = Region.NA},
            new ReleaseDate{Year = 2002, Month = 2, Day = 15, Region = Region.EU},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "mohaab",
          Name = "Medal of Honor: Allied Assault Breakthrough",
          Description = "Standalone expansion pack for Medal of Honor: Allied Assault.",
          EngineID = "idtech3",
          Developer = "EA Los Angeles",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 1, Day = 22, Region = Region.NA},
            new ReleaseDate{Year = 2002, Month = 2, Day = 15, Region = Region.EU},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "mohaareborn",
          Name = "Medal of Honor: Allied Assault Reborn",
          Description = "Developed by 2015 Inc and published by Electronic Arts, Medal of Honor: Allied Assault was the first Medal of Honor title available on PC. Two Expansion Packs were released, Spearhead and Breakthrough. Default game port is 12203.",
          EngineID = "idtech3",
          Developer = "EA Los Angeles",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 1, Day = 22, Region = Region.NA},
            new ReleaseDate{Year = 2002, Month = 2, Day = 15, Region = Region.EU},
          ],
          //ServerConfig = new ServerBrowserConfig {
          //  MasterServerKey = "Reborn",
          //  QueryProtocol = "GameSpy"
          //}
        },
        new Game {
          GameID = "medalofhonorpacificassault",
          Name = "Medal of Honor: Pacific Assault",
          Description = "Medal of Honor: Pacific Assault is a first-person shooter game set during the Pacific War.",
          EngineID = "idtech3",
          Developer = "EA Los Angeles",
          IsFree = false, 
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2004, Month = 11, Day = 4, Region = Region.NA},
            new ReleaseDate{Year = 2004, Month = 11, Day = 19, Region = Region.EU}
          ]
        },
        new Game {
          GameID = "medalofhonorairborne",
          Name = "Medal of Honor: Airborne",
          Description = "Medal of Honor: Airborne is a first-person shooter game set during the Pacific War.",
          EngineID = "unreal3",
          Developer = "EA Los Angeles",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2007, Month = 8, Day = 28 },
          ]
        },
        new Game {
          GameID = "medalofhonor2010",
          Name = "Medal of Honor (2010)",
          Description = "Medal of Honor (2010) is a first-person shooter game set during World War II.",
          EngineID = "unreal3",
          Developer = "DICE",
          IsFree = false,
          SteamID = 47790,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2010, Month = 10, Day = 12, Region = Region.NA},
            new ReleaseDate{Year = 2010, Month = 10, Day = 14, Region = Region.AU},
            new ReleaseDate{Year = 2010, Month = 10, Day = 15, Region = Region.EU}
          ]
        },
        new Game {
          GameID = "medalofhonorwartfighter",
          Name = "Medal of Honor: Warfighter",
          Description = "Medal of Honor: Warfighter is a first-person shooter game set during the Pacific War.",
          EngineID = "frostbite2",
          Developer = "Danger Close Games",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2012, Month = 10, Day = 23, Region = Region.NA},
            new ReleaseDate{Year = 2012, Month = 10, Day = 25, Region = Region.AU},
            new ReleaseDate{Year = 2012, Month = 10, Day = 26, Region = Region.EU}
          ]
        },
        new Game {
          GameID = "missilecommandrecharged",
          Name = "Missile Command Recharged",
          Description = "Missile Command Recharged is a remake of the classic 1980s arcade game Missile Command and is playable with a lightgun.",
          SteamID = 2114990,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 11, Day = 1}
          ]
        },
        new Game {
          GameID = "mobileforces",
          Name = "Mobile Forces",
          Description = "Mobile Forces is a first-person shooter game developed by Rage Games.",
          EngineID = "unreal",
          Developer = "Rage Games",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 5, Day = 31, Region = Region.EU},
            new ReleaseDate{Year = 2002, Month = 8, Day = 16, Region = Region.NA},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "modularcombat",
          Name = "Modular Combat",
          Description = "",
          EngineID = "source",
          SteamID = 218,
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/modcom",
            GameDirectory = "ModularCombat"
          }
        },
        new Game {
          GameID = "naturalselection",
          Name = "Natural Selection",
          Description = "A unique blend of first-person shooter and real-time strategy where two teams (humans and aliens) fight against each other.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 6 },
          SteamID = 70,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/ns",
            GameDirectory = "ns"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2002},
          ]
        },
        new Game {
          GameID = "neotokyo",
          Name = "NEOTOKYO",
          Description = "Source mod with unqiue movement and gameplay mechanics.",
          SteamID = 218,
          ModForGameID = "sdk2006",
          EngineID = "source",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/nt",
            GameDirectory = "NeotokyoSource"
          }
        },
        new Game {
          GameID = "nerfarena",
          Name = "Nerf Arena",
          Description = "Nerf Arena is a first-person shooter game developed by Visionary Media Inc.",
          EngineID = "unreal",
          Developer = "Visionary Media Inc.",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 11, Day = 2, Region = Region.NA},
            new ReleaseDate{Year = 2000, Month = 3, Day = 10, Region = Region.UK},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "nomoreroominhell",
          Name = "No More Room in Hell",
          Description = "",
          ModForGameID = "sdk2013",
          EngineID = "source",
          SteamID = 224260,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/nmrih"
          }
        },
        new Game {
          GameID = "nucleardawn",
          Name = "Nuclear Dawn",
          Description = "A first-person shooter set in a post-apocalyptic world where players must fight against hordes of mutants and other enemies.",
          EngineID = "source",
          SteamID = 17710,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/nd"
          }
        },
        new Game {
          GameID = "obsidianconflict",
          Name = "Obsidian Conflict",
          Description = "",
          EngineID = "source",
          SteamID = 382110,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/oc"
          }
        },
        new Game {
          GameID = "obsidianconflictmod",
          Name = "Obsidian Conflict (MOD)",
          Description = "",
          ModForGameID = "sdk2007",
          EngineID = "source",
          SteamID = 218,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/oc",
            GameDirectory = "obsidian"
          }
        },
        new Game {
          GameID = "occupationcs",
          Name = "OccupationCS",
          Description = "",
          EngineID = "source",
          SteamID = 218,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/occupationcs",
            GameDirectory = "OccupationCS"
          }
        },     
        new Game {
          GameID = "openfortress",
          Name = "Open Fortress",
          Description = "",
          EngineID = "source",
          SteamID = 243750,
          Genre = Genre.FPS,  
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/tf2",
            GameDirectory = "open_fortress"
          }
        },
        new Game {
          GameID = "orion: source",
          Name = "Orion: Source",
          Description = "",
          EngineID = "source",
          SteamID = 218,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl2",
            GameDirectory = "orion"
          }
        },
        new Game {
          GameID = "pavlovvr",
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
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2017, Month = 2, Day = 27}
          ]
        },

        new Game {
          GameID = "portal",
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
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2007, Month = 10, Day = 10},
          ]
        },
        new Game {
          GameID = "portal2",
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
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2011, Month = 4, Day = 19},
          ]
        },
        new Game {
          GameID = "postal",
          Name = "Postal",
          Description = "Postal is a first-person shooter game developed by Running With Scissors.",
          Developer = "Running With Scissors",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1997, Month = 9, Day = 24, Region = Region.Worldwide}
          ]
        },
        new Game {
          GameID = "postal2",
          Name = "Postal 2",
          Description = "Postal 2 is a first-person shooter game developed by Running With Scissors.",
          EngineID = "unreal2",
          Developer = "Running With Scissors",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2003, Month = 4, Day = 14, Region = Region.NA},
            new ReleaseDate{Year = 2003, Month = 4, Day = 17, Region = Region.EU},
            new ReleaseDate{Year = 2003, Month = 4, Day = 17, Region = Region.JP},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "postal3",
          Name = "Postal 3",
          Description = "Postal 3 is a first-person shooter game developed by Running With Scissors.",
          EngineID = "source",
          Developer = "Running With Scissors",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2005, Month = 10, Day = 11, Region = Region.NA},
            new ReleaseDate{Year = 2005, Month = 10, Day = 14, Region = Region.EU},
          ],
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/pvkii",
          }
        },
        new Game {
          GameID = "postal4",
          Name = "Postal 4",
          Description = "Postal 4 is a first-person shooter game developed by Running With Scissors.",
          EngineID = "unreal4",
          Developer = "Running With Scissors",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 4, Day = 20, Region = Region.Worldwide}
          ]
        },
        new Game {
          GameID = "powerstone",
          Name = "Power Stone",
          Description = "Power Stone is a fighting game developed by Capcom.",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          EngineID = "NAOMI",
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 2, ReleaseVersion = ReleaseVersion.Arcade, Region = Region.JP},
            new ReleaseDate{Year = 1999, Month = 3, ReleaseVersion = ReleaseVersion.Arcade, Region = Region.NA},
            new ReleaseDate{Year = 1999, Month = 2, Day = 25, ReleaseVersion = ReleaseVersion.Dreamcast, Region = Region.JP},
            new ReleaseDate{Year = 1999, Month = 9, Day = 9, ReleaseVersion = ReleaseVersion.Dreamcast, Region = Region.NA},
            new ReleaseDate{Year = 1999, Month = 10, Day = 14, ReleaseVersion = ReleaseVersion.Dreamcast, Region = Region.EU},
            new ReleaseDate{Year = 2006, Month = 10, Day = 20, ReleaseVersion = ReleaseVersion.PSP, Region = Region.EU},
            new ReleaseDate{Year = 2006, Month = 10, Day = 25, ReleaseVersion = ReleaseVersion.PSP, Region = Region.AU},
            new ReleaseDate{Year = 2006, Month = 10, Day = 31, ReleaseVersion = ReleaseVersion.PSP, Region = Region.NA},
            new ReleaseDate{Year = 2006, Month = 11, Day = 30, ReleaseVersion = ReleaseVersion.PSP, Region = Region.JP},
          ]
        },
        new Game {
          GameID = "powerstone2",
          Name = "Power Stone 2",
          Description = "Power Stone 2 is a fighting game developed by Capcom.",
          EngineID = "NAOMI",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2000, Month = 4, Day = 20, ReleaseVersion = ReleaseVersion.Arcade, Region = Region.Worldwide},
            new ReleaseDate{Year = 2000, Month = 4, Day = 27, ReleaseVersion = ReleaseVersion.Arcade, Region = Region.JP},
            new ReleaseDate{Year = 2000, Month = 8, Day = 23, ReleaseVersion = ReleaseVersion.Dreamcast, Region = Region.NA},
            new ReleaseDate{Year = 2000, Month = 8, Day = 24, ReleaseVersion = ReleaseVersion.Dreamcast, Region = Region.EU},
            new ReleaseDate{Year = 2000, Month = 9, Day = 15, ReleaseVersion = ReleaseVersion.Dreamcast, Region = Region.UK},
            new ReleaseDate{Year = 2006, Month = 10, Day = 20, ReleaseVersion = ReleaseVersion.PSP, Region = Region.EU},
            new ReleaseDate{Year = 2006, Month = 10, Day = 25, ReleaseVersion = ReleaseVersion.PSP, Region = Region.AU},
            new ReleaseDate{Year = 2006, Month = 10, Day = 31, ReleaseVersion = ReleaseVersion.PSP, Region = Region.NA},
            new ReleaseDate{Year = 2006, Month = 11, Day = 30, ReleaseVersion = ReleaseVersion.PSP, Region = Region.JP},
          ]
        },
        new Game {
          GameID = "prefortress2",
          Name = "Pre-Fortress 2",
          Description = "A Source engine mod that recreates the beta era of Team Fortress 2.",
          ModForGameID = "tf2",
          EngineID = "source",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2007},
          ]
        },
        new Game {
          GameID = "pvk",
          Name = "Pirates, Vikings and Knights",
          Description = "A unique team-based combat game where three factions battle each other with period-appropriate weapons and abilities.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          SteamID = 70,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/pvk",
            GameDirectory = "pvk"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2003},
          ]
        },
        new Game {
          GameID = "pvkii",
          Name = "Pirates, Vikings and Knights II",
          Description = "Source mod sequel to Pirates, Vikings and Knights.",
          SteamID = 17570,
          ModForGameID = "halflife2",
          EngineID = "source",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/pvkii",
          }
        },
        new Game {
          GameID = "penemy",
          Name = "Public Enemy",
          Description = "",
          SteamID = 70,
          ModForGameID = "halflife2",
          EngineID = "source",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/penemy",
            GameDirectory = "penemy"
          }
        },
        new Game {
          GameID = "q3f",
          Name = "Quake 3 Fortress",
          Description = "Q3F was created in 2000 by the team that would become Splash Damage Studios. It was last updated in 2003 and to my knowledge there are no servers and the mod is not currently playable.",
          ModForGameID = "quake3",
          EngineID = "idtech3",
          IsOpenSource = true,
          IsCommunityMaintained = false,
          IsDeveloperMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 2000},
          ]
        },
        new Game {
          GameID = "quake1",
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
          PlayWith = new List<int> { 0, 1, 2, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 1996, Month = 6, Day = 22},
            new ReleaseDate{Year = 2007, Month = 8, Day = 3, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
            new ReleaseDate{Year = 2021, Month = 8, Day = 19, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2025, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "quake2",
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
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1997, Month = 12, Day = 9},
            new ReleaseDate{Year = 2007, Month = 8, Day = 3, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
            new ReleaseDate{Year = 2023, Month = 8, Day = 10, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.ReRelease},
            new ReleaseDate{Year = 2023, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.LatestUpdate}
          ]
        },
        new Game {
          GameID = "quake3",
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
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 12, Day = 2},
          ] 
        },
        new Game {
          GameID = "quake4",
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
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2005, Month = 10, Day = 18},
          ]
        },
        new Game {
          GameID = "qc",
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
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2017, Month = 8, Day = 22},
          ]
        },
        new Game {
          GameID = "quakelive",
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
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2010, Month = 8, Day = 6},
            new ReleaseDate{Year = 2014, Month = 9, Day = 14, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease},
          ]
        },
        new Game {
          GameID = "qwtf",
          Name = "QuakeWorld Team Fortress",
          Description = "The original Team Fortress, released as a mod in 1996. This team was hired by Valve to make TFC.",
          ModForGameID = "quake1",
          EngineID = "idtech2",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 1996},
          ]
        },
        new Game {
          GameID = "rage",
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
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2011, Month = 10, Day = 4},
          ]
        },
        new Game {
          GameID = "railbreak",
          Name = "Reload",
          Description = "Reload is a lightgun game available on Steam with a classic 90s Area 51 style.",
          SteamID = 330370,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1, 2, 3, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 2015, Month = 2, Day = 13}
          ]
        },
        new Game {
          GameID = "residentevilcoldblood",
          Name = "Resident Evil: Cold Blood",
          Description = "",
          EngineID = "goldsrc",
          SteamID = 70,
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/recb",
            GameDirectory = "recb"
          }
        },
        new Game {
          GameID = "resistanceandliberation",
          Name = "Resistance and Liberation",
          Description = "",
          EngineID = "goldsrc",
          SteamID = 218,
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/rnl",
            GameDirectory = "RnLBeta"
          }
        },
        new Game {
          GameID = "rezinfinite",
          Name = "Rez Infinite",
          Description = "Rez Infinite is a remake of the original Rez game available on Steam and is playable with a lightgun.",
          SteamID = 636450,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2017, Month = 8, Day = 9}
          ]
        },
        new Game {
          GameID = "ricochet",
          Name = "Ricochet",
          Description = "Ricochet is a fast-paced first-person shooter with a unique focus on precision and accuracy.",
          EngineID = "goldsrc",
          Developer = "Valve Software",
          SteamID = 60,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 }, 
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/ricochet",
            GameDirectory = "ricochet"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2000},
          ]
        },
        new Game {
          GameID = "rocketleague",
          Name = "Rocket League",
          Description = "Rocket League is a vehicular soccer game developed by Psyonix.",
          Genre = Genre.Sports,
          PlayWith = new List<int> { 3 },
          EngineID = "unreal3",
          ReleaseDates = [	
            new ReleaseDate{Year = 2015, Month = 7, Day = 7}
          ]
        },
        new Game {
          GameID = "rtcw",
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
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2001, Month = 11, Day = 20}
          ]
        },
        new Game {
          GameID = "rune",
          Name = "Rune",
          Description = "Rune is a first-person shooter game developed by Human Head Studios.",
          EngineID = "unreal",
          Developer = "Human Head Studios",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2000, Month = 10, Day = 27, Region = Region.NA},
            new ReleaseDate{Year = 2000, Month = 11, Day = 3, Region = Region.EU},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "sandi",
          Name = "Science and Industry",
          Description = "A team-based multiplayer mod in which players take the roles of security guards at two competing research firms. Features a weapons research system.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 6 },
          SteamID = 70,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/sai",
            GameDirectory = "sai",
            MasterServerKey = "GoldSource"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2002},
          ]
        },
        new Game {
          GameID = "scientisthunt",
          Name = "Scientist Hunt",
          ModForGameID = "halflife",
          Description = "",
          EngineID = "goldsrc",
          SteamID = 70,
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/sh",
            GameDirectory = "scihunt",
            MasterServerKey = "GoldSource"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2002},
          ]
        },
        new Game {
          GameID = "serioussam",
          Name = "Serious Sam: The First Encounter",
          Description = "Serious Sam: The First Encounter is a first-person shooter game developed by Croteam.",
          EngineID = "seriousengine",
          Developer = "Croteam",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2001, Month = 3, Day = 21 }
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "serioussamse",
          Name = "Serious Sam: The Second Encounter",
          Description = "Serious Sam: The Second Encounter is a first-person shooter game developed by Croteam.",
          EngineID = "seriousengine",
          Developer = "Croteam",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 2, Day = 5, Region = Region.Worldwide}
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "serioussam2",
          Name = "Serious Sam 2",
          Description = "Serious Sam 2 is a first-person shooter game developed by Croteam.",
          EngineID = "seriousengine2",
          Developer = "Croteam",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2005, Month = 10, Day = 11, Region = Region.NA},
            new ReleaseDate{Year = 2005, Month = 10, Day = 14, Region = Region.EU},
          ]
        },
        new Game {
          GameID = "serioussam3",
          Name = "Serious Sam 3: BFE",
          Description = "Serious Sam 3: BFE is a first-person shooter game developed by Croteam.",
          EngineID = "seriousengine3",
          Developer = "Croteam",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [	
            new ReleaseDate{Year = 2011, Month = 11, Day = 22, Region = Region.Worldwide}
          ]
        },
        new Game {
          GameID = "serioussam4",
          Name = "Serious Sam 4",
          Description = "Serious Sam 4 is a first-person shooter game developed by Croteam.",
          EngineID = "seriousengine4",
          Developer = "Croteam",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2020, Month = 9, Day = 24, Region = Region.Worldwide}
          ]
        },
        new Game {
          GameID = "shogi",
          Name = "Shogi",
          Description = "Shogi is a type of Japense chess. It is played by two players on a board with 10x9 squares.",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.TBS,
          PlayWith = new List<int> { 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1500}
          ]
        },
        new Game {
          GameID = "situationoutbreak",
          Name = "Situation Outbreak",
          Description = "",
          SteamID = 218,
          EngineID = "goldsrc",
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/so",
            GameDirectory = "so"
          }
        },
        new Game {
          GameID = "situationoutbreak2",
          Name = "Situation Outbreak 2",
          Description = "",
          SteamID = 218,
          EngineID = "goldsrc",
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/so",
            GameDirectory = "so2"
          }
        },
        new Game {
          GameID = "smashball",
          Name = "Smashball",
          Description = "",
          SteamID = 17730,
          EngineID = "source",
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/smashball",
          }
        },
        new Game {
          GameID = "smodtroopers",
          Name = "SMOD Troopers",
          Description = "",
          SteamID = 215,
          EngineID = "goldsrc",
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl2",
            GameDirectory = "SmodTroopers",
            MasterServerKey = "Source",
            NoBackgroundService = true
          }
        },
        new Game {
          GameID = "sofretail",
          Name = "Soldier of Fortune",
          Description = "",
          EngineID = "idtech2",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2000, Month = 3, Day = 28, Region = Region.NA},
            new ReleaseDate{Year = 2000, Month = 4, Day = 1, Region = Region.EU},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "sof2",
          Name = "Soldier of Fortune 2",
          Description = "",
          EngineID = "idtech3",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 5, Day = 21, Region = Region.NA},
            new ReleaseDate{Year = 2002, Month = 5, Day = 31, Region = Region.EU},
          ]
        },
        new Game {
          GameID = "sdk2006",
          Name = "Source SDK Base 2006",
          Description = "",
          SteamID = 215,
          EngineID = "source",
          Genre = Genre.FPS,
          Developer = "Valve",
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/sdk",
            GameDirectory = "hl2mp"
          }
        },
        new Game {
          GameID = "sdk2007",
          Name = "Source SDK Base 2007",
          Description = "",
          SteamID = 218,
          EngineID = "source",
          Genre = Genre.FPS,
          Developer = "Valve",
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/sdk",
            GameDirectory = "sourcetest"
          }
        },
        new Game {
          GameID = "sdk2013",
          Name = "Source SDK Base 2013 Multiplayer",
          Description = "",
          SteamID = 243750,
          EngineID = "source",
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          Developer = "Valve",
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/sdk"
          }
        },
        new Game {
          GameID = "southpark",
          Name = "South Park",
          Description = "South Park is a first-person shooter game developed by Iguana Entertainment.",
          Developer = "Iguana Entertainment",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 3, Day = 1, Region = Region.NA},
            new ReleaseDate{Year = 1999, Month = 3, Day = 5, Region = Region.EU},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "starcraft",
          Name = "Starcraft",
          Description = "Starcraft is a real-time strategy game developed by Blizzard Entertainment.",
          Genre = Genre.RTS,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          PlayWith = new List<int> { 1, 2, 3, 4 },
          Developer = "Blizzard Entertainment",
        },
        new Game {
          GameID = "starcraft2",
          Name = "Starcraft 2",
          Description = "Starcraft 2 is a real-time strategy game developed by Blizzard Entertainment.",
          EngineID = "source",
          Developer = "Blizzard Entertainment",
          SteamID = 1180620,
          IsFree = true,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.RTS,
          PlayWith = new List<int> { 1, 2, 3, 4 },
          ReleaseDates = [
            new ReleaseDate{Year = 2010, Month = 7, Day = 27},
          ]
        },
        new Game {
          GameID = "sf2ww",
          Name = "Street Fighter 2: The World Warrior",
          Description = "Capcom's sequel to Street Fighter, this game launched the fighting game genre.",
          EngineID = "CPS-1",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1991, Month = 2, Day = 6}
          ]
        },
        new Game {
          GameID = "sf2ce",
          Name = "Street Fighter 2: Champion Edition",
          Description = "'Street Fighter Dash' in Japan, the first update to The World Warrior, this version added the 4 bosses as playable characters and allowed for mirror matches.",
          EngineID = "CPS-1",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1992, Month = 3, Day = 13}
          ]
        },
        new Game {
          GameID = "sf2hf",
          Name = "Street Fighter 2: Hyper Fighting Edition",
          Description = "The second update to The World Warrior, this version added faster gameplay and some new moves.",
          EngineID = "CPS-1",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1992, Month = 12, Day = 9}
          ]
        },
        new Game {
          GameID = "ssf2nc",
          Name = "Super Street Fighter 2: The New Challengers",
          Description = "The third update to The World Warrior, this version was a graphics overhaul and added four new characters: Cammy, Fei Long, Dee Jay, and T. Hawk.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1993, Month = 9, Day = 10}
          ]
        },
        new Game {
          GameID = "ssf2t",
          Name = "Super Street Fighter 2: Turbo",
          Description = "The fourth update to The World Warrior, this version added super moves and Akuma as a playable character.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1994, Month = 2, Day = 23}
          ]
        },
        new Game {
          GameID = "sfalpha",
          Name = "Street Fighter Alpha",
          Description = "Street Fighter Alpha (ストリートファイターZERO) is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1995, Month = 6, Day = 5}
          ]
        },
        new Game {
          GameID = "sfalpha2",
          Name = "Street Fighter Alpha 2",
          Description = "Street Fighter Alpha 2 (ストリートファイターZERO2) is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1996, Month = 2, Day = 27}
          ]
        },
        new Game {
          GameID = "spf2t",
          Name = "Super Puzzle Fighter II Turbo",
          Description = "Super Puzzle Fighter II Turbo (スーパーパズルファイターIIX) is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1996, Month = 5, Day = 29}
          ]
        },
        new Game {
          GameID = "sfalpha3",
          Name = "Street Fighter Alpha 3",
          Description = "Street Fighter Alpha 3 (ストリートファイターZERO3) is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1998, Month = 6, Day = 29}
          ]
        },
        new Game {
          GameID = "sf3",
          Name = "Street Fighter 3",
          Description = "Street Fighter 3 (ストリートファイターIII) is a fighting game developed by Capcom.",
          EngineID = "CPS-3",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1997, Month = 2, Day = 4}
          ]
        },
        new Game {
          GameID = "sf32ndimpact",
          Name = "Street Fighter 3: 2nd Impact",
          Description = "Street Fighter 3: 2nd Impact (ストリートファイターIII 2nd Impact) is a fighting game developed by Capcom.",
          EngineID = "CPS-3",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1997, Month = 9, Day = 30}
          ]
        },
        new Game {
          GameID = "sf33rdstrike",
          Name = "Street Fighter 3: 3rd Strike",
          Description = "Street Fighter 3: 3rd Strike (ストリートファイターIII 3rd Strike) is a fighting game developed by Capcom.",
          EngineID = "CPS-3",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 5, Day = 12}
          ]
        },
        new Game {
          GameID = "svencoop",
          Name = "Sven Co-op",
          Description = "A cooperative mod that allows players to fight against computer-controlled enemies together. Can play through the original Half-Life game and its expansions in co-op mode.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          SteamID = 225840,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/sven"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2016, Region = Region.Worldwide, ReleaseVersion = ReleaseVersion.SteamRelease}
          ]
        },
        new Game {
          GameID = "svencoopclassic",
          Name = "Sven Co-op Classic",
          Description = "A cooperative mod that allows players to fight against computer-controlled enemies together. Can play through the original Half-Life game and its expansions in co-op mode.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          SteamID = 70,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/sven",
            GameDirectory = "svencoop",
            MasterServerKey = "GoldSource"
          }
        },
        new Game {
          GameID = "syndicateblackops",
          Name = "Syndicate Black Ops",
          Description = "",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            GameDirectory = "syndicate"
          }
        },
        new Game {
          GameID = "synergy",
          Name = "Synergy",
          Description = "",
          ModForGameID = "sdk2013",
          EngineID = "source",
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          Developer = "",
          SteamID = 17520,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/synergy",
            GameDirectory = "synergy"
          }
        },
        new Game {
          GameID = "thetalosprinciple",
          Name = "The Talos Principle",
          Description = "The Talos Principle is a first-person puzzle game developed by Croteam.",
          EngineID = "seriousengine4",
          Developer = "Croteam",
          SteamID = 257510,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Puzzle,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2014, Month = 12, Day = 11, Region = Region.Worldwide}
          ]
        },
        new Game {
          GameID = "thetalosprinciple2",
          Name = "The Talos Principle 2",
          Description = "The Talos Principle 2 is a first-person puzzle game developed by Croteam.",
          EngineID = "unreal5",
          Developer = "Croteam",
          SteamID = 835960,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Puzzle,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2023, Month = 11, Day = 2, Region = Region.Worldwide}
          ]
        },
        new Game {
          GameID = "tannenberg",
          Name = "Tannenberg",
          Description = "A large scale WW1 squad based shooter allowing up to 64 players on a server.",
          Developer = "M2H, Black Mill Games",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2019, Month = 2, Day = 13, Region = Region.Worldwide}
          ]
        },
        new Game {
          GameID = "tf2",
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
          PlayWith = new List<int> { 0, 6 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/tf2",
            GameDirectory = "tf"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2007, Month = 10, Day = 10},
          ]
        },
        new Game {
          GameID = "tf2classic",
          Name = "Team Fortress 2 Classic",
          Description = "A Source engine mod that recreates the 2008 era of Team Fortress 2.",
          ModForGameID = "tf2",
          EngineID = "source",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/tf2",
            GameDirectory = "tf2classic"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 2008},
          ]
        },
        new Game {
          GameID = "tf2source",
          Name = "Team Fortress 2: Source",
          Description = "A Source 2 engine mod that recreates the early era of Team Fortress 2.",
          ModForGameID = "tf2",
          EngineID = "source",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2007},
          ]
        },
        new Game {
          GameID = "tf2vintage",
          Name = "Team Fortress 2: Vintage",
          Description = "A Source engine mod that recreates the 2010 era of Team Fortress 2.",
          ModForGameID = "tf2",
          EngineID = "source",
          IsOpenSource = true,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2010},
          ]
        },
        new Game {
          GameID = "tfc",
          Name = "Team Fortress Classic",
          Description = "Team Fortress Classic is a mod for Half-Life that ported QWTF to the goldsrc engine.",
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          Developer = "Valve Software",
          SteamID = 20,
          IsOpenSource = false,
          IsFree = false,
          IsPaid = true,
          IsDeveloperMaintained = true,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 4 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/tfc",
            GameDirectory = "tfc"
          },
          ReleaseDates = [
            new ReleaseDate{Year = 1999}
          ]
        },
        new Game {
          GameID = "thefinals",
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
          PlayWith = new List<int> { 3 },
          ReleaseDates = [
            new ReleaseDate{Year = 2023, Month = 12, Day = 8}
          ]
        },
        new Game {
          GameID = "thespecialists",
          Name = "The Specialists",
          Description = "",
          EngineID = "goldsrc",
          SteamID = 70,
          ModForGameID = "halflife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "ts",
            MasterServerKey = "GoldSource"
          }
        },
        new Game {
          GameID = "thetrenches",
          Name = "The Trenches",
          Description = "",
          SteamID = 70,
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "tt",
            MasterServerKey = "GoldSource"
          }
        },
        new Game {
          GameID = "touhoucrisis",
          Name = "Touhou Crisis",
          Description = "Touhou Crisis is a free cover-based lightgun game available on Steam, inspired by the anime series and Time Crisis.",
          SteamID = 1989990,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2022, Month = 5, Day = 26}
          ]
        },
        new Game {
          GameID = "treason",
          Name = "Treason",
          Description = "",
          EngineID = "goldsrc",
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/treason",
            GameDirectory = "treason"
          }
        },
        new Game {
          GameID = "tribes1",
          Name = "Starsiege: Tribes",
          Description = "A groundbreaking multiplayer first-person shooter featuring jetpack-based combat.",
          Developer = "Dynamix",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = true,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 1998, Month = 12, Day = 1}
          ]
        },
        new Game {
          GameID = "tribes2",
          Name = "Tribes 2",
          Description = "Tribes 2 is a first-person shooter game developed by Dynamix.",
          EngineID = "",
          Developer = "Dynamix",
          SteamID = 1234560,
          IsFree = false,
          IsPaid = false,
          IsOpenSource = true,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2001, Month = 12, Day = 1}
          ]
        },
        new Game {
          GameID = "tribes3",
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
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2024}
          ]
        },
        new Game {
          GameID = "tribesascend",
          Name = "Tribes: Ascend",
          Description = "Tribes: Ascend was delisted from Steam but still accessible through the link.",
          EngineID = "unreal3",
          Developer = "Hi-Rez Studios",
          SteamID = 17080,
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2012, Month = 4, Day = 12}
          ]
        },
        new Game {
          GameID = "typingofthedead",
          Name = "The Typing of the Dead: Overkill",
          Description = "The Typing of the Dead: Overkill is a typing trainer available on Steam in the style of House of the Dead. This release includes the original House of the Dead playable with a lightgun.",
          SteamID = 246580,
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Sports,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 2010, Month = 10, Day = 12}
          ]
        },
        new Game {
          GameID = "underworldbloodline",
          Name = "Underworld: Bloodline",
          EngineID = "goldsrc",
          Genre = Genre.FPS,
          Description = "",
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/underworld",
            GameDirectory = "underworld"
          }
        },
        new Game {
          GameID = "undying",
          Name = "Clive Barker's Undying",
          Description = "Clive Barker's Undying is a first-person shooter game developed by EA Los Angeles.",
          EngineID = "unreal",
          Developer = "EA Los Angeles",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2001, Month = 2, Day = 20, Region = Region.NA},
            new ReleaseDate{Year = 2001, Month = 3, Day = 16, Region = Region.EU},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "unreal",
          Name = "Unreal",
          Description = "Unreal is a first-person shooter game developed by Epic Games.",
          EngineID = "unreal",
          Developer = "Epic Games",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0, 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1998, Month = 5, Day = 22, Region = Region.NA},
            new ReleaseDate{Year = 1998, Month = 6, Day = 12, Region = Region.UK}
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "ut",
          Name = "Unreal Tournament 99",
          Description = "Unreal Tournament 99 is a free-to-play arena shooter that brings the classic Quake gameplay to the modern era with unique champion abilities.",
          EngineID = "unreal",
          Developer = "Epic Games",
          RequiresCommunityPatch = true,
          PlayWith = new List<int> { 0, 1 },
          Genre = Genre.FPS,
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 11, Day = 22}
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "ut2003",
          Name = "Unreal Tournament 2003",
          Description = "Unreal Tournament 2003.",
          EngineID = "unreal2",
          Developer = "Epic Games",
          RequiresCommunityPatch = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2002, Month = 9, Day = 30, Region = Region.NA}
          ]
        },
        new Game {
          GameID = "ut2004",
          Name = "Unreal Tournament 2004",
          Description = "Unreal Tournament 2004.",
          EngineID = "unreal2",
          Developer = "Epic Games",
          RequiresCommunityPatch = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2004, Month = 3, Day = 16, Region = Region.NA},
            new ReleaseDate{Year = 2004, Month = 3, Day = 19, Region = Region.EU}
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "ut3",
          Name = "Unreal Tournament 3",
          Description = "Unreal Tournament 3.",
          EngineID = "unreal3",
          Developer = "Epic Games",
          RequiresCommunityPatch = true,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ReleaseDates = [
            new ReleaseDate{Year = 2007, Month = 11, Day = 19, Region = Region.NA}
          ]
        },
        new Game {
          GameID = "ut4",
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
          PlayWith = new List<int> { 0 },
          ReleaseDates = []
        },
        new Game {
          GameID = "vampireslayer",
          Name = "Vampire Slayer",
          Description = "",
          SteamID = 70,
          ModForGameID = "halflife",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/hl",
            GameDirectory = "vs"
          }
        },
        new Game {  
          GameID = "vs",
          Name = "Vampire Savior",
          Description = "Vampire Savior (ヴァンパイアセイヴァー) is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1997, Month = 5, Day = 19}
          ]
        },
        new Game {  
          GameID = "vh2",
          Name = "Vampire Hunter 2",
          Description = "Vampire Hunter 2 (ヴァンパイアハンター2) is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1997, Month = 9, Day = 13}
          ]
          },
        new Game {  
          GameID = "vs2",
          Name = "Vampire Savior 2",
          Description = "Vampire Savior 2 (ヴァンパイアセイヴァー2) is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1997, Month = 9, Day = 13}
          ]
        },
        new Game {
          GameID = "wanted",
          Name = "Wanted!",
          Description = "",
          SteamID = 70,
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          IsFree = true,
          IsPaid = false,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/wanted",
            GameDirectory = "wantedsp"
          }
        },
        new Game {
          GameID = "wot",
          Name = "Wheel of Time",
          Description = "Wheel of Time is a first-person shooter based on the Wheel of Time series.",
          EngineID = "unreal",
          Developer = "Legend Entertainment",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1999, Month = 11, Day = 9, Region = Region.NA},
            new ReleaseDate{Year = 1999, Month = 11, Day = 25, Region = Region.EU},
          ],
          ServerConfig = new ServerBrowserConfig {
            MasterServerKey = "333networks",
            QueryProtocol = "GameSpy",
          }
        },
        new Game {
          GameID = "wizardwars",
          Name = "Wizard Wars",
          Description = "",
          EngineID = "goldsrc",
          Genre = Genre.FPS,
          PlayWith = new List<int> { 0 },
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/ww",
            GameDirectory = "wizardwars"
          }
        },
        new Game {
          GameID = "wolf3d",
          Name = "Wolfenstein 3D",
          Description = "Wolfenstein 3D is a first-person shooter game developed by id Software.",
          EngineID = "idtech0",
          Developer = "id Software",
          IsFree = true,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.FPS,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 1992, Month = 5, Day = 5}
          ]
        },
        new Game {
          GameID = "x-men",
          Name = "X-Men: Children of the Atom",
          Description = "X-Men: Children of the Atom is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1994, Month = 12, Day = 8}
          ]
        },
        new Game {
          GameID = "xvsf",
          Name = "X-Men vs. Street Fighter",
          Description = "X-Men vs. Street Fighter is a fighting game developed by Capcom.",
          EngineID = "CPS-2",
          Developer = "Capcom",
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          Genre = Genre.Fighting,
          PlayWith = new List<int> { 1, 2 },
          ReleaseDates = [
            new ReleaseDate{Year = 1996, Month = 9, Day = 9}
          ]
        },
        new Game {
          GameID = "zombiemaster",
          Name = "Zombie Master (CLASSIC)",
          Description = "",
          SteamID = 215,
          EngineID = "source",
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/zmaster",
            GameDirectory = "zombie_master",
            MasterServerKey = "Source",
            NoBackgroundService = true
          }
        },
        new Game {
          GameID = "zombiemasterreborn",
          Name = "Zombie Master: Reborn",
          Description = "",
          SteamID = 243750,
          EngineID = "source",
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/zmr",
            GameDirectory = "zombie_master_reborn"
          }
        },
        new Game {
          GameID = "zombiepanic",
          Name = "Zombie Panic!",
          Description = "",
          SteamID = 70,
          ModForGameID = "halflife",
          EngineID = "goldsrc",
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/zp",
            GameDirectory = "zp",
            MasterServerKey = "GoldSource"
          }
        },
        new Game {
          GameID = "zombiepanicsource",
          Name = "Zombie Panic! Source",
          Description = "",
          ModForGameID = "sdk2013",
          SteamID = 17500,
          EngineID = "source",
          Genre = Genre.FPS,
          ServerConfig = new ServerBrowserConfig {
            IconPath = "img/icons/zps",
            GameDirectory = "zps"
          }
          },
      new Game {
        GameID = "zombiepanicinwonderlanddx",
          Name = "Zombie Panic! In Wonderland DX",
          Description = "Zombie Panic! In Wonderland DX is a gallery style lightgun game available on Steam.",
          SteamID = 1173850,  
          IsFree = false,
          IsPaid = true,
          IsOpenSource = false,
          IsDeveloperMaintained = false,
          IsCommunityMaintained = false,
          Genre = Genre.Lightgun,
          PlayWith = new List<int> { 1 },
          ReleaseDates = [
            new ReleaseDate{Year = 2019, Month = 11, Day = 6}
          ]
        }
      };
    }
  }
}
