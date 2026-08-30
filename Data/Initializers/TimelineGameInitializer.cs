using ASP_site.Models;

namespace ASP_site.Data.Initializers
{
    public static class TimelineGameInitializer
    {
        public static Game[] GetGames() =>
        [
            // Other historical / setting-year games
            Timeline("agkit", "American Girl: Kit Mystery Challenge!", "Nintendo DS game based on the American Girl Kit Kittredge books.", "THQ", Genre.Adventure, 1934, AgeAppropriateness.Early, 2008, 6, 25),
            Timeline("dow", "Warhammer 40,000: Dawn of War", "Real-time strategy game set in the Warhammer 40,000 universe.", "Relic Entertainment", Genre.RTS, 41901, AgeAppropriateness.Teen, 2004, 9, 20),
            Timeline("dow2", "Warhammer 40,000: Dawn of War II", "Real-time strategy sequel set in the Warhammer 40,000 universe.", "Relic Entertainment", Genre.RTS, 41902, AgeAppropriateness.Teen, 2009, 2, 19),
            Timeline("dow3", "Warhammer 40,000: Dawn of War III", "Real-time strategy sequel set in the Warhammer 40,000 universe.", "Relic Entertainment", Genre.RTS, 41903, AgeAppropriateness.Teen, 2017, 4, 27),
            Timeline("ghostoftsushima", "Ghost of Tsushima", "Set during the first Mongol invasion of Japan. Beautifully depicts feudal Japan.", "Sucker Punch Productions", Genre.Adventure, 1274, AgeAppropriateness.Teen, 2020, 7, 17),
            Timeline("gow2", "God of War II", "Action-adventure game set in a mythic ancient Greece.", "Santa Monica Studio", Genre.Adventure, -282, AgeAppropriateness.Teen, 2007, 3, 13),
            Timeline("gta3", "Grand Theft Auto III", "Events of the game take place in 2001.", "Rockstar Games", Genre.Adventure, 2001, AgeAppropriateness.Teen, 2001, 10, 22),
            Timeline("gta4", "Grand Theft Auto IV", "Events of the game take place in 2008.", "Rockstar Games", Genre.Adventure, 2008, AgeAppropriateness.Teen, 2008, 4, 29),
            Timeline("gta5", "Grand Theft Auto V", "Events of the game take place in 2013.", "Rockstar Games", Genre.Adventure, 2013, AgeAppropriateness.Teen, 2013, 9, 17),
            Timeline("gta6", "Grand Theft Auto VI", "Events of the game take place in 2026.", "Rockstar Games", Genre.Adventure, 2026, AgeAppropriateness.Teen, 2026, isReleased: false),
            Timeline("gtavc", "Grand Theft Auto: Vice City", "Events of the game take place in 1986.", "Rockstar Games", Genre.Adventure, 1986, AgeAppropriateness.Teen, 2002, 10, 29),
            Timeline("kcd", "Kingdom Come: Deliverance", "A realistic RPG set in the Kingdom of Bohemia (modern-day Czech Republic) in 1403. Known for its historical accuracy.", "Warhorse Studios", Genre.Adventure, 1403, AgeAppropriateness.Teen, 2018, 2, 13),
            Timeline("northandsouth", "North and South", "Classic NES game set in the War between the States.", "Infogrames", Genre.TBS, 1861, AgeAppropriateness.Middle, 1989),
            Timeline("praetorians", "Praetorians", "Real-time tactics game set during Julius Caesar's campaigns.", "Pyro Studios", Genre.RTS, -58, AgeAppropriateness.Middle, 2003, 3, 10),
            Timeline("rdr2", "Red Dead Redemption 2", "Captures the decline of the Wild West era in America (around 1899-1907).", "Rockstar Games", Genre.Adventure, 1899, AgeAppropriateness.Teen, 2018, 10, 26),
            Timeline("ryse", "Ryse: Son of Rome", "Action-adventure game set in ancient Rome.", "Crytek", Genre.Adventure, -68, AgeAppropriateness.Middle, 2013, 11, 22),
            Timeline("shadowofrome", "Shadow of Rome", "Playstation 2 game about the assassination of Julius Caesar. The sequel Shadow of Rome 2 was cancelled and became Dead Rising.", "Capcom", Genre.Adventure, -44, AgeAppropriateness.Teen, 2005, 2, 8),
            Timeline("sto", "Star Trek Online", "Star Trek Online MMORPG set in 2409.", "Cryptic Studios", Genre.Adventure, 2409, AgeAppropriateness.Teen, 2010, 2, 2),
            Timeline("startrek25th", "Star Trek: 25th Anniversary", "Point-and-click adventure following the original Enterprise crew.", "Interplay", Genre.Adventure, 2268, AgeAppropriateness.Middle, 1992, 9, 1),
            Timeline("startrekjudgmentrites", "Star Trek: Judgment Rites", "Sequel adventure continuing Kirk's five-year mission.", "Interplay", Genre.Adventure, 2269, AgeAppropriateness.Middle, 1993),
            Timeline("startrekklingonacademy", "Star Trek: Klingon Academy", "Space combat sim set at the Klingon Elite Command Academy before The Undiscovered Country.", "Interplay", Genre.Adventure, 2292, AgeAppropriateness.Teen, 2000, 6, 8),
            Timeline("startrekstarfleetcmd", "Star Trek: Starfleet Command", "Real-time starship combat based on Star Fleet Battles, set in the original movie era.", "Interplay", Genre.RTS, 2291, AgeAppropriateness.Teen, 1999, 7, 31),
            Timeline("startrekbridgecommander", "Star Trek: Bridge Commander", "Starship command simulation set after The Next Generation films.", "Totally Games", Genre.Adventure, 2372, AgeAppropriateness.Middle, 2002, 2, 27),
            Timeline("startrekarmada", "Star Trek: Armada", "Real-time strategy game set after First Contact.", "Activision", Genre.RTS, 2376, AgeAppropriateness.Teen, 2000, 3, 22),
            Timeline("startrekarmada2", "Star Trek: Armada II", "Real-time strategy sequel expanding the Dominion War aftermath.", "Activision", Genre.RTS, 2377, AgeAppropriateness.Teen, 2001, 11, 16),
            Timeline("startrekhiddenevil", "Star Trek: Hidden Evil", "Third-person adventure set after Insurrection.", "Presto Studios", Genre.Adventure, 2375, AgeAppropriateness.Middle, 1999, 11, 16),
            Timeline("startrekawayteam", "Star Trek: Away Team", "Squad tactics game following a covert Starfleet special-operations unit.", "Reflexive Entertainment", Genre.TBS, 2371, AgeAppropriateness.Teen, 2001, 3, 28),
            Timeline("startrekds9fallen", "Star Trek: Deep Space Nine - The Fallen", "Third-person action-adventure set on Deep Space Nine.", "The Collective", Genre.Adventure, 2372, AgeAppropriateness.Teen, 2000, 11, 15),
            Timeline("startrekbotf", "Star Trek: The Next Generation - Birth of the Federation", "Turn-based 4X strategy set in the Next Generation era.", "MicroProse", Genre.TBS, 2365, AgeAppropriateness.Middle, 1999, 5, 25),
            Timeline("startreklegacy", "Star Trek: Legacy", "Real-time starship combat spanning Kirk through Picard.", "Mad Doc Software", Genre.RTS, 2379, AgeAppropriateness.Teen, 2006, 12, 21),
            Timeline("startrekbridgecrew", "Star Trek: Bridge Crew", "VR starship-bridge simulation set in the Kelvin Timeline. Next Generation content as DLC.", "Ubisoft", Genre.Adventure, 2263, AgeAppropriateness.Middle, 2017, 5, 30),
            Timeline("startrekresurgence", "Star Trek: Resurgence", "Narrative adventure set after Nemesis aboard the Resolute.", "Dramatic Labs", Genre.Adventure, 2380, AgeAppropriateness.Teen, 2023, 5, 23),
            Timeline("dune1992", "Dune (1992)", "Adventure game adapting David Lynch's Dune.", "Cryo Interactive", Genre.Adventure, 10191, AgeAppropriateness.Middle, 1992, settingCalendar: SettingCalendar.AfterGuild),
            Timeline("dune2", "Dune II: The Building of a Dynasty", "Real-time strategy game that defined the Westwood RTS lineage, set on Arrakis.", "Westwood Studios", Genre.RTS, 10191, AgeAppropriateness.Middle, 1992, 12, 1, settingCalendar: SettingCalendar.AfterGuild),
            Timeline("dune2000", "Dune 2000", "Real-time strategy remake of Dune II.", "Westwood Studios", Genre.RTS, 10191, AgeAppropriateness.Middle, 1998, 9, 4, settingCalendar: SettingCalendar.AfterGuild),
            Timeline("duneemperor", "Emperor: Battle for Dune", "Real-time strategy sequel set after the first Dune novel.", "Westwood Studios", Genre.RTS, 10193, AgeAppropriateness.Teen, 2001, 6, 12, settingCalendar: SettingCalendar.AfterGuild),
            Timeline("duneminiseries", "Frank Herbert's Dune (2001)", "3D adventure based on the 2000 Sci-Fi Channel miniseries.", "Cryo Interactive", Genre.Adventure, 10191, AgeAppropriateness.Middle, 2001, 11, 14, settingCalendar: SettingCalendar.AfterGuild),
            Timeline("dunespicewars", "Dune: Spice Wars", "Real-time 4X strategy set during the struggle for Arrakis.", "Shiro Games", Genre.RTS, 10191, AgeAppropriateness.Teen, 2022, 4, 26, settingCalendar: SettingCalendar.AfterGuild),
            Timeline("duneawakening", "Dune: Awakening", "Open-world survival MMO on an Arrakis where Paul Atreides never became the Kwisatz Haderach.", "Funcom", Genre.Adventure, 10191, AgeAppropriateness.Teen, 2025, 6, 10, settingCalendar: SettingCalendar.AfterGuild),
            Timeline("halowars", "Halo Wars", "Real-time strategy game set on the planet Harvest during the early Human-Covenant War.", "Ensemble Studios", Genre.RTS, 2531, AgeAppropriateness.Teen, 2009, 2, 26),
            Timeline("haloreach", "Halo: Reach", "First-person shooter following Noble Team during the fall of Reach.", "Bungie", Genre.FPS, 2552, AgeAppropriateness.Teen, 2010, 9, 14),
            Timeline("halo", "Halo: Combat Evolved", "First-person shooter following Master Chief on Installation 04 after the fall of Reach.", "Bungie", Genre.FPS, 2552, AgeAppropriateness.Teen, 2001, 11, 15),
            Timeline("halo2", "Halo 2", "First-person shooter sequel following Master Chief and the Arbiter during the Battle of Earth and Installation 05.", "Bungie", Genre.FPS, 2552, AgeAppropriateness.Teen, 2004, 11, 9),
            Timeline("halo3", "Halo 3", "First-person shooter concluding the original trilogy's war against the Covenant and the Flood.", "Bungie", Genre.FPS, 2552, AgeAppropriateness.Teen, 2007, 9, 25),
            Timeline("halo3odst", "Halo 3: ODST", "First-person shooter following Orbital Drop Shock Troopers in New Mombasa during Halo 2.", "Bungie", Genre.FPS, 2552, AgeAppropriateness.Teen, 2009, 9, 22),
            Timeline("halo4", "Halo 4", "First-person shooter following Master Chief and Cortana on Requiem after years of drift.", "343 Industries", Genre.FPS, 2557, AgeAppropriateness.Teen, 2012, 11, 6),
            Timeline("halo5", "Halo 5: Guardians", "First-person shooter following Master Chief and Spartan Locke across the galaxy.", "343 Industries", Genre.FPS, 2558, AgeAppropriateness.Teen, 2015, 10, 27),
            Timeline("halowars2", "Halo Wars 2", "Real-time strategy sequel set on the ark after a 28-year slipspace jump.", "Creative Assembly", Genre.RTS, 2559, AgeAppropriateness.Teen, 2017, 2, 21),
            Timeline("haloinfinite", "Halo Infinite", "First-person shooter following Master Chief on Installation 07 against the Banished.", "343 Industries", Genre.FPS, 2560, AgeAppropriateness.Teen, 2021, 12, 8),
            Timeline("lotrbfme", "The Lord of the Rings: The Battle for Middle-earth", "Real-time strategy game covering the War of the Ring.", "EA Los Angeles", Genre.RTS, 3018, AgeAppropriateness.Teen, 2004, 12, 6, settingCalendar: SettingCalendar.MiddleEarth),
            Timeline("lotro", "The Lord of the Rings Online", "MMORPG set in Middle-earth during the War of the Ring.", "Turbine", Genre.Adventure, 3018, AgeAppropriateness.Middle, 2007, 4, 24, settingCalendar: SettingCalendar.MiddleEarth),
            Timeline("shadowofmordor", "Middle-earth: Shadow of Mordor", "Action-adventure following Talion in Mordor in the years after The Hobbit.", "Monolith Productions", Genre.Adventure, 2941, AgeAppropriateness.Teen, 2014, 9, 30, settingCalendar: SettingCalendar.MiddleEarth),
            Timeline("shadowofwar", "Middle-earth: Shadow of War", "Sequel following Talion's war against Sauron in the years before The Lord of the Rings.", "Monolith Productions", Genre.Adventure, 3018, AgeAppropriateness.Teen, 2017, 10, 10, settingCalendar: SettingCalendar.MiddleEarth),
            Timeline("timelinegame", "Timeline", "Video game based on the novel Timeline by Michael Crichton.", "Eidos Interactive", Genre.Adventure, 1347, AgeAppropriateness.Middle, 2000, 11, 10),
        ];

        private static Game Timeline(
            string id,
            string name,
            string description,
            string developer,
            Genre genre,
            int settingYear,
            AgeAppropriateness age,
            int releaseYear,
            int? releaseMonth = null,
            int? releaseDay = null,
            bool isReleased = true,
            SettingCalendar settingCalendar = SettingCalendar.Gregorian) => new()
        {
            GameID = id,
            Name = name,
            Description = description,
            Developer = developer,
            Genre = genre,
            SettingYear = settingYear,
            SettingCalendar = settingCalendar,
            Age = age,
            IsReleased = isReleased,
            IsFree = false,
            IsPaid = true,
            IsOpenSource = false,
            PlayWith = new List<int> { 1 },
            ReleaseDates =
            [
                new ReleaseDate { Year = releaseYear, Month = releaseMonth, Day = releaseDay }
            ]
        };
    }
}
