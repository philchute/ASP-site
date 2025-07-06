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
        new Link { GameID = "", Label = "Bunnyhopping guide by Zel", Description = "Bunnyhopping guide for Quake, QWTF, goldsrc, and source engine physics",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=3e_W1VYuAME" },
        new Link { GameID = "", Label = "Air control guide by nuki", Description = "Air control guide for Quake, QWTF, goldsrc, and source engine physics",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=QhiRrNedvOs" },
        new Link { GameID = "", Label = "GoldSrc.one multigame goldsource server", Description = "GoldSrc.one multigame goldsource server",
          LinkType = LinkType.Community, Url = "https://goldsrc.one/" }, 
        new Link { GameID = "", Label = "DOS Deck", Description = "Play DOS games in browser",
          LinkType = LinkType.Download, Url = "https://dosdeck.com/" }, 
        new Link { GameID = "", Label = "Play strategy games online", Description = "Play various turn based strategy games online for free in this lichess fork",
          LinkType = LinkType.Community, Url = "https://playstrategy.org/" },
        new Link { GameID = "", Label = "Abandonware games", Description = "Links to games which are no longer available for sale, so can be legally downloaded",
          LinkType = LinkType.Download, Url = "https://www.myabandonware.com/" },
        new Link { GameID = "", Label = "Delisted games", Description = "Tracks games which are about to be delisted from Steam and other stores",
          LinkType = LinkType.Download, Url = "https://delistedgames.com/" },
        new Link { GameID = "", Label = "Fightcade 2", Description = "Play fighting games and other roms online with rollback netcode",
          LinkType = LinkType.Community, Url = "https://www.fightcade.com/" },
        new Link { GameID = "", Label = "Fightcade 2 guide", Description = "Guide for setting up Fightcade 2 for automatic peer download of roms",
          LinkType = LinkType.Guide, Url = "https://fightcade.guide/" },
        new Link { GameID = "", Label = "The Best Thing to Happen to the FGC", Description = "Video essay covering Fightcade 2 and the transition to online play",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=yxonhj_YQAY" },
        new Link { GameID = "", Label = "FGC Discords by game", Description = "Hundreds of Discords for fighting games organized by game",
          LinkType = LinkType.Community, Url = "https://wiki.supercombo.gg/w/SuperCombo_Wiki:Community_portal/Discords/Game" },
        new Link { GameID = "", Label = "FGC Discords by region", Description = "Hundreds of Discords for fighting games organized by region",
          LinkType = LinkType.Community, Url = "https://wiki.supercombo.gg/w/SuperCombo_Wiki:Community_portal/Discords/Region" },
        new Link { GameID = "", Label = "Every Fighting Game Type Explained", Description = "Every Fighting Game Type Explained",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=b4Kc1p6Iat8" },


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


        new Link { GameID = "0ad", Label = "0ad", Description = "0ad is a free, open-source, real-time strategy game",
          LinkType = LinkType.Download, Url = "https://play0ad.com/" },

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
        new Link { GameID = "Battlebit", Label = "Battlebit nighttime train", Description = "Me playing Battlebit on nighttime train", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/aUuRIuZR-Ac" },

        // BlackMesa
        new Link { GameID = "BlackMesa", Label = "Black Mesa Gameplay Launch Trailer", Description = "Black Mesa Gameplay Launch Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/V7vDsarvyoc" },
        new Link { GameID = "BlackMesa", Label = "Black Mesa: The 16 Year Project to Remake Half-Life", Description = "Black Mesa documentary",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/G_TcAxAKCAI" },
        new Link { GameID = "BlackMesa", Label = "Black Mesa is Genius, And Here's Why", Description = "Black Mesa video essay",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/-d8KAq78gco" },

        // Bridge
        new Link { GameID = "Bridge", Label = "Bridge Puzzles and Guides", Description = "Bridge puzzles and guides",
          LinkType = LinkType.Community, Url = "http://www.rpbridge.net/index.htm" },
        new Link { GameID = "Bridge", Label = "Point count and distribution trainers", Description = "Point count and distribution trainers",
          LinkType = LinkType.Community, Url = "https://bridgewinners.com/games/" },
        new Link { GameID = "Bridge", Label = "Learn-Bridge Android App", Description = "Learn-Bridge Android App, uses programmed learning",
          LinkType = LinkType.Community, Url = "https://play.google.com/store/apps/details?id=com.wesleymay.bridgeapp" },
        new Link { GameID = "Bridge", Label = "Bridge Lesson's Basic Lessons Playlist", Description = "Bridge Lesson's Basic Lessons Playlist",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PLph3TgcRG2u5raaHTuhXPeqPnz1VcnNOQ" },
        new Link { GameID = "Bridge", Label = "Road to Victory: Bridge Analysis Playlist", Description = "Road to Victory: Bridge Analysis Playlist",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PLmJkVXoUPxmSGN1UfpphXxUg9mEachRpz" },
        new Link { GameID = "Bridge", Label = "Bridge Lesson's Intermedite and Advanced Topics Playlist", Description = "Bridge Lesson's Intermedite and Advanced Topics Playlist",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PLph3TgcRG2u7sl7YvyjnLzInKGbPyv3jD" },
        new Link { GameID = "Bridge", Label = "Bridge Lessons: Standard American Yellow Card Playlist", Description = "Bridge Lessons: Standard American Yellow Card Playlist",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PLSqWRrPK5TScKMvUKf4YYBzLAcAeYgr31" },

        // Bumpercars
        new Link { GameID = "Bumpercars", Label = "Bumpercars gameplay", Description = "Me playing Bumpercars on bc_nukeplant", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=xKBA9KE7DCg" },
        new Link { GameID = "Bumpercars", Label = "Bumpercars on ModDB", Description = "Bumpercars on ModDB",
          LinkType = LinkType.Download, Url = "https://www.moddb.com/mods/bumper-cars/downloads/half-life-bumper-cars-v20" },
        new Link { GameID = "Bumpercars", Label = "Archived Bumpercars website", Description = "Bumpercars website",
          LinkType = LinkType.Official, Url = "https://web.archive.org/web/20031002104542/http://www.planethalflife.com/bumpercars/" },

        // Capcom vs SNK 2
        new Link { GameID = "CapcomVsSNK2", Label = "Capcom Vs SNK 2 is broken", Description = "Capcom Vs SNK 2 is broken",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=6bsHoIAZRBc" },

        // Chess
        new Link { GameID = "Chess", Label = "Chess on Lichess", Description = "My profile on lichess", 
          LinkType = LinkType.Community, Url = "https://lichess.org/user/philchute" },
        new Link { GameID = "Chess", Label = "Chess on Chess.com", Description = "My profile on chess.com", 
          LinkType = LinkType.Community, Url = "https://www.chess.com/member/philchute" },
        new Link { GameID = "Chess", Label = "Chess L's are Lessons", Description = "Me playing Chess on lichess", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=fG_wydPhFYg" },
        new Link { GameID = "Chess", Label = "Chess Records", Description = "Chess Records",
          LinkType = LinkType.Community, Url = "https://timkr.home.xs4all.nl/records/recordstxt.htm" },
        new Link { GameID = "Chess", Label = "30,000+ Chess Problems", Description = "30,000+ Chess Problems",
          LinkType = LinkType.Community, Url = "https://wtharvey.com/" },
        new Link { GameID = "Chess", Label = "Play Chess varients on pychess", Description = "Play Chess varients online for free",
          LinkType = LinkType.Community, Url = "https://www.pychess.org/" },
        new Link { GameID = "Chess", Label = "Chess variants training", Description = "Chess variants training",
          LinkType = LinkType.Community, Url = "https://chessvariants.training/" },
        new Link { GameID = "Chess", Label = "Blitz Tactics", Description = "Blitz Tactics",
          LinkType = LinkType.Community, Url = "https://blitztactics.com/" },
        new Link { GameID = "Chess", Label = "Beginner to Chess Master Playlist by Chess Network", Description = "Chess Video Lessons",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PLQsLDm9Rq9bHKEBnElquF8GuWkI1EJ8Zp" },

        // Civ6
        new Link { GameID = "Civ6", Label = "Civilization 6 introduction", Description = "My Civilization 6 overview", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=qtTeJlAm-94" },

        // CnCGenerals
        new Link { GameID = "CnCGenerals", Label = "CnC Online replacement online service", Description = "CnC Online replacement online service", 
          LinkType = LinkType.Community, Url = "https://cnc-online.net/en/" },
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

        //callofduty
        new Link { GameID = "callofduty", Label = "COD | compLexity - ready up [NightFaLL]", Description = "COD | compLexity - ready up [NightFaLL]", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=SJ7EkXhF7Dg" },
        new Link { GameID = "callofduty", Label = "COD | united5 - 3D [crzg]", Description = "COD | united5 - 3D [crzg]", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=IJTZ52dASfc" },
        new Link { GameID = "callofduty", Label = "CoD: United Offensive on Steam", Description = "CoD: United Offensive Stand Alone expansion on Steam", 
          LinkType = LinkType.Store, Url = "https://store.steampowered.com/app/2640/Call_of_Duty_United_Offensive/" },
        new Link { GameID = "callofduty", Label = "CoD UO Wars 2 - United Offensive frag movie", Description = "CoD UO Wars 2 - United Offensive frag movie", 
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=LFZIRZoLi94" },

        //CoD2
        new Link { GameID = "CoD2", Label = "eSuba - Revisioned Story", Description = "eSuba - Revisioned Story", 
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=hBU4Bkm_FSM" },
        new Link { GameID = "CoD2", Label = "Call of Duty 2 - GONE WITH THE WIND [community]", Description = "Call of Duty 2 - GONE WITH THE WIND [community]", 
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=u9IQAKBMVKk" },
        new Link { GameID = "CoD2", Label = "COD2 | tek9 - eSuba [Luboshmir]", Description = "COD2 | tek9 - eSuba [Luboshmir]", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=njNIEUxTjVI" },
        new Link { GameID = "CoD2", Label = "COD2 - The good old days (Frag Movie)", Description = "COD2 - The good old days (Frag Movie)", 
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=jzDT6fJ0E1w" },

        // ColdIce
        new Link { GameID = "ColdIce", Label = "Cold Ice", Description = "Me playing Horde mode on snowcross", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=LhspfckRDyU" },
        new Link { GameID = "ColdIce", Label = "Cold Ice on ModDB", Description = "Cold Ice on ModDB",
          LinkType = LinkType.Download, Url = "https://www.moddb.com/mods/cold-ice-remastered/downloads/cold-ice-remastered-beta-3" },

        // Dark Messiah
        new Link { GameID = "DarkMessiah", Label = "Dark Messiah Co-op", Description = "Dark Messiah Co-op",
          LinkType = LinkType.Download, Url = "https://www.moddb.com/mods/dark-messiah-co-op" },

        // Deadlock
        new Link { GameID = "Deadlock", Label = "Daily Deadlock puzzles", Description = "Daily Deadlock puzzles",
          LinkType = LinkType.Gameplay, Url = "https://deadlockdle.keii.dev/" },
        new Link { GameID = "Deadlock", Label = "Neon Prime Gameplay", Description = "Footage from the game before getting the Deadlock theme",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=bhyh1M-HwPg" },
        new Link { GameID = "Deadlock", Label = "Valve's Neon Prime - All Tutorial Videos", Description = "Valve's Neon Prime - All Tutorial Videos",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=xqJsU0iN_UI" },
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
        new Link { GameID = "Deadlock", Label = "Deadlock Movement Guide", Description = "Deadlock Movement Guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=XiaSTPykOFk" },

        // Diabotical
        new Link { GameID = "Diabotical", Label = "Diabotical Rogue", Description = "4v4 Wipeout gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=fjwuaoPAnsk" },
        new Link { GameID = "Diabotical", Label = "Diabotical Speedrun Community", Description = "Diabotical speedrun community",
          LinkType = LinkType.Community, Url = "https://quakelife.ru/diabotical/race/" },
        new Link { GameID = "Diabotical", Label = "Diabotical guide", Description = "Diabotical guide",
          LinkType = LinkType.Guide, Url = "https://www.district.wiki/home" },
        new Link { GameID = "Diabotical", Label = "Diabotical beginners guide", Description = "Diabotical beginners guide",
          LinkType = LinkType.Guide, Url = "https://www.twitch.tv/videos/1413376600" },

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
          LinkType = LinkType.Discord, Url = "https://discord.gg/jqmQZJG" },
        new Link { GameID = "DirtyBomb", Label = "Engineer gameplay", Description = "Me playing Bushwhacker on offense", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=fRk_zF3UYAY" },

        // DMC
        new Link { GameID = "DMC", Label = "DMC: threewave", Description = "Me playing CTF on q1e1m1", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=JSnC9o-kZIg" },

        // DMCR
        new Link { GameID = "DMCR", Label = "DMC:R official discord", Description = "DMC:R official discord",
          LinkType = LinkType.Discord, Url = "https://discord.gg/n2xpW9x" },
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
          LinkType = LinkType.Discord, Url = "https://discord.gg/TvEyWQcm4j" },

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
        new Link { GameID = "DoD", Label = "How to play railroad by Cory Price", Description = "How to play railroad by Cory Price",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=dLrdc5Q82pA" },
        new Link { GameID = "DoD", Label = "CS Pros play DoD, TFC, and 1.6", Description = "CS Pros play DoD, TFC, and 1.6",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=2siXaD_e14U&t=15047s" },

        // Doom 
        new Link { GameID = "Doom", Label = "An Even More Condensed History of Doom Source Ports", Description = "A look at the history of Doom Source ports",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=Ho6mY3gIRDM" },
        new Link { GameID = "Doom", Label = "Retroahoy: Doom", Description = "Retroahoy: Doom",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=6A4-SVUHQYI" },
        new Link { GameID = "Doom", Label = "QuestZDoom VR Source port", Description = "QuestZDoom VR Source port",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/796/questzdoom" },
        new Link { GameID = "Doom", Label = "PicoZDoom for Pico 4", Description = "PicoZDoom for Pico 4",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/40085/picozdoom-questzdoom-for-pico-4" },

        // Doom 3
        new Link { GameID = "Doom3", Label = "Doom 3 BFG VR", Description = "Doom 3 BFG with native Oculus Rift/Touch or OpenVR support ",
          LinkType = LinkType.Download, Url = "https://github.com/NPi2Loup/DOOM-3-BFG-VR" },
        new Link { GameID = "Doom3", Label = "Doom 3 VR on for meta Quest", Description = "Doom 3 VR for meta Quest",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/2651/doom3quest" },
        new Link { GameID = "Doom3", Label = "Doom 3 VR for Pico 4", Description = "Doom 3 VR for Pico 4",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/42786/doom3quest-for-pico-4" },
        
        // Doom The Dark Ages
        new Link { GameID = "DoomDarkAges", Label = "Doom: The Dark Ages Launch Trailer", Description = "Doom: The Dark Ages Launch Trailer",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=S7IEg0_qNXs" },
        new Link { GameID = "DoomDarkAges", Label = "Doom: The Dark Ages - DF Deep Dive Review", Description = "DF Deep Dive Review - The id Tech 8 Engine Is Stunning",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=Ed4vNNQwCDU" },

        // Duke Nukem 3D
        new Link { GameID = "Duke3D", Label = "Razexr Build Engine for Quest", Description = "Razexr Build Engine for Quest",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/24502/razexr-build-engine-for-quest" },
        new Link { GameID = "Duke3D", Label = "Razexr Build Engine for Pico 4", Description = "Razexr Build Engine for Pico 4",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/24600/razexr-pico" },

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
        new Link { GameID = "ET", Label = "This is ET - Enemy Territory Fragmovie", Description = "This is ET - Enemy Territory Fragmovie",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=1ljXDiER4UQ" },
        new Link { GameID = "ET", Label = "ET: Legacy Official Site", Description = "Enemy Territory: Legacy official website",
          LinkType = LinkType.Official, Url = "https://www.etlegacy.com" },
        new Link { GameID = "ET", Label = "ET: Legacy Discord", Description = "Enemy Territory: Legacy Discord server",
          LinkType = LinkType.Discord, Url = "https://discord.gg/etlegacy" },
        new Link { GameID = "ET", Label = "ET: Legacy Competitive Discord", Description = "Enemy Territory: Legacy Competitive Discord server",
          LinkType = LinkType.Discord, Url = "https://discord.gg/etcompetitive" },
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
        new Link { GameID = "Go", Label = "Michael Redmon's beginner Go Lessons Playlist", Description = "Michael Redmon's beginner Go Lessons Playlist",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PLW5_cMTm0wvamCNX7qNoUqbXxeHt9n67i" },
        new Link { GameID = "Go", Label = "YoungBlade's must know Go Playlist", Description = "YoungBlade's must know Go Playlist",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PLFG-jNjCiKSNyAKGZwQ-rCTxf1GroGAQ3" },
        new Link { GameID = "Go", Label = "Lecture on shape", Description = "Lecture on Shape",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=IkzuAE93-bc" },
        new Link { GameID = "Go", Label = "AlphaGo - The Movie", Description = "Award winning documentary about AlphaGo",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=WXuK6gekU1Y" },
        new Link { GameID = "Go", Label = "Lee Sedol vs. AlphaGo: What Really Happened in the Match", Description = "Lee Sedol vs. AlphaGo: What Really Happened in the Match",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=Pd-kOPyVvRc" },
        new Link { GameID = "Go", Label = "Go games with English commentary playlist", Description = "Go games with English commentary playlist",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PLLoPXkTJconpvyrTeBzW5IK1A1CPKsMCG" },

        // HalfLife
        new Link { GameID = "HalfLife", Label = "Half-Life Fan Trailer", Description = "Half-Life Fan Trailer",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=_vHnHSEf_Q0" },
        new Link { GameID = "HalfLife", Label = "Half-life 1 developer videos playlist", Description = "Half-life 1 developer videos playlist",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/playlist?list=PLASWINVvIWaMDkG4KgHtbIZxN2rQhygX-" },
        new Link { GameID = "HalfLife", Label = "RetroAhoy: Half-life", Description = "RetroAhoy: Half-life",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/bp5vOgz8vyI" },
        new Link { GameID = "HalfLife", Label = "Errant Signal: Half-life", Description = "Errant Signal: Half-life",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/q-3gcVICiCs" },
        new Link { GameID = "HalfLife", Label = "A Thorough Look At Half-Life (Revised/Expanded)", Description = "A Thorough Look At Half-Life (Revised/Expanded)",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/_bsIXA8lNZc" },
        new Link { GameID = "HalfLife", Label = "Glitches and Tricks in Half-life 1", Description = "Glitches and Tricks in Half-life 1",
          LinkType = LinkType.Guide, Url = "https://youtu.be/zX5AHYZ5NJM" },
        new Link { GameID = "HalfLife", Label = "Half-Life 2 Sound Design Facts you have 0 chance knowing about", Description = "Half-Life 2 Sound Design Facts you have 0 chance knowing about",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=3NEq3Z588iY" },
        new Link { GameID = "HalfLife", Label = "Half-life Adrenaline Gamer frag movie by Alex", Description = "Half-life Adrenaline Gamer frag movie by Alex",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/c745LBQTmz0" },
        new Link { GameID = "HalfLife", Label = "Half-life: Opposing Force Trailer (Remake)", Description = "Half-life: Opposing Force Trailer (Remake)",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/gg5S1xcQMok" },
        new Link { GameID = "HalfLife", Label = "Half-life: Blue Shift Fan Trailer", Description = "Half-life: Blue Shift Fan Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/c9yKppVxsTQ" },
        new Link { GameID = "HalfLife", Label = "Half-life: VR Mod for PC VR", Description = "Half-life: VR Mod on Steam",
          LinkType = LinkType.Download, Url = "https://store.steampowered.com/app/1908720/HalfLife_VR_Mod/" },
        new Link { GameID = "HalfLife", Label = "Half-life: VR Mod for meta Quest", Description = "Half-life: VR Mod for meta Quest",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/124/lambda1vr-half-life-vr-meta-quest" },
        new Link { GameID = "HalfLife", Label = "Half-life: VR Mod for Pico 4", Description = "Half-life: VR Mod for Pico 4",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/20767/lambda1vr-half-life-vr-pico-4" },
        new Link { GameID = "HalfLife", Label = "Goldsrc and Source Mod discord", Description = "Goldsrc and Source Mod discord",
          LinkType = LinkType.Discord, Url = "https://discord.gg/kr8WWsB" },
        new Link { GameID = "HalfLife", Label = "Goldsrc Saturdays group", Description = "Goldsrc Saturdays group",
          LinkType = LinkType.Community, Url = "https://linktr.ee/gssat" },
        new Link { GameID = "HalfLife", Label = "goldsrc Forever", Description = "A Half-life 20th Anniversary Tribute",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=OY2_53oydbM" },
        new Link { GameID = "HalfLife", Label = "Lambda Generation", Description = "Half-life community",
          LinkType = LinkType.Community, Url = "https://community.lambdageneration.com/" },


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
        new Link { GameID = "HalfLife2", Label = "source 1 forever", Description = "source engine tribute",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=v6LI-QA-OvQ" },

        // HalfLifeAlyx
        new Link { GameID = "HalfLifeAlyx", Label = "Half-life: Alyx Trailer", Description = "Half-life: Alyx Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/O2W0N3uKXmo" },
        new Link { GameID = "HalfLifeAlyx", Label = "Half-life: Alyx Changed Everything (Spoiler free)", Description = "Half-life: Alyx Documentary",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/ZudAl7uUQfE" },

        // HellLetLoose
        new Link { GameID = "HellLetLoose", Label = "Welcome to Hell", Description = "My first game of Hell Let Loose, playing as Rifleman on Foy", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=XRxRvMa512o" },
        new Link { GameID = "HellLetLoose", Label = "How to \"Get\" Hell Let Loose", Description = "How to \"Get\" Hell Let Loose",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=1y2DnZ96JjY" },
        new Link { GameID = "HellLetLoose", Label = "Why you should be playing Hell Let Loose", Description = "Why you should be playing Hell Let Loose",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=ae3vaa1cOhU" },
        new Link { GameID = "HellLetLoose", Label = "Hell Let Loose Cinematic and funny moments", Description = "Hell Let Loose Cinematic and funny moments",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=O_An91MpwYg" },
        new Link { GameID = "HellLetLoose", Label = "Hell Let Loose Understanding Warfare vs Offensive", Description = "Understanding Warfare vs Offensive gamemodes",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=Mvvfgk5gxYk" },
        new Link { GameID = "HellLetLoose", Label = "Hell Let Loose Ultimate Rifleman Guide", Description = "Hell Let Loose Ultimate Rifleman Guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=9ENLfg-xOrU" },

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
        new Link { GameID = "Holdfast", Label = "Don't Stop me now", Description = "Holdfast music video. We're having a good time", 
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=CzaYwWOlaWc" },
        new Link { GameID = "Holdfast", Label = "Holdfast 51st regiment trailer", Description = "bang bang you're about to die", 
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=YIK5YNjMDHM" },

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

        // House of the Dead 3
        new Link { GameID = "HouseOfTheDead3", Label = "House of the Dead 3 PC Mod", Description = "Makes House of the Dead 3 playable with a lightgun",
          LinkType = LinkType.Download, Url = "https://github.com/argonlefou/Hotd3pc_ArcadeMod" },

        // Isonzo
        new Link { GameID = "Isonzo", Label = "Isonzo", Description = "Me playing Isonzo as Rifleman on piana", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=ioxdqxe6oT8" },

        // LambdaFortress
        new Link { GameID = "LambdaFortress", Label = "Lambda Fortress", Description = "Me playing Lambda Fortress as Medic on Half-Life 2: Episode 2", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Roa8lmfpR4Q" },

        // Midair2
        new Link { GameID = "Midair2", Label = "Midair 2", Description = "Me playing CTF on map crater", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=lc269BpmM0I" },

        // Marvel vs Capcom 2
        new Link { GameID = "MvC2", Label = "MvC2 101 - Competitive Fundamentals!", Description = "2 hour lecture on Marvel vs Capcom 2",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=MRB9rEPP_Bo" },
        new Link { GameID = "MvC2", Label = "Andor's Beginner's Guides Playlist", Description = "Playlist of beginner's guides for different MvC2 characters",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PLzHB9xp8a2w5brG430zngXRvmdsHFTKpm" },
        new Link { GameID = "MvC2", Label = "Dhalism complete DVD tutorial", Description = "Dhalism complete DVD tutorial",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=dRAd5brVUmU" },
        new Link { GameID = "MvC2", Label = "MvC2 - Ataraxia Combo Video (2020)", Description = "Marvel vs Capcom 2 combo video",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=IfER_bm7e5c" },

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
          LinkType = LinkType.Discord, Url = "https://discord.gg/ZUSSBUA" },
        
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
        
        //Prey
        new Link { GameID = "Prey", Label = "Prey VR for meta Quest", Description = "Prey VR for meta Quest",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/23478/prey-vr" },
        
        // PVK
        new Link { GameID = "PVK", Label = "pirates vikings and knights", Description = "Beserker viking gameplay on helms_deep", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=NRfRaGpmcJY" },

        // Quake1
        // General
        new Link { GameID = "Quake1", Label = "Quake 1 2025 guide", Description = "My complete guide to playing Quake 1 in 2025", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=VC-CW_NH45E" },
        new Link { GameID = "Quake1", Label = "So you want to play some Quake?", Description = "Video guide to playing Quake 1",
          LinkType = LinkType.Guide, Url = "https://youtu.be/CGj4gXyCzg0" },
        new Link { GameID = "Quake1", Label = "The Legacy of Quake", Description = "The Legacy of Quake Documentary",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=AZ9TAzZXfqM" },
        new Link { GameID = "Quake1", Label = "Why I love Quake", Description = "Video essay on Quake 1", 
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=QulZjDAGTLM" },
        new Link { GameID = "Quake1", Label = "RetroAhoy: Quake", Description = "RetroAhoy: Quake",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=OipJYWhMi3k" },
        new Link { GameID = "Quake1", Label = "Nailing the sound of horror: NIN + id Documentary", Description = "NIN + id Documentary",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=mp12k6LOgV0" },
        new Link { GameID = "Quake1", Label = "Quake launch event 1996", Description = "Quake launch event 1996",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=LXw6BkZ-gdY" },
        new Link { GameID = "Quake1", Label = "In-browser shareware Quake", Description = "In-browser shareware Quake",
          LinkType = LinkType.Download, Url = "https://www.netquake.io/" },
        new Link { GameID = "Quake1", Label = "EzQuake", Description = "EzQuake Multiplayer Client",
          LinkType = LinkType.Download, Url = "http://www.ezquake.com/" },
        new Link { GameID = "Quake1", Label = "NQuake", Description = "NQuake (EzQuake Installer)",
          LinkType = LinkType.Download, Url = "https://nquake.com/" },
        new Link { GameID = "Quake1", Label = "My Quake config", Description = "My Quake config",
          LinkType = LinkType.Guide, Url = "https://raw.githubusercontent.com/philchute/configs/master/philquake.cfg" },
        new Link { GameID = "Quake1", Label = "Active Quake Servers", Description = "Active Servers on badplace.eu",
          LinkType = LinkType.Community, Url = "https://badplace.eu/" },
        new Link { GameID = "Quake1", Label = "All Quake Servers", Description = "All Quake Servers on quakeservers.net",
          LinkType = LinkType.Community, Url = "https://www.quakeservers.net/quakeworld/servers/" },
        new Link { GameID = "Quake1", Label = "usquake.world discord", Description = "usquake.world discord",
          LinkType = LinkType.Discord, Url = "http://discord.usquake.world/" },
        

        new Link { GameID = "Quake1", Label = "QuakeQuest for Quest and Pico", Description = "QuakeQuest for Quest and Pico",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/93/quakequest-for-quest-pico" },

        //General Video Links  
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
        new Link { GameID = "Quake1", Label = "Quake 1 bunny hopping guide", Description = "Quake 1 bunny hopping guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=v6jm9iGW2Co" },
        new Link { GameID = "Quake1", Label = "Power bunny guide by Elgu", Description = "Power bunny guide by Elgu",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=Yjh-9ExEcp0" },
        new Link { GameID = "Quake1", Label = "Trenchbroom 2 mapping by dumptruck_ds", Description = "Trenchbroom 2 mapping by dumptruck_ds",
          LinkType = LinkType.Guide, Url = "https://youtube.com/playlist?list=PLgDKRPte5Y0AZ_K_PZbWbgBAEt5xf74aE" },
        new Link { GameID = "Quake1", Label = "Minecraft-style logic in Quake", Description = "Minecraft-style logic in Quake",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=xVLtnKyRSb4" },
        new Link { GameID = "Quake1", Label = "libre quake", Description = "Installation and gameplay using open source libre quake", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=GfO8OEtdBqc" },
        new Link { GameID = "Quake1", Label = "Quake Dwell Trailer (Custom episode)", Description = "Quake Dwell Trailer (Custom episode)",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=5i8pHwbZlOo" },
        //Frags
        new Link { GameID = "Quake1", Label = "Frags Done Extreme", Description = "Retro frag video",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/3ttIogcNe0A" },
        new Link { GameID = "Quake1", Label = "QuakeCon QuakeWorld 2on2", Description = "Modern frag video",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/2T2mhSFRRMg" },
        new Link { GameID = "Quake1", Label = "kyu.one", Description = "One of the best Quake 1 frag videos",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=LNxm7ljeFoU" },
        // Tricks
        new Link { GameID = "Quake1", Label = "Quakeworld basic tricks", Description = "Quakeworld basic tricks",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=Iz5wlNJpD1g" },
        new Link { GameID = "Quake1", Label = "NetQuake trick jumps", Description = "NetQuake trick jumps",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=gBaxSWfwobE" },
        // Speedruns
        new Link { GameID = "Quake1", Label = "Quake Speedruns Explained", Description = "Quake Speedruns Explained youtube channel",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/channel/UCqjTN5ZTN69baab1pJgYW0w/videos" },
        new Link { GameID = "Quake1", Label = "The five month grind to save one second", Description = "Quake Speedruns Explained doc on e4m3 Nightmare 100%",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=cbmphzC05oo" },
        new Link { GameID = "Quake1", Label = "speeddemosarchive.com/quake", Description = "Quake speedruns website",
          LinkType = LinkType.Community, Url = "https://speeddemosarchive.com/quake/" },
        new Link { GameID = "Quake1", Label = "Old Speeddemos Archive Promo video", Description = "Old Speeddemos Archive promo video",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=iZQe5Yza_Og" },
        new Link { GameID = "Quake1", Label = "Quake Done 100% Quickest Lite Trailer", Description = "New Speeddemos Archive promo video",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=NRlt0LM4NEM" },
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
        new Link { GameID = "Quake1", Label = "Quake speed mechanics on controller", Description = "Quake speed mechanics on controller",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=HvnG4vNeIZQ" },
        new Link { GameID = "Quake1", Label = "Quake 1 TAS (Tool Assisted Speedrun)", Description = "Quake 1 TAS (Tool Assisted Speedrun)",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=ekdcUOW1geA" },
        new Link { GameID = "Quake1", Label = "How to TAS Quake with TASQuake", Description = "How to TAS Quake with TASQuake",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=ZmtlCD5Rxmw" },
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
        new Link { GameID = "Quake2", Label = "FFA gameplay on q2dm1", Description = "FFA gameplay on q2dm1", 
          LinkType = LinkType.Gameplay, MapID = "q2dm1", Url = "https://www.youtube.com/watch?v=sgPyQ6wUtwY" },
        new Link { GameID = "Quake2", Label = "Quake 2 VR for meta Quest", Description = "Quake 2 VR for meta Quest",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/353/quake-2-vr-for-quest" },

        // Quake3
        new Link { GameID = "Quake3", Label = "Quakecon duel retrospectives playlist", Description = "Analysis of duels from Quakecon history",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PL18s8FLAe6l7olmMJ2SfHMYzFgGwhyAVY" },
        new Link { GameID = "Quake3", Label = "Shaolin Productions - Tricking iT2 Remastered", Description = "One of the best trick jumping videos",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/UYbQIsAtlnY" },
        new Link { GameID = "Quake3", Label = "Quake 3 Frag Highlights - AnnihilatioN", Description = "One of the all time best Quake 3 frag movies",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/MQJzUsZb7co" },
        new Link { GameID = "Quake3", Label = "Quake 3 Castor Fiber", Description = "One of my favorite Quake 3 frag movies",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=111YR7B6PvU" },
        new Link { GameID = "Quake3", Label = "Quake 3 VR for meta Quest", Description = "Quake 3 VR for meta Quest",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/8601/quake3quest" },
        new Link { GameID = "Quake3", Label = "Quake 3 VR for Pico 4", Description = "Quake 3 VR for Pico 4",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/12683/quake3pico" },

        // QuakeChampions
        new Link { GameID = "QC", Label = "Quake Champions Trailer", Description = "Quake Champions GameplayTrailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/B5WXQW5opa8" },
        new Link { GameID = "QC", Label = "The Greatest Quake Player on Earth | rapha short movie", Description = "The Greatest Quake Player on Earth | rapha short movie",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/lJBN_lu-OVo" },
        new Link { GameID = "QC", Label = "Is Quake Champions Any Good?", Description = "Is Quake Champions Any Good? - A sign of the times in modern gaming",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/L4ej5xk-HHY" },
        new Link { GameID = "QC", Label = "Death of a Game: Quake Champions", Description = "Death of a Game: Quake Champions",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/zsQFxBndRG0" },

        // QuakeLive
        new Link { GameID = "QuakeLive", Label = "Quake Live Trailer", Description = "Quake Live Launch Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/4aNG7cd7rGM" },

        // Ricochet
        new Link { GameID = "Ricochet", Label = "Ricochet discord", Description = "Ricochet community discord",
          LinkType = LinkType.Discord, Url = "https://discord.gg/b2teuWM" },
        new Link { GameID = "Ricochet", Label = "Ricochet: A Deep Look at a Shallow Game", Description = "Ricochet: A Deep Look at a Shallow Game",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=4B2DRbbloEs" },
        new Link { GameID = "Ricochet", Label = "Ricochet Mapping Tutorial", Description = "Ricochet Mapping Tutorial",
          LinkType = LinkType.Guide, Url = "https://youtu.be/5R0zHzTX95Y" },
        new Link { GameID = "Ricochet", Label = "Ricochet Pub Practice", Description = "Ricochet Pub Practice", 
          LinkType = LinkType.Highlights, Url = "https://youtu.be/eZW5iDiSoZ4" },
        new Link { GameID = "Ricochet", Label = "ricochet random maps", Description = "Gameplay on various maps", 
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=XYqK1bxGWic" },
        new Link { GameID = "Ricochet", Label = "ricochet random maps 2", Description = "rc_pillars, rc_glupshitto_v2, rc_gss_dust2, rc_deathmatch_extended, rc_snake, rc_skiz", 
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=iXjZ5xNTXcs" },
        new Link { GameID = "Ricochet", Label = "ricochet dust2 pub", Description = "Gameplay on rc_dust2",
          LinkType = LinkType.Highlights, MapID = "dust2", Url = "https://www.youtube.com/watch?v=S5_IBXCFGX8" },
        new Link { GameID = "Ricochet", Label = "Ricocheting the bar:  Player Count Event", Description = "Deathmatch gameplay on rc_ratrace",
          LinkType = LinkType.Highlights, MapID = "ratrace", Url = "https://www.youtube.com/watch?v=mZKNFQL35Zk" },

        // Rocket League
        new Link { GameID = "RocketLeague", Label = "Top 10 Rocket League Goals Of All-Time", Description = "Rocket League featured on SportsNet",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=l0xE-X64MtE" },

        // RTCW
        new Link { GameID = "RTCW", Label = "Steam Sale Sleepers: Return to Castle Wolfenstein", Description = "My video about Return to Castle Wolfenstein", 
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=9feP9IyXdwk" },
        new Link { GameID = "RTCW", Label = "Real RTCW on Steam", Description = "Complete overhaul of RTCW",
          LinkType = LinkType.Download, Url = "https://store.steampowered.com/app/1379630/RealRTCW/" },
        new Link { GameID = "RTCW", Label = "RTCW Wolfenstein competitive history: Quakecon 2003", Description = "RTCW Wolfenstein competitive history: Quakecon 2003",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=84B6mOTD9Q4" },
        new Link { GameID = "RTCW", Label = "Homiejump 2 the end. RtCW trickjump map", Description = "Homiejump 2 the end. RtCW trickjump map",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=7QkqKc3uN_k" },
        new Link { GameID = "RTCW", Label = "Return to Castle Wolfenstein VR for meta Quest", Description = "Return to Castle Wolfenstein VR for meta Quest",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/1446/return-to-castle-wolfenstein-vr" },

        // ScienceAndIndustry
        new Link { GameID = "SAndI", Label = "Science and Industry", Description = "Gameplay on si_deep", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=RLS0ilDNsgE" },
        
        // Shogi
        new Link { GameID = "Shogi", Label = "Lishogi", Description = "Play Shogi online for free",
          LinkType = LinkType.Community, Url = "https://lishogi.org/" },

        // Star Wars: Jedi Knight
        new Link { GameID = "JediKnight", Label = "Star Wars: Jedi Knight in VR for meta Quest", Description = "Star Wars: Jedi Knight in VR for meta Quest",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/15472/jk-xr-jedi-knight-in-vr-meta-quest" },
        new Link { GameID = "JediKnight", Label = "Star Wars: Jedi Knight in VR for Pico 4", Description = "Star Wars: Jedi Knight in VR for Pico 4",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/15541/jk-xr-jk2-outcast-jk-academy-pico" },

        // Starcraft
        new Link { GameID = "SC", Label = "How to get started with Starcraft 2", Description = "Macro tutorial all three races",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=OJs6qS5TQyo" },

        // Street Fighter 2
        new Link { GameID = "SSF2T", Label = "Street Fighter 2: Mastering Great Combinations & Strategies", Description = "Retro Street Fighter 2 video guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=IfS02WjRU8g" },
        new Link { GameID = "SSF2T", Label = "CvS2 is broken", Description = "Some broken things about Capcom vs. SNK 2",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=6bsHoIAZRBc" },
        new Link { GameID = "SSF2T", Label = "Analysis: The consequences of reducing the skill gap", Description = "Video essay about the diago parry and the evolution of Street Fighter",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=iSgA_nK_w3A" },

        // Street Fighter 3 
        new Link { GameID = "SSF3", Label = "Street Fighter 3: 3rd Strike is broken", Description = "3rd Strike is broken",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=iOuVA1wYMic" },

        // Super Street Fighter 2 Turbo
        new Link { GameID = "SSF2T", Label = "Super Street Fighter 2 Turbo is the Ultimate Fighting Game", Description = "Super Street Fighter 2 Turbo is the Ultimate Fighting Game",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=RlhK7fNqNE0" },
        new Link { GameID = "SSF2T", Label = "David Sirlin's Tutorial Playlist", Description = "David Sirlin's Tutorial Playlist",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PL5E8E2A6415422B77" },
        new Link { GameID = "SSF2T", Label = "Super Turbo Tutorials Playlist", Description = "Super Turbo Tutorials hosted by Sergjiev and eltrouble",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/playlist?list=PLjqLxjAWgCpbcJapyOgY44Ck44lfrb7u6" },
        new Link { GameID = "SSF2T", Label = "Super Turbo - How to Reverse Tick Attempts", Description = "How to Reverse Tick Attempts",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=1ZCBiKXKfy0" },
        new Link { GameID = "SSF2T", Label = "Super Turbo is broken", Description = "Some broken things about Super Turbo",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=2s-gOeLbANM" },
        new Link { GameID = "SSF2T", Label = "Fight Kingdom 2025 - ST Top 8", Description = "Super Turbo Tournament Finals",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=4QiQ-fHugG8" },
        new Link { GameID = "SSF2T", Label = "Super Street Fighter 2 Turbo Wiki", Description = "Super Street Fighter 2 Turbo Wiki",
          LinkType = LinkType.Community, Url = "https://wiki.supercombo.gg/w/Super_Street_Fighter_2_Turbo" },
        new Link { GameID = "SSF2T", Label = "Super Street Fighter 2 Turbo FAQ", Description = "Super Street Fighter 2 Turbo FAQ",
          LinkType = LinkType.Community, Url = "https://wiki.supercombo.gg/w/Super_Street_Fighter_2_Turbo/FAQ" },
        new Link { GameID = "SSF2T", Label = "Super Street Fighter 2 Turbo Moves", Description = "Super Street Fighter 2 Turbo Moves",
          LinkType = LinkType.Community, Url = "https://strategywiki.org/wiki/Super_Street_Fighter_II_Turbo/Moves" },
        
        // Super Puzzle Fighter 2 Turbo 
        new Link { GameID = "SPF2T", Label = "Super Puzzle Fighter 2 Turbo Chaining Tutorial", Description = "Super Puzzle Fighter 2 Turbo Chaining Tutorial",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=CwrHWsssgzw" },

        // Syndicate Black Ops
        new Link { GameID = "SyndicateBlackOps", Label = "Syndicate Black Ops on ModDB", Description = "Syndicate Black Ops on ModDB",
          LinkType = LinkType.Download, Url = "https://www.moddb.com/mods/syndicate-black-ops" },

        // TheFinals
        new Link { GameID = "TheFinals", Label = "the finals playtest", Description = "3v3v3 gameplay on stadium", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=o9GwWDeB8PA" },
        new Link { GameID = "TheFinals", Label = "Finals free and easy", Description = "Light gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=ZXQfdhRMqEA" },
        new Link { GameID = "TheFinals", Label = "Finals slowmotion", Description = "Light gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=kfvcTN2eFYY" },

        // Tomb Raider
        new Link { GameID = "TombRaider", Label = "Beef Raider: Tomb Raider in VR", Description = "Beef Raider: Tomb Raider in VR",
          LinkType = LinkType.Download, Url = "https://sidequestvr.com/app/38086/beef-raider-xr-tomb-raider-in-vr" },

        // Tribes1
        new Link { GameID = "Tribes1", Label = "Tribes1", Description = "Pub gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/SNl4jWwUbaI" },
        new Link { GameID = "Tribes1", Label = "Starseige Tribes pickups", Description = "Tribes 1 discord and pickup games",
          LinkType = LinkType.Community, Url = "https://playt1.com/" },
        new Link { GameID = "Tribes1", Label = "Tribes 1", Description = "Tribes 1 community",
          LinkType = LinkType.Community, Url = "https://tr1bes.us/" },

        // Tribes2
        new Link { GameID = "Tribes2", Label = "Tribes 2 Community Release", Description = "Tribes 2 Community Release and Server info",
          LinkType = LinkType.Download, Url = "https://www.tribesnext.com/" },
        new Link { GameID = "Tribes2", Label = "Tribes 2: yavor - Travel ", Description = "One of my all time favorite gaming montages. Low quality on youtube but there's a dl link.",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=qXC3tezqwrA" },

        // Tribes3
        new Link { GameID = "Tribes3", Label = "Tribes 3", Description = "Mid gameplay on island", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=69FXmkBriFk" },
        new Link { GameID = "Tribes3", Label = "Tribes 3", Description = "Mid gameplay on katabatic", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=CnNYf6Oc1zw" },
        new Link { GameID = "Tribes3", Label = "Tribes 3 12s", Description = "Mid gameplay on mountain", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=o9oP8EwTBeQ" },
        new Link { GameID = "Tribes3", Label = "Through the Fire and the Fury - Tribes 3 Mortar Montage", Description = "Through the Fire and the Fury - Tribes 3 Mortar Montage",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=nC-7XQThY38" },
        
        //TribesAscend
        new Link { GameID = "TribesAscend", Label = "TRIBES ASCEND Korean Fan Trailer 'Give me the flag'", Description = "TRIBES ASCEND Korean Fan Trailer 'Give me the flag'",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=TOtuw4qq4gA" },
        new Link { GameID = "TribesAscend", Label = "Fast Movers - A Tribes: Ascend Montage", Description = "My favorite Tribes Ascend montage",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=_FBfV55tDQo" },
        new Link { GameID = "TribesAscend", Label = "Best Of OOTB | Tribes : Ascend Community Montage", Description = "Best Of OOTB | Tribes : Ascend Community Montage",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=Kb8UmlLodao" },
        new Link { GameID = "TribesAscend", Label = "Best Of OOTB 2 | Tribes : Ascend Community Montage", Description = "Tribes : Ascend Community Montage",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=GzTIDaRmocg" },
        new Link { GameID = "TribesAscend", Label = "Best Of OOTB 3 | The Final Tribes : Ascend Community Montage", Description = "The Final Tribes : Ascend Community Montage",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=-DBU8upBip4" },
        new Link { GameID = "TribesAscend", Label = "Tribes Ascend | Team Flag Passing", Description = "Tribes Ascend | Team Flag Passing",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=lXhvwHYxmwk" },
        new Link { GameID = "TribesAscend", Label = "I Am King [Tribes Ascend Frag Video]", Description = "I Am King [Tribes Ascend Frag Video]",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=ZmKMw5cn_bw" },

        // Unreal Tournament
        new Link { GameID = "UT", Label = "UT99 in browser", Description = "Unreal Tournament 99 in browser",
          LinkType = LinkType.Download, Url = "https://icculus.org/ut99-emscripten/flyby/wasm/" },
        new Link { GameID = "UT", Label = "UT's living on", Description = "Unreal Tournament 99 frag movie",
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=lbvX9sqCnSU" },

        // Wolfenstein 3D
        new Link { GameID = "Wolf3D", Label = "RetroAhoy: Wolfenstein 3D", Description = "Documentary about Wolfenstein 3D",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/watch?v=BSb87DC-PtA" },
        new Link { GameID = "Wolf3D", Label = "Pro Wolfenstein 3D", Description = "Pro Wolfenstein 3D Analysis",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=U-tNx4-p2qM" },
    };
  }
}
}