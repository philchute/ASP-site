using ASP_site.Models;

namespace ASP_site.Data.Initializers
{
  public static class TFMapInitializer
  {
    public static Map[] GetMaps()
    {
      return new Map[]
      {
        new Map
        {
          MapID = "2fort",
          IsCompetitive = true,
          Description = "2fort - Classic Team Fortress map featuring two bases connected by a bridge over water - Industrial setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "2fort5", Author = "", Description = "QWTF" },
            new MapGameInfo { GameID = "TFC", FileName = "2fort", Author = "Valve Corporation", Description = "TFC" },
            new MapGameInfo { GameID = "TFC", FileName = "2kfort5_lg", Author = "", Description = "Competitive TFC map with 0 MIRV grenades" },
            new MapGameInfo { GameID = "FF", FileName = "ff_2fort", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "TF2", FileName = "2fort", Author = "Valve Corporation", Description = "TF2" }
          }
        },
        new Map
        {
          MapID = "2mesa3",
          IsCompetitive = true,
          Description = "2mesa3 - Classic Team Fortress map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_2mesa3_classic", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "TFC", FileName = "2mesa3_lg", Author = "", Description = "Competitive TFC map with 1 MIRV grenade" }
          }
        },
        new Map
        {
          MapID = "2morforever",
          IsCompetitive = false,
          Description = "2morforever - Non-competitive map - too tight to play",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_2morforever", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "2trof",
          IsCompetitive = true,
          Description = "2trof_b3 - Competitive TFC map with 0 MIRV grenades",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "2trof_b3", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "aardvark",
          IsCompetitive = false,
          Description = "aardvark - Non-competitive map - too big? can be 5v5?",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_aardvark", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "alchimy",
          IsCompetitive = true,
          Description = "alchimy - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_alchimy_b1", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "ameliorate",
          IsCompetitive = true,
          Description = "ameliorate - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_ameliorate_b2", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "TFC", FileName = "ameliorate_b4", Author = "", Description = "Competitive TFC map with 2 MIRV grenades" }
          }
        },
        new Map
        {
          MapID = "amped",
          IsCompetitive = false,
          Description = "amped - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_amped", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "annex",
          IsCompetitive = true,
          Description = "annex_b1 - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "annex_b1", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "anticitizen",
          IsCompetitive = false,
          Description = "anticitizen - Attack Defend map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_anticitizen", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "argon",
          IsCompetitive = false,
          Description = "argon - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_argon_beta_1", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "attribute",
          IsCompetitive = false,
          Description = "attribute - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_attribute_b2", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "avanti",
          IsCompetitive = false,
          Description = "avanti - Attack/Defend map - Town setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", Author = "Valve Corporation", Description = "TFC" },
            new MapGameInfo { GameID = "FF", FileName = "ff_avanti_classic", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "baked",
          IsCompetitive = true,
          Description = "baked - Fortress Forever map by churchmouth",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_baked_b2", Author = "churchmouth", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "badlands",
          IsCompetitive = false,
          Description = "badlands - Capture the Flag map - Desert Canyon setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "badlands", Author = "Valve Corporation", Description = "TFC" },
            new MapGameInfo { GameID = "TF2", FileName = "cp_badlands", Author = "Valve Corporation", Description = "TF2" }
          }
        },
        new Map
        {
          MapID = "bases",
          IsCompetitive = true,
          Description = "bases - Fortress Forever map - don't det generator during prematch",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_bases", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "bf_ssb",
          IsCompetitive = true,
          Description = "bf_ssb - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "bf_ssb", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "bigzag",
          IsCompetitive = true,
          Description = "bigzag - Competitive QWTF and FO map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "etf-bigzag_b1", Author = "", Description = "QTF" }
          }
        },
        new Map
        {
          MapID = "bleepbloop",
          IsCompetitive = true,
          Description = "bleepbloop - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_bleepbloop_b3", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "blis_2fort",
          IsCompetitive = false,
          Description = "blis_2fort - 3v3 map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_blis_2fort", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "blitzkrieg2",
          IsCompetitive = true,
          Description = "blitzkrieg2 - Competitive QWTF and FO map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "blitzkrieg2", Author = "", Description = "QTF" }
          }
        },
        new Map
        {
          MapID = "blockfort",
          IsCompetitive = false,
          Description = "blockfort - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_blockfort", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "blutopia",
          IsCompetitive = true,
          Description = "blutopia - Competitive TFC map with 2 MIRV grenades",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "blutopia", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "boketto",
          IsCompetitive = true,
          Description = "boketto - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_boketto_b1", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "boot_camp",
          IsCompetitive = false,
          Description = "boot_camp - Training map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "boot_camp", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "bounce",
          IsCompetitive = false,
          Description = "bounce - Capture the Flag map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "bounce", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "brutalist",
          IsCompetitive = true,
          Description = "brutalist - new TFC map by Manu",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "brutalist_b6", Author = "Manu", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "canal",
          IsCompetitive = true,
          Description = "canal_b7 - Competitive QWTF and FO map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "canal_b7", Author = "", Description = "QTF" }
          }
        },
        new Map
        {
          MapID = "canalzone",
          IsCompetitive = false,
          Description = "canalzone - Command Point map - Industrial setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "canalzone", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "cannon",
          IsCompetitive = false,
          Description = "cannon - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_cannon", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "casbah",
          IsCompetitive = false,
          Description = "casbah - Capture the Flag map - Town setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "casbah", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "catharsis",
          IsCompetitive = true,
          Description = "catharsis - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_catharsis_b4", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "TFC", FileName = "catharsis_b1", Author = "", Description = "Competitive TFC map with 1 MIRV grenade" }
          }
        },
        new Map
        {
          MapID = "changeofpace",
          IsCompetitive = true,
          Description = "changeofpace - Fortress Forever map - can be 3v3",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_changeofpace", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "chimkeyz",
          IsCompetitive = true,
          Description = "chimkeyz - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_chimkeyz_b5", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "circa",
          IsCompetitive = false,
          Description = "circa - 5v5 map by fruitcake",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_circa_b2", Author = "fruitcake", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "complex",
          IsCompetitive = false,
          Description = "complex - 3v3 map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_complex_b2", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "crossfaded2",
          IsCompetitive = true,
          Description = "mm_crossfaded2_b3 - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "mm_crossfaded2_b3", Author = "", Description = "TFC" },
            new MapGameInfo { GameID = "TFC", FileName = "mm_crossfaded2_b6", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "crossfire",
          IsCompetitive = false,
          Description = "crossfire - Capture the Flag map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "crossfire", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "crossover",
          IsCompetitive = true,
          Description = "crossover - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_crossover", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "crossover2",
          IsCompetitive = false,
          Description = "crossover2 - Capture the Flag map - Industrial setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "crossover2", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "cranked",
          IsCompetitive = true,
          Description = "cranked - Competitive TFC map with 2 MIRV grenades",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "cranked", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "cz2",
          IsCompetitive = false,
          Description = "cz2 - Command Point map - Sewers setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", Author = "", Description = "TFC" },
            new MapGameInfo { GameID = "FF", FileName = "ff_cz2", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "dalequandary",
          IsCompetitive = true,
          Description = "dalequandary - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_dalequandary_b2", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "datacore",
          IsCompetitive = false,
          Description = "datacore - Capture the Flag map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "datacore", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "demolish",
          IsCompetitive = true,
          Description = "demolish",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "demolish_r", Author = "", Description = "Competitive TFC map with 1 MIRV grenade (NO HWGUY)" },
            new MapGameInfo { GameID = "QWTF", FileName = "tfc-demolish_b2", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "destroy",
          IsCompetitive = true,
          Description = "destroy - Classic simple donut shaped Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_destroy", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "QWTF", FileName = "ff-destroy3", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "dragongod",
          IsCompetitive = true,
          Description = "dragongod - Competitive QWTF and FO map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "dragongod", Author = "", Description = "QTF" }
          }
        },
        new Map
        {
          MapID = "dropdown",
          IsCompetitive = false,
          Description = "dropdown - Uncategorized map by Sh4x",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_dropdown", Author = "Sh4x", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "dustbowl",
          IsCompetitive = false,
          Description = "dustbowl - Attack/Defend map - Desert setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "dustbowl", Author = "Valve Corporation", Description = "TFC" },
            new MapGameInfo { GameID = "FF", FileName = "ff_dustbowl", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "TF2", FileName = "cp_dustbowl", Author = "", Description = "One of the initial 6 maps in TF2" }
          }
        },
        new Map
        {
          MapID = "elusive",
          IsCompetitive = true,
          Description = "elusive_2020_v6 - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "elusive_2020_v6", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "entomb",
          IsCompetitive = true,
          Description = "entomb_b10 - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "entomb_b10", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "epicenter",
          IsCompetitive = false,
          Description = "epicenter - Reverse Capture the Flag map - Mideast Town setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", Author = "Valve Corporation", Description = "TFC" },
            new MapGameInfo { GameID = "FF", FileName = "ff_epicenter", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "evenflow",
          IsCompetitive = false,
          Description = "evenflow - 3v3 map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_evenflow_b2", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "fidd",
          IsCompetitive = true,
          Description = "fidd - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_fidd_l", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "flagrun",
          IsCompetitive = false,
          Description = "flagrun - Capture the Flag Variant map - Desert Town setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "flagrun", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "flare",
          IsCompetitive = false,
          Description = "flare - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_flare", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "flashpoint",
          IsCompetitive = false,
          Description = "flashpoint - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_flashpoint_b3_fix", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "flow",
          IsCompetitive = false,
          Description = "flow - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_flowb2", Author = "", Description = "FF" }
          }
        },
                new Map
        {
          MapID = "frenzy",
          IsCompetitive = false,
          Description = "frenzy - Capture the Flag map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "frenzy", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "gasworks",
          IsCompetitive = false,
          Description = "gasworks - Capture the Flag map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "gasworks", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "h4rdcore",
          IsCompetitive = true,
          Description = "h4rdcore - Team Fortress map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "h4rdcore_b2", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "hammer2",
          IsCompetitive = true,
          Description = "hammer2_b4 - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "hammer2_b4", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "hectic",
          IsCompetitive = true,
          Description = "hectic_b3 - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "hectic_b3", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "hellion",
          IsCompetitive = true,
          Description = "hellion - Classic Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_hellion_classic_b3", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "high_flag",
          IsCompetitive = true,
          Description = "high_flag - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_high_flag_b4", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "hollow",
          IsCompetitive = false,
          Description = "hollow - Uncategorized map - neon broken now?",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_hollow_b4", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "hunted",
          IsCompetitive = false,
          Description = "hunted - Assassination/Escort map - Military setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "hunted", Author = "Valve Corporation", Description = "TFC" },
            new MapGameInfo { GameID = "FF", FileName = "ff_hunted", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "ibex",
          IsCompetitive = true,
          Description = "ibex - Fortress Forever map - don't break glass during prematch - can be 3v3",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_ibex_b1", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "japanesecastles",
          IsCompetitive = false,
          Description = "japanese castles",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_japanesecastles_b1", Author = "", Description = " 3v3 map - can be 4v4 - not on pickup server" },
            new MapGameInfo { GameID = "QWTF", FileName = "japanc", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "ksour",
          IsCompetitive = false,
          Description = "ksour - Invade Defend map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_ksour", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "lambda_bunker",
          IsCompetitive = false,
          Description = "lambda_bunker - Capture the Flag map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "lambda_bunker", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "lastresport_b8",
          IsCompetitive = true,
          Description = "lastresport_b8 - Team Fortress map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "lastresport_b8", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "medieval",
          IsCompetitive = true,
          Description = "medieval - Team Fortress map in a medieval setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_medieval_b11", Author = "elmo", Description = "FF" },
            new MapGameInfo { GameID = "QWTF", FileName = "ff-medievalr", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "monkey",
          IsCompetitive = true,
          Description = "monkey - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_monkey", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "mortality",
          IsCompetitive = true,
          Description = "mortality - Classic Team Fortress map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_mortality_gz_b1", Author = "", Description = "Fortress Forever map - can be 3v3 maybe with no top?" },
            new MapGameInfo { GameID = "TFC", FileName = "mortality_c_b3", Author = "", Description = "Competitive TFC map with 1 MIRV grenade" },
            new MapGameInfo { GameID = "QWTF", FileName = "ff-mortality", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "mulch_dm",
          IsCompetitive = false,
          Description = "mulch_dm - 1v1 map by churchmouth",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_mulch_dm", Author = "churchmouth", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "mystique",
          IsCompetitive = true,
          Description = "mystique - Fortress Forever map by fruitcake",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_mystique_a4", Author = "fruitcake", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "myth",
          IsCompetitive = false,
          Description = "myth - 2v2 map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_myth_b2", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "napoli",
          IsCompetitive = false,
          Description = "napoli - Invade Defend map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_napoli", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "nyoom",
          IsCompetitive = true,
          Description = "nyoom - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "nyoom", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "nyx",
          IsCompetitive = true,
          Description = "nyx - Fortress Forever map by churchmouth, remaking supersumo TFC map ss_nyx",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_nyx_b2", Author = "churchmouth", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "oblivion",
          IsCompetitive = true,
          Description = "oblivion - Fortress Forever map by fruitcake",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_oblivion_b5", Author = "fruitcake", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "openfire",
          IsCompetitive = false,
          Description = "openfire - ",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_openfire", Author = "", Description = "2v2 map - can be 3v3" },
            new MapGameInfo { GameID = "QWTF", FileName = "openfire", Author = "", Description = "QWTF and FO map played 4v4" },
            new MapGameInfo { GameID = "QWTF", FileName = "propenfire", Author = "", Description = "QWTF and FO map played 4v4" },
            new MapGameInfo { GameID = "TFC", FileName = "openfire", Author = "", Description = "TFC map" }
          }
        },
        new Map
        {
          MapID = "oppose",
          IsCompetitive = true,
          Description = "oppose - Fortress Forever map by churchmouth",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_oppose_b4", Author = "churchmouth", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "orbit",
          IsCompetitive = true,
          Description = "orbit - Fortress Forever map by ian.c.moreno, original TFC map Orbit_l3 by jungle",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_orbit_b1", Author = "ian.c.moreno", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "orbit",
          IsCompetitive = true,
          Description = "orbit_tfp - Competitive TFC map with 2 MIRV grenades",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "orbit_tfp", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "palermo",
          IsCompetitive = false,
          Description = "palermo - Invade Defend map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_palermo", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "phantom",
          IsCompetitive = true,
          Description = "phantom - Team Fortress map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_phantom_r", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "QWTF", FileName = "ff-phantomr", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "pineapple",
          IsCompetitive = true,
          Description = "pineapple - Team Fortress map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "pineapple_b3", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "pitfall",
          IsCompetitive = true,
          Description = "pitfall - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_pitfall", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "plasma",
          IsCompetitive = false,
          Description = "plasma - 3v3 map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_plasma_beta1", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "prolifique",
          IsCompetitive = true,
          Description = "prolifique - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_prolifique_b2", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "TFC", FileName = "prolifique2_b7", Author = "", Description = "Competitive TFC map with 1 MIRV grenade" },
            new MapGameInfo { GameID = "TFC", FileName = "prolifique2_b10", Author = "", Description = "Competitive TFC map with 1 MIRV grenade" }
          }
        },
        new Map
        {
          MapID = "propinquity",
          IsCompetitive = true,
          Description = "propinquity - Team Fortress map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_propinquity_b4", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "QWTF", FileName = "ff-propinquity_b2", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "protein",
          IsCompetitive = false,
          Description = "protein - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_protein", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "proton",
          IsCompetitive = true,
          Description = "proton",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "proton_l", Author = "", Description = "Competitive TFC map with 1 MIRV grenade" },
            new MapGameInfo { GameID = "QWTF", FileName = "proton", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "push",
          IsCompetitive = false,
          Description = "push - Football map - Industrial setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "push", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "quark",
          IsCompetitive = false,
          Description = "quark - 3v3 map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_quark", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "raiden3",
          IsCompetitive = true,
          Description = "raiden3 - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_raiden3_b1", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "rapidcore",
          IsCompetitive = false,
          Description = "rapidcore - Capture the Flag map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "rapidcore", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "ravelin",
          IsCompetitive = false,
          Description = "ravelin - Reverse Capture the Flag map - Industrial setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "ravelin", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "redgiant",
          IsCompetitive = true,
          Description = "redgiant - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_redgiant", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "reloaded",
          IsCompetitive = true,
          Description = "reloaded - Fortress Forever map by churchmouth",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_reloaded_b1", Author = "churchmouth", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "resolve",
          IsCompetitive = true,
          Description = "resolve - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_resolve_b2", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "rock2",
          IsCompetitive = false,
          Description = "rock2 - Capture the Flag Variant map - Prison setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "rock2", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "roasted",
          IsCompetitive = true,
          Description = "roasted - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_roastedr", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "sahara",
          IsCompetitive = true,
          Description = "sahara - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_sahara_b1", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "schrape",
          IsCompetitive = true,
          Description = "schrape - Fortress Forever map by churchmouth",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_schrape_b4", Author = "churchmouth", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "schtop",
          IsCompetitive = true,
          Description = "schtop - Team Fortress map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_schtop", Author = "", Description = "Fortress Forever map - can be 3v3" },
            new MapGameInfo { GameID = "QWTF", FileName = "ff-schtop", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "security",
          IsCompetitive = true,
          Description = "security - Fortress Forever map by churchmouth - don't det generator during prematch",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_security_b1", Author = "churchmouth", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "session",
          IsCompetitive = false,
          Description = "session - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_session", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "shoop",
          IsCompetitive = true,
          Description = "shoop - Team Fortress map ",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "ff-shoop", Author = "Zang[KiN] (original) and Arc (revision)", Description = "QWTF map with updated FF textures" }
          }
        },
        new Map
        {
          MapID = "shutdown2",
          IsCompetitive = true,
          Description = "shutdown2 - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_shutdown2", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "siden",
          IsCompetitive = true,
          Description = "siden - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_siden_b2", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "siden",
          IsCompetitive = true,
          Description = "siden_lg - Competitive TFC map with 2 MIRV grenades",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "siden_lg", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "siege",
          IsCompetitive = true,
          Description = "siege - Classic TFC map by omega, ported by squeek",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_siege_classic", Author = "squeek", Description = "FF" }
          }
        },
        new Map{
          MapID = "smartbases",
          IsCompetitive = true,
          Description = "smartbases - Team Fortress map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "fo_smartbases_b2", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "snark_pit",
          IsCompetitive = false,
          Description = "snark_pit - Capture the Flag map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "snark_pit", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "spaceape",
          IsCompetitive = true,
          Description = "spaceape_b13 - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "spaceape_b13", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "spiderx",
          IsCompetitive = true,
          Description = "spiderx - Team Fortress map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "fo-spiderx_b6", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "stalkyard",
          IsCompetitive = false,
          Description = "stalkyard - Capture the Flag map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "stalkyard", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "startec",
          IsCompetitive = true,
          Description = "startec - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_startec", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "stowaway",
          IsCompetitive = true,
          Description = "stowaway - Fortress Forever map - don't det fence during prematch - can be 3v3",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_stowaway_b2", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "stowaway2",
          IsCompetitive = true,
          Description = "stowaway2 - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_stowaway2", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "TFC", FileName = "stowaway2_lg2", Author = "", Description = "Competitive TFC map with 0 MIRV grenades" }
          }
        },
        new Map
        {
          MapID = "subtransit",
          IsCompetitive = false,
          Description = "subtransit - Capture the Flag map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "subtransit", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "swoop",
          IsCompetitive = true,
          Description = "swoop - Fortress Forever map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_swoop_b2", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "QWTF", FileName = "ff-swoop", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "tidalwave",
          IsCompetitive = true,
          Description = "tidalwave - Fortress Forever map by FDA",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_tidalwave_b4", Author = "FDA", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "tiger",
          IsCompetitive = false,
          Description = "tiger - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_tiger", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "toasted",
          IsCompetitive = true,
          Description = "toasted_b8 - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "toasted_b8", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "totem",
          IsCompetitive = true,
          Description = "totem - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "totem", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "turbo",
          IsCompetitive = true,
          Description = "turbo",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "turbo", Author = "", Description = "QWTF and FO map" }
          }
        },
        new Map
        {
          MapID = "turbowave",
          IsCompetitive = true,
          Description = "turbowave_b1 - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "turbowave_b1", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "undertow",
          IsCompetitive = false,
          Description = "undertow - Capture the Flag map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "undertow", Author = "Valve Corporation", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "venganza",
          IsCompetitive = false,
          Description = "venganza - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_venganza_b1", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "vertigo",
          IsCompetitive = false,
          Description = "vertigo - Invade Defend map, de_vertigo remake",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_vertigo", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "viridian",
          IsCompetitive = true,
          Description = "viridian - Competitive TFC map with 1 MIRV grenade",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "viridian", Author = "", Description = "TFC" },
            new MapGameInfo { GameID = "TFC", FileName = "viridian_b10", Author = "", Description = "Competitive TFC map with 1 MIRV grenade" }
          }
        },
        new Map
        {
          MapID = "warpath",
          IsCompetitive = false,
          Description = "warpath - Command Point map - Desert setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "warpath", Author = "Valve Corporation", Description = "TFC" },
            new MapGameInfo { GameID = "FF", FileName = "ff_warpath", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "waterhazard",
          IsCompetitive = false,
          Description = "waterhazard - Uncategorized map",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_waterhazard", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "waterpolo",
          IsCompetitive = false,
          Description = "waterpolo - Non-competitive map - can be played 4v4 - most goals after one period",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_waterpolo", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "waterwar",
          IsCompetitive = true,
          Description = "waterwar_lg - Competitive TFC map with 2 MIRV grenades",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "TFC", FileName = "waterwar_lg", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "well",
          IsCompetitive = false,
          Description = "well - Capture the Flag map - Industrial setting",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "well", Author = "", Description = "QWTF and FO map" },
            new MapGameInfo { GameID = "TFC", FileName = "well", Author = "Valve Corporation", Description = "TFC" },
            new MapGameInfo { GameID = "FF", FileName = "ff_well", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "TF2", FileName = "cp_well", Author = "", Description = "One of the initial 6 maps in TF2" },
            new MapGameInfo { GameID = "TF2", FileName = "ctf_well", Author = "", Description = "The first official map to be added toTF2" }
          }
        },
        new Map
        {
          MapID = "xpress",
          IsCompetitive = false,
          Description = "xpress - 2v2 map - can be 3v3",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_xpress_b1", Author = "", Description = "FF" },
            new MapGameInfo { GameID = "TFC", FileName = "xpress2k4", Author = "", Description = "TFC" }
          }
        },
        new Map
        {
          MapID = "zion",
          IsCompetitive = false,
          Description = "zion - 2v2 map - can be 3v3",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "FF", FileName = "ff_zion_b1", Author = "", Description = "FF" }
          }
        },
        new Map
        {
          MapID = "zzr",
          IsCompetitive = true,
          Description = "zzr",
          GameInfo = new List<MapGameInfo>
          {
            new MapGameInfo { GameID = "QWTF", FileName = "rs_zzr", Author = "", Description = "QWTF and FO map" }
          }
        }
      };
    }
  }
}