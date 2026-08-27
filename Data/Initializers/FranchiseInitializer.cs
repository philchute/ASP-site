using ASP_site.Models;

namespace ASP_site.Data.Initializers
{
    public static class FranchiseInitializer
    {
        public const string AlienPredatorId = "alien-vs-predator";
        public const string StarTrekId = "star-trek";
        public const string DuneId = "dune";

        public static (List<Franchise> franchises, List<FranchiseWork> works) GetData()
        {
            var franchises = new List<Franchise>
            {
                new Franchise
                {
                    FranchiseID = AlienPredatorId,
                    Name = "Alien vs Predator",
                    Description = "Films, games, books, and comics from the shared Alien and Predator universe, including Alien vs Predator crossovers."
                },
                new Franchise
                {
                    FranchiseID = StarTrekId,
                    Name = "Star Trek",
                    Description = "Films, television series, and games spanning Prime, Kelvin, and later-era Star Trek."
                },
                new Franchise
                {
                    FranchiseID = DuneId,
                    Name = "Dune",
                    Description = "Films, television, and games set in Frank Herbert's Dune universe."
                }
            };

            var works = new List<FranchiseWork>();
            works.AddRange(AlienPredatorWorks());
            works.AddRange(StarTrekWorks());
            works.AddRange(DuneWorks());
            return (franchises, works);
        }

        private static IEnumerable<FranchiseWork> AlienPredatorWorks()
        {
            const string alien = "Alien";
            const string predator = "Predator";
            const string avp = "AvP";

            // Movies
            yield return Movie(AlienPredatorId, alien, "media-alien-1979");
            yield return Movie(AlienPredatorId, alien, "media-aliens-1986");
            yield return Movie(AlienPredatorId, alien, "media-alien-3-1992");
            yield return Movie(AlienPredatorId, alien, "media-alien-resurrection-1997");
            yield return Movie(AlienPredatorId, alien, "media-prometheus-2012");
            yield return Movie(AlienPredatorId, alien, "media-alien-covenant-2017");
            yield return Movie(AlienPredatorId, alien, "media-alien-romulus-2024");
            yield return Movie(AlienPredatorId, predator, "media-predator-1987");
            yield return Movie(AlienPredatorId, predator, "media-predator-2-1990");
            yield return Movie(AlienPredatorId, predator, "media-predators-2010");
            yield return Movie(AlienPredatorId, predator, "media-the-predator-2018");
            yield return Movie(AlienPredatorId, predator, "media-prey-2022");
            yield return Movie(AlienPredatorId, avp, "media-alien-vs-predator-2004");
            yield return Movie(AlienPredatorId, avp, "media-aliens-vs-predator-requiem-2007");

            // Games
            yield return Game(AlienPredatorId, avp, "AvP(Arcade)");
            yield return Game(AlienPredatorId, avp, "AvP(1994)");
            yield return Game(AlienPredatorId, avp, "AvP(1999)");
            yield return Game(AlienPredatorId, avp, "AvP(2010)");
            yield return Game(AlienPredatorId, avp, "alienscolonialmarines");
            yield return Game(AlienPredatorId, alien, "aliendescent");
            yield return Game(AlienPredatorId, predator, "predatorvr");
            yield return Game(AlienPredatorId, predator, "predatorhuntinggrounds");
            yield return Game(AlienPredatorId, avp, "aliensrogueincursion");
            yield return Game(AlienPredatorId, avp, "aliensdarkdescent");
            yield return Game(AlienPredatorId, avp, "aliensfireteamelite");
            yield return Game(AlienPredatorId, avp, "aliensfireteamelite2");
            yield return Game(AlienPredatorId, alien, "alienisolation");
            yield return Game(AlienPredatorId, alien, "alienisolation2");

            // Books
            yield return Book(AlienPredatorId, alien, "Prometheus");
            yield return Book(AlienPredatorId, alien, "Alien: Covenant - Origins");
            yield return Book(AlienPredatorId, alien, "Alien: Covenant");
            yield return Book(AlienPredatorId, alien, "Alien");
            yield return Book(AlienPredatorId, alien, "Alien: Isolation");
            yield return Book(AlienPredatorId, alien, "Alien: Prototype");
            yield return Book(AlienPredatorId, alien, "Alien: Inferno's Fall");
            yield return Book(AlienPredatorId, alien, "Alien: Seventh Circle");
            yield return Book(AlienPredatorId, alien, "Alien: Out of the Shadows");
            yield return Book(AlienPredatorId, alien, "Alien: Vasquez");
            yield return Book(AlienPredatorId, alien, "Alien: Echo");
            yield return Book(AlienPredatorId, alien, "Alien: River of Pain");
            yield return Book(AlienPredatorId, alien, "Aliens");
            yield return Book(AlienPredatorId, alien, "Alien 3");
            yield return Book(AlienPredatorId, alien, "Alien 3: The Unproduced Screenplay");
            yield return Book(AlienPredatorId, alien, "Aliens: Bishop");
            yield return Book(AlienPredatorId, alien, "Alien: The Cold Forge");
            yield return Book(AlienPredatorId, alien, "Alien: Into Charybdis");
            yield return Book(AlienPredatorId, alien, "Aliens: Infiltrator");
            yield return Book(AlienPredatorId, alien, "Aliens: Resurrection");
            yield return Book(AlienPredatorId, alien, "Aliens: Original Sin");
            yield return Book(AlienPredatorId, alien, "Aliens: DNA War");
            yield return Book(AlienPredatorId, alien, "Aliens: Cauldron");
            yield return Book(AlienPredatorId, alien, "Aliens: Steel Egg");
            yield return Book(AlienPredatorId, alien, "Aliens: Criminal Enterprise");
            yield return Book(AlienPredatorId, alien, "Aliens: No Exit");
            yield return Book(AlienPredatorId, alien, "Alien: Sea of Sorrows");
            yield return Book(AlienPredatorId, avp, "The Rage War: Predator: Incursion");
            yield return Book(AlienPredatorId, avp, "The Rage War: Alien: Invasion");
            yield return Book(AlienPredatorId, avp, "The Rage War: Alien vs. Predator: Armageddon");
            yield return Book(AlienPredatorId, alien, "Aliens: Phalanx");
            yield return Book(AlienPredatorId, alien, "Alien: Colony War");
            yield return Book(AlienPredatorId, alien, "Alien: Enemy of My Enemy");
            yield return Book(AlienPredatorId, alien, "Alien: Uncivil War");
            yield return Book(AlienPredatorId, alien, "Alien: Cult");
            yield return Book(AlienPredatorId, alien, "Alien: Perfect Organisms");
            yield return Book(AlienPredatorId, alien, "Aliens: Bug Hunt");
            yield return Book(AlienPredatorId, alien, "Aliens: Earth Hive");
            yield return Book(AlienPredatorId, alien, "Aliens: Nightmare Asylum");
            yield return Book(AlienPredatorId, alien, "Aliens: The Female War");
            yield return Book(AlienPredatorId, alien, "Aliens: Genocide");
            yield return Book(AlienPredatorId, alien, "Aliens: Alien Harvest");
            yield return Book(AlienPredatorId, alien, "Aliens: Rogue");
            yield return Book(AlienPredatorId, alien, "Aliens: Labyrinth");
            yield return Book(AlienPredatorId, alien, "Aliens: Music of the Spears");
            yield return Book(AlienPredatorId, alien, "Aliens: Berserker");

            // Comics
            yield return Comic(AlienPredatorId, alien, "arc-aliens-outbreak");
            yield return Comic(AlienPredatorId, predator, "arc-predator-1989");
            yield return Comic(AlienPredatorId, avp, "arc-aliens-vs-predator-1990");
        }

