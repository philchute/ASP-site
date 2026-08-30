using ASP_site.Models;

namespace ASP_site.Data.Initializers
{
    public static class LordOfTheRingsInitializer
    {
        public static Media[] GetMedia() =>
        [
            Movie("media-lotr-fellowship", "The Lord of the Rings: The Fellowship of the Ring", 2001, 12, 19, 3018,
                "Peter Jackson's 2001 adaptation of the first volume of The Lord of the Rings."),
            Movie("media-lotr-two-towers", "The Lord of the Rings: The Two Towers", 2002, 12, 18, 3019,
                "Peter Jackson's 2002 sequel following the breaking of the Fellowship."),
            Movie("media-lotr-return-of-the-king", "The Lord of the Rings: The Return of the King", 2003, 12, 17, 3019,
                "Peter Jackson's 2003 conclusion to the War of the Ring."),
            Movie("media-hobbit-unexpected-journey", "The Hobbit: An Unexpected Journey", 2012, 12, 14, 2941,
                "Peter Jackson's 2012 film adapting the first part of The Hobbit."),
            Movie("media-hobbit-desolation-of-smaug", "The Hobbit: The Desolation of Smaug", 2013, 12, 13, 2941,
                "Peter Jackson's 2013 sequel following Bilbo and the dwarves toward Erebor."),
            Movie("media-hobbit-five-armies", "The Hobbit: The Battle of the Five Armies", 2014, 12, 17, 2941,
                "Peter Jackson's 2014 conclusion to the Hobbit trilogy."),
            Movie("media-war-of-the-rohirrim", "The Lord of the Rings: The War of the Rohirrim", 2024, 12, 13, 2758,
                "Animated film about Helm Hammerhand and the founding of Helm's Deep, set centuries before The Lord of the Rings."),
            Tv("media-rings-of-power-s1", "The Lord of the Rings: The Rings of Power season 1", 2022, 9, 1, -1600,
                "Amazon series set in the Second Age, around the forging of the Rings of Power."),
            Tv("media-rings-of-power-s2", "The Lord of the Rings: The Rings of Power season 2", 2024, 8, 29, -1600,
                "Second season continuing the Second Age story of Númenor, the Southlands, and Sauron."),
        ];

        public static Book[] GetBooks() =>
        [
            Novel("The Hobbit", "J. R. R. Tolkien", 1937, 9, 2941,
                "Bilbo Baggins joins Thorin Oakenshield's company on a quest to reclaim Erebor from Smaug.",
                "Collection: The Hobbit", "Adapted for Screen"),
            Novel("The Fellowship of the Ring", "J. R. R. Tolkien", 1954, 7, 3018,
                "Frodo Baggins leaves the Shire with the One Ring and the Fellowship is formed.",
                "Collection: The Lord of the Rings", "Adapted for Screen"),
            Novel("The Two Towers", "J. R. R. Tolkien", 1954, 11, 3019,
                "The Fellowship is broken; Rohan goes to war and Frodo and Sam approach Mordor.",
                "Collection: The Lord of the Rings", "Adapted for Screen"),
            Novel("The Return of the King", "J. R. R. Tolkien", 1955, 10, 3019,
                "The War of the Ring reaches Gondor, and the One Ring is destroyed.",
                "Collection: The Lord of the Rings", "Adapted for Screen"),
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
            SettingCalendar = SettingCalendar.MiddleEarth,
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
            SettingCalendar = SettingCalendar.MiddleEarth,
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
            SettingCalendar = SettingCalendar.MiddleEarth,
            Type = BookType.Novel,
            Age = AgeAppropriateness.Middle,
            Description = description,
            Tags = tags.Select(name => new Tag { Name = name }).ToList()
        };
    }
}
