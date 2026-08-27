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
    }
}