        private static IEnumerable<FranchiseWork> StarTrekWorks()
        {
            const string enterprise = "Enterprise";
            const string tos = "TOS";
            const string kelvin = "Kelvin";
            const string tng = "TNG";
            const string ds9 = "DS9";
            const string voyager = "Voyager";
            const string discovery = "Discovery";
            const string snw = "Strange New Worlds";
            const string lowerDecks = "Lower Decks";
            const string picard = "Picard";
            const string prodigy = "Prodigy";

            // Movies
            yield return Movie(StarTrekId, tos, "media-star-trek-tmp");
            yield return Movie(StarTrekId, tos, "media-star-trek-twok");
            yield return Movie(StarTrekId, tos, "media-star-trek-tsfs");
            yield return Movie(StarTrekId, tos, "media-star-trek-tvh");
            yield return Movie(StarTrekId, tos, "media-star-trek-tff");
            yield return Movie(StarTrekId, tos, "media-star-trek-tuc");
            yield return Movie(StarTrekId, tng, "media-star-trek-generations");
            yield return Movie(StarTrekId, tng, "media-star-trek-first-contact");
            yield return Movie(StarTrekId, tng, "media-star-trek-insurrection");
            yield return Movie(StarTrekId, tng, "media-star-trek-nemesis");
            yield return Movie(StarTrekId, kelvin, "media-star-trek-2009");
            yield return Movie(StarTrekId, kelvin, "media-star-trek-into-darkness");
            yield return Movie(StarTrekId, kelvin, "media-star-trek-beyond");
            yield return Movie(StarTrekId, discovery, "media-star-trek-section-31");

            // TV seasons
            for (var season = 1; season <= 4; season++)
                yield return Tv(StarTrekId, enterprise, $"media-star-trek-enterprise-s{season}");
            for (var season = 1; season <= 3; season++)
                yield return Tv(StarTrekId, tos, $"media-star-trek-tos-s{season}");
            for (var season = 1; season <= 2; season++)
                yield return Tv(StarTrekId, tos, $"media-star-trek-tas-s{season}");
            for (var season = 1; season <= 7; season++)
                yield return Tv(StarTrekId, tng, $"media-star-trek-tng-s{season}");
            for (var season = 1; season <= 7; season++)
                yield return Tv(StarTrekId, ds9, $"media-star-trek-ds9-s{season}");
            for (var season = 1; season <= 7; season++)
                yield return Tv(StarTrekId, voyager, $"media-star-trek-voyager-s{season}");
            for (var season = 1; season <= 5; season++)
                yield return Tv(StarTrekId, discovery, $"media-star-trek-discovery-s{season}");
            for (var season = 1; season <= 3; season++)
                yield return Tv(StarTrekId, picard, $"media-star-trek-picard-s{season}");
            for (var season = 1; season <= 5; season++)
                yield return Tv(StarTrekId, lowerDecks, $"media-star-trek-lower-decks-s{season}");
            for (var season = 1; season <= 2; season++)
                yield return Tv(StarTrekId, prodigy, $"media-star-trek-prodigy-s{season}");
            for (var season = 1; season <= 3; season++)
                yield return Tv(StarTrekId, snw, $"media-star-trek-snw-s{season}");

            // Games
            yield return Game(StarTrekId, tos, "startrek25th");
            yield return Game(StarTrekId, tos, "startrekjudgmentrites");
            yield return Game(StarTrekId, tos, "startrekklingonacademy");
            yield return Game(StarTrekId, tos, "startrekstarfleetcmd");
            yield return Game(StarTrekId, tng, "startrekbridgecommander");
            yield return Game(StarTrekId, voyager, "startrekeliteforce");
            yield return Game(StarTrekId, tng, "startrekeliteforce2");
            yield return Game(StarTrekId, tng, "startrekarmada");
            yield return Game(StarTrekId, tng, "startrekarmada2");
            yield return Game(StarTrekId, tng, "startrekhiddenevil");
            yield return Game(StarTrekId, tng, "startrekawayteam");
            yield return Game(StarTrekId, ds9, "startrekds9fallen");
            yield return Game(StarTrekId, tng, "startrekbotf");
            yield return Game(StarTrekId, tng, "startreklegacy");
            yield return Game(StarTrekId, kelvin, "startrekbridgecrew");
            yield return Game(StarTrekId, tng, "startrekresurgence");
            yield return Game(StarTrekId, tng, "startrekinfinite");
            yield return Game(StarTrekId, picard, "sto");
        }

