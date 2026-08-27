using ASP_site.Models;

namespace ASP_site.Data.Initializers {
  public static class EngineInitializer {
    public static Engine[] GetEngines() {
      return new Engine[] {
        new Engine {
          EngineID = "idtech0",
          Name = "idtech0 (Wolfenstein 3D Engine)",
          Developer = "id Software",
          License = "Open Source",
          DebutGameID = "wolf3d",
          Description = "idtech0 is a game engine developed by id Software, first used in the 1992 first-person shooter game Wolfenstein 3D.",
          ParentID = "", Year = 1992
        },
        new Engine {
          EngineID = "idtech1",
          Name = "idtech1 (Doom Engine)",
          Developer = "id Software",
          License = "Open Source",
          DebutGameID = "doom",
          Description = "idtech1 is a game engine developed by id Software, first used in the 1993 first-person shooter game Doom.",
          ParentID = "idtech0", Year = 1993
        },
        new Engine {
          EngineID = "idtech2",
          Name = "idtech2 (Quake 1 Engine)",
          Developer = "id Software",
          License = "Open Source",
          DebutGameID = "quake1",
          Description = "idtech2 is a game engine developed by id Software, first used in the 1996 first-person shooter game Quake.",
          ParentID = "idtech1", Year = 1996
        },
        new Engine {
          EngineID = "idtech3",
          Name = "idtech3 (Quake 3 Engine)",
          Developer = "id Software",
          License = "Open Source",
          DebutGameID = "quake3",
          Description = "idtech3 is a game engine developed by id Software, first used in the 1998 first-person shooter game Quake III Arena.",
          ParentID = "idtech2", Year = 1998
        },
        new Engine {
          EngineID = "idtech4",
          Name = "idtech4 (Doom 3 Engine)",
          Developer = "id Software",
          License = "Open Source",
          DebutGameID = "doom3",
          Description = "idtech4 is a game engine developed by id Software, first used in the 2004 first-person shooter game Doom 3.",
          ParentID = "idtech3", Year = 2004
        },
        new Engine {
          EngineID = "idtech5",
          Name = "idtech5 (Rage Engine)",
          Developer = "id Software",
          License = "Proprietary",
          DebutGameID = "rage",
          Description = "idtech5 is a game engine developed by id Software, first used in the 2011 first-person shooter game Rage.",
          ParentID = "idtech4", Year = 2011
        },
        new Engine {
          EngineID = "idtech6",
          Name = "idtech6 (Doom 2016 Engine)",
          Developer = "id Software",
          License = "Proprietary",
          DebutGameID = "doom2016",
          Description = "idtech6 is a game engine developed by id Software, first used in the 2016 first-person shooter game Doom 2016.",
          ParentID = "idtech5", Year = 2016
        },
        new Engine {
          EngineID = "idtech7",
          Name = "idtech7 (Doom Eternal Engine)",
          Developer = "id Software",
          License = "Proprietary",
          DebutGameID = "doometernal",
          Description = "idtech7 is a game engine developed by id Software, first used in the 2020 first-person shooter game Doom Eternal.",
          ParentID = "idtech6", Year = 2020
        },
        new Engine {
          EngineID = "idtech8",
          Name = "idtech8 (Doom Dark Ages Engine)",
          Developer = "id Software",
          License = "Proprietary",
          DebutGameID = "doomdarkages",
          Description = "idtech8 is a game engine developed by id Software, first used in the 2025 first-person shooter game Doom Dark Ages.",
          ParentID = "idtech7", Year = 2025
        },
        new Engine {
          EngineID = "goldsrc",
          Name = "GoldSrc (Half-Life Engine)",
          Developer = "Valve Software",
          License = "Proprietary",
          DebutGameID = "halflife",
          Description = "GoldSrc is a game engine developed by Valve Software, first used in the 1998 first-person shooter game Half-Life.",
          ParentID = "idtech2", Year = 1998
        },
        new Engine {
          EngineID = "source",
          Name = "Source (Half-Life 2 Engine)",
          Developer = "Valve Software",
          License = "Proprietary",
          DebutGameID = "halflife2",
          Description = "Source Engine is a game engine developed by Valve Software, first used in the 2004 first-person shooter game Half-Life 2.",
          ParentID = "goldsrc", Year = 2004
        },
        new Engine {
          EngineID = "source2",
          Name = "Source 2 (Half-Life: Alyx Engine)",
          Developer = "Valve Software",
          License = "Proprietary",
          DebutGameID = "dota2",
          Description = "Source 2 is a game engine developed by Valve Software, first used in Dota 2 in 2015.",
          ParentID = "source", Year = 2015
        },
        new Engine {
          EngineID = "iw2",
          Name = "IW 2.0 (Call of Duty 2 Engine)",
          Developer = "Infinity Ward",
          License = "Proprietary",
          DebutGameID = "cod2",
          Description = "IW 2.0 is a game engine developed by Infinity Ward, first used in Call of Duty 2. Based on Quake 3 engine idtech3.",
          ParentID = "idtech3", Year = 2005
        },
        new Engine {
          EngineID = "iw3",
          Name = "IW 3.0 (Modern Warfare Engine)",
          Developer = "Infinity Ward",
          License = "Proprietary",
          DebutGameID = "cod4",
          Description = "IW 3.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Modern Warfare.",
          ParentID = "iw2", Year = 2007
        },
        new Engine {
          EngineID = "iw4",
          Name = "IW 4.0 (Modern Warfare 2 Engine)",
          Developer = "Infinity Ward",
          License = "Proprietary",
          DebutGameID = "codmw2",
          Description = "IW 4.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Modern Warfare 2. Based on IW 3.0.",
          ParentID = "iw3", Year = 2009
        },
        new Engine {
          EngineID = "iw5",
          Name = "IW 5.0 (Modern Warfare 3 Engine)",
          Developer = "Infinity Ward",
          License = "Proprietary",
          DebutGameID = "codmw3",
          Description = "IW 5.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Modern Warfare 3. Based on IW 4.0.",
          ParentID = "iw4", Year = 2011
        },
        new Engine {
          EngineID = "iw6",
          Name = "IW 6.0 (Ghosts Engine)",
          Developer = "Infinity Ward",
          License = "Proprietary",
          DebutGameID = "codghosts",
          Description = "IW 6.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Ghosts. Based on IW 5.0.",
          ParentID = "iw5", Year = 2013
        },
        new Engine {
          EngineID = "iw7",
          Name = "IW 7.0 (Infinite Warfare Engine)",
          Developer = "Infinity Ward",
          License = "Proprietary",
          DebutGameID = "codiw",
          Description = "IW 7.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Infinite Warfare. Based on IW 6.0.",
          ParentID = "iw6", Year = 2016
        },
        new Engine {
          EngineID = "iw8",
          Name = "IW 8.0 (Modern Warfare 2019 Engine)",
          Developer = "Infinity Ward",
          License = "Proprietary",
          DebutGameID = "codmw2019",
          Description = "IW 8.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Modern Warfare (2019). Based on IW 7.0.",
          ParentID = "iw7", Year = 2019
        },
        new Engine {
          EngineID = "iw9",
          Name = "IW 9.0 (Modern Warfare 2 Engine)",
          Developer = "Infinity Ward",
          License = "Proprietary",
          DebutGameID = "codmw2r",
          Description = "IW 9.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Modern Warfare 2022. Based on IW 8.0.",
          ParentID = "iw8", Year = 2022
        },
        new Engine {
          EngineID = "treyarch",
          Name = "Treyarch Engine",
          Developer = "Treyarch",
          License = "Proprietary",
          DebutGameID = "codwaw",
          Description = "Treyarch Engine is a game engine developed by Treyarch, first used in Call of Duty: World at War. Based on IW 3.",
          ParentID = "iw3", Year = 2008
        },
        new Engine {
          EngineID = "treyarch2",
          Name = "Treyarch Engine 2.0",
          Developer = "Treyarch",
          License = "Proprietary",
          DebutGameID = "codbo3",
          Description = "Treyarch Engine 2.0 is a game engine developed by Treyarch, first used in Call of Duty: Black Ops III. Based on Treyarch Engine.",
          ParentID = "treyarch", Year = 2015
        },
        new Engine {
          EngineID = "sledgehammer",
          Name = "Sledgehammer Engine",
          Developer = "Sledgehammer Games",
          License = "Proprietary",
          DebutGameID = "codaw",
          Description = "Sledgehammer Engine is a game engine developed by Sledgehammer Games, first used in Call of Duty: Advanced Warfare."
                      + " Based on IW 6.0. No longer in use.",
          ParentID = "iw6", Year = 2014
        },
        new Engine {
          EngineID = "refractor1",
          Name = "Refractor 1",
          Developer = "Electronic Arts",
          License = "Proprietary",
          DebutGameID = "bfield1942",
          Description = "Refractor 1 is a game engine developed by Electronic Arts, first used in Battlefield 1942.",
          ParentID = "", Year = 2002
        },
        new Engine {
          EngineID = "refractor2",
          Name = "Refractor 2",
          Developer = "Electronic Arts",
          License = "Proprietary",
          DebutGameID = "battlefield2",
          Description = "Refractor 2 is a game engine developed by Electronic Arts, first used in Battlefield 2.",
          ParentID = "refractor1", Year = 2005
        },
        new Engine {
          EngineID = "frostbite1",
          Name = "Frostbite 1",
          Developer = "Electronic Arts",
          License = "Proprietary",
          DebutGameID = "battlefieldbadcompany",
          Description = "Frostbite 1 is a game engine developed by Electronic Arts, first used in Battlefield: Bad Company.",
          ParentID = "refractor2", Year = 2008
        },
        new Engine {
          EngineID = "frostbite15",
          Name = "Frostbite 1.5",
          Developer = "Electronic Arts",
          License = "Proprietary",
          DebutGameID = "battlefield1943",
          Description = "Frostbite 1.5 added destructible environments, first used in Battlefield 1943.",
          ParentID = "frostbite1", Year = 2009
        },
        new Engine {
          EngineID = "frostbite2",
          Name = "Frostbite 2",
          Developer = "Electronic Arts",
          License = "Proprietary",
          DebutGameID = "battlefield3",
          Description = "Frostbite 2 is a game engine developed by Electronic Arts, first used in Battlefield 3.",
          ParentID = "frostbite15", Year = 2011
        },
        new Engine {
          EngineID = "frostbite3",
          Name = "Frostbite 3",
          Developer = "Electronic Arts",
          License = "Proprietary",
          DebutGameID = "battlefield4",
          Description = "Frostbite 3 is a game engine developed by Electronic Arts, first used in Battlefield 4.",
          ParentID = "frostbite2", Year = 2013
        },
        new Engine {
          EngineID = "Asura Engine",
          Name = "Asura Engine",
          Developer = "Rebellion Developments",
          License = "Proprietary",
          DebutGameID = "avp(2010)",
          Description = "Asura Engine is a game engine developed by Rebellion Developments, first used in Aliens vs. Predator. Typically will default your monitor to 60 hz.",
          ParentID = "", Year = 2010
        },
        new Engine {
          EngineID = "build",
          Name = "Build Engine",
          Developer = "Ken Silverman",
          License = "Open Source",
          DebutGameID = "duke3d",
          Description = "Build Engine is a first-person shooter engine created by Ken Silverman, author of Ken's Labyrinth, for 3D Realms.",
          ParentID = "", Year = 1995
        },
        new Engine {
          EngineID = "seriousengine",
          Name = "Serious Engine",
          Developer = "Croteam",
          License = "Proprietary",
          DebutGameID = "serioussam",
          Description = "Serious Engine is a game engine developed by Croteam, first used in Serious Sam: The First Encounter.",
          ParentID = "", Year = 2001
        },
        new Engine {
          EngineID = "seriousengine2",
          Name = "Serious Engine 2",
          Developer = "Croteam",
          License = "Proprietary",
          DebutGameID = "serioussam2",
          Description = "Serious Engine 2 is a game engine developed by Croteam, first used in Serious Sam 2.",
          ParentID = "seriousengine", Year = 2009
        },
        new Engine {
          EngineID = "seriousengine3",
          Name = "Serious Engine 3",
          Developer = "Croteam",
          License = "Proprietary",
          DebutGameID = "serioussam3",
          Description = "Serious Engine 3 is a game engine developed by Croteam, first used in Serious Sam 3: BFE.",
          ParentID = "seriousengine2", Year = 2011
        },
        new Engine {
          EngineID = "seriousengine4",
          Name = "Serious Engine 4",
          Developer = "Croteam",
          License = "Proprietary",
          DebutGameID = "thetalosprinciple",
          Description = "Serious Engine 4 is a game engine developed by Croteam, first used in The Talos Principle.",
          ParentID = "seriousengine3", Year = 2014
        },
        new Engine {
          EngineID = "SWARM",
          Name = "SWARM Engine",
          Developer = "Strangelite",
          License = "Proprietary",
          DebutGameID = "starshiptroopers",
          Description = "SWARM Engine is a game engine developed by Strangelite, only used in the 2005 game Starship Troopers.",
          ParentID = "", Year = 2005
        },
        new Engine {
          EngineID = "tombraider",
          Name = "Tomb Raider Engine",
          Developer = "Core Design",
          License = "Proprietary",
          DebutGameID = "tombraider",
          Description = "Tomb Raider Engine is a game engine developed by Core Design, first used in Tomb Raider and heavily upgraded for each of the sequels.",
          ParentID = "", Year = 1996
        },
        new Engine {
          EngineID = "torque",
          Name = "Torque Engine",
          Developer = "Dynamix",
          License = "Open Source",
          DebutGameID = "tribes2",
          Description = "Torque Engine is a game engine originally developed by Dynamix for Tribes 2, later licensed by GarageGames then released as Open Source.",
          ParentID = "", Year = 2001
        },
        new Engine {
          EngineID = "CryEngine1",
          Name = "CryEngine 1",
          Developer = "Crytek",
          License = "Proprietary",
          DebutGameID = "farCry",
          Description = "CryEngine 1 is a game engine developed by Crytek, first used in Far Cry.",
          ParentID = "", Year = 2004
        },
        new Engine {
          EngineID = "Dunia",
          Name = "Dunia Engine",
          Developer = "Ubisoft",
          License = "Proprietary",
          DebutGameID = "farCry2",
          Description = "Dunia Engine is a fork of the Cry Engine used by Ubisoft for subsequent Far Cry titles.",
          ParentID = "CryEngine1", Year = 2008
        },
        new Engine {
          EngineID = "Dunia2",
          Name = "Dunia 2 Engine",
          Developer = "Ubisoft",
          License = "Proprietary",
          DebutGameID = "farCry3",
          Description = "Dunia 2 Engine is a continuation of the Dunia Engine used by Ubisoft for subsequent Far Cry titles.",
          ParentID = "Dunia", Year = 2012
        },
        new Engine {
          EngineID = "CryEngine2",
          Name = "CryEngine 2",
          Developer = "Crytek",
          License = "Proprietary",
          DebutGameID = "crysis",
          Description = "CryEngine 2 is a game engine developed by Crytek, first used in Crysis.",
          ParentID = "CryEngine1", Year = 2007
        },
        new Engine {
          EngineID = "CryEngine3",
          Name = "CryEngine 3",
          Developer = "Crytek",
          License = "Proprietary",
          DebutGameID = "crysis2",
          Description = "CryEngine 3 is a game engine developed by Crytek, first used in Crysis 2.",
          ParentID = "CryEngine2", Year = 2011
        },
        new Engine {
          EngineID = "AmazonLumberyard",
          Name = "Amazon Lumberyard Engine",
          Developer = "Amazon",
          License = "Proprietary",
          Description = "Amazon Lumberyard Engine is a game engine developed by Amazon.",
          ParentID = "CryEngine3", Year = 2015
        },
        new Engine {
          EngineID = "CryEngineV",
          Name = "CryEngine V",
          Developer = "Crytek",
          License = "Proprietary",
          Description = "After skipping CryEngine 4, CryEngine V is a game engine developed by Crytek in 2016.",
          ParentID = "CryEngine3", Year = 2016
        },
        new Engine {
          EngineID = "unity",
          Name = "Unity Engine",
          Description = "Unity Engine is a game engine developed by Unity Technologies, first used in 2005 for MacOS titles, it has become a common engine for cross-platform and mobile development. In 2023 they announced they would charge per-install royalties to their developers, prompting many to switch away from Unity.",
          ParentID = "", Year = 2005
        },
        new Engine {
          EngineID = "unreal",
          Name = "Unreal Engine",
          Developer = "Epic Games",
          License = "Proprietary",
          DebutGameID = "unreal",
          Description = "Unreal Engine is a game engine developed by Epic Games, first used in 1998's Unreal.",
          ParentID = "", Year = 1998
        },
        new Engine {
          EngineID = "unreal2",
          Name = "Unreal Engine 2",
          Developer = "Epic Games",
          License = "Proprietary",
          DebutGameID = "ut2003",
          Description = "Unreal Engine 2 is a game engine developed by Epic Games, first used in Unreal Tournament 2k3.",
          ParentID = "unreal", Year = 2002
        },
        new Engine {
          EngineID = "unreal3",
          Name = "Unreal Engine 3",
          Developer = "Epic Games",
          License = "Proprietary",
          DebutGameID = "ut3",
          Description = "Unreal Engine 3 is a game engine developed by Epic Games, used in Unreal Tournament 3.",
          ParentID = "unreal2", Year = 2007
        },
        new Engine {
          EngineID = "unreal4",
          Name = "Unreal Engine 4",
          Developer = "Epic Games",
          License = "Proprietary",
          Description = "Unreal Engine 4 is a game engine developed by Epic Games for the planned Unreal Tournament remake.",
          ParentID = "unreal3", Year = 2014
        },
        new Engine {
          EngineID = "unreal5",
          Name = "Unreal Engine 5",
          Developer = "Epic Games",
          License = "Proprietary",
          DebutGameID = "fortnite",
          Description = "Unreal Engine 5 is a game engine developed by Epic Games, first used in in an engine update for Fortnite.",
          ParentID = "unreal4", Year = 2022
        }, 
        new Engine {
          EngineID = "unreal6",
          Name = "Unreal Engine 6",
          Developer = "Epic Games",
          License = "Proprietary",
          DebutGameID = "rocketleague",
          Description = "Unreal Engine 6 is a game engine developed by Epic Games, first used in an engine update for Rocket League.",
          ParentID = "unreal5", Year = 2028
        }, 
        new Engine {
          EngineID = "jedi",
          Name = "Jedi Engine",
          Developer = "LucasArts",
          License = "Proprietary",
          DebutGameID = "starwarsdarkforces",
          Description = "Jedi Engine is a game engine developed by LucasArts, similar to the Build Engine, first used in Star Wars: Dark Forces.",
          Year = 1995
        },
        new Engine {
          EngineID = "sith",
          Name = "Sith Engine",
          Developer = "LucasArts",
          License = "Proprietary",
          DebutGameID = "starwarsjediknight",
          Description = "Sith Engine is a game engine developed by LucasArts, similar to the Quake Engine, first used in Star Wars: Jedi Knight: Dark Forces II.",
          ParentID = "jedi", Year = 1997
        },
        new Engine {
          EngineID = "CPS-1",
          Name = "CPS-1",
          Developer = "Capcom",
          License = "Proprietary",
          Description = "CPS-1 is an arcade system board developed by Capcom.",
          ParentID = "", Year = 1988
        },
        new Engine {
          EngineID = "CPS-2",
          Name = "CPS-2",
          Developer = "Capcom",
          License = "Proprietary",
          Description = "CPS-2 is an arcade system board developed by Capcom.",
          ParentID = "CPS-1", Year = 1993
        },
        new Engine {
          EngineID = "CPS-3",
          Name = "CPS-3",
          Developer = "Capcom",
          License = "Proprietary",
          Description = "CPS-3 is an arcade system board developed by Capcom.",
          ParentID = "CPS-2", Year = 1996       
        },
        new Engine {
          EngineID = "Model 1",
          Name = "Model 1",
          Developer = "Sega",
          License = "Proprietary",
          Description = "Model 1 is a game engine developed by Sega, first used in 1992 Virtua Racing.",
          ParentID = "", Year = 1992
        },
        new Engine {
          EngineID = "Model 2",
          Name = "Model 2",
          Developer = "Sega",
          License = "Proprietary",
          Description = "Developed in collaboration with GE Aerospace, first used in 1994 Daytona USA.",
          ParentID = "Model 1", Year = 1994
        },
        new Engine {
          EngineID = "Model 3",
          Name = "Model 3",
          Developer = "Sega",
          License = "Proprietary",
          Description = "Developed in collaboration with Lockheed Martin, first used in 1996 Virtua Fighter 3.",
          ParentID = "Model 2", Year = 1996
        },
        new Engine {
          EngineID = "NAOMI",
          Name = "NAOMI",
          Developer = "Sega",
          License = "Proprietary",
          Description = "NAOMI is an arcade system board developed by SEGA based on the Dreamcast hardware.",
          ParentID = "Model 3", Year = 1998
        },
        new Engine {
          EngineID = "Chihiro",
          Name = "Chihiro",
          Developer = "SEGA",
          License = "Proprietary",
          Description = "Chihiro is an arcade system board developed by SEGA based on the X-Box hardware.",
          ParentID = "NAOMI", Year = 2000
        },
        new Engine {
          EngineID = "MT-Framework",
          Name = "MT-Framework",
          Developer = "Capcom",
          License = "Proprietary",
          Description = "MT-Framework is a game engine developed by Capcom, based on the Onimusha 3 engine, first used in 2006's Dead Rising, last used in 2018's Monster Hunter: World (and still used in some new other ports of previous titles).",
          ParentID = "", Year = 2006
        },
        new Engine {
          EngineID = "RE-Engine",
          Name = "RE-Engine",
          Developer = "Capcom",
          License = "Proprietary",
          Description = "RE-Engine is a game engine developed by Capcom, first used in 2017's Resident Evil 7: Biohazard.",
          ParentID = "MT-Framework", Year = 2017
        },
        new Engine {
          EngineID = "Pyrogenesis",
          Name = "Pyrogenesis",
          Developer = "Wildfire Games",
          License = "Open Source",
          DebutGameID = "0ad",
          Description = "Pyrogenesis is a custom game engine designed for 0 A.D. by Wildfire Games.",
          ParentID = "", Year = 2009
        },
        new Engine {
          EngineID = "genie",
          Name = "Genie Engine",
          Developer = "Ensemble Studios",
          License = "Proprietary",
          DebutGameID = "aoe",
          Description = "Genie Engine is a game engine developed by Ensemble Studios, first used in 1997's Age of Empires.",
          ParentID = "", Year = 1997
        },
        new Engine {
          EngineID = "scimitar",
          Name = "Scimitar Engine",
          Developer = "Ubisoft",
          License = "Proprietary",
          DebutGameID = "ac",
          Description = "Scimitar Engine is a game engine developed by Ubisoft, first used in 2007's Assassin's Creed.",
          ParentID = "", Year = 2007
        },
        new Engine {
          EngineID = "anvil",
          Name = "Anvil Engine",
          Developer = "Ubisoft",
          License = "Proprietary",
          DebutGameID = "ac3",
          Description = "Anvil Engine is a game engine developed by Ubisoft, first used in 2012's Assassin's Creed III.",
          ParentID = "scimitar", Year = 2012
        },
        new Engine {
          EngineID = "anvilnext",
          Name = "AnvilNext Engine",
          Developer = "Ubisoft",
          License = "Proprietary",
          DebutGameID = "ac4",
          Description = "AnvilNext Engine is a game engine developed by Ubisoft, first used in 2013's Assassin's Creed IV: Black Flag.",
          ParentID = "anvil", Year = 2013
        },
        new Engine {
          EngineID = "anvilnext2",
          Name = "AnvilNext 2 Engine",
          Developer = "Ubisoft",
          License = "Proprietary",
          DebutGameID = "acunity",
          Description = "AnvilNext 2 Engine is a game engine developed by Ubisoft, first used in 2014's Assassin's Creed Unity.",
          ParentID = "anvilnext", Year = 2014
        },
        new Engine {
          EngineID = "steep",
          Name = "Steep Engine",
          Developer = "Ubisoft",
          License = "Proprietary",
          Description = "Steep Engine is a game engine developed by Ubisoft, first used in 2016's 'For Honor'",
          ParentID = "anvilnext2", Year = 2016
        },
        new Engine {
          EngineID = "ubisoftanvil",
          Name = "Ubisoft Anvil Engine",
          Developer = "Ubisoft",
          License = "Proprietary",
          DebutGameID = "acvalhalla",
          Description = "Ubisoft Anvil Engine is a game engine developed by Ubisoft, first used in 2020's Assassin's Creed Valhalla.",
          ParentID = "anvilnext2", Year = 2020
        },
      };
    }
  }
}