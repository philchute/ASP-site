using ASP_site.Models;

namespace ASP_site.Data.Initializers {
  public static class LinkInitializer {
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

        // AoE2
        new Link { GameID = "AoE2", Label = "Age of Empires 2 Overview", Description = "My overview of Age of Empires 2", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=VLXfLIOciTQ" },

        // AoE4
        new Link { GameID = "AoE4", Label = "Age of Empires 4 Overview", Description = "My overview of Age of Empires 4", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=9GTc1nfHehg" },

        // AttackersGoRed
        new Link { GameID = "AttackersGoRed", Label = "Attackers Go Red", Description = "Me playing Medic on rock2", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=MxRhBqu5vT4" },

        // BattleGrounds
        new Link { GameID = "BattleGrounds", Label = "Battlegrounds", Description = "Me playing Battlegrounds on bg_bridge", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=wJfindDcLA4" },

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

        // Chess
        new Link { GameID = "Chess", Label = "Chess L's are Lessons", Description = "Me playing Chess", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=fG_wydPhFYg" },

        // Civ6
        new Link { GameID = "Civ6", Label = "Civilization 6 introduction", Description = "My Civ 6 overview", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=qtTeJlAm-94" },

        // CnCGenerals
        new Link { GameID = "CnCGenerals", Label = "CnC Generals online", Description = "My CnC Generals online video guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=zkY1-a1r6AQ" },
        new Link { GameID = "CnCGenerals", Label = "CnC Generals mods", Description = "My CnC Generals mods video guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=7plPL84o5xw" },
        new Link { GameID = "CnC", Label = "CnC 2025 updates", Description = "My CnC 2025 updates", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=OLW6vajvrTw" },

        // CnCRA2
        new Link { GameID = "CnCRA2", Label = "CnC Red Alert 2 online", Description = "My RA2 online video guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=lRumNSTEcuo" },
        new Link { GameID = "CnCRA2", Label = "OpenRA", Description = "My OpenRA video guide", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=TeiML1_EDxc" },

        // CnCRenegade
        new Link { GameID = "CnCRenegade", Label = "CnC Renegade", Description = "My CnC Renegade video guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=CvNfHg-Pgo0" },

        // CnCTS
        new Link { GameID = "CnCTS", Label = "CnC Tiberian Sun", Description = "My CnC Tiberian Sun video guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=EMWNDDsaROw" },

        //CoD
        new Link { GameID = "CoD", Label = "CoD: United Offensive on Steam", Description = "CoD: United Offensive on Steam", 
          LinkType = LinkType.Store, Url = "https://store.steampowered.com/app/2640/Call_of_Duty_United_Offensive/" },

        // ColdIce
        new Link { GameID = "ColdIce", Label = "Cold Ice", Description = "Me playing Horde mode on snowcross", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=LhspfckRDyU" },

        // CounterStrike
        new Link { GameID = "CounterStrike", Label = "The Story of CS:GO: The Game That Never Dies", Description = "CS:GO documentary",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/H8Nv--NOU2k" },
        new Link { GameID = "CounterStrike", Label = "Legendary Astalis' dev1ce - CSGO frag movie", Description = "One of my favorite CS:GO frag movies",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/J_lsx_qc70o" },
        new Link { GameID = "CounterStrike", Label = "6 year old kid wins CS:GO round", Description = "6 year old kid wins CS:GO round",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/3-XekLszoQw" },
        new Link { GameID = "CounterStrike", Label = "CS:GO - Where Amazing Happens", Description = "CS:GO - Where Amazing Happens",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/dXd8JVRn7rY" },
        new Link { GameID = "CounterStrike", Label = "Let's do this Anubis", Description = "Competitive gameplay on de_anubis", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/rLHM7OWsl0s" },
        new Link { GameID = "CounterStrike", Label = "CS:GO 2v2 Shortdust", Description = "Me playing 2v2 with Tweety on the old shortdust map", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/E2ZYkwKia5w" },
        new Link { GameID = "CounterStrike", Label = "New Knife", Description = "Me playing 2v2 with Batman on nuke and the old boat house map", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=FAYz3AZ9dbM" },
        new Link { GameID = "CounterStrike", Label = "Dangerzone Hacker", Description = "Me playing Dangerzone vs a hacker", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/9YiGzlBM_WI" },
        new Link { GameID = "CounterStrike", Label = "Dangerzone Win", Description = "My first Dangerzone win", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/rpvvpJED0DI" },
        new Link { GameID = "CounterStrike", Label = "Don't Forget to Plant", Description = "Me playing de_mirage 5v5", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/sqTsGzuoa8g" },
        new Link { GameID = "CounterStrike", Label = "Danger Zone Coaching", Description = "DZ gameplay on blacksite", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Uem9eQa3s7o" },
        new Link { GameID = "CounterStrike", Label = "learning to fly on surf_pantheon", Description = "Surf gameplay on surf_pantheon", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/XEIIc1gFfpw" },
        new Link { GameID = "CounterStrike", Label = "Counterstrike in 2024", Description = "Gameplay on de_overpass", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=l7YBgaO3Jcw" },
        new Link { GameID = "CounterStrike", Label = "CS2 combat surf", Description = "Combat surf gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=MewoHsaWHJo" },
        new Link { GameID = "CounterStrike", Label = "zombie escape", Description = "Zombie escape gameplay on colors", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=RstiQUX9trw" },
        new Link { GameID = "CounterStrike", Label = "nuke gameplay", Description = "Gameplay on de_nuke", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Odd3PLg8g2U" },
        new Link { GameID = "CounterStrike", Label = "Arms Race insane game", Description = "Arms Race gameplay on ar_shoots", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Rp1jWGpNNJU" },
        new Link { GameID = "CounterStrike", Label = "CS2 Scancodes", Description = "CS2 Keybind Scancodes guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=6E1FOMlyN-w" },
        new Link { GameID = "CounterStrike", Label = "new map mills", Description = "CT gameplay on de_mills", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Hlo6Ehs6Bbk" },
        new Link { GameID = "CounterStrike", Label = "new map thera", Description = "T gameplay on de_thera", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=SUi8FzGwacc" },
        new Link { GameID = "CounterStrike", Label = "Counter-strike guide", Description = "", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=3rMQ3YxADaY" },

        // CS16
        new Link { GameID = "CS16", Label = "Where CS Happens (Where Amazing Happens) by EJA", Description = "Classic CS 1.6 edit",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/H4r3EJXo25Q" },
        new Link { GameID = "CS16", Label = "eoLithic - The Movie", Description = "eoLithic - The Movie",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/DQROf32t4yQ" },
        new Link { GameID = "CS16", Label = "eoLithic - Oslo by Storm", Description = "eoLithic - Oslo by Storm",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/REjjTOSzeE4" },
        new Link { GameID = "CS16", Label = "The Story of Door Stuck", Description = "Door stuck documentary",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/cXFBHtaQd40" },
        new Link { GameID = "CS16", Label = "play-cs", Description = "Me playing gun game on fy_pool_day on play-cs.com", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=aM1ocjaRXaE" },

        // CSCZ
        new Link { GameID = "CSCZ", Label = "VNN: The History of Counter-Strike: Condition Zero", Description = "VNN: The History of Counter-Strike: Condition Zero",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/E7dFt9-aGJQ" },
        new Link { GameID = "CSCZ", Label = "CS: CZ func_vehicle maps", Description = "Me playing some nipper func_vehicle maps with GSS", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=EOazC0R_nxk" },

        // CustomTF
        new Link { GameID = "CustomTF", Label = "QuakeWorld Prozac CustomTF website", Description = "QuakeWorld Prozac CustomTF website",
          LinkType = LinkType.Official, Url = "http://quake.midioz.com/" },

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

        // DoD
        new Link { GameID = "DoD", Label = "Nineteen Eleven DoD Community", Description = "Pickups, tournaments, forums and info",
          LinkType = LinkType.Community, Url = "https://nineteeneleven.org/" },
        new Link { GameID = "DoD", Label = "Day of Defeat - A retrospective tribute to Half-life modding", Description = "DoD documentary",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/-zUSp1u81I4" },
        new Link { GameID = "DoD", Label = "Defeat. Valve's Forgotten Game", Description = "Defeat. Valve's Forgotten Game",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/_MlspJ8M9kI" },
        new Link { GameID = "DoD", Label = "STOP IT!!! [DoD 1.3] (funny clip)", Description = "STOP IT!!! [DoD 1.3] (funny clip)",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/zwtpKTU5cn4" },
        new Link { GameID = "DoD", Label = "compLextity DoD (frag movie)", Description = "compLextity DoD (frag movie)",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/mJWYlbsK9r4" },
        new Link { GameID = "DoD", Label = "Day of Defeat Harrington", Description = "Me playing dod_harrington", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Tt_xRuPwAKw" },
        new Link { GameID = "DoD", Label = "DoD The Anzio Attempt", Description = "Funny gameplay clip on dod_anzio", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=m_sHi9dcrXQ" },
        new Link { GameID = "DoD", Label = "Day of Defeat lennon", Description = "Me playing dod_lennon", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/nz_DodIy--o" },

        // ESF
        new Link { GameID = "ESF", Label = "ESF pub", Description = "Gameplay on esf_canyon", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=NYOZ_X9XsV8" },
        new Link { GameID = "ESF", Label = "ESF duel", Description = "Goku gameplay on esf_cube", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=2Jt4Z9wTMBo" },

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

        // ETF
        new Link { GameID = "ETF", Label = "Enemy Territory Fortress Promo - ETF", Description = "Enemy Territory Fortress Promo - ETF",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=autxXIr7KOg" },
        new Link { GameID = "ETF", Label = "Moose & More - ETF Extreme", Description = "Moose & More - ETF Extreme",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/ZKlk6REUL70" },

        // FF
        new Link { GameID = "FF", Label = "Fortress Forever Official Site", Description = "Fortress Forever Official Site",
          LinkType = LinkType.Official, Url = "https://www.fortress-forever.com" },
        new Link { GameID = "FF", Label = "Fortress Forever Official Discord", Description = "Fortress Forever Official Discord",
          LinkType = LinkType.OfficialDiscord, Url = "https://discord.gg/jCphsAE" },
        new Link { GameID = "FF", Label = "Fortress Forever Official Wiki", Description = "Fortress Forever Official Wiki",
          LinkType = LinkType.Guide, Url = "http://www.fortress-forever.com/wiki/index.php?title=Main_Page" },
        new Link { GameID = "FF", Label = "Fortress Forever Fan Site", Description = "Fortress Forever Fan Site and guide",
          LinkType = LinkType.Community, Url = "https://sites.google.com/view/fortress-forever-fan-page/game" },
        new Link { GameID = "FF", Label = "FF SDK 2013", Description = "FF SDK 2013", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=fszh23SzfGw" },
        new Link { GameID = "FF", Label = "swoop engineer bingo", Description = "My playing engineer on swoop, many kill types in one game", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=PX1wEY3MMxk" },
        new Link { GameID = "FF", Label = "Scout phantom", Description = "Me playing scout on ff_phantom", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=s6AmiHUjpXw" },
        new Link { GameID = "FF", Label = "the soldier game", Description = "The four soldier defense on ff_tidal_b3", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=7RXkH-eiwaM" },
        new Link { GameID = "FF", Label = "demoman full half", Description = "Me playing demoman on ff_nyx", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=-tB8Y_Cs758" },
        new Link { GameID = "FF", Label = "destroy demoman chaos", Description = "Me playing demoman on ff_destroy", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=f8O7dPmuqAI" },
        new Link { GameID = "FF", Label = "Pitfalls of pitfall - We don't go to pitfall", Description = "Me playing on ff_pitfall", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/1NgpsZpVdLI" },
        new Link { GameID = "FF", Label = "FF schtop water game", Description = "Engineer/scout full game on ff_schtop", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/X0Ew4xIhMRg" },
        new Link { GameID = "FF", Label = "TF2 players guide to FF", Description = "All class gameplay on ff_openfire", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Cp-cETaiqDY" },
        new Link { GameID = "FF", Label = "Engineer adventures on mortality", Description = "Me playing engineer on ff_mortality_gz_b1", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/jsqyuPHQfkY" },
        new Link { GameID = "FF", Label = "Interesting start on catharsis", Description = "Me playing demoman on ff_catharsis_b4", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=NdgzhbyzspU" },
        new Link { GameID = "FF", Label = "FF alpha4", Description = "FF alpha4", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=mbpyssjZLas" },
        new Link { GameID = "FF", Label = "Fortress Forever 4v4 with commentary", Description = "4v4 gameplay with commentary on ff_destroy", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=ikYhLU6D2Rk" },

        // FLF
        new Link { GameID = "FLF", Label = "Front Line Force gameplay", Description = "Me playing assault on flf_village", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=jDLCM4pSQkw" },

        // FortressOne
        new Link { GameID = "FortressOne", Label = "FortressOne", Description = "FortressOne Official Site",
          LinkType = LinkType.Official, Url = "https://www.fortressone.org/" },
        new Link { GameID = "FortressOne", Label = "FortressOne Official Discord", Description = "FortressOne Official Discord",
          LinkType = LinkType.OfficialDiscord, Url = "https://discord.fortressone.org" },
        new Link { GameID = "FortressOne", Label = "FortressOne Latest Release", Description = "FortressOne Latest Release",
          LinkType = LinkType.Download, Url = "https://github.com/FortressOne/windows-installer/releases/latest" },
        new Link { GameID = "FortressOne", Label = "schtop snoozer stall", Description = "Me playing on ff-schtop", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=gUqfgc7jS98" },
        new Link { GameID = "FortressOne", Label = "prelude in phantom", Description = "Me playing on ff-phantom", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=WwoQJK-gY6Q" },
        new Link { GameID = "FortressOne", Label = "Spy Attacks on Swoop", Description = "Me playing spy on swoop", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=SDTcWKMXvGg" },
        new Link { GameID = "FortressOne", Label = "Weird pyro plays", Description = "Me playing pyro on openfire", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=2smzY17Hp7E" },
        new Link { GameID = "FortressOne", Label = "moving the flag out of destroy", Description = "Me playing on ff-destroy", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=ajTd3L8n6_w" },

        // HalfLife
        new Link { GameID = "HalfLife", Label = "Half-Life Fan Trailer", Description = "Half-Life Fan Trailer",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=_vHnHSEf_Q0" },
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

        // HalfLifeAlyx
        new Link { GameID = "HalfLifeAlyx", Label = "Half-life: Alyx Trailer", Description = "Half-life: Alyx Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/O2W0N3uKXmo" },
        new Link { GameID = "HalfLifeAlyx", Label = "Half-life: Alyx Changed Everything (Spoiler free)", Description = "Half-life: Alyx Changed Everything (Spoiler free)",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/ZudAl7uUQfE" },

        // HellLetLoose
        new Link { GameID = "HellLetLoose", Label = "Welcome to Hell", Description = "Rifleman gameplay on Foy", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=XRxRvMa512o" },

        // Holdfast
        new Link { GameID = "Holdfast", Label = "Holdfast", Description = "Me playing on islands", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Ji-lLwfoNf4" },
        new Link { GameID = "Holdfast", Label = "Holdfast intro", Description = "Holdfast intro guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=VO_NRkGgL3Q" },

        // Homefront
        new Link { GameID = "Homefront", Label = "homefront", Description = "Single player gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=hdWewUscSOM" },

        // Isonzo
        new Link { GameID = "Isonzo", Label = "isonzo", Description = "Rifleman gameplay on piana", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=ioxdqxe6oT8" },

        // LambdaFortress
        new Link { GameID = "LambdaFortress", Label = "Lambda Fortress", Description = "Medic gameplay on hl2:episode 2", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Roa8lmfpR4Q" },

        // MegaTF
        new Link { GameID = "MegaTF", Label = "Mega Fortress Wiki", Description = "Mega Fortress Wiki",
          LinkType = LinkType.Guide, Url = "https://wiki.megateamfortress.com/Main_Page" },

        // Midair2
        new Link { GameID = "Midair2", Label = "midair 2", Description = "CTF gameplay on crater", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=lc269BpmM0I" },

        // MilitaryConflictVietnam
        new Link { GameID = "MilitaryConflictVietnam", Label = "MCV Breaking the LAW", Description = "Me playing on base", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/GGw_pUOuFNE" },
        new Link { GameID = "MilitaryConflictVietnam", Label = "Military Conflict Vietnam Gungame", Description = "Gun game gameplay on mcv_tower_lgg", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=xJ6WapkO81U" },

        // Momentum
        new Link { GameID = "Momentum", Label = "momentum mod showcase", Description = "Momentum mod showcase", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=RdetcTpKe0k" },

        // NaturalSelection
        new Link { GameID = "NaturalSelection", Label = "Natural Selection", Description = "Gameplay footage", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=WVajO-U1o74" },

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

        // Q3F
        new Link { GameID = "Q3F", Label = "Quake 3 Fortress - The Dark Side", Description = "Quake 3 Fortress - The Dark Side",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/r1m50MI1WJk" },

        // Quake1
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
        new Link { GameID = "Quake1", Label = "Frags Done Extreme", Description = "Retro frag video",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/3ttIogcNe0A" },
        new Link { GameID = "Quake1", Label = "QuakeCon QuakeWorld 2on2", Description = "Modern frag video",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/2T2mhSFRRMg" },
        new Link { GameID = "Quake1", Label = "remembering how to aerowalk", Description = "1v1 gameplay on aerowalk", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=-f39CsoO4RE" },
        new Link { GameID = "Quake1", Label = "live by the ns die by the ns", Description = "2v2 gameplay on aerowalk", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=-d2Y05OrDiw" },
        new Link { GameID = "Quake1", Label = "beauty in simplicity", Description = "1v1 gameplay on bravado", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=oV-C-X2xB4Y" },
        new Link { GameID = "Quake1", Label = "ztndm3 bloodrun makes my blood run", Description = "2v2 gameplay on ztndm3", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=xQyB7ftUaBU" },
        new Link { GameID = "Quake1", Label = "Quake single segment attempt", Description = "Speedrun fail", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/iOiVOpOkaPE" },
        new Link { GameID = "Quake1", Label = "Quake single segment success", Description = "Single player speedrun no deaths", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=9qN0iUS37vo" },
        new Link { GameID = "Quake1", Label = "Quake 1 2v2", Description = "2v2 gameplay on aerowalk", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=yMLfyGYwHRI" },
        new Link { GameID = "Quake1", Label = "Quake 1 4v4 dm2", Description = "4v4 gameplay on dm2", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/FtfgfyTv0JQ" },
        new Link { GameID = "Quake1", Label = "Quake 1 2v2 bloodrun", Description = "2v2 gameplay on bloodrun", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/dXuw8hzAFho" },
        new Link { GameID = "Quake1", Label = "Quake 1 4v4 e1m2", Description = "4v4 gameplay on e1m2", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/9TBZRxJQW9g" },
        new Link { GameID = "Quake1", Label = "Zoned in on bravado", Description = "2v2 gameplay on bravado", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=7Z4rgK1Onb8" },
        new Link { GameID = "Quake1", Label = "QWDM chaos on catalyst", Description = "FFA gameplay on catalyst", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/2ZMj7FeyAbc" },
        new Link { GameID = "Quake1", Label = "italy", Description = "4v4 gameplay on italy", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=zKpmf03ejDY" },
        new Link { GameID = "Quake1", Label = "schloss", Description = "4v4 gameplay on schloss", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=UROFH2Qo4No" },
        new Link { GameID = "Quake1", Label = "Decino's Quake 25th Anniversary Event - Complete Chaos", Description = "packed server",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/rf7jFrhnhHU" },
        new Link { GameID = "Quake1", Label = "Kovaak teaches QuakeWorld duels", Description = "Kovaak teaches QuakeWorld duels playlist",
          LinkType = LinkType.Guide, Url = "https://youtube.com/playlist?list=PLxP7tvMqaXzDjw7OYYIEbplCdZOaHLFPg" },
        new Link { GameID = "Quake1", Label = "QuakePhil's QW Live Commentary", Description = "QuakePhil's QW Live Commentary playlist",
          LinkType = LinkType.Gameplay, Url = "https://youtube.com/playlist?list=PL5CE7BF3E83EBD8C0" },
        new Link { GameID = "Quake1", Label = "QuakePhil's QuakeWorld Tricks on DM6", Description = "QuakePhil's QuakeWorld Tricks on DM6",
          LinkType = LinkType.Guide, Url = "https://youtube.com/playlist?list=PLvMshQnM8rSuzxlmZSL6cfYanQ3OnVMK3" },
        new Link { GameID = "Quake1", Label = "QuakeWorld Basic Tricks", Description = "QuakeWorld Basic Tricks",
          LinkType = LinkType.Guide, Url = "https://youtu.be/Iz5wlNJpD1g" },
        new Link { GameID = "Quake1", Label = "DM2 2on2 strategy guide by milton", Description = "DM2 2on2 strategy guide by milton",
          LinkType = LinkType.Guide, Url = "https://youtu.be/snOVDPZfNtU" },
        new Link { GameID = "Quake1", Label = "FullStart w/ddk QuakeWorld 4v4 guides", Description = "FullStart w/ddk QuakeWorld 4v4 guides",
          LinkType = LinkType.Guide, Url = "https://youtube.com/playlist?list=PL3E4C95FD99C6594E" },
        new Link { GameID = "Quake1", Label = "Trenchbroom 2 mapping by dumptruck_ds", Description = "Trenchbroom 2 mapping by dumptruck_ds",
          LinkType = LinkType.Guide, Url = "https://youtube.com/playlist?list=PLgDKRPte5Y0AZ_K_PZbWbgBAEt5xf74aE" },
        new Link { GameID = "Quake1", Label = "Minecraft-style logic in Quake", Description = "Minecraft-style logic in Quake",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=xVLtnKyRSb4" },
        new Link { GameID = "Quake1", Label = "SO YOU WANT TO PLAY SOME QUAKE", Description = "SO YOU WANT TO PLAY SOME QUAKE",
          LinkType = LinkType.Guide, Url = "https://youtu.be/CGj4gXyCzg0" },
        new Link { GameID = "Quake1", Label = "This Quake Record Took 17 Years To Beat", Description = "This Quake Record Took 17 Years To Beat",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/43d8fICz6gM" },
        new Link { GameID = "Quake1", Label = "Quake Speedruns Explained", Description = "Quake Speedruns Explained channel",
          LinkType = LinkType.Documentary, Url = "https://www.youtube.com/channel/UCqjTN5ZTN69baab1pJgYW0w/videos" },
        new Link { GameID = "Quake1", Label = "speeddemosarchive.com/quake", Description = "Quake speedruns",
          LinkType = LinkType.Community, Url = "https://speeddemosarchive.com/quake/" },
        new Link { GameID = "Quake1", Label = "libre quake", Description = "DM guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=GfO8OEtdBqc" },

        // Quake2
        new Link { GameID = "Quake2", Label = "", Description = "FFA gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=sgPyQ6wUtwY" },

        // Quake3
        new Link { GameID = "Quake3", Label = "Shaolin Productions - Tricking iT2 Remastered", Description = "Shaolin Productions - Tricking iT2 Remastered",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/UYbQIsAtlnY" },
        new Link { GameID = "Quake3", Label = "Quake 3 Frag Highlights - AnnihilatioN", Description = "Quake 3 Frag Highlights - AnnihilatioN",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/MQJzUsZb7co" },

        // QuakeChampions
        new Link { GameID = "QuakeChampions", Label = "Quake Champions Trailer", Description = "Quake Champions Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/B5WXQW5opa8" },
        new Link { GameID = "QuakeChampions", Label = "The Greatest Quake Player on Earth | rapha short movie", Description = "The Greatest Quake Player on Earth | rapha short movie",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/lJBN_lu-OVo" },
        new Link { GameID = "QuakeChampions", Label = "Is Quake Champions Any Good? - A sign of the times in modern gaming", Description = "Is Quake Champions Any Good? - A sign of the times in modern gaming",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/L4ej5xk-HHY" },
        new Link { GameID = "QuakeChampions", Label = "Death of a Game: Quake Champions", Description = "Death of a Game: Quake Champions",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/zsQFxBndRG0" },

        // QuakeLive
        new Link { GameID = "QuakeLive", Label = "Quake Live Trailer", Description = "Quake Live Trailer",
          LinkType = LinkType.Trailer, Url = "https://youtu.be/4aNG7cd7rGM" },

        // QWTF
        new Link { GameID = "QWTF", Label = "Team Fortress Done Extreme", Description = "Team Fortress Done Extreme",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/23bfEouzFxY" },
        new Link { GameID = "QWTF", Label = "Team Fortress Done Extreme 2", Description = "Team Fortress Done Extreme 2",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/gPEkSWj6Jyc" },
        new Link { GameID = "QWTF", Label = "QWTF - The Redemption", Description = "QWTF - The Redemption",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/uepAtTQhyVs" },

        // Ricochet
        new Link { GameID = "Ricochet", Label = "Ricochet discord", Description = "Ricochet discord",
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
          LinkType = LinkType.Highlights, Url = "https://www.youtube.com/watch?v=S5_IBXCFGX8" },

        // RTCW
        new Link { GameID = "RTCW", Label = "Steam Sale Sleepers", Description = "Steam Sale Recomendations", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=9feP9IyXdwk" },

        // ScienceAndIndustry
        new Link { GameID = "ScienceAndIndustry", Label = "Science and Industry", Description = "Gameplay on si_deep", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=RLS0ilDNsgE" },

        // TF2
        new Link { GameID = "TF2", Label = "Errant Signal: Social Spaces & Payload Races", Description = "Errant Signal: Social Spaces & Payload Races",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/-hj1haLcdI0" },
        new Link { GameID = "TF2", Label = "What happens when overwatch players play TF2", Description = "What happens when overwatch players play TF2",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/rGHazA5a0pM" },
        new Link { GameID = "TF2", Label = "the best competitive game that nobody plays", Description = "the best competitive game that nobody plays",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/iHtmqtsRi3I" },
        new Link { GameID = "TF2", Label = "The soul of TF2 in one clip", Description = "The soul of TF2 in one clip",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/2hu1bUHL1mc" },

        // TFC
        new Link { GameID = "TFC", Label = "Nuki's TFC Learning Center", Description = "Nuki's TFC Learning Center",
          LinkType = LinkType.Guide, Url = "https://sites.google.com/view/nlc-tfc/home" },
        new Link { GameID = "TFC", Label = "20th Anniversary Retrospective", Description = "20th Anniversary Retrospective",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/q9nJLfjx7sA" },
        new Link { GameID = "TFC", Label = "Defrag and vriens TFC Skills movie", Description = "Defrag and vriens TFC Skills movie",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/LvTd9JkElNU" },
        new Link { GameID = "TFC", Label = "Skillout", Description = "Skillout",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/kRrjh8yp5yE" },
        new Link { GameID = "TFC", Label = "Team Spirit", Description = "Team Spirit",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/fbXsFZShsSE" },
        new Link { GameID = "TFC", Label = "Plain", Description = "Plain",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/V3Qu_47uUxI" },

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
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=o9oP8EwTBeQ" }
    };
  }

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
}
}