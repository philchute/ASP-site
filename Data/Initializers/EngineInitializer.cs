using ASP_site.Models;

namespace ASP_site.Data.Initializers {
  public static class EngineInitializer {
    public static Engine[] GetEngines() {
      return new Engine[] {
        new Engine {
          EngineID = "idtech0",
          Name = "idtech0 (Wolfenstein 3D Engine)",
          Description = "idtech0 is a game engine developed by id Software, first used in the 1992 first-person shooter game Wolfenstein 3D.",
          ParentID = "", Year = 1992
        },
        new Engine {
          EngineID = "idtech1",
          Name = "idtech1 (Doom Engine)",
          Description = "idtech1 is a game engine developed by id Software, first used in the 1993 first-person shooter game Doom.",
          ParentID = "idtech0", Year = 1993
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
        },
        new Engine {
          EngineID = "iw2",
          Name = "IW 2.0 (Call of Duty 2 Engine)",
          Description = "IW 2.0 is a game engine developed by Infinity Ward, first used in Call of Duty 2. Based on Quake 3 engine idtech3.",
          ParentID = "idtech3", Year = 2005
        },
        new Engine {
          EngineID = "iw3",
          Name = "IW 3.0 (Modern Warfare Engine)",
          Description = "IW 3.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Modern Warfare.",
          ParentID = "iw2", Year = 2007
        },
        new Engine {
          EngineID = "iw4",
          Name = "IW 4.0 (Modern Warfare 2 Engine)",
          Description = "IW 4.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Modern Warfare 2. Based on IW 3.0.",
          ParentID = "iw3", Year = 2009
        },
        new Engine {
          EngineID = "iw5",
          Name = "IW 5.0 (Modern Warfare 3 Engine)",
          Description = "IW 5.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Modern Warfare 3. Based on IW 4.0.",
          ParentID = "iw4", Year = 2011
        },
        new Engine {
          EngineID = "iw6",
          Name = "IW 6.0 (Ghosts Engine)",
          Description = "IW 6.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Ghosts. Based on IW 5.0.",
          ParentID = "iw5", Year = 2013
        },
        new Engine {
          EngineID = "iw7",
          Name = "IW 7.0 (Infinite Warfare Engine)",
          Description = "IW 7.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Infinite Warfare. Based on IW 6.0.",
          ParentID = "iw6", Year = 2016
        },
        new Engine {
          EngineID = "iw8",
          Name = "IW 8.0 (Modern Warfare 2019 Engine)",
          Description = "IW 8.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Modern Warfare (2019). Based on IW 7.0.",
          ParentID = "iw7", Year = 2019
        },
        new Engine {
          EngineID = "iw9",
          Name = "IW 9.0 (Modern Warfare 2 Engine)",
          Description = "IW 9.0 is a game engine developed by Infinity Ward, first used in Call of Duty: Modern Warfare 2022. Based on IW 8.0.",
          ParentID = "iw8", Year = 2022
        },
        new Engine {
          EngineID = "treyarch",
          Name = "Treyarch Engine",
          Description = "Treyarch Engine is a game engine developed by Treyarch, first used in Call of Duty: World at War. Based on IW 4.0.",
          ParentID = "iw3", Year = 2008
        },
        new Engine {
          EngineID = "treyarch2",
          Name = "Treyarch Engine 2.0",
          Description = "Treyarch Engine 2.0 is a game engine developed by Treyarch, first used in Call of Duty: Black Ops III. Based on Treyarch Engine.",
          ParentID = "treyarch", Year = 2015
        },
        new Engine {
          EngineID = "sledgehammer",
          Name = "Sledgehammer Engine",
          Description = "Sledgehammer Engine is a game engine developed by Sledgehammer Games, first used in Call of Duty: Advanced Warfare."
                      + " Based on IW 6.0. No longer in use.",
          ParentID = "iw6", Year = 2014
        },
        new Engine {
          EngineID = "refractor1",
          Name = "Refractor 1",
          Description = "Refractor 1 is a game engine developed by Electronic Arts, first used in Battlefield 1942.",
          ParentID = "", Year = 2002
        },
        new Engine {
          EngineID = "refractor2",
          Name = "Refractor 2",
          Description = "Refractor 2 is a game engine developed by Electronic Arts, first used in Battlefield 2.",
          ParentID = "refractor1", Year = 2005
        },
        new Engine {
          EngineID = "frostbite1",
          Name = "Frostbite 1",
          Description = "Frostbite 1 is a game engine developed by Electronic Arts, first used in Battlefield: Bad Company.",
          ParentID = "refractor2", Year = 2008
        },
        new Engine {
          EngineID = "frostbite15",
          Name = "Frostbite 1.5",
          Description = "Frostbite 1.5 added destructable environments, first used in Battlefield 1943.",
          ParentID = "frostbite1", Year = 2009
        },
        new Engine {
          EngineID = "frostbite2",
          Name = "Frostbite 2",
          Description = "Frostbite 2 is a game engine developed by Electronic Arts, first used in Battlefield 3.",
          ParentID = "frostbite15", Year = 2011
        },
        new Engine {
          EngineID = "frostbite3",
          Name = "Frostbite 3",
          Description = "Frostbite 3 is a game engine developed by Electronic Arts, first used in Battlefield 4.",
          ParentID = "frostbite2", Year = 2013
        },
        new Engine {
          EngineID = "seriousengine",
          Name = "Serious Engine",
          Description = "Serious Engine is a game engine developed by Croteam, first used in Serious Sam: The First Encounter.",
          ParentID = "", Year = 2001
        },
        new Engine {
          EngineID = "seriousengine2",
          Name = "Serious Engine 2",
          Description = "Serious Engine 2 is a game engine developed by Croteam, first used in Serious Sam 2.",
          ParentID = "seriousengine", Year = 2009
        },
        new Engine {
          EngineID = "seriousengine3",
          Name = "Serious Engine 3",
          Description = "Serious Engine 3 is a game engine developed by Croteam, first used in Serious Sam 3: BFE.",
          ParentID = "seriousengine2", Year = 2011
        },
        new Engine {
          EngineID = "seriousengine4",
          Name = "Serious Engine 4",
          Description = "Serious Engine 4 is a game engine developed by Croteam, first used in The Talos Principle.",
          ParentID = "seriousengine3", Year = 2014
        },
        new Engine {
          EngineID = "build",
          Name = "Build Engine",
          Description = "Build Engine is a first-person shooter engine created by Ken Silverman, author of Ken's Labyrinth, for 3D Realms.",
          ParentID = "", Year = 1995
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
          Description = "Unreal Engine is a game engine developed by Epic Games, first used in 1998's Unreal.",
          ParentID = "", Year = 1998
        },
        new Engine {
          EngineID = "unreal2",
          Name = "Unreal Engine 2",
          Description = "Unreal Engine 2 is a game engine developed by Epic Games, first used in Unreal Tournament 2k3.",
          ParentID = "unreal", Year = 2004
        },
        new Engine {
          EngineID = "unreal3",
          Name = "Unreal Engine 3",
          Description = "Unreal Engine 3 is a game engine developed by Epic Games, used in Unreal Tournament 3.",
          ParentID = "unreal2", Year = 2007
        },
        new Engine {
          EngineID = "unreal4",
          Name = "Unreal Engine 4",
          Description = "Unreal Engine 4 is a game engine developed by Epic Games for the planned Unreal Tournament remake.",
          ParentID = "unreal3", Year = 2014
        },
        new Engine {
          EngineID = "unreal5",
          Name = "Unreal Engine 5",
          Description = "Unreal Engine 5 is a game engine developed by Epic Games.",
          ParentID = "unreal4", Year = 2022
        }, 
        new Engine {
          EngineID = "jedi",
          Name = "Jedi Engine",
          Description = "Jedi Engine is a game engine developed by LucasArts, similar to the Build Engine, first used in Star Wars: Dark Forces.",
          Year = 1997
        },
        new Engine {
          EngineID = "sith",
          Name = "Sith Engine",
          Description = "Sith Engine is a game engine developed by LucasArts, similar to the Quake Engine, first used in Star Wars: Jedi Knight 2: Jedi Outcast.",
          ParentID = "jedi", Year = 2002
        },
        new Engine {
          EngineID = "tombraider",
          Name = "Tomb Raider Engine",
          Description = "Tomb Raider Engine is a game engine developed by Core Design, first used in Tomb Raider and heavily upgraded for each of the sequels.",
          ParentID = "", Year = 1996
        },
        new Engine {
          EngineID = "CPS-1",
          Name = "CPS-1",
          Description = "CPS-1 is an arcade system board developed by Capcom.",
          ParentID = "", Year = 1988
        },
        new Engine {
          EngineID = "CPS-2",
          Name = "CPS-2",
          Description = "CPS-2 is an arcade system board developed by Capcom.",
          ParentID = "CPS-1", Year = 1993
        },
        new Engine {
          EngineID = "CPS-3",
          Name = "CPS-3",
          Description = "CPS-3 is an arcade system board developed by Capcom.",
          ParentID = "CPS-2", Year = 1996       
        },
        new Engine {
          EngineID = "NAOMI",
          Name = "NAOMI",
          Description = "NAOMI is an arcade system board developed by SEGA based on the Dreamcast hardware.",
          ParentID = "CPS-3", Year = 1998
        },
        new Engine {
          EngineID = "Chihiro",
          Name = "Chihiro",
          Description = "Chihiro is an arcade system board developed by SEGA based on the X-Box hardware.",
          ParentID = "CPS-3", Year = 2000
        },
        new Engine {
          EngineID = "MT-Framework",
          Name = "MT-Framework",
          Description = "MT-Framework is a game engine developed by Capcom, based on the Onimusha 3 engine, first used in 2006's Dead Rising, last used in 2018's Monster Hunter: World (and still used in some new other ports of previous tiles).",
          ParentID = "", Year = 2006
        },
        new Engine {
          EngineID = "RE-Engine",
          Name = "RE-Engine",
          Description = "RE-Engine is a game engine developed by Capcom, first used in 2017's Resident Evil 7: Biohazard.",
          ParentID = "MT-Framework", Year = 2017
        }
      };
    }
  }
}