using ASP_site.Data;
using ASP_site.Models;
using ASP_site.Pages.Universe;

namespace ASP_site.Tests
{
    public class FranchiseHubTests : IClassFixture<SeedFixture>
    {
        private readonly GameContext _context;

        public FranchiseHubTests(SeedFixture fixture)
        {
            _context = fixture.Context;
        }

        [Fact]
        public async Task Index_ListsAlienPredatorUniverse()
        {
            var page = new IndexModel(_context);
            await page.OnGetAsync();

            var avp = Assert.Single(page.Universes, f => f.Id == "alien-vs-predator");
            Assert.Equal("Alien vs Predator", avp.Name);
            Assert.True(avp.WorkCount >= 20, $"Expected a starter catalog, found {avp.WorkCount} works");
        }

        [Fact]
        public async Task AlienPredatorPage_ListsAndLinksCatalogItemsInSettingOrder()
        {
            var page = new UniverseModel(_context);
            await page.OnGetAsync("alien-vs-predator");

            Assert.NotNull(page.Universe);
            var kinds = page.Works.Select(w => w.Kind).Distinct().ToList();
            Assert.Contains(FranchiseWorkKind.Movie, kinds);
            Assert.Contains(FranchiseWorkKind.Game, kinds);
            Assert.Contains(FranchiseWorkKind.Book, kinds);
            Assert.Contains(FranchiseWorkKind.ComicArc, kinds);

            AssertWork(page.Works, "Alien", FranchiseWorkKind.Movie, FranchiseBranch.Alien, "/Media/Details", "media-alien-1979");
            AssertWork(page.Works, "Alien: Isolation", FranchiseWorkKind.Game, FranchiseBranch.Alien, "/Games/Game", "alienisolation");
            AssertWork(page.Works, "Aliens: Earth Hive", FranchiseWorkKind.Book, FranchiseBranch.Alien, "/Books/Book", "Aliens: Earth Hive");
            AssertWork(page.Works, "Aliens vs. Predator", FranchiseWorkKind.ComicArc, FranchiseBranch.Crossover, "/Comics/Arc", "arc-aliens-vs-predator-1990");

            var settingYears = page.Works
                .Where(w => w.SettingYear.HasValue)
                .Select(w => w.SettingYear!.Value)
                .ToList();
            Assert.True(settingYears.Count > 1, "Expected setting years so chronology sort can work");
            Assert.Equal(settingYears.OrderBy(y => y).ToList(), settingYears);
        }

        [Fact]
        public async Task AlienPredatorPage_FiltersByBranch()
        {
            var page = new UniverseModel(_context)
            {
                SelectedBranches = new List<string> { nameof(FranchiseBranch.Crossover) },
                SelectedKinds = new List<string>
                {
                    nameof(FranchiseWorkKind.Movie),
                    nameof(FranchiseWorkKind.Game),
                    nameof(FranchiseWorkKind.Book),
                    nameof(FranchiseWorkKind.ComicArc)
                }
            };
            await page.OnGetAsync("alien-vs-predator");

            var titles = page.Works.Select(w => w.Title).ToList();
            Assert.Contains("Alien vs. Predator", titles);
            Assert.DoesNotContain("Alien: Isolation", titles);
            Assert.DoesNotContain("Alien", titles);
        }

        [Fact]
        public async Task AlienPredatorPage_FiltersByCollectionTags()
        {
            var page = new UniverseModel(_context);
            await page.OnGetAsync("alien-vs-predator");

            Assert.Contains(page.AllCollections.Keys, k => k.StartsWith("Collection: "));
            var shadowArchive = page.AllCollections.Keys
                .First(k => k.Contains("Shadow Archive", StringComparison.OrdinalIgnoreCase));

            var filtered = new UniverseModel(_context)
            {
                SelectedCollections = new List<string> { shadowArchive }
            };
            await filtered.OnGetAsync("alien-vs-predator");

            Assert.Contains(filtered.Works, w => w.Title == "Alien: Out of the Shadows");
            Assert.DoesNotContain(filtered.Works, w => w.Title == "Alien" && w.Kind == FranchiseWorkKind.Movie);
        }

        private static void AssertWork(
            List<FranchiseWork> works,
            string title,
            FranchiseWorkKind kind,
            FranchiseBranch branch,
            string page,
            string routeValue)
        {
            var work = Assert.Single(works, w => w.Title == title && w.Kind == kind);
            Assert.Equal(kind, work.Kind);
            Assert.Equal(branch, work.Branch);
            Assert.True(work.ReleasedYear.HasValue || work.SettingYear.HasValue, $"{title} should have a year");
            var link = work.GetCatalogLink();
            Assert.NotNull(link);
            Assert.Equal(page, link.Page);
            Assert.Equal(routeValue, link.RouteValue);
        }
    }
}
