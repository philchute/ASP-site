using ASP_site.Models;

namespace ASP_site.Data.Initializers
{
  public static class CSMapInitializer
  {
    public static Map[] GetMaps()
    {
      return new Map[]
      {
        // Assassination Maps
        new Map
        {
          MapID = "oilrig",
          IsCompetitive = false,
          Description = "One of the original two assassination maps in Counterstrike, Oilrig was released in Counterstrike beta 6.",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "Chris \"MacMan\" Ashton ", Description = "1.6", FileName = "as_oilrig" },
            new MapGameInfo { GameID = "CSCZ", Author = "Chris \"MacMan\" Ashton ", Description = "CSCZ", FileName = "as_oilrig" }
          }
        },

        // Hostage Maps
        new Map
        {
          MapID = "747",
          IsCompetitive = false,
          Description = "Small hostage rescue map set inside a 747 airplane",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "Leon Nieuwoudt, Stephen Superville", Description = "1.6", FileName = "cs_747" },
            new MapGameInfo { GameID = "CSCZ", Author = "Leon Nieuwoudt, Stephen Superville", Description = "CSCZ", FileName = "cs_747" }
          }
        },
        new Map
        {
          MapID = "agency",
          IsCompetitive = false,
          Description = "Small hostage rescue map set inside an office building",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSGO", Author = "Chris Ashton", Description = "CS:GO", FileName = "cs_agency" }
          }
        },
        new Map
        {
          MapID = "assault",
          IsCompetitive = false,
          Description = "Classic warehouse themed hostage rescue map first added in Counterstrike beta 1.1",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "Lari Muuriaisniemi", Description = "1.6", FileName = "cs_assault" },
            new MapGameInfo { GameID = "CSS", Author = "Jess Cliffe, Valve Corporation", Description = "CSS", FileName = "cs_assault" },
            new MapGameInfo { GameID = "CSGO", Author = "Hidden Path Entertainment, Valve Corporation", Description = "CS:GO", FileName = "cs_assault" }
          }
        },
        new Map
        {
          MapID = "backalley",
          IsCompetitive = false,
          Description = "Back alley themed hostage rescue map first added in Counterstrike beta 5",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "Jamie Mactaggart (Barking Dog Studios)", Description = "1.6", FileName = "cs_backalley" },
            new MapGameInfo { GameID = "CSCZ", Author = "Jamie Mactaggart (Barking Dog Studios)", Description = "CSCZ", FileName = "cs_backalley" }
          }
        },
        new Map
        {
          MapID = "compound",
          IsCompetitive = false,
          Description = "Compound themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "cs_compound" }
          }
        },
        new Map
        {
          MapID = "downed",
          IsCompetitive = false,
          Description = "Downed themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "cs_downed_cz" }
          }
        },
        new Map
        {
          MapID = "estate",
          IsCompetitive = false,
          Description = "Estate themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "cs_estate" }
          }
        },
        new Map
        {
          MapID = "havana",
          IsCompetitive = false,
          Description = "Cuban themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "cs_havana" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "cs_havana" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "cs_havana_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "cs_havana" }
          }
        },
        new Map
        {
          MapID = "italy",
          IsCompetitive = false,
          Description = "Hostage rescue map set in an Italian town",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "cs_italy" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "cs_italy" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "cs_italy_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "cs_italy" },
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "cs_italy" },
            new MapGameInfo { GameID = "CS2", Author = "", Description = "CS2", FileName = "cs_italy" }
          }
        },
        new Map
        {
          MapID = "miami",
          IsCompetitive = false,
          Description = "Miami themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "cs_miami" }
          }
        },
        new Map
        {
          MapID = "militia",
          IsCompetitive = false,
          Description = "Militia themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "cs_militia" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "cs_militia" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "cs_militia_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "cs_militia" },
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "cs_militia" }
          }
        },
        new Map
        {
          MapID = "office",
          IsCompetitive = false,
          Description = "Hostage rescue map set in an office building",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "cs_office" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "cs_office" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "cs_office_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "cs_office" },
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "cs_office" },
            new MapGameInfo { GameID = "CS2", Author = "", Description = "CS2", FileName = "cs_office" }
          }
        },
        new Map
        {
          MapID = "siege",
          IsCompetitive = false,
          Description = "Siege themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "cs_siege" }
          }
        },

        // Defusal Maps
        new Map
        {
          MapID = "airstrip",
          IsCompetitive = false,
          Description = "Airport themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_airstrip" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_airstrip" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_airstrip_cz" }
          }
        },
        new Map
        {
          MapID = "ancient",
          IsCompetitive = true,
          Description = "Map set in a Mayan temple complex",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_ancient" },
            new MapGameInfo { GameID = "CS2", Author = "", Description = "CS2", FileName = "de_ancient" }
          }
        },
        new Map
        {
          MapID = "anubis",
          IsCompetitive = true,
          Description = "Egyptian themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_anubis" },
            new MapGameInfo { GameID = "CS2", Author = "", Description = "CS2", FileName = "de_anubis" }
          }
        },
        new Map
        {
          MapID = "aztec",
          IsCompetitive = false,
          Description = "Ancient Aztec temple themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_aztec" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_aztec" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_aztec_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "de_aztec" }
          }
        },
        new Map
        {
          MapID = "cache",
          IsCompetitive = false,
          Description = "Modern map set in a warehouse district",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_cache" }
          }
        },
        new Map
        {
          MapID = "canals",
          IsCompetitive = false,
          Description = "Venetian canals themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_canals" }
          }
        },
        new Map
        {
          MapID = "cbble",
          IsCompetitive = false,
          Description = "Cobblestone castle themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_cbble" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_cbble" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_cbble_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "de_cbble" },
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_cbble" }
          }
        },
        new Map
        {
          MapID = "chateau",
          IsCompetitive = false,
          Description = "French chateau themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_chateau" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_chateau" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_chateau_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "de_chateau" }
          }
        },
        new Map
        {
          MapID = "corruption",
          IsCompetitive = false,
          Description = "Industrial themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_corruption" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_corruption_cz" }
          }
        },
        new Map
        {
          MapID = "dust",
          IsCompetitive = false,
          Description = "Classic desert themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_dust" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_dust" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_dust_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "de_dust" }
          }
        },
        new Map
        {
          MapID = "dust2",
          IsCompetitive = true,
          Description = "Iconic Counter-Strike map set in a Middle Eastern town",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "David Johnston, Chris Ashton", Description = "1.6", FileName = "de_dust2" },
            new MapGameInfo { GameID = "CSX", Author = "Ritual Entertainment, Turtle Rock Studios", Description = "Xbox", FileName = "de_dust2" },
            new MapGameInfo { GameID = "CSCZ", Author = "Ritual Entertainment, Turtle Rock Studios", Description = "CSCZ", FileName = "de_dust2_cz" },
            new MapGameInfo { GameID = "CSS", Author = "Valve Corporation", Description = "CSS", FileName = "de_dust2" },
            new MapGameInfo { GameID = "CSGO", Author = "Valve Corporation, Hidden Path Entertainment", Description = "CS:GO", FileName = "de_dust2" },
            new MapGameInfo { GameID = "CS2", Author = "Valve Corporation", Description = "CS2", FileName = "de_dust2" }
          }
        },
        new Map
        {
          MapID = "fastline",
          IsCompetitive = false,
          Description = "Highway themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_fastline" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_fastline_cz" }
          }
        },
        new Map
        {
          MapID = "inferno",
          IsCompetitive = true,
          Description = "Classic map set in an Italian village",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_inferno" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_inferno" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_inferno_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "de_inferno" },
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_inferno" },
            new MapGameInfo { GameID = "CS2", Author = "", Description = "CS2", FileName = "de_inferno" }
          }
        },
        new Map
        {
          MapID = "mirage",
          IsCompetitive = true,
          Description = "Popular map set in a Middle Eastern city",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_mirage" },
            new MapGameInfo { GameID = "CS2", Author = "", Description = "CS2", FileName = "de_mirage" }
          }
        },
        new Map
        {
          MapID = "nuke",
          IsCompetitive = true,
          Description = "One of the original defusal maps, has been continuously updated and is one of the most challenging maps to play.",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_nuke" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_nuke_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "de_nuke" },
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_nuke" },
            new MapGameInfo { GameID = "CS2", Author = "", Description = "CS2", FileName = "de_nuke" }
          }
        },
        new Map
        {
          MapID = "overpass",
          IsCompetitive = false,
          Description = "Modern map set in Berlin",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_overpass" },
            new MapGameInfo { GameID = "CS2", Author = "", Description = "CS2", FileName = "de_overpass" }
          }
        },
        new Map
        {
          MapID = "piranesi",
          IsCompetitive = false,
          Description = "Italian themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_piranesi" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_piranesi" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_piranesi_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "de_piranesi" }
          }
        },
        new Map
        {
          MapID = "port",
          IsCompetitive = false,
          Description = "Port themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "de_port" }
          }
        },
        new Map
        {
          MapID = "prodigy",
          IsCompetitive = false,
          Description = "Industrial themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_prodigy" },
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_prodigy" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_prodigy_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "de_prodigy" }
          }
        },
        new Map
        {
          MapID = "sienna",
          IsCompetitive = false,
          Description = "Italian themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_sienna_cz" }
          }
        },
        new Map
        {
          MapID = "stadium",
          IsCompetitive = false,
          Description = "Stadium themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_stadium" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_stadium_cz" }
          }
        },
        new Map
        {
          MapID = "storm",
          IsCompetitive = false,
          Description = "Storm themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_storm" }
          }
        },
        new Map
        {
          MapID = "survivor",
          IsCompetitive = false,
          Description = "Survival themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_survivor" }
          }
        },
        new Map
        {
          MapID = "tides",
          IsCompetitive = false,
          Description = "Tides themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_tides" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_tides_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "de_tides" }
          }
        },
        new Map
        {
          MapID = "torn",
          IsCompetitive = false,
          Description = "Torn themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_torn" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_torn_cz" }
          }
        },
        new Map
        {
          MapID = "train",
          IsCompetitive = true,
          Description = "Train yard themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_train" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_train_cz" },
            new MapGameInfo { GameID = "CSS", Author = "", Description = "CSS", FileName = "de_train" },
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_train" },
            new MapGameInfo { GameID = "CS2", Author = "", Description = "CS2", FileName = "de_train" }
          }
        },
        new Map
        {
          MapID = "truth",
          IsCompetitive = false,
          Description = "Truth themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_truth" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_truth_cz" }
          }
        },
        new Map
        {
          MapID = "tuscan",
          IsCompetitive = false,
          Description = "Italian themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_tuscan" }
          }
        },
        new Map
        {
          MapID = "vertigo",
          IsCompetitive = false,
          Description = "Skyscraper construction site map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CS16", Author = "", Description = "1.6", FileName = "de_vertigo" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_vertigo" },
            new MapGameInfo { GameID = "CSGO", Author = "", Description = "CS:GO", FileName = "de_vertigo" },
            new MapGameInfo { GameID = "CS2", Author = "", Description = "CS2", FileName = "de_vertigo" }
          }
        },
        new Map
        {
          MapID = "vostok",
          IsCompetitive = false,
          Description = "Russian themed map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "CSX", Author = "", Description = "Xbox", FileName = "de_vostok" },
            new MapGameInfo { GameID = "CSCZ", Author = "", Description = "CSCZ", FileName = "de_vostok_cz" }
          }
        }
      };
    }
  }
}