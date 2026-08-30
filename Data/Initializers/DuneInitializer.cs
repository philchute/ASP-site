using ASP_site.Models;

namespace ASP_site.Data.Initializers
{
    public static class DuneInitializer
    {
        public static Media[] GetMedia() =>
        [
            Movie("media-dune-1984", "Dune (1984)", 1984, 12, 14, 10191,
                "David Lynch's 1984 adaptation of Frank Herbert's novel."),
            Movie("media-dune-2021", "Dune (2021)", 2021, 10, 22, 10191,
                "Denis Villeneuve's 2021 adaptation covering the first half of Dune."),
            Movie("media-dune-part-two", "Dune: Part Two", 2024, 3, 1, 10193,
                "Denis Villeneuve's 2024 sequel completing the first novel."),
            Tv("media-dune-miniseries", "Frank Herbert's Dune", 2000, 12, 3, 10191,
                "John Harrison's 2000 Sci-Fi Channel miniseries."),
            Tv("media-children-of-dune", "Frank Herbert's Children of Dune", 2003, 3, 16, 10212,
                "Greg Yaitanes's 2003 miniseries adapting Dune Messiah and Children of Dune."),
            Tv("media-dune-prophecy-s1", "Dune: Prophecy season 1", 2024, 11, 17, 43,
                "HBO series set in the early years of the Bene Gesserit, about 10,000 years before Paul Atreides."),
        ];

        public static Book[] GetBooks() =>
        [
            Novel("Dune", "Frank Herbert", 1965, 8, 10191,
                "Frank Herbert's 1965 novel about Paul Atreides, Arrakis, and the struggle for the spice melange.",
                "Collection: Original Dune Series", "Adapted for Screen"),
            Novel("Dune Messiah", "Frank Herbert", 1969, 10, 10207,
                "Twelve years after Dune, Paul Atreides as Emperor faces conspiracy and the consequences of jihad.",
                "Collection: Original Dune Series", "Adapted for Screen"),
            Novel("Children of Dune", "Frank Herbert", 1976, 4, 10216,
                "The twins Leto II and Ghanima Atreides confront the Golden Path and the fate of the Imperium.",
                "Collection: Original Dune Series", "Adapted for Screen"),
            Novel("God Emperor of Dune", "Frank Herbert", 1981, 5, 13728,
                "3,500 years later, Leto II rules as a human-sandworm hybrid, enforcing a millennia-long peace.",
                "Collection: Original Dune Series"),
            Novel("Heretics of Dune", "Frank Herbert", 1984, 4, 15229,
                "1,500 years after Leto II's death, the Bene Gesserit, Bene Tleilax, and Honored Matres contest the old Imperium.",
                "Collection: Original Dune Series"),
            Novel("Chapterhouse: Dune", "Frank Herbert", 1985, 4, 15232,
                "The Bene Gesserit retreat to Chapterhouse as the Honored Matres overrun the old empire.",
                "Collection: Original Dune Series"),

            Novel("Dune: The Butlerian Jihad", "Brian Herbert and Kevin J. Anderson", 2002, 9, -200,
                "The war between free humans and thinking machines, set about 10,000 years before Dune.",
                "Collection: Legends of Dune"),
            Novel("Dune: The Machine Crusade", "Brian Herbert and Kevin J. Anderson", 2003, 9, -175,
                "The long middle of the Butlerian Jihad, as the League of Nobles and the machine empire fight across the stars.",
                "Collection: Legends of Dune"),
            Novel("Dune: The Battle of Corrin", "Brian Herbert and Kevin J. Anderson", 2004, 8, -88,
                "The campaign that ends the Jihad and sets the Corrino Imperium in place for the next ten millennia.",
                "Collection: Legends of Dune"),

            Novel("Sisterhood of Dune", "Brian Herbert and Kevin J. Anderson", 2012, 1, -8,
                "Decades after the Jihad, the early Bene Gesserit take shape amid a rising anti-technology movement.",
                "Collection: Great Schools of Dune"),
            Novel("Mentats of Dune", "Brian Herbert and Kevin J. Anderson", 2014, 3, -4,
                "The Mentat school trains human computers while Butlerian fervor threatens remaining machines.",
                "Collection: Great Schools of Dune"),
            Novel("Navigators of Dune", "Brian Herbert and Kevin J. Anderson", 2016, 9, 0,
                "Spacefolding, spice, and the first Navigators give rise to the Spacing Guild.",
                "Collection: Great Schools of Dune"),

            Novel("Dune: House Atreides", "Brian Herbert and Kevin J. Anderson", 1999, 10, 10154,
                "Young Leto Atreides, Crown Prince Shaddam, and the generation before Paul, set decades before Dune.",
                "Collection: Prelude to Dune"),
            Novel("Dune: House Harkonnen", "Brian Herbert and Kevin J. Anderson", 2000, 10, 10174,
                "Harkonnen, Atreides, and Bene Gesserit threads continue in the years after House Atreides.",
                "Collection: Prelude to Dune"),
            Novel("Dune: House Corrino", "Brian Herbert and Kevin J. Anderson", 2001, 10, 10188,
                "House Corrino, Ix, and the Landsraad in the last years before the Atreides leave Caladan.",
                "Collection: Prelude to Dune"),

            Novel("Dune: The Duke of Caladan", "Brian Herbert and Kevin J. Anderson", 2020, 10, 10190,
                "Duke Leto Atreides on Caladan in the years immediately before the move to Arrakis.",
                "Collection: Caladan Trilogy"),
            Novel("Dune: The Lady of Caladan", "Brian Herbert and Kevin J. Anderson", 2021, 9, 10190,
                "Lady Jessica's path on Caladan and beyond in the same stretch before Dune.",
                "Collection: Caladan Trilogy"),
            Novel("Dune: The Heir of Caladan", "Brian Herbert and Kevin J. Anderson", 2022, 11, 10191,
                "Paul Atreides on Caladan immediately before the events of Dune.",
                "Collection: Caladan Trilogy"),

            Novel("Princess of Dune", "Brian Herbert and Kevin J. Anderson", 2023, 10, 10189,
                "Princess Irulan and Chani two years before Dune, as their paths begin to converge on Arrakis.",
                "Collection: Heroes of Dune"),
            Novel("Paul of Dune", "Brian Herbert and Kevin J. Anderson", 2008, 9, 10196,
                "Paul's early years and the years between Dune and Dune Messiah.",
                "Collection: Heroes of Dune"),
            Novel("The Winds of Dune", "Brian Herbert and Kevin J. Anderson", 2009, 8, 10210,
                "The years between Dune Messiah and Children of Dune, as Paul's inner circle holds the Imperium together.",
                "Collection: Heroes of Dune"),

            Novel("Hunters of Dune", "Brian Herbert and Kevin J. Anderson", 2006, 8, 15236,
                "A continuation of the story left open at the end of Chapterhouse: Dune.",
                "Collection: Dune Sequels"),
            Novel("Sandworms of Dune", "Brian Herbert and Kevin J. Anderson", 2007, 8, 15238,
                "The second half of that continuation, closing the saga begun in Heretics and Chapterhouse.",
                "Collection: Dune Sequels"),
        ];

