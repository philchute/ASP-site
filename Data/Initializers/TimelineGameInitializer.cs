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
            Timeline("sto", "Star Trek Online", "Star Trek Online MMORPG.", "Cryptic Studios", Genre.Adventure, 2409, AgeAppropriateness.Teen, 2010, 2, 2),
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
