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
            Timeline("dune1992", "Dune (1992)", "Adventure game adapting David Lynch's Dune.", "Cryo Interactive", Genre.Adventure, 10191, AgeAppropriateness.Middle, 1992),
            Timeline("dune2", "Dune II: The Building of a Dynasty", "Real-time strategy game that defined the Westwood RTS lineage, set on Arrakis.", "Westwood Studios", Genre.RTS, 10191, AgeAppropriateness.Middle, 1992, 12, 1),
            Timeline("dune2000", "Dune 2000", "Real-time strategy remake of Dune II.", "Westwood Studios", Genre.RTS, 10191, AgeAppropriateness.Middle, 1998, 9, 4),
            Timeline("duneemperor", "Emperor: Battle for Dune", "Real-time strategy sequel set after the first Dune novel.", "Westwood Studios", Genre.RTS, 10193, AgeAppropriateness.Teen, 2001, 6, 12),
            Timeline("duneminiseries", "Frank Herbert's Dune (2001)", "3D adventure based on the 2000 Sci-Fi Channel miniseries.", "Cryo Interactive", Genre.Adventure, 10191, AgeAppropriateness.Middle, 2001, 11, 14),
            Timeline("dunespicewars", "Dune: Spice Wars", "Real-time 4X strategy set during the struggle for Arrakis.", "Shiro Games", Genre.RTS, 10191, AgeAppropriateness.Teen, 2022, 4, 26),
            Timeline("duneawakening", "Dune: Awakening", "Open-world survival MMO on an Arrakis where Paul Atreides never became the Kwisatz Haderach.", "Funcom", Genre.Adventure, 10191, AgeAppropriateness.Teen, 2025, 6, 10),
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
            bool isReleased = true) => new()
        {
            GameID = id,
            Name = name,
            Description = description,
            Developer = developer,
            Genre = genre,
            SettingYear = settingYear,
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
