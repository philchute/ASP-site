using ASP_site.Data;
using ASP_site.Models;
using ASP_site.Pages.Universe;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

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
        public async Task Index_ListsStarTrekUniverse()
        {
            var page = new IndexModel(_context);
            await page.OnGetAsync();

            var trek = Assert.Single(page.Universes, f => f.Id == "star-trek");
            Assert.Equal("Star Trek", trek.Name);
            Assert.True(trek.WorkCount >= 20, $"Expected a starter catalog, found {trek.WorkCount} works");
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

            AssertWork(page.Works, "Alien", FranchiseWorkKind.Movie, "Alien", "/Media/Details", "media-alien-1979");
            AssertWork(page.Works, "Alien: Isolation", FranchiseWorkKind.Game, "Alien", "/Games/Game", "alienisolation");
            AssertWork(page.Works, "Aliens: Earth Hive", FranchiseWorkKind.Book, "Alien", "/Books/Book", "Aliens: Earth Hive");
            AssertWork(page.Works, "Aliens vs. Predator", FranchiseWorkKind.ComicArc, "AvP", "/Comics/Arc", "arc-aliens-vs-predator-1990");

            var settingYears = page.Works
                .Where(w => w.SettingYear.HasValue)
                .Select(w => w.SettingYear!.Value)
                .ToList();
            Assert.True(settingYears.Count > 1, "Expected setting years so chronology sort can work");
            Assert.Equal(settingYears.OrderBy(y => y).ToList(), settingYears);
        }

        [Fact]
        public async Task StarTrekPage_ListsMoviesTvAndGamesInSettingOrder()
        {
            var page = new UniverseModel(_context);
            await page.OnGetAsync("star-trek");

            Assert.NotNull(page.Universe);
            var kinds = page.Works.Select(w => w.Kind).Distinct().ToList();
            Assert.Contains(FranchiseWorkKind.Movie, kinds);
            Assert.Contains(FranchiseWorkKind.TVShow, kinds);
            Assert.Contains(FranchiseWorkKind.Game, kinds);
            Assert.Contains(FranchiseWorkKind.Book, kinds);

            AssertWork(page.Works, "Star Trek: The Motion Picture", FranchiseWorkKind.Movie, "TOS", "/Media/Details", "media-star-trek-tmp");
            AssertWork(page.Works, "Star Trek: The Next Generation season 1", FranchiseWorkKind.TVShow, "TNG", "/Media/Details", "media-star-trek-tng-s1");
            AssertWork(page.Works, "Star Trek Online", FranchiseWorkKind.Game, "Picard", "/Games/Game", "sto");
            AssertWork(page.Works, "Star Trek (2009)", FranchiseWorkKind.Movie, "Kelvin", "/Media/Details", "media-star-trek-2009");
            AssertWork(page.Works, "Imzadi", FranchiseWorkKind.Book, "TNG", "/Books/Book", "Imzadi");

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
                SelectedBranches = new List<string> { "AvP" },
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
        public async Task StarTrekPage_FiltersByKelvinBranch()
        {
            var page = new UniverseModel(_context)
            {
                SelectedBranches = new List<string> { "Kelvin" },
                SelectedKinds = new List<string>
                {
                    nameof(FranchiseWorkKind.Movie),
                    nameof(FranchiseWorkKind.TVShow),
                    nameof(FranchiseWorkKind.Game)
                }
            };
            await page.OnGetAsync("star-trek");

            var titles = page.Works.Select(w => w.Title).ToList();
            Assert.Contains("Star Trek (2009)", titles);
            Assert.Contains("Star Trek Into Darkness", titles);
            Assert.DoesNotContain("Star Trek: The Motion Picture", titles);
            Assert.DoesNotContain("Star Trek Online", titles);
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

        [Fact]
        public async Task YearsPage_IncludesTrekCatalogAndExtraBeatsWithoutDuplicateFilms()
        {
            var page = new ASP_site.Pages.Years.IndexModel(_context);
            await page.OnGetAsync();

            var titles = page.TimelineEntries.Select(e => e.Title).ToList();
            Assert.Contains("Vulcan First Contact", titles);
            Assert.Contains("Kelvin Timeline: Narada incident", titles);
            Assert.Contains("Enterprise-B maiden voyage", titles);
            Assert.Contains("Dominion War", titles);
            Assert.Contains("Star Trek: First Contact", titles);
            Assert.Contains("Star Trek: The Next Generation season 1", titles);
            Assert.Contains("Star Trek: Lower Decks season 5", titles);
            Assert.Contains("Star Trek Online", titles);

            Assert.Equal(1, titles.Count(t => t == "Star Trek: First Contact"));
            Assert.DoesNotContain("Star Trek: Lower Decks season 2-4", titles);
            Assert.DoesNotContain("Star Trek (Prologue)", titles);
        }

        [Fact]
        public async Task Index_ListsDuneUniverse()
        {
            var page = new IndexModel(_context);
            await page.OnGetAsync();

            var dune = Assert.Single(page.Universes, f => f.Id == "dune");
            Assert.Equal("Dune", dune.Name);
            Assert.True(dune.WorkCount >= 10, $"Expected a starter catalog, found {dune.WorkCount} works");
        }

        [Fact]
        public async Task DunePage_ListsMoviesTvAndGamesInSettingOrder()
        {
            var page = new UniverseModel(_context);
            await page.OnGetAsync("dune");

            Assert.NotNull(page.Universe);
            var kinds = page.Works.Select(w => w.Kind).Distinct().ToList();
            Assert.Contains(FranchiseWorkKind.Movie, kinds);
            Assert.Contains(FranchiseWorkKind.TVShow, kinds);
            Assert.Contains(FranchiseWorkKind.Game, kinds);
            Assert.Contains(FranchiseWorkKind.Book, kinds);

            AssertWork(page.Works, "Dune (2021)", FranchiseWorkKind.Movie, "Villeneuve", "/Media/Details", "media-dune-2021");
            AssertWork(page.Works, "Dune: Prophecy season 1", FranchiseWorkKind.TVShow, "Prophecy", "/Media/Details", "media-dune-prophecy-s1");
            AssertWork(page.Works, "Dune II: The Building of a Dynasty", FranchiseWorkKind.Game, "Westwood", "/Games/Game", "dune2");
            AssertWork(page.Works, "Dune", FranchiseWorkKind.Book, "Novels", "/Books/Book", "Dune");

            var settingYears = page.Works
                .Where(w => w.SettingYear.HasValue)
                .Select(w => w.SettingYear!.Value)
                .ToList();
            Assert.True(settingYears.Count > 1, "Expected setting years so chronology sort can work");
            Assert.Equal(settingYears.OrderBy(y => y).ToList(), settingYears);
        }

        [Fact]
        public async Task DunePage_FiltersByVilleneuveBranch()
        {
            var page = new UniverseModel(_context)
            {
                SelectedBranches = new List<string> { "Villeneuve" },
                SelectedKinds = new List<string>
                {
                    nameof(FranchiseWorkKind.Movie),
                    nameof(FranchiseWorkKind.TVShow),
                    nameof(FranchiseWorkKind.Game)
                }
            };
            await page.OnGetAsync("dune");

            var titles = page.Works.Select(w => w.Title).ToList();
            Assert.Contains("Dune (2021)", titles);
            Assert.Contains("Dune: Part Two", titles);
            Assert.DoesNotContain("Dune (1984)", titles);
            Assert.DoesNotContain("Dune II: The Building of a Dynasty", titles);
        }

        [Fact]
        public async Task MediaDetails_ShowsSettingYearAndUniverseBackLink()
        {
            var page = new ASP_site.Pages.MediaPages.DetailsModel(_context);
            await page.OnGetAsync("media-star-trek-tmp");

            Assert.NotNull(page.Item);
            Assert.Equal(2273, page.Item!.SettingYear);
            var universe = Assert.Single(page.Universes);
            Assert.Equal("star-trek", universe.FranchiseID);
        }

        [Fact]
        public async Task GameDetails_ShowsUniverseBackLink()
        {
            var page = new ASP_site.Pages.Games.GamesModel(_context)
            {
                PageContext = new PageContext
                {
                    ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                }
            };
            await page.OnGetAsync("sto");

            Assert.NotNull(page.Game);
            var universe = Assert.Single(page.Universes);
            Assert.Equal("star-trek", universe.FranchiseID);
        }

        private static void AssertWork(
            List<FranchiseWork> works,
            string title,
            FranchiseWorkKind kind,
            string branch,
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
