using ASP_site.Models;

namespace ASP_site.Data.Initializers
{
    public static class HaloInitializer
    {
        public static Media[] GetMedia() =>
        [
            Movie("media-halo-legends", "Halo Legends", 2010, 2, 16, 2552,
                "Animated anthology of Halo short films spanning the Human-Covenant War."),
            Tv("media-halo-forward-unto-dawn", "Halo 4: Forward Unto Dawn", 2012, 10, 5, 2526,
                "Live-action web series following cadets at Corbulo Academy at the outbreak of the Covenant War."),
            Tv("media-halo-nightfall", "Halo: Nightfall", 2014, 3, 31, 2556,
                "Live-action digital series following Jameson Locke on a mission to the planet Sedra."),
            Tv("media-halo-s1", "Halo season 1", 2022, 3, 24, 2552,
                "Paramount+ series following Master Chief in the Silver Timeline."),
            Tv("media-halo-s2", "Halo season 2", 2024, 2, 8, 2552,
                "Second season of the Paramount+ Halo series, continuing the Silver Timeline."),
        ];

        public static Book[] GetBooks() =>
        [
            Novel("Halo: Contact Harvest", "Joseph Staten", 2007, 10, 2525,
                "The first encounter between humanity and the Covenant on the colony world Harvest.",
                "Collection: Halo Novels"),
            Novel("Halo: The Fall of Reach", "Eric Nylund", 2001, 10, 2552,
                "The origin of the SPARTAN-II program and the fall of the fortress world Reach.",
                "Collection: Halo Novels", "Collection: The Original Trilogy"),
            Novel("Halo: The Flood", "William C. Dietz", 2003, 4, 2552,
                "Novelization of Halo: Combat Evolved, following the fight against the Covenant and the Flood on Installation 04.",
                "Collection: Halo Novels", "Collection: The Original Trilogy"),
            Novel("Halo: First Strike", "Eric Nylund", 2003, 12, 2552,
                "The gap between Halo and Halo 2, as John-117 and surviving Spartans strike back after Installation 04.",
                "Collection: Halo Novels", "Collection: The Original Trilogy"),
            Novel("Halo: Ghosts of Onyx", "Eric Nylund", 2006, 10, 2552,
                "The SPARTAN-III program on Onyx and the discovery of a Forerunner shield world.",
                "Collection: Halo Novels"),
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
