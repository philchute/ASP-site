using ASP_site.Models;

namespace ASP_site.Data.Initializers
{
    public static class StarTrekInitializer
    {
        public static Media[] GetMedia() =>
        [
            // Movies
            Movie("media-star-trek-tmp", "Star Trek: The Motion Picture", 1979, 12, 7, 2273,
                "Robert Wise's 1979 film following the original Enterprise crew."),
            Movie("media-star-trek-twok", "Star Trek II: The Wrath of Khan", 1982, 6, 4, 2285,
                "Nicholas Meyer's 1982 sequel pitting Kirk against Khan Noonien Singh."),
            Movie("media-star-trek-tsfs", "Star Trek III: The Search for Spock", 1984, 6, 1, 2285,
                "Leonard Nimoy's 1984 sequel to The Wrath of Khan."),
            Movie("media-star-trek-tvh", "Star Trek IV: The Voyage Home", 1986, 11, 26, 2286,
                "Leonard Nimoy's 1986 time-travel film sending the crew to 1986 San Francisco."),
            Movie("media-star-trek-tff", "Star Trek V: The Final Frontier", 1989, 6, 9, 2287,
                "William Shatner's 1989 film about a renegade Vulcan hijacking the Enterprise."),
            Movie("media-star-trek-tuc", "Star Trek VI: The Undiscovered Country", 1991, 12, 6, 2293,
                "Nicholas Meyer's 1991 finale for the original crew, set around Khitomer."),
            Movie("media-star-trek-generations", "Star Trek: Generations", 1994, 11, 18, 2371,
                "David Carson's 1994 film passing the torch from Kirk to Picard."),
            Movie("media-star-trek-first-contact", "Star Trek: First Contact", 1996, 11, 22, 2373,
                "Jonathan Frakes's 1996 film sending the Enterprise-E after the Borg to 2063."),
            Movie("media-star-trek-insurrection", "Star Trek: Insurrection", 1998, 12, 11, 2375,
                "Jonathan Frakes's 1998 film about the Ba'ku and a Starfleet conspiracy."),
            Movie("media-star-trek-nemesis", "Star Trek: Nemesis", 2002, 12, 13, 2379,
                "Stuart Baird's 2002 film pitting Picard against Shinzon of Romulus."),
            Movie("media-star-trek-2009", "Star Trek (2009)", 2009, 5, 8, 2258,
                "J. J. Abrams's 2009 Kelvin Timeline reboot."),
            Movie("media-star-trek-into-darkness", "Star Trek Into Darkness", 2013, 5, 16, 2259,
                "J. J. Abrams's 2013 Kelvin Timeline sequel."),
            Movie("media-star-trek-beyond", "Star Trek Beyond", 2016, 7, 22, 2263,
                "Justin Lin's 2016 Kelvin Timeline film set during the five-year mission."),
            Movie("media-star-trek-section-31", "Star Trek: Section 31", 2025, 1, 24, 2324,
                "Olatunde Osunsanmi's 2025 film following Philippa Georgiou in Section 31."),

            // Enterprise
            Season("media-star-trek-enterprise-s1", "Star Trek: Enterprise season 1", 2001, 9, 26, 2151),
            Season("media-star-trek-enterprise-s2", "Star Trek: Enterprise season 2", 2002, 9, 18, 2152),
            Season("media-star-trek-enterprise-s3", "Star Trek: Enterprise season 3", 2003, 9, 10, 2153),
            Season("media-star-trek-enterprise-s4", "Star Trek: Enterprise season 4", 2004, 10, 8, 2154),

            // The Original Series
            Season("media-star-trek-tos-s1", "Star Trek: The Original Series season 1", 1966, 9, 8, 2266),
            Season("media-star-trek-tos-s2", "Star Trek: The Original Series season 2", 1967, 9, 15, 2267),
            Season("media-star-trek-tos-s3", "Star Trek: The Original Series season 3", 1968, 9, 20, 2268),

            // The Animated Series
            Season("media-star-trek-tas-s1", "Star Trek: The Animated Series season 1", 1973, 9, 8, 2269),
            Season("media-star-trek-tas-s2", "Star Trek: The Animated Series season 2", 1974, 9, 7, 2270),

            // The Next Generation
            Season("media-star-trek-tng-s1", "Star Trek: The Next Generation season 1", 1987, 9, 28, 2364),
            Season("media-star-trek-tng-s2", "Star Trek: The Next Generation season 2", 1988, 11, 21, 2365),
            Season("media-star-trek-tng-s3", "Star Trek: The Next Generation season 3", 1989, 9, 25, 2366),
            Season("media-star-trek-tng-s4", "Star Trek: The Next Generation season 4", 1990, 9, 24, 2367),
            Season("media-star-trek-tng-s5", "Star Trek: The Next Generation season 5", 1991, 9, 23, 2368),
            Season("media-star-trek-tng-s6", "Star Trek: The Next Generation season 6", 1992, 9, 21, 2369),
            Season("media-star-trek-tng-s7", "Star Trek: The Next Generation season 7", 1993, 9, 20, 2370),

            // Deep Space Nine
            Season("media-star-trek-ds9-s1", "Star Trek: Deep Space Nine season 1", 1993, 1, 3, 2369),
            Season("media-star-trek-ds9-s2", "Star Trek: Deep Space Nine season 2", 1993, 9, 26, 2370),
            Season("media-star-trek-ds9-s3", "Star Trek: Deep Space Nine season 3", 1994, 9, 26, 2371),
            Season("media-star-trek-ds9-s4", "Star Trek: Deep Space Nine season 4", 1995, 10, 2, 2372),
            Season("media-star-trek-ds9-s5", "Star Trek: Deep Space Nine season 5", 1996, 9, 30, 2373),
            Season("media-star-trek-ds9-s6", "Star Trek: Deep Space Nine season 6", 1997, 9, 29, 2374),
            Season("media-star-trek-ds9-s7", "Star Trek: Deep Space Nine season 7", 1998, 9, 30, 2375),

            // Voyager
            Season("media-star-trek-voyager-s1", "Star Trek: Voyager season 1", 1995, 1, 16, 2371),
            Season("media-star-trek-voyager-s2", "Star Trek: Voyager season 2", 1995, 8, 28, 2372),
            Season("media-star-trek-voyager-s3", "Star Trek: Voyager season 3", 1996, 9, 4, 2373),
            Season("media-star-trek-voyager-s4", "Star Trek: Voyager season 4", 1997, 9, 3, 2374),
            Season("media-star-trek-voyager-s5", "Star Trek: Voyager season 5", 1998, 10, 14, 2375),
            Season("media-star-trek-voyager-s6", "Star Trek: Voyager season 6", 1999, 9, 22, 2376),
            Season("media-star-trek-voyager-s7", "Star Trek: Voyager season 7", 2000, 10, 4, 2377),

            // Discovery
            Season("media-star-trek-discovery-s1", "Star Trek: Discovery season 1", 2017, 9, 24, 2256),
            Season("media-star-trek-discovery-s2", "Star Trek: Discovery season 2", 2019, 1, 17, 2257),
            Season("media-star-trek-discovery-s3", "Star Trek: Discovery season 3", 2020, 10, 15, 3188),
            Season("media-star-trek-discovery-s4", "Star Trek: Discovery season 4", 2021, 11, 18, 3190),
            Season("media-star-trek-discovery-s5", "Star Trek: Discovery season 5", 2024, 4, 4, 3191),

            // Picard
            Season("media-star-trek-picard-s1", "Star Trek: Picard season 1", 2020, 1, 23, 2399),
            Season("media-star-trek-picard-s2", "Star Trek: Picard season 2", 2022, 3, 3, 2401),
            Season("media-star-trek-picard-s3", "Star Trek: Picard season 3", 2023, 2, 16, 2401),

            // Lower Decks
            Season("media-star-trek-lower-decks-s1", "Star Trek: Lower Decks season 1", 2020, 8, 6, 2380),
            Season("media-star-trek-lower-decks-s2", "Star Trek: Lower Decks season 2", 2021, 8, 12, 2381),
            Season("media-star-trek-lower-decks-s3", "Star Trek: Lower Decks season 3", 2022, 8, 25, 2382),
            Season("media-star-trek-lower-decks-s4", "Star Trek: Lower Decks season 4", 2023, 9, 7, 2382),
            Season("media-star-trek-lower-decks-s5", "Star Trek: Lower Decks season 5", 2024, 10, 24, 2382),

            // Prodigy
            Season("media-star-trek-prodigy-s1", "Star Trek: Prodigy season 1", 2021, 10, 28, 2383),
            Season("media-star-trek-prodigy-s2", "Star Trek: Prodigy season 2", 2024, 7, 1, 2384),

            // Strange New Worlds
            Season("media-star-trek-snw-s1", "Star Trek: Strange New Worlds season 1", 2022, 5, 5, 2259),
            Season("media-star-trek-snw-s2", "Star Trek: Strange New Worlds season 2", 2023, 6, 15, 2259),
            Season("media-star-trek-snw-s3", "Star Trek: Strange New Worlds season 3", 2025, 7, 17, 2261),
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

        private static Media Season(
            string id,
            string title,
            int releaseYear,
            int month,
            int day,
            int settingYear) => new()
        {
            MediaID = id,
            Title = title,
            MediaType = MediaType.TVShow,
            ReleaseYear = releaseYear,
            ReleaseMonth = month,
            ReleaseDay = day,
            SettingYear = settingYear,
            Description = title + "."
        };
    }
}
