using ASP_site.Models;

namespace ASP_site.Data.Initializers {
  public static class LinkInitializer {
    public static Link[] GetSteamLinks(Game game) {
      return new Link[] {
        new Link {
          Url = $"https://store.steampowered.com/app/{game.SteamID}/",
        Label = "Steam Store Link",
        LinkType = LinkType.Store,
        Description = $"{game.Name} on Steam",
          GameID = game.GameID
        },
        new Link {
          Url = $"https://steamdb.info/app/{game.SteamID}/",
          Label = "SteamDB Link",
          LinkType = LinkType.SteamDB,
          Description = $"{game.Name} on SteamDB",
          GameID = game.GameID
        }
      };
    }
    
    public static Link[] GetLinks() {
      return new Link[] {
        // Empty GameID links
        new Link { GameID = "", Label = "Symbolic Links Guide", Description = "My video guide on how to use symbolic linking on game configs", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=w3LaDk1VUqg" },
        new Link { GameID = "", Label = "Face Turning Octohedron (FTO) tutorial", Description = "My Face Turning Octohedron tutorial", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=Hz5ubgsmCEY" },

        // ActionHalfLife
        new Link { GameID = "ActionHalfLife", Label = "Action Half-Life gameplay", Description = "Me playing Action Half-Life on napoli and streets", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=j5g048zyO2c" },
        new Link { GameID = "ActionHalfLife", Label = "Action Half-Life on ModDB", Description = "Action Half-Life on ModDB",
          LinkType = LinkType.Download, Url = "https://www.moddb.com/mods/action-half-life" },

        // AoE2
        new Link { GameID = "AoE2", Label = "Age of Empires 2 Overview", Description = "My overview of Age of Empires 2 in its current state", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=VLXfLIOciTQ" },
        new Link { GameID = "AoE2", Label = "AoE Stats", Description = "Replay analysis tool",
          LinkType = LinkType.Guide, Url = "https://aoestats.io/" },
        new Link { GameID = "AoE2", Label = "AoE Companion", Description = "AoE build guides and overlay tool",
          LinkType = LinkType.Guide, Url = "https://aoecompanion.com/" },
        new Link { GameID = "AoE2", Label = "AoE2 Build Order Guide", Description = "AoE2 build order guides",
          LinkType = LinkType.Guide, Url = "https://buildorderguide.com/" },
        new Link { GameID = "AoE2", Label = "AoE2 Tech Tree", Description = "AoE2 tech tree for all civilizations",
          LinkType = LinkType.Guide, Url = "https://aoe2techtree.net" },
        new Link { GameID = "AoE2", Label = "AoE2 Library", Description = "Tools and websites for Age of Empires 2",
          LinkType = LinkType.Community, Url = "https://aoelibrary.com/" },
        new Link { GameID = "AoE2", Label = "Awesome AoE2", Description = "Awesome list of AoE2 resources",
          LinkType = LinkType.Community, Url = "https://github.com/Arkanosis/awesome-aoe2" },
        new Link { GameID = "AoE2", Label = "AoE2 Hotkey Trainer", Description = "AoE2 hotkey trainer",
          LinkType = LinkType.Guide, Url = "https://aoe-hippo.com/" },
        new Link { GameID = "AoE2", Label = "AoE2 Mod Directory", Description = "AoE2 mod directory",
          LinkType = LinkType.Community, Url = "https://mods.aoe2.se/" },
        new Link { GameID = "AoE2", Label = "AoE2 Tournaments List", Description = "AoE2 tournaments list",
          LinkType = LinkType.Community, Url = "https://liquipedia.net/ageofempires/Age_of_Empires_II/Tournaments/2024-25" },


        // AoE4
        new Link { GameID = "AoE4", Label = "Age of Empires 4 Overview", Description = "My overview of Age of Empires 4 in its current state", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=9GTc1nfHehg" },
        new Link { GameID = "AoE4", Label = "AoE4 Build Order Tool", Description = "AoE4 build order tool",
          LinkType = LinkType.Guide, Url = "https://age4builder.com/" },
        new Link { GameID = "AoE4", Label = "AoE4 Build Order Guides", Description = "AoE4 build order guides",
          LinkType = LinkType.Guide, Url = "https://aoe4guides.com/" },
        new Link { GameID = "AoE4", Label = "AoE4 World", Description = "AoE4 community site",
          LinkType = LinkType.Community, Url = "https://aoe4world.com/" },
        new Link { GameID = "AoE4", Label = "phil on AoE4 World", Description = "me on AoE4 World",
          LinkType = LinkType.Community, Url = "https://aoe4world.com/players/10636636-Phil" },
        new Link { GameID = "AoE4", Label = "AoE4 TypeScript definitions", Description = "AoE4 TypeScript definitions",
          LinkType = LinkType.Community, Url = "https://aoemods.github.io/aoetypes-docs/" },
        new Link { GameID = "AoE4", Label = "AoE4 Tournaments List", Description = "AoE4 tournaments list",
          LinkType = LinkType.Community, Url = "https://liquipedia.net/ageofempires/Age_of_Empires_IV/Tournaments" },


        // BattleGrounds
        new Link { GameID = "BattleGrounds", Label = "Battlegrounds", Description = "Me playing Battlegrounds on bg_bridge", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=wJfindDcLA4" },
        new Link { GameID = "BattleGrounds", Label = "Battlegrounds on ModDB", Description = "Battlegrounds on ModDB",
          LinkType = LinkType.Download, Url = "https://www.moddb.com/mods/battle-grounds/downloads/the-battle-grounds-10f-final" },
        new Link { GameID = "BattleGrounds", Label = "Battlegrounds website", Description = "Battlegrounds website",
          LinkType = LinkType.Official, Url = "http://www.bgmod.com/" },

        // Battlebit
        new Link { GameID = "Battlebit", Label = "battlebit nighttime train", Description = "Me playing Battlebit on nighttime train", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/aUuRIuZR-Ac" },

        // BlackMesa
        new Link { GameID = "BlackMesa", Label = "Black Mesa Gameplay Launch Trailer", Description = "Black Mesa Gameplay Launch Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/V7vDsarvyoc" },
        new Link { GameID = "BlackMesa", Label = "Black Mesa: The 16 Year Project to Remake Half-Life | Noclip Documentary", Description = "Black Mesa documentary",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/G_TcAxAKCAI" },
        new Link { GameID = "BlackMesa", Label = "Black Mesa is Genius, And Here's Why", Description = "Black Mesa video essay",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/-d8KAq78gco" },

        // Bumpercars
        new Link { GameID = "Bumpercars", Label = "bumpercars", Description = "Me playing Bumpercars on bc_nukeplant", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=xKBA9KE7DCg" },
        new Link { GameID = "Bumpercars", Label = "Bumpercars on ModDB", Description = "Bumpercars on ModDB",
          LinkType = LinkType.Download, Url = "https://www.moddb.com/mods/bumper-cars/downloads/half-life-bumper-cars-v20" },
        new Link { GameID = "Bumpercars", Label = "Archived Bumpercars website", Description = "Bumpercars website",
          LinkType = LinkType.Official, Url = "https://web.archive.org/web/20031002104542/http://www.planethalflife.com/bumpercars/" },

        // Chess
        new Link { GameID = "Chess", Label = "Chess on Lichess", Description = "My profile on lichess", 
          LinkType = LinkType.Community, Url = "https://lichess.org/user/philchute" },
        new Link { GameID = "Chess", Label = "Chess on Chess.com", Description = "My profile on chess.com", 
          LinkType = LinkType.Community, Url = "https://www.chess.com/member/philchute" },
        new Link { GameID = "Chess", Label = "Chess L's are Lessons", Description = "Me playing Chess on lichess", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=fG_wydPhFYg" },
        new Link { GameID = "Chess", Label = "Chess Records", Description = "Chess Records",
          LinkType = LinkType.Community, Url = "https://timkr.home.xs4all.nl/records/recordstxt.htm" },

        // Civ6
        new Link { GameID = "Civ6", Label = "Civilization 6 introduction", Description = "My Civilization 6 overview", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=qtTeJlAm-94" },

        // CnCGenerals
        new Link { GameID = "CnCGenerals", Label = "CnC Generals online", Description = "My CnC Generals online video guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=zkY1-a1r6AQ" },
        new Link { GameID = "CnCGenerals", Label = "CnC Generals mods", Description = "My CnC Generals mods video guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=7plPL84o5xw" },
        new Link { GameID = "CnC", Label = "CnC 2025 updates", Description = "My CnC 2025 news updates", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=OLW6vajvrTw" },
        new Link { GameID = "CnC", Label = "Logicas path to expert", Description = "Logicas path to expert",
          LinkType = LinkType.Guide, Url = "https://legi.cc/articles/logicas-path-to-expert/" },

        // CnCRA2
        new Link { GameID = "CnCRA2", Label = "CnC Red Alert 2 online", Description = "My RA2 online video guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=lRumNSTEcuo" },
        new Link { GameID = "CnCRA2", Label = "OpenRA", Description = "My OpenRA video guide", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=TeiML1_EDxc" },

        // CnCRenegade
        new Link { GameID = "CnCRenegade", Label = "CnC Renegade", Description = "My CnC: Renegade video guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=CvNfHg-Pgo0" },

        // CnCTS
        new Link { GameID = "CnCTS", Label = "CnC Tiberian Sun", Description = "My CnC: Tiberian Sun video guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=EMWNDDsaROw" },

        //CoD
        new Link { GameID = "CoD", Label = "CoD: United Offensive on Steam", Description = "CoD: United Offensive Stand Alone expansion on Steam", 
          LinkType = LinkType.Store, Url = "https://store.steampowered.com/app/2640/Call_of_Duty_United_Offensive/" },

        // ColdIce
        new Link { GameID = "ColdIce", Label = "Cold Ice", Description = "Me playing Horde mode on snowcross", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=LhspfckRDyU" },
        new Link { GameID = "ColdIce", Label = "Cold Ice on ModDB", Description = "Cold Ice on ModDB",
          LinkType = LinkType.Download, Url = "https://www.moddb.com/mods/cold-ice-remastered/downloads/cold-ice-remastered-beta-3" },

        // Deadlock
        new Link { GameID = "Deadlock", Label = "Deadlock introductory commentary", Description = "My introductory guide to Deadlock", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=lk_xrTuIuDw" },
        new Link { GameID = "Deadlock", Label = "Deadlock Map Exploration", Description = "Me walking through (the old 4 lane) street_test", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=oNqs5rHGGXs" },
        new Link { GameID = "Deadlock", Label = "Deadlock Abrams Clip", Description = "Clip of me playing Abrams", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=oRPlf8vpA6c" },
        new Link { GameID = "Deadlock", Label = "Deadlock Viscous Midgame", Description = "Me playing Viscous on street_test", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=JuNAWJdoNSE" },
        new Link { GameID = "Deadlock", Label = "Deadlock Magician", Description = "Me playing Magician", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=UMvQ5ZWaLJ4" },
        new Link { GameID = "Deadlock", Label = "Deadlock extra competitive", Description = "Full game of me playing Abrams", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Sn-L4-x47Ls" },
        new Link { GameID = "Deadlock", Label = "There can be only one", Description = "Clip of me playing Abrams", 
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=isJL6eyceaw" },

        // Diabotical
        new Link { GameID = "Diabotical", Label = "Diabotical Rogue", Description = "4v4 Wipeout gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=fjwuaoPAnsk" },
        new Link { GameID = "Diabotical", Label = "Diabotical Speedrun Community", Description = "Diabotical speedrun community",
          LinkType = LinkType.Community, Url = "https://quakelife.ru/diabotical/race/" },
        new Link { GameID = "Diabotical", Label = "Diabotical guide", Description = "Diabotical guide",
          LinkType = LinkType.Guide, Url = "https://www.district.wiki/home" },

        // DirtyBomb
        new Link { GameID = "DirtyBomb", Label = "Dirty Bomb Official Site", Description = "Dirty Bomb official website",
          LinkType = LinkType.Official, Url = "https://www.dirtybomb.com" },
        new Link { GameID = "DirtyBomb", Label = "Dirty Bomb New Player's Guide", Description = "Dirty Bomb new players guide",
          LinkType = LinkType.Guide, Url = "https://dirtybomb-archive.fandom.com/wiki/New_Player%27s_Guide" },
        new Link { GameID = "DirtyBomb", Label = "Dirty Bomb: 10 New-Player Tips & Tricks Tutorial", Description = "Dirty Bomb: 10 New-Player Tips & Tricks Tutorial",
          LinkType = LinkType.Guide, Url = "https://youtu.be/HI7csAS_gDE" },
        new Link { GameID = "DirtyBomb", Label = "Dirty Bomb jumps everyone should know", Description = "Dirty Bomb jumps everyone should know",
          LinkType = LinkType.Guide, Url = "https://youtu.be/-kAjnx90yvA" },
        new Link { GameID = "DirtyBomb", Label = "Dirty Bomb - Shaped by Gamers Gameplay Trailer", Description = "Dirty Bomb - Shaped by Gamers Gameplay Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/DfrAXpcMbQQ" },
        new Link { GameID = "DirtyBomb", Label = "Dirty Bomb [Flashbacks] by NgN", Description = "Dirty Bomb frag movie by NgN",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/fHgYV85xMy8" },
        new Link { GameID = "DirtyBomb", Label = "Born 2 Frag :: INF3RN0 :: Dirty Bomb", Description = "Dirty Bomb frag movie by INF3RN0",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=KK5r8-_WgCo" },
        new Link { GameID = "DirtyBomb", Label = "What Makes Dirty Bomb Great", Description = "What Makes Dirty Bomb Great",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/FK-WGzgW3hw" },
        new Link { GameID = "DirtyBomb", Label = "Death of a Game: Dirty Bomb", Description = "Death of a Game: Dirty Bomb",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/ORf1dIgbXTY" },
        new Link { GameID = "DirtyBomb", Label = "Dirty Bomb Official Discord", Description = "Dirty Bomb official Discord server",
          LinkType = LinkType.OfficialDiscord, Url = "https://discord.gg/jqmQZJG" },
        new Link { GameID = "DirtyBomb", Label = "Engineer gameplay", Description = "Me playing Bushwhacker on offense", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=fRk_zF3UYAY" },

        // DMC
        new Link { GameID = "DMC", Label = "DMC: threewave", Description = "Me playing CTF on q1e1m1", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=JSnC9o-kZIg" },

        // DMCR
        new Link { GameID = "DMCR", Label = "DMC:R official discord", Description = "DMC:R official discord",
          LinkType = LinkType.CommunityDiscord, Url = "https://discord.gg/n2xpW9x" },
        new Link { GameID = "DMCR", Label = "DMC:R beta test", Description = "Me playing DMC:R on dm6 and e1m2", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=mmv3yiMkcOA" },
        new Link { GameID = "DMCR", Label = "Deathmatch Classic Refragged beta test", Description = "Me playing DMC:R on dm2 and dm3", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=paDMQ3toGnc" },
        new Link { GameID = "DMCR", Label = "DMC:R CTF test", Description = "Me playing CTF", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/eiBD-TUa8p4" },
        new Link { GameID = "DMCR", Label = "DMC:R playtest", Description = "Me playing DMC:R on aerowalk and 2fort", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=D7rohq1V_KI" },
        new Link { GameID = "DMCR", Label = "DMC:R TDM", Description = "Me playing TDM on dm_flames", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=rxNRAvQZ3Gs" },
        new Link { GameID = "DMCR", Label = "DMC:R dm3", Description = "Me playing dm3", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=rhtRdCRdCdM" },
        new Link { GameID = "DMCR", Label = "DMC:R grapple test", Description = "Me playing CTF", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=27X4uxzeUpA" },
        new Link { GameID = "DMCR", Label = "Coaxion Games", Description = "Coaxion Games",
          LinkType = LinkType.Official, Url = "https://coaxion.games/" },
        new Link { GameID = "DMCR", Label = "Coaxion Games discord", Description = "Coaxion Games discord",
          LinkType = LinkType.CommunityDiscord, Url = "https://discord.gg/TvEyWQcm4j" },

        // DoD
        new Link { GameID = "DoD", Label = "Nineteen Eleven DoD Community", Description = "Pickups, tournaments, forums and info",
          LinkType = LinkType.Community, Url = "https://nineteeneleven.org/" },
        new Link { GameID = "DoD", Label = "Day of Defeat - A retrospective tribute to Half-life modding", Description = "DoD documentary",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/-zUSp1u81I4" },
        new Link { GameID = "DoD", Label = "Defeat. Valve's Forgotten Game", Description = "Defeat. Valve's Forgotten Game",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/_MlspJ8M9kI" },
        new Link { GameID = "DoD", Label = "A REAL History lesson about Day of Defeat", Description = "Dod history documentary",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=-zUSp1u81I4" },
        new Link { GameID = "DoD", Label = "RR Going Ham", Description = "Funny DoD highlight",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=pbtkLzolMQ8" },
        new Link { GameID = "DoD", Label = "STOP IT!!! [DoD 1.3] (funny clip)", Description = "STOP IT!!! [DoD 1.3] (funny clip)",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/zwtpKTU5cn4" },
        new Link { GameID = "DoD", Label = "compLextity DoD (frag movie)", Description = "compLextity DoD (classic frag movie)",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/mJWYlbsK9r4" },
        new Link { GameID = "DoD", Label = "CHAR Fragmart 2003", Description = "CHAR Fragmart 2003 (classic frag movie)",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=en7yysmggl8" },
        new Link { GameID = "DoD", Label = "DoD draft 2021", Description = "modern frag movie",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=xGq_V0Puc7U" },
        new Link { GameID = "DoD", Label = "Day of Defeat Harrington", Description = "Me playing dod_harrington", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Tt_xRuPwAKw" },
        new Link { GameID = "DoD", Label = "DoD The Anzio Attempt", Description = "Funny gameplay clip on dod_anzio", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=m_sHi9dcrXQ" },
        new Link { GameID = "DoD", Label = "Day of Defeat lennon", Description = "Me playing dod_lennon", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/nz_DodIy--o" },
        new Link { GameID = "DoD", Label = "CS Pros play DoD, TFC, and 1.6", Description = "CS Pros play DoD, TFC, and 1.6",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=2siXaD_e14U&t=15047s" },

        // Doom 
        new Link { GameID = "Doom", Label = "An Even More Condensed History of Doom Source Ports", Description = "A look at the history of Doom Source ports",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=Ho6mY3gIRDM" },
        new Link { GameID = "Doom", Label = "Retroahoy: Doom", Description = "Retroahoy: Doom",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=6A4-SVUHQYI" },

        // Doom 3
        new Link { GameID = "Doom3", Label = "Doom 3 BFG VR", Description = "Doom 3 BFG with native Oculus Rift/Touch or OpenVR support ",
          LinkType = LinkType.Download, Url = "https://github.com/NPi2Loup/DOOM-3-BFG-VR" },
        
        // Doom The Dark Ages
        new Link { GameID = "DoomDarkAges", Label = "Doom: The Dark Ages Launch Trailer", Description = "Doom: The Dark Ages Launch Trailer",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=S7IEg0_qNXs" },

        // Eleven Table Tennis
        new Link { GameID = "Eleven", Label = "Eleven VR stats", Description = "Eleven VR stats",
          LinkType = LinkType.Stats, Url = "https://www.elevenvr.net/" },

        // ESF
        new Link { GameID = "ESF", Label = "ESF pub", Description = "Gameplay on esf_canyon", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=NYOZ_X9XsV8" },
        new Link { GameID = "ESF", Label = "ESF duel", Description = "Goku gameplay on esf_cube", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=2Jt4Z9wTMBo" },
        new Link { GameID = "ESF", Label = "ESF Download", Description = "ESF Download",
          LinkType = LinkType.Download, Url = "https://esforces.com/download" },
        new Link { GameID = "ESF", Label = "ESF Website", Description = "ESF Website",
          LinkType = LinkType.Official, Url = "https://esforces.com/" },

        // ET
        new Link { GameID = "ET", Label = "A Casual Movie", Description = "Enemy Territory gameplay video",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/Hw1mhKPXclE" },
        new Link { GameID = "ET", Label = "Oldschool Superstars", Description = "Enemy Territory gameplay video",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/zvJUn8Db_fU" },
        new Link { GameID = "ET", Label = "Wolfenstein Enemy Territory - Greatest Moments", Description = "Enemy Territory highlights",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/3R3SyATZm70" },
        new Link { GameID = "ET", Label = "ET 3on3 World Championship '15 [wings] by NgN", Description = "Enemy Territory highlights",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/RbriTPyr-5U" },
        new Link { GameID = "ET", Label = "ET Spring Cup 2021 Group Stage Highlights", Description = "Enemy Territory highlights",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/i1lq8aXOlIg" },
        new Link { GameID = "ET", Label = "ET: Legacy Official Site", Description = "Enemy Territory: Legacy official website",
          LinkType = LinkType.Official, Url = "https://www.etlegacy.com" },
        new Link { GameID = "ET", Label = "ET: Legacy Discord", Description = "Enemy Territory: Legacy Discord server",
          LinkType = LinkType.CommunityDiscord, Url = "https://discord.gg/etlegacy" },
        new Link { GameID = "ET", Label = "ET: Legacy Competitive Discord", Description = "Enemy Territory: Legacy Competitive Discord server",
          LinkType = LinkType.CommunityDiscord, Url = "https://discord.gg/etcompetitive" },
        new Link { GameID = "ET", Label = "ET: Legacy Server List", Description = "List of current Enemy Territory: Legacy servers",
          LinkType = LinkType.Community, Url = "https://etlegacy.com/servers" },
        new Link { GameID = "ET", Label = "Enemy Territory Singleplayer Trailer", Description = "Enemy Territory Singleplayer trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/gS5IfummjX4" },
        new Link { GameID = "ET", Label = "ET Singleplayer & Co-op Downloads", Description = "Enemy Territory Singleplayer & Co-op downloads from modDB",
          LinkType = LinkType.Download, Url = "https://www.moddb.com/mods/enemy-territory-singleplayer" },
        new Link { GameID = "ET", Label = "ET Singleplayer on Steam Workshop", Description = "Enemy Territory Singleplayer on Steam Workshop",
          LinkType = LinkType.Download, Url = "https://steamcommunity.com/sharedfiles/filedetails/?id=1873030" },
        new Link { GameID = "ET", Label = "ET Co-op on Steam Workshop", Description = "Enemy Territory Co-op on Steam Workshop",
          LinkType = LinkType.Download, Url = "https://steamcommunity.com/sharedfiles/filedetails/?id=1873031" },
        new Link { GameID = "ET", Label = "How to play ET: Legacy with ET Steam release", Description = "Guide on how to play Enemy Territory: Legacy with the Steam release",
          LinkType = LinkType.Guide, Url = "https://youtu.be/lUxPCx1zbAs" },

        // FLF
        new Link { GameID = "FLF", Label = "Front Line Force gameplay", Description = "Me playing assault on flf_village", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=jDLCM4pSQkw" },

        // Go
        new Link { GameID = "Go", Label = "Play Go online", Description = "Play Go online",
          LinkType = LinkType.Official, Url = "https://www.cosumi.net/en/" },
        new Link { GameID = "Go", Label = "Sensei's Library", Description = "Sensei's Library wiki",
          LinkType = LinkType.Community, Url = "https://senseis.xmp.net/" },
        new Link { GameID = "Go", Label = "Go Problem Book Grades", Description = "How difficult are the problems in the Go Problem Books",
          LinkType = LinkType.Guide, Url = "https://senseis.xmp.net/?ProblemBookGrades" },
        new Link { GameID = "Go", Label = "Go books list", Description = "Go books list",
          LinkType = LinkType.Guide, Url = "https://senseis.xmp.net/?GoBook" },
        new Link { GameID = "Go", Label = "Go books", Description = "AGA Annotated Bibliography of Go Books in English",
          LinkType = LinkType.Guide, Url = "https://www.usgo-archive.org/aga-annotated-bibliography-go-books-english" },
        new Link { GameID = "Go", Label = "Go on Wikipedia", Description = "Go on Wikipedia",
          LinkType = LinkType.Wiki, Url = "https://en.wikipedia.org/wiki/Go_(game)" },

        // HalfLife
        new Link { GameID = "HalfLife", Label = "Half-Life Fan Trailer", Description = "Half-Life Fan Trailer",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=_vHnHSEf_Q0" },
        new Link { GameID = "HalfLife", Label = "Half-Life: Developer movies", Description = "Behind the scenes of Half-Life Development",
          LinkType = LinkType.Documentary, Url = "https://youtube.com/playlist?list=PLASWINVvIWaMDkG4KgHtbIZxN2rQhygX-&si=zo-jZI3qXLDyd7Tc" },
        new Link { GameID = "HalfLife", Label = "RetroAhoy: Half-life", Description = "RetroAhoy: Half-life",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/bp5vOgz8vyI" },
        new Link { GameID = "HalfLife", Label = "Errant Signal: Half-life", Description = "Errant Signal: Half-life",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/q-3gcVICiCs" },
        new Link { GameID = "HalfLife", Label = "A Thorough Look At Half-Life (Revised/Expanded)", Description = "A Thorough Look At Half-Life (Revised/Expanded)",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/_bsIXA8lNZc" },
        new Link { GameID = "HalfLife", Label = "Glitches and Tricks in Half-life 1", Description = "Glitches and Tricks in Half-life 1",
          LinkType = LinkType.Guide, Url = "https://youtu.be/zX5AHYZ5NJM" },
        new Link { GameID = "HalfLife", Label = "Half-life Adrenaline Gamer frag movie by Alex", Description = "Half-life Adrenaline Gamer frag movie by Alex",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/c745LBQTmz0" },
        new Link { GameID = "HalfLife", Label = "Half-life: Opposing Force Trailer (Remake)", Description = "Half-life: Opposing Force Trailer (Remake)",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/gg5S1xcQMok" },
        new Link { GameID = "HalfLife", Label = "Half-life: Blue Shift Fan Trailer", Description = "Half-life: Blue Shift Fan Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/c9yKppVxsTQ" },
        new Link { GameID = "HalfLife", Label = "Half-life: VR Mod", Description = "Half-life: VR Mod on Steam",
          LinkType = LinkType.Download, Url = "https://store.steampowered.com/app/1908720/HalfLife_VR_Mod/" },
        new Link { GameID = "HalfLife", Label = "Goldsrc and Source Mod discord", Description = "Goldsrc and Source Mod discord",
          LinkType = LinkType.CommunityDiscord, Url = "https://discord.gg/kr8WWsB" },
        new Link { GameID = "HalfLife", Label = "Goldsrc Saturdays group", Description = "Goldsrc Saturdays group",
          LinkType = LinkType.Community, Url = "https://linktr.ee/gssat" },

        // HalfLife2
        new Link { GameID = "HalfLife2", Label = "Half-Life 2 Fan Trailer", Description = "Half-Life 2 Fan Trailer",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=ID1dWN3n7q4" },
        new Link { GameID = "HalfLife2", Label = "Half-Life 2 | Trailer [FAN-MADE]", Description = "Half-Life 2 | Trailer [FAN-MADE]",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=_vS3idZI6TM" },
        new Link { GameID = "HalfLife2", Label = "A Love Letter to the Source Engine", Description = "A Love Letter to the Source Engine",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/9ojTBNfDKrw" },
        new Link { GameID = "HalfLife2", Label = "Half-life 2: Episode 1 Trailer", Description = "Half-life 2: Episode 1 Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/DL_mPw7KEU8" },
        new Link { GameID = "HalfLife2", Label = "Half-life 2: Episode 2 Trailer", Description = "Half-life 2: Episode 2 Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/jiTEUkqTeUI" },
        new Link { GameID = "HalfLife2", Label = "Why we need Half-Life 3", Description = "Why we need Half-Life 3 (Half-Life 2: Episode 2 spoilers)",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=MMYsEJ-vZaQ" },
        new Link { GameID = "HalfLife2", Label = "Half-Life 2: VR Mod on Steam", Description = "Half-Life 2: VR Mod on Steam",
          LinkType = LinkType.Download, Url = "https://store.steampowered.com/app/658920/HalfLife_2_VR_Mod/" },
        new Link { GameID = "HalfLife2", Label = "When you play Half-life 2 way too much", Description = "Funny clips and bugs in Half-Life 2",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=1wROIlgTwjE" },

        // HalfLifeAlyx
        new Link { GameID = "HalfLifeAlyx", Label = "Half-life: Alyx Trailer", Description = "Half-life: Alyx Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/O2W0N3uKXmo" },
        new Link { GameID = "HalfLifeAlyx", Label = "Half-life: Alyx Changed Everything (Spoiler free)", Description = "Half-life: Alyx Documentary",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/ZudAl7uUQfE" },

        // HellLetLoose
        new Link { GameID = "HellLetLoose", Label = "Welcome to Hell", Description = "My first game of Hell Let Loose, playing as Rifleman on Foy", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=XRxRvMa512o" },

        //HL:Rally
        new Link { GameID = "HLRally", Label = "HL:Rally source code", Description = "HL:Rally source code",
          LinkType = LinkType.Download, Url = "https://gitlab.com/hlrally/src" },
        new Link { GameID = "HLRally", Label = "HL:Rally downloads", Description = "HL:Rally downloads",
          LinkType = LinkType.Download, Url = "https://www.hlrally.net/hlrally/downloads/" },
        new Link { GameID = "HLRally", Label = "HL:Rally on Gamebanana", Description = "HL:Rally on Gamebanana",
          LinkType = LinkType.Download, Url = "https://gamebanana.com/games/831" },

        // Holdfast
        new Link { GameID = "Holdfast", Label = "Holdfast", Description = "Me playing on Holdfast on islands map", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Ji-lLwfoNf4" },
        new Link { GameID = "Holdfast", Label = "Holdfast intro", Description = "Holdfast introduction and gameplay", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=VO_NRkGgL3Q" },

        // Homefront
        new Link { GameID = "Homefront", Label = "Homefront gameplay", Description = "Me playing Homefront single player", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=hdWewUscSOM" },
        new Link { GameID = "Homefront", Label = "The rise and fall of Homefront", Description = "Homefront Documentery",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=8cSxSxEwKMs" },

        // Hostile Intent
        new Link { GameID = "HostileIntent", Label = "Hostile Intent on ModDB", Description = "Hostile Intent on ModDB",
          LinkType = LinkType.Download, Url = "https://www.moddb.com/mods/hostile-intent" },
        new Link { GameID = "HostileIntent", Label = "Hostile Intent Gameplay", Description = "Me playing Hostile Intent",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=bmqgHsAh2w0" },
        new Link { GameID = "HostileIntent", Label = "Client.dll file fix", Description = "Client.dll file fix",
          LinkType = LinkType.Download, Url = "https://www.moddb.com/mods/hostile-intent/downloads/hostile-intent-16-missing-nvidia-files" },

        // Isonzo
        new Link { GameID = "Isonzo", Label = "Isonzo", Description = "Me playing Isonzo as Rifleman on piana", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=ioxdqxe6oT8" },

        // LambdaFortress
        new Link { GameID = "LambdaFortress", Label = "Lambda Fortress", Description = "Me playing Lambda Fortress as Medic on Half-Life 2: Episode 2", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Roa8lmfpR4Q" },

        // Midair2
        new Link { GameID = "Midair2", Label = "Midair 2", Description = "Me playing CTF on map crater", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=lc269BpmM0I" },

        // MCVietnam
        new Link { GameID = "MCVietnam", Label = "MCV Breaking the LAW", Description = "Me playing team deathmatch on map base", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/GGw_pUOuFNE" },
        new Link { GameID = "MCVietnam", Label = "Military Conflict: Vietnam Gungame", Description = "Me playing gungame on mcv_tower_lgg", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=xJ6WapkO81U" },

        // Momentum
        new Link { GameID = "Momentum", Label = "Momentum Mod showcase", Description = "Momentum Mod showcase and current status", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=RdetcTpKe0k" },

        // NaturalSelection
        new Link { GameID = "NaturalSelection", Label = "Natural Selection", Description = "Gameplay footage", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=WVajO-U1o74" },
        new Link { GameID = "NaturalSelection", Label = "Natural Selection pickups", Description = "Natural Selection pickups", 
          LinkType = LinkType.Community, Url = "https://www.ensl.org/" },
        new Link { GameID = "NaturalSelection", Label = "Natural Selection discord", Description = "Natural Selection discord", 
          LinkType = LinkType.CommunityDiscord, Url = "https://discord.gg/ZUSSBUA" },
        
        // NeoTokyo
        new Link { GameID = "NeoTokyo", Label = "Neo Tokyo Guide", Description = "Neo Tokyo Guide",
          LinkType = LinkType.Guide, Url = "https://bonahnsa.com/guide.html" },

        // PavlovVR
        new Link { GameID = "PavlovVR", Label = "i drop things and get killed on dod_anzio", Description = "Me playing on dod_anzio", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=hAjpktDZ2QE" },
        new Link { GameID = "PavlovVR", Label = "halo vehicles are janky in pavlov vr", Description = "Gameplay on blood gulch", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=b9zcKO6mPXA" },
        new Link { GameID = "PavlovVR", Label = "inferno pub in pavlov VR", Description = "Counterstrike gameplay on de_inferno", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=AQHbsc0a5Wg" },

        // Portal
        new Link { GameID = "Portal", Label = "Portal Teaser Trailer", Description = "Portal Teaser Trailer",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=TluRVBhmf8w" },

        // Portal2
        new Link { GameID = "Portal2", Label = "Portal 2 Teaser Trailer", Description = "Portal 2 Teaser Trailer",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=tax4e4hBBZc" },
        new Link { GameID = "Portal2", Label = "Portal 2 - Full Co-op Trailer", Description = "Portal 2 - Full Co-op Trailer",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=A88YiZdXugA" },

        // PVK
        new Link { GameID = "PVK", Label = "pirates vikings and knights", Description = "Beserker viking gameplay on helms_deep", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=NRfRaGpmcJY" },

        // Quake1
        // General
        new Link { GameID = "Quake1", Label = "Quake 1 2025 guide", Description = "My complete guide to playing Quake 1 in 2025", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=VC-CW_NH45E" },
        new Link { GameID = "Quake1", Label = "So you want to play some Quake?", Description = "Video guide to playing Quake 1",
          LinkType = LinkType.Guide, Url = "https://youtu.be/CGj4gXyCzg0" },
        new Link { GameID = "Quake1", Label = "Why I love Quake", Description = "Video essay on Quake 1", 
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=QulZjDAGTLM" },
        new Link { GameID = "Quake1", Label = "Nailing the sound of horror: NIN + id Documentary", Description = "NIN + id Documentary",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=mp12k6LOgV0" },
        new Link { GameID = "Quake1", Label = "EzQuake", Description = "EzQuake Multiplayer Client",
          LinkType = LinkType.Download, Url = "http://www.ezquake.com/" },
        new Link { GameID = "Quake1", Label = "NQuake", Description = "NQuake (EzQuake Installer)",
          LinkType = LinkType.Download, Url = "https://nquake.com/" },
        new Link { GameID = "Quake1", Label = "QuakeWorld Launch Event - 1996", Description = "QuakeWorld Launch Event - 1996",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/LXw6BkZ-gdY" },
        new Link { GameID = "Quake1", Label = "RetroAhoy: Quake", Description = "RetroAhoy: Quake",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/OipJYWhMi3k" },
        new Link { GameID = "Quake1", Label = "State of Quake: 2022", Description = "State of Quake: 2022",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/--iN4aPCaMI" },
        new Link { GameID = "Quake1", Label = "nQuake installation video guide", Description = "nQuake installation video guide",
          LinkType = LinkType.Guide, Url = "https://youtu.be/W0U1xiuHYGQ" },
        new Link { GameID = "Quake1", Label = "My QuakeWorld clips", Description = "My QuakeWorld clips",
          LinkType = LinkType.Gameplay, Url = "https://youtube.com/playlist?list=PLb_7r6G15cTB2srm2SUVDCxl-wKDVDO7m" },
        new Link { GameID = "Quake1", Label = "My Quake config", Description = "My Quake config",
          LinkType = LinkType.Guide, Url = "https://raw.githubusercontent.com/philchute/configs/master/philquake.cfg" },
        new Link { GameID = "Quake1", Label = "badplace.eu", Description = "Current games",
          LinkType = LinkType.Community, Url = "https://badplace.eu/" },
        new Link { GameID = "Quake1", Label = "quakeservers.net", Description = "Active servers",
          LinkType = LinkType.Community, Url = "https://www.quakeservers.net/quakeworld/servers/" },
        new Link { GameID = "Quake1", Label = "usquake.world discord", Description = "usquake.world discord",
          LinkType = LinkType.CommunityDiscord, Url = "http://discord.usquake.world/" },
        new Link { GameID = "Quake1", Label = "Decino's Quake 25th Anniversary Event - Complete Chaos", Description = "packed server",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/rf7jFrhnhHU" },
        new Link { GameID = "Quake1", Label = "Kovaak teaches QuakeWorld duels", Description = "Kovaak teaches QuakeWorld duels playlist",
          LinkType = LinkType.Guide, Url = "https://youtube.com/playlist?list=PLxP7tvMqaXzDjw7OYYIEbplCdZOaHLFPg" },
        new Link { GameID = "Quake1", Label = "FullStart w/ddk QuakeWorld 4v4 guides", Description = "FullStart w/ddk QuakeWorld 4v4 guides",
          LinkType = LinkType.Guide, Url = "https://youtube.com/playlist?list=PL3E4C95FD99C6594E" },
        new Link { GameID = "Quake1", Label = "QuakePhil's QW Live Commentary", Description = "QuakePhil's QW Live Commentary playlist",
          LinkType = LinkType.Gameplay, Url = "https://youtube.com/playlist?list=PL5CE7BF3E83EBD8C0" },
        new Link { GameID = "Quake1", Label = "QuakeWorld Basic Tricks", Description = "QuakeWorld Basic Tricks",
          LinkType = LinkType.Guide, Url = "https://youtu.be/Iz5wlNJpD1g" },
        new Link { GameID = "Quake1", Label = "Trenchbroom 2 mapping by dumptruck_ds", Description = "Trenchbroom 2 mapping by dumptruck_ds",
          LinkType = LinkType.Guide, Url = "https://youtube.com/playlist?list=PLgDKRPte5Y0AZ_K_PZbWbgBAEt5xf74aE" },
        new Link { GameID = "Quake1", Label = "Minecraft-style logic in Quake", Description = "Minecraft-style logic in Quake",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=xVLtnKyRSb4" },
        new Link { GameID = "Quake1", Label = "libre quake", Description = "Installation and gameplay using open source libre quake", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=GfO8OEtdBqc" },
        //Frags
        new Link { GameID = "Quake1", Label = "Frags Done Extreme", Description = "Retro frag video",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/3ttIogcNe0A" },
        new Link { GameID = "Quake1", Label = "QuakeCon QuakeWorld 2on2", Description = "Modern frag video",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/2T2mhSFRRMg" },
        // Speedruns
        new Link { GameID = "Quake1", Label = "Quake Speedruns Explained", Description = "Quake Speedruns Explained youtube channel",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/channel/UCqjTN5ZTN69baab1pJgYW0w/videos" },
        new Link { GameID = "Quake1", Label = "speeddemosarchive.com/quake", Description = "Quake speedruns website",
          LinkType = LinkType.Community, Url = "https://speeddemosarchive.com/quake/" },
        new Link { GameID = "Quake1", Label = "Old Speeddemos Archive Promo video", Description = "Old Speeddemos Archive Promo video",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=iZQe5Yza_Og" },
        new Link { GameID = "Quake1", Label = "Coolkid speedrun live", Description = "Live any % speedrun of quake in 17:50",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=y2Xve3VGGMo" },
        new Link { GameID = "Quake1", Label = "Sphere speedrun live", Description = "Live 100% speedrun in 48:36",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=ql-5Ywokfdc" },
        new Link { GameID = "Quake1", Label = "Jukebox single segment 11:47", Description = "Jukebox single segment 11:47",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=hcareEsIXHM" },
        new Link { GameID = "Quake1", Label = "Alexh0w speedrun live", Description = "Live any% speedrun in 17:48",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Lzo6geKTtQo" },
        new Link { GameID = "Quake1", Label = "Cubeface's speedrun tutorial", Description = "Cubeface's speedrun tutorial",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=wjvGf9hLP3c" },
        new Link { GameID = "Quake1", Label = "Elgu's speedrun tutorial", Description = "Elgu's speedrun tutorial",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=i__AApGprog" },
        new Link { GameID = "Quake1", Label = "Quake 1 TAS (Tool Assisted Speedrun)", Description = "Quake 1 TAS (Tool Assisted Speedrun)",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=ekdcUOW1geA" },
        new Link { GameID = "Quake1", Label = "Quake single segment attempt", Description = "My speedrun fail", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/iOiVOpOkaPE" },
        new Link { GameID = "Quake1", Label = "Quake single segment success", Description = "My single segment speedrun (no deaths)", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=9qN0iUS37vo" },
        // Gameplay maps
        new Link { GameID = "Quake1", Label = "remembering how to aerowalk", Description = "1v1 gameplay on aerowalk", 
          LinkType = LinkType.Gameplay, MapID = "aerowalk", Url = "https://www.youtube.com/watch?v=-f39CsoO4RE" },
        new Link { GameID = "Quake1", Label = "live by the ns die by the ns", Description = "2v2 gameplay on aerowalk", 
          LinkType = LinkType.Gameplay, MapID = "aerowalk", Url = "https://www.youtube.com/watch?v=-d2Y05OrDiw" },
        new Link { GameID = "Quake1", Label = "Quake 1 2v2", Description = "2v2 gameplay on aerowalk", 
          LinkType = LinkType.Gameplay, MapID = "aerowalk", Url = "https://www.youtube.com/watch?v=yMLfyGYwHRI" },
        new Link { GameID = "Quake1", Label = "beauty in simplicity", Description = "1v1 gameplay on bravado", 
          LinkType = LinkType.Gameplay, MapID = "bravado", Url = "https://www.youtube.com/watch?v=oV-C-X2xB4Y" },
        new Link { GameID = "Quake1", Label = "Zoned in on bravado", Description = "2v2 gameplay on bravado", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=7Z4rgK1Onb8" },
        new Link { GameID = "Quake1", Label = "QWDM chaos on catalyst", Description = "FFA gameplay on catalyst", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/2ZMj7FeyAbc" },
        new Link { GameID = "Quake1", Label = "DM2 2on2 strategy guide by milton", Description = "DM2 2on2 strategy guide by milton",
          LinkType = LinkType.Guide, MapID = "dm2", Url = "https://youtu.be/snOVDPZfNtU" },
        new Link { GameID = "Quake1", Label = "Quake 1 4v4 dm2", Description = "4v4 gameplay on dm2", 
          LinkType = LinkType.Gameplay, MapID = "dm2", Url = "https://youtu.be/FtfgfyTv0JQ" },
        new Link { GameID = "Quake1", Label = "QuakePhil's QuakeWorld Tricks on DM6", Description = "QuakePhil's QuakeWorld Tricks on DM6",
          LinkType = LinkType.Guide, MapID = "dm6", Url = "https://youtube.com/playlist?list=PLvMshQnM8rSuzxlmZSL6cfYanQ3OnVMK3" },
        new Link { GameID = "Quake1", Label = "Quake 1 4v4 e1m2", Description = "4v4 gameplay on e1m2", 
          LinkType = LinkType.Gameplay, MapID = "e1m2", Url = "https://youtu.be/9TBZRxJQW9g" },
        new Link { GameID = "Quake1", Label = "4v4 gameplay on italy", Description = "4v4 gameplay on italy", 
          LinkType = LinkType.Gameplay, MapID = "italy", Url = "https://www.youtube.com/watch?v=zKpmf03ejDY" },
        new Link { GameID = "Quake1", Label = "4v4 gameplay on schloss", Description = "4v4 gameplay on schloss", 
          LinkType = LinkType.Gameplay, MapID = "schloss", Url = "https://www.youtube.com/watch?v=UROFH2Qo4No" },
        new Link { GameID = "Quake1", Label = "ztndm3 bloodrun makes my blood run", Description = "2v2 gameplay on ztndm3 bloodrun", 
          LinkType = LinkType.Gameplay, MapID = "ztndm3", Url = "https://www.youtube.com/watch?v=xQyB7ftUaBU" },
        new Link { GameID = "Quake1", Label = "Quake 1 2v2 bloodrun", Description = "2v2 gameplay on ztndm3 bloodrun", 
          LinkType = LinkType.Gameplay, MapID = "ztndm3", Url = "https://youtu.be/dXuw8hzAFho" },

        // Quake2
        new Link { GameID = "Quake2", Label = "", Description = "FFA gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=sgPyQ6wUtwY" },

        // Quake3
        new Link { GameID = "Quake3", Label = "Quakecon duel retrospectives playlist", Description = "Analysis of duels from Quakecon history",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PL18s8FLAe6l7olmMJ2SfHMYzFgGwhyAVY" },
        new Link { GameID = "Quake3", Label = "Shaolin Productions - Tricking iT2 Remastered", Description = "One of the best trick jumping videos",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/UYbQIsAtlnY" },
        new Link { GameID = "Quake3", Label = "Quake 3 Frag Highlights - AnnihilatioN", Description = "One of the all time best Quake 3 frag movies",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/MQJzUsZb7co" },
        new Link { GameID = "Quake3", Label = "Quake 3 Castor Fiber", Description = "One of my favorite Quake 3 frag movies",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=111YR7B6PvU" },

        // QuakeChampions
        new Link { GameID = "QuakeChampions", Label = "Quake Champions Trailer", Description = "Quake Champions GameplayTrailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/B5WXQW5opa8" },
        new Link { GameID = "QuakeChampions", Label = "The Greatest Quake Player on Earth | rapha short movie", Description = "The Greatest Quake Player on Earth | rapha short movie",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/lJBN_lu-OVo" },
        new Link { GameID = "QuakeChampions", Label = "Is Quake Champions Any Good? - A sign of the times in modern gaming", Description = "Is Quake Champions Any Good? - A sign of the times in modern gaming",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/L4ej5xk-HHY" },
        new Link { GameID = "QuakeChampions", Label = "Death of a Game: Quake Champions", Description = "Death of a Game: Quake Champions",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/zsQFxBndRG0" },

        // QuakeLive
        new Link { GameID = "QuakeLive", Label = "Quake Live Trailer", Description = "Quake Live Launch Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/4aNG7cd7rGM" },

        // Ricochet
        new Link { GameID = "Ricochet", Label = "Ricochet discord", Description = "Ricochet community discord",
          LinkType = LinkType.CommunityDiscord, Url = "https://discord.gg/b2teuWM" },
        new Link { GameID = "Ricochet", Label = "Ricochet: A Deep Look at a Shallow Game", Description = "Ricochet: A Deep Look at a Shallow Game",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=4B2DRbbloEs" },
        new Link { GameID = "Ricochet", Label = "Ricochet Mapping Tutorial", Description = "Ricochet Mapping Tutorial",
          LinkType = LinkType.Guide, Url = "https://youtu.be/5R0zHzTX95Y" },
        new Link { GameID = "Ricochet", Label = "Ricochet Pub Practice", Description = "Ricochet Pub Practice", 
          LinkType = LinkType.Highlights, Url = "https://youtu.be/eZW5iDiSoZ4" },
        new Link { GameID = "Ricochet", Label = "ricochet random maps", Description = "Gameplay on various maps", 
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=XYqK1bxGWic" },
        new Link { GameID = "Ricochet", Label = "ricochet random maps 2", Description = "Gameplay on rc_pillars, rc_glupshitto_v2, rc_gss_dust2, rc_deathmatch_extended, rc_snake, and rc_skiz", 
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=iXjZ5xNTXcs" },
        new Link { GameID = "Ricochet", Label = "ricochet dust2 pub", Description = "Gameplay on rc_dust2",
          LinkType = LinkType.Highlights, MapID = "dust2", Url = "https://www.youtube.com/watch?v=S5_IBXCFGX8" },
        new Link { GameID = "Ricochet", Label = "Ricocheting the bar:  Player Count Event", Description = "Deathmatch gameplay on rc_ratrace",
          LinkType = LinkType.Highlights, MapID = "ratrace", Url = "https://www.youtube.com/watch?v=mZKNFQL35Zk" },

        // RTCW
        new Link { GameID = "RTCW", Label = "Steam Sale Sleepers", Description = "Steam Sale Recomendations", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=9feP9IyXdwk" },

        // ScienceAndIndustry
        new Link { GameID = "SAndI", Label = "Science and Industry", Description = "Gameplay on si_deep", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=RLS0ilDNsgE" },

        // TheFinals
        new Link { GameID = "TheFinals", Label = "the finals playtest", Description = "3v3v3 gameplay on stadium", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=o9GwWDeB8PA" },
        new Link { GameID = "TheFinals", Label = "Finals free and easy", Description = "Light gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=ZXQfdhRMqEA" },
        new Link { GameID = "TheFinals", Label = "Finals slowmotion", Description = "Light gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=kfvcTN2eFYY" },

        // Tribes1
        new Link { GameID = "Tribes1", Label = "Tribes1", Description = "Pub gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/SNl4jWwUbaI" },

        // Tribes3
        new Link { GameID = "Tribes3", Label = "Tribes 3", Description = "Mid gameplay on island", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=69FXmkBriFk" },
        new Link { GameID = "Tribes3", Label = "Tribes 3", Description = "Mid gameplay on katabatic", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=CnNYf6Oc1zw" },
        new Link { GameID = "Tribes3", Label = "Tribes 3 12s", Description = "Mid gameplay on mountain", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=o9oP8EwTBeQ" },

        // Unreal Tournament
        new Link { GameID = "UT", Label = "UT99 in browser", Description = "Unreal Tournament 99 in browser",
          LinkType = LinkType.Download, Url = "https://icculus.org/ut99-emscripten/flyby/wasm/" },
        new Link { GameID = "UT", Label = "UT's living on", Description = "Unreal Tournament 99 frag movie",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=lbvX9sqCnSU" },

        // Wolfenstein 3D
        new Link { GameID = "Wolf3D", Label = "RetroAhoy: Wolfenstein 3D", Description = "Documentary about Wolfenstein 3D",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=BSb87DC-PtA" }
    };
  }
}
}