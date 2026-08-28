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
            Type = BookType.Novel,
            Age = AgeAppropriateness.Teen,
            Description = description,
            Tags = tags.Select(name => new Tag { Name = name }).ToList()
        };
    }
}