        private static IEnumerable<FranchiseWork> DuneWorks()
        {
            const string lynch = "Lynch";
            const string miniseries = "Miniseries";
            const string villeneuve = "Villeneuve";
            const string prophecy = "Prophecy";
            const string westwood = "Westwood";

            yield return Movie(DuneId, lynch, "media-dune-1984");
            yield return Movie(DuneId, villeneuve, "media-dune-2021");
            yield return Movie(DuneId, villeneuve, "media-dune-part-two");
            yield return Tv(DuneId, miniseries, "media-dune-miniseries");
            yield return Tv(DuneId, miniseries, "media-children-of-dune");
            yield return Tv(DuneId, prophecy, "media-dune-prophecy-s1");

            yield return Game(DuneId, lynch, "dune1992");
            yield return Game(DuneId, westwood, "dune2");
            yield return Game(DuneId, westwood, "dune2000");
            yield return Game(DuneId, westwood, "duneemperor");
            yield return Game(DuneId, miniseries, "duneminiseries");
            yield return Game(DuneId, villeneuve, "dunespicewars");
            yield return Game(DuneId, villeneuve, "duneawakening");
        }

        private static FranchiseWork Movie(string franchiseId, string branch, string mediaId) => new()
        {
            FranchiseID = franchiseId,
            Branch = branch,
            Kind = FranchiseWorkKind.Movie,
            MediaID = mediaId
        };

        private static FranchiseWork Tv(string franchiseId, string branch, string mediaId) => new()
        {
            FranchiseID = franchiseId,
            Branch = branch,
            Kind = FranchiseWorkKind.TVShow,
            MediaID = mediaId
        };

        private static FranchiseWork Game(string franchiseId, string branch, string gameId) => new()
        {
            FranchiseID = franchiseId,
            Branch = branch,
            Kind = FranchiseWorkKind.Game,
            GameID = gameId
        };

        private static FranchiseWork Book(string franchiseId, string branch, string bookTitle) => new()
        {
            FranchiseID = franchiseId,
            Branch = branch,
            Kind = FranchiseWorkKind.Book,
            BookTitle = bookTitle
        };

        private static FranchiseWork Comic(string franchiseId, string branch, string arcId) => new()
        {
            FranchiseID = franchiseId,
            Branch = branch,
            Kind = FranchiseWorkKind.ComicArc,
            StoryArcID = arcId
        };
    }
}
