using ASP_site.Models;

namespace ASP_site.Data.Initializers
{
    public static class FranchiseInitializer
    {
        public const string AlienPredatorId = "alien-vs-predator";

        public static (List<Franchise> franchises, List<FranchiseWork> works) GetData()
        {
            var franchises = new List<Franchise>
            {
                new Franchise
                {
                    FranchiseID = AlienPredatorId,
                    Name = "Alien vs Predator",
                    Description = "Films, games, books, and comics from the shared Alien and Predator universe, including Alien vs Predator crossovers."
                }
            };

            var works = new List<FranchiseWork>();
            works.AddRange(AlienPredatorWorks());
            return (franchises, works);
        }

        private static IEnumerable<FranchiseWork> AlienPredatorWorks()
        {
            // Movies
            yield return Movie(FranchiseBranch.Alien, "media-alien-1979");
            yield return Movie(FranchiseBranch.Alien, "media-aliens-1986");
            yield return Movie(FranchiseBranch.Alien, "media-alien-3-1992");
            yield return Movie(FranchiseBranch.Alien, "media-alien-resurrection-1997");
            yield return Movie(FranchiseBranch.Alien, "media-prometheus-2012");
            yield return Movie(FranchiseBranch.Alien, "media-alien-covenant-2017");
            yield return Movie(FranchiseBranch.Alien, "media-alien-romulus-2024");
            yield return Movie(FranchiseBranch.Predator, "media-predator-1987");
            yield return Movie(FranchiseBranch.Predator, "media-predator-2-1990");
            yield return Movie(FranchiseBranch.Predator, "media-predators-2010");
            yield return Movie(FranchiseBranch.Predator, "media-the-predator-2018");
            yield return Movie(FranchiseBranch.Predator, "media-prey-2022");
            yield return Movie(FranchiseBranch.Crossover, "media-alien-vs-predator-2004");
            yield return Movie(FranchiseBranch.Crossover, "media-aliens-vs-predator-requiem-2007");

            // Games
            yield return Game(FranchiseBranch.Alien, "alienisolation");
            yield return Game(FranchiseBranch.Crossover, "AvP(Arcade)");
            yield return Game(FranchiseBranch.Crossover, "AvP(1994)");
            yield return Game(FranchiseBranch.Crossover, "AvP(1999)");
            yield return Game(FranchiseBranch.Crossover, "AvP(2010)");

            // Books
            yield return Book(FranchiseBranch.Alien, "Prometheus");
            yield return Book(FranchiseBranch.Alien, "Alien: Covenant - Origins");
            yield return Book(FranchiseBranch.Alien, "Alien: Covenant");
            yield return Book(FranchiseBranch.Alien, "Alien");
            yield return Book(FranchiseBranch.Alien, "Alien: Isolation");
            yield return Book(FranchiseBranch.Alien, "Alien: Prototype");
            yield return Book(FranchiseBranch.Alien, "Alien: Inferno's Fall");
            yield return Book(FranchiseBranch.Alien, "Alien: Seventh Circle");
            yield return Book(FranchiseBranch.Alien, "Alien: Out of the Shadows");
            yield return Book(FranchiseBranch.Alien, "Alien: Vasquez");
            yield return Book(FranchiseBranch.Alien, "Alien: Echo");
            yield return Book(FranchiseBranch.Alien, "Alien: River of Pain");
            yield return Book(FranchiseBranch.Alien, "Aliens");
            yield return Book(FranchiseBranch.Alien, "Alien 3");
            yield return Book(FranchiseBranch.Alien, "Alien 3: The Unproduced Screenplay");
            yield return Book(FranchiseBranch.Alien, "Aliens: Bishop");
            yield return Book(FranchiseBranch.Alien, "Alien: The Cold Forge");
            yield return Book(FranchiseBranch.Alien, "Alien: Into Charybdis");
            yield return Book(FranchiseBranch.Alien, "Aliens: Infiltrator");
            yield return Book(FranchiseBranch.Alien, "Aliens: Resurrection");
            yield return Book(FranchiseBranch.Alien, "Aliens: Original Sin");
            yield return Book(FranchiseBranch.Alien, "Aliens: DNA War");
            yield return Book(FranchiseBranch.Alien, "Aliens: Cauldron");
            yield return Book(FranchiseBranch.Alien, "Aliens: Steel Egg");
            yield return Book(FranchiseBranch.Alien, "Aliens: Criminal Enterprise");
            yield return Book(FranchiseBranch.Alien, "Aliens: No Exit");
            yield return Book(FranchiseBranch.Alien, "Alien: Sea of Sorrows");
            yield return Book(FranchiseBranch.Crossover, "The Rage War: Predator: Incursion");
            yield return Book(FranchiseBranch.Crossover, "The Rage War: Alien: Invasion");
            yield return Book(FranchiseBranch.Crossover, "The Rage War: Alien vs. Predator: Armageddon");
            yield return Book(FranchiseBranch.Alien, "Aliens: Phalanx");
            yield return Book(FranchiseBranch.Alien, "Alien: Colony War");
            yield return Book(FranchiseBranch.Alien, "Alien: Enemy of My Enemy");
            yield return Book(FranchiseBranch.Alien, "Alien: Uncivil War");
            yield return Book(FranchiseBranch.Alien, "Alien: Cult");
            yield return Book(FranchiseBranch.Alien, "Alien: Perfect Organisms");
            yield return Book(FranchiseBranch.Alien, "Aliens: Earth Hive");
            yield return Book(FranchiseBranch.Alien, "Aliens: Nightmare Asylum");
            yield return Book(FranchiseBranch.Alien, "Aliens: The Female War");
            yield return Book(FranchiseBranch.Alien, "Aliens: Genocide");
            yield return Book(FranchiseBranch.Alien, "Aliens: Alien Harvest");
            yield return Book(FranchiseBranch.Alien, "Aliens: Rogue");
            yield return Book(FranchiseBranch.Alien, "Aliens: Labyrinth");
            yield return Book(FranchiseBranch.Alien, "Aliens: Music of the Spears");
            yield return Book(FranchiseBranch.Alien, "Aliens: Berserker");

            // Comics
            yield return Comic(FranchiseBranch.Alien, "arc-aliens-outbreak");
            yield return Comic(FranchiseBranch.Predator, "arc-predator-1989");
            yield return Comic(FranchiseBranch.Crossover, "arc-aliens-vs-predator-1990");
        }

        private static FranchiseWork Movie(FranchiseBranch branch, string mediaId) => new()
        {
            FranchiseID = AlienPredatorId,
            Branch = branch,
            Kind = FranchiseWorkKind.Movie,
            MediaID = mediaId
        };

        private static FranchiseWork Game(FranchiseBranch branch, string gameId) => new()
        {
            FranchiseID = AlienPredatorId,
            Branch = branch,
            Kind = FranchiseWorkKind.Game,
            GameID = gameId
        };

        private static FranchiseWork Book(FranchiseBranch branch, string bookTitle) => new()
        {
            FranchiseID = AlienPredatorId,
            Branch = branch,
            Kind = FranchiseWorkKind.Book,
            BookTitle = bookTitle
        };

        private static FranchiseWork Comic(FranchiseBranch branch, string arcId) => new()
        {
            FranchiseID = AlienPredatorId,
            Branch = branch,
            Kind = FranchiseWorkKind.ComicArc,
            StoryArcID = arcId
        };
    }
}