        private static Media Movie(
            string id,
            string title,
            int releaseYear,
            int month,
            int day,
            int settingYear,
            string description) => new()
        {
            MediaID = id,
            Title = title,
            MediaType = MediaType.Movie,
            ReleaseYear = releaseYear,
            ReleaseMonth = month,
            ReleaseDay = day,
            SettingYear = settingYear,
            SettingCalendar = SettingCalendar.AfterGuild,
            Description = description
        };

        private static Media Tv(
            string id,
            string title,
            int releaseYear,
            int month,
            int day,
            int settingYear,
            string description) => new()
        {
            MediaID = id,
            Title = title,
            MediaType = MediaType.TVShow,
            ReleaseYear = releaseYear,
            ReleaseMonth = month,
            ReleaseDay = day,
            SettingYear = settingYear,
            SettingCalendar = SettingCalendar.AfterGuild,
            Description = description
        };

        private static Book Novel(
            string title,
            string author,
            int publicationYear,
            int? publicationMonth,
            int settingYear,
            string description,
            params string[] tags) => new()
        {
            Title = title,
            Author = author,
            PublicationYear = publicationYear,
            PublicationMonth = publicationMonth,
            SettingYear = settingYear,
            SettingCalendar = SettingCalendar.AfterGuild,
            Type = BookType.Novel,
            Age = AgeAppropriateness.Teen,
            Description = description,
            Tags = tags.Select(name => new Tag { Name = name }).ToList()
        };
    }
}
