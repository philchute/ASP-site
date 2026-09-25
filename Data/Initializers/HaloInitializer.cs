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
            // The Original Series
            Novel("Halo: The Fall of Reach", "Eric Nylund", 2001, 10, 2552,
                "The origin of the SPARTAN-II program and the fall of the fortress world Reach.", AgeAppropriateness.Middle,
                "Collection: The Original Series", "Collection: The Master Chief Omnibus"),
            Novel("Halo: The Flood", "William C. Dietz", 2003, 4, 2552,
                "Novelization of Halo: Combat Evolved, following the fight against the Covenant and the Flood on Installation 04.", AgeAppropriateness.Middle,
                "Collection: The Original Series", "Collection: The Master Chief Omnibus"),
            Novel("Halo: First Strike", "Eric Nylund", 2003, 12, 2552,
                "The gap between Halo and Halo 2, as John-117 and surviving Spartans strike back after Installation 04.",
                AgeAppropriateness.Middle, "Collection: The Original Series", "Collection: The Master Chief Omnibus"),
            Novel("Halo: Ghosts of Onyx", "Eric Nylund", 2006, 10, 2552,
                "The SPARTAN-III program on Onyx and the discovery of a Forerunner shield world.",
                AgeAppropriateness.Middle, "Collection: The Original Series"),

            // The Forerunner Saga (~97,445 BCE)
            Novel("Halo: Cryptum", "Greg Bear", 2011, 1, -97445,
                "A young Forerunner awakens the Didact during the last age of the ecumene, about 100,000 years before Halo.",
                AgeAppropriateness.Middle, "Collection: The Forerunner Saga"),
            Novel("Halo: Primordium", "Greg Bear", 2012, 1, -97445,
                "The ancient human Chakas is stranded on Installation 07 as the Forerunner-Flood war reaches its end.",
                AgeAppropriateness.Middle, "Collection: The Forerunner Saga"),
            Novel("Halo: Silentium", "Greg Bear", 2013, 3, -97445,
                "The Forerunners' war with the Flood ends in the firing of the Halo Array.",
                AgeAppropriateness.Middle, "Collection: The Forerunner Saga"),

            // Kilo-Five Trilogy
            Novel("Halo: Glasslands", "Karen Traviss", 2011, 10, 2553,
                "After the Covenant War, ONI's Kilo-Five sows discord among the Sangheili while survivors of Onyx remain trapped inside the shield world.",
                AgeAppropriateness.Middle, "Collection: Kilo-Five Trilogy"),
            Novel("Halo: The Thursday War", "Karen Traviss", 2012, 10, 2553,
                "Kilo-Five is drawn into civil war on Sanghelios as the UNSC Infinity is dispatched to aid the Arbiter.",
                AgeAppropriateness.Middle, "Collection: Kilo-Five Trilogy"),
            Novel("Halo: Mortal Dictata", "Karen Traviss", 2014, 1, 2553,
                "A Venezian insurgent whose daughter was taken into the SPARTAN-II program comes after ONI.",
                AgeAppropriateness.Middle, "Collection: Kilo-Five Trilogy"),

            // A Master Chief Story
            Novel("Halo: Silent Storm", "Troy Denning", 2018, 9, 2526,
                "In the first year of the Covenant War, John-117 leads a boarding campaign to buy humanity time.",
                AgeAppropriateness.Middle, "Collection: A Master Chief Story"),
            Novel("Halo: Oblivion", "Troy Denning", 2019, 9, 2526,
                "Blue Team tries to recover data from a downed Covenant frigate on Netherop.",
                AgeAppropriateness.Middle, "Collection: A Master Chief Story"),
            Novel("Halo: Shadows of Reach", "Troy Denning", 2020, 10, 2559,
                "A year after Halo 5, Blue Team returns to Reach to recover assets from CASTLE Base.",
                AgeAppropriateness.Middle, "Collection: A Master Chief Story"),
            Novel("Halo: Edge of Dawn", "Kelly Gay", 2025, 12, 2560,
                "After Halo Infinite, John-117 searches Zeta Halo for UNSC survivors while Jega 'Rdomnai hunts him.",
                AgeAppropriateness.Middle, "Collection: A Master Chief Story", "Collection: A Halo Infinite Story"),

            // Gray Team
            Novel("Halo: The Cole Protocol", "Tobias Buckell", 2008, 11, 2535,
                "Gray Team, Jacob Keyes, and Thel 'Vadamee clash over the Cole Protocol and a hidden asteroid habitat.",
                AgeAppropriateness.Middle, "Collection: Gray Team"),
            Novel("Halo: Envoy", "Tobias Buckell", 2017, 4, 2558,
                "A UEG envoy tries to keep peace on jointly occupied Carrow and free Gray Team from stasis.",
                AgeAppropriateness.Middle, "Collection: Gray Team"),

            // The Ferrets
            Novel("Halo: Last Light", "Troy Denning", 2015, 9, 2553,
                "Inspector Veta Lopis and Blue Team investigate murders on Gao as a Forerunner ancilla wakes.",
                AgeAppropriateness.Middle, "Collection: The Ferrets"),
            Novel("Halo: Retribution", "Troy Denning", 2017, 8, 2553,
                "Veta Lopis and the Ferrets hunt the assassin of Admiral Graselyn Tuwa.",
                AgeAppropriateness.Middle, "Collection: The Ferrets"),
            Novel("Halo: Divine Wind", "Troy Denning", 2021, 10, 2559,
                "The Ferrets follow Keepers of the One Freedom to the Ark to stop another firing of the Halo Array.",
                AgeAppropriateness.Middle, "Collection: The Ferrets"),

            // Rion Forge & Ace of Spades
            Novel("Halo: Smoke and Shadow", "Kelly Gay", 2016, 11, 2556,
                "Salvager Rion Forge searches for her father and the missing UNSC Spirit of Fire.",
                AgeAppropriateness.Middle, "Collection: Rion Forge and Ace of Spades"),
            Novel("Halo: Renegades", "Kelly Gay", 2019, 2, 2557,
                "Rion's crew crosses paths with 343 Guilty Spark while ONI and Covenant remnants close in.",
                AgeAppropriateness.Middle, "Collection: Rion Forge and Ace of Spades"),
            Novel("Halo: Point of Light", "Kelly Gay", 2021, 3, 2558,
                "Rion, Spark, and the Ace of Spades try to finish the Librarian's plan as Cortana's Created rise.",
                AgeAppropriateness.Middle, "Collection: Rion Forge and Ace of Spades"),

            // Alpha-Nine
            Novel("Halo: New Blood", "Matt Forbeck", 2015, 3, 2555,
                "Edward Buck's memoir from ODST service through joining the SPARTAN-IV program.",
                AgeAppropriateness.Middle, "Collection: Alpha-Nine"),
            Novel("Halo: Bad Blood", "Matt Forbeck", 2018, 6, 2558,
                "After Halo 5, Buck reforms Alpha-Nine for a mission as Cortana's Created reshape the galaxy.",
                AgeAppropriateness.Middle, "Collection: Alpha-Nine"),

            // Battle Born (YA)
            Novel("Halo: Battle Born", "Cassandra Rose Clarke", 2019, 1, 2551,
                "Four teens on Meridian try to survive a Covenant invasion with the help of an injured Spartan.",
                AgeAppropriateness.Early,
                "Collection: Battle Born"),
            Novel("Halo: Meridian Divide", "Cassandra Rose Clarke", 2019, 10, 2551,
                "The Meridian teens join a militia recon force as the Covenant excavates a Forerunner artifact.",
                AgeAppropriateness.Early,
                "Collection: Battle Born"),

            // Halo Infinite
            Novel("Halo: The Rubicon Protocol", "Kelly Gay", 2022, 8, 2560,
                "UNSC survivors endure the Banished occupation of Zeta Halo after the ambush of Infinity.",
                AgeAppropriateness.Middle, "Collection: A Halo Infinite Story"),

            // Standalones
            Novel("Halo: Contact Harvest", "Joseph Staten", 2007, 10, 2525,
                "The first encounter between humanity and the Covenant on the colony world Harvest.",
                AgeAppropriateness.Middle, "Collection: Halo Novels"),
            Novel("Halo: Broken Circle", "John Shirley", 2014, 11, -852,
                "Sangheili and San'Shyuum at the founding of the Covenant, and again during the Great Schism.",
                AgeAppropriateness.Middle, "Collection: Halo Novels"),
            Novel("Halo: Hunters in the Dark", "Peter David", 2015, 6, 2555,
                "A joint human-Sangheili expedition returns to the Ark in 2555.",
                AgeAppropriateness.Middle, "Collection: Halo Novels"),
            Novel("Halo: Saint's Testimony", "Frank O'Connor", 2015, 7, 2558,
                "The smart AI Iona appeals against her scheduled decommissioning.",
                AgeAppropriateness.Middle, "Collection: Halo Novels"),
            Novel("Halo: Shadow of Intent", "Joseph Staten", 2015, 12, 2553,
                "Rtas 'Vadum faces a vengeful San'Shyuum Prelate months after the Covenant War.",
                AgeAppropriateness.Middle, "Collection: Halo Novels"),
            Novel("Halo: Legacy of Onyx", "Matt Forbeck", 2017, 11, 2558,
                "Molly Patel grows up inside the Onyx shield world as Servants of the Abiding Truth threaten Paxopolis.",
                AgeAppropriateness.Middle, "Collection: Halo Novels"),
            Novel("Halo: Outcasts", "Troy Denning", 2023, 8, 2559,
                "The Arbiter and Spartan Vale hunt a weapon on Netherop weeks before the Banished strike Zeta Halo.",
                AgeAppropriateness.Middle, "Collection: Halo Novels"),
            Novel("Halo: Epitaph", "Kelly Gay", 2024, 2, 2557,
                "The Ur-Didact's journey after Halo 4, stripped of armor and memory.",
                AgeAppropriateness.Middle, "Collection: Halo Novels"),
            Novel("Halo: Empty Throne", "Jeremy Patenaude", 2025, 2, 2559,
                "While Infinity moves on Zeta Halo, the UNSC races to claim an ancient Domain access point.",
                AgeAppropriateness.Middle, "Collection: Halo Novels"),
            Novel("Halo: Parasite's Wake", "Tim Lebbon", 2026, 9, 2552,
                "Marines on Installation 04 during Halo: Combat Evolved, as the Flood outbreak takes hold.",
                AgeAppropriateness.Middle, "Collection: Halo Novels"),
            Novel("Halo: Fireteam Noble", "Troy Denning", 2027, null, 2560,
                "Jun-A266 and a new fireteam on a rescue mission in Banished territory after Halo Infinite.",
                AgeAppropriateness.Middle, "Collection: Halo Novels"),
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
            AgeAppropriateness age = AgeAppropriateness.Middle,
            params string[] tags) => new()
        {
            Title = title,
            Author = author,
            PublicationYear = publicationYear,
            PublicationMonth = publicationMonth,
            SettingYear = settingYear,
            Type = BookType.Novel,
            Age = age,
            Description = description,
            Tags = tags.Select(name => new Tag { Name = name }).ToList()
        };
    }
}
