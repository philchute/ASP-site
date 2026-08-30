using ASP_site.Data;
using ASP_site.Helpers;
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
        public async Task Index_ListsFoundationUniverse()
        {
            var page = new IndexModel(_context);
            await page.OnGetAsync();

            var foundation = Assert.Single(page.Universes, f => f.Id == "foundation");
            Assert.Equal("Foundation Universe", foundation.Name);
            Assert.True(foundation.WorkCount >= 50, $"Expected Robot/Empire/Foundation catalog, found {foundation.WorkCount} works");
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
            Assert.DoesNotContain("Dune: The Butlerian Jihad", titles);
            Assert.DoesNotContain("Dune: House Atreides", titles);
            Assert.DoesNotContain("The Fellowship of the Ring", titles);
            Assert.DoesNotContain("The Lord of the Rings: The Rings of Power season 1", titles);
            Assert.Contains("Halo: Combat Evolved", titles);
            Assert.Equal(new List<string> { nameof(SettingCalendar.Gregorian) }, page.SelectedCalendars);
        }

        [Fact]
        public async Task YearsPage_IncludesDuneWhenAfterGuildSelected()
        {
            var page = new ASP_site.Pages.Years.IndexModel(_context)
            {
                SelectedCalendars = new List<string> { nameof(SettingCalendar.AfterGuild) }
            };
            await page.OnGetAsync();

            var titles = page.TimelineEntries.Select(e => e.Title).ToList();
            Assert.Contains("Dune: The Butlerian Jihad", titles);
            Assert.Contains("Dune: House Atreides", titles);
            Assert.Contains("Hunters of Dune", titles);
            Assert.Contains("Dune: Prophecy season 1", titles);
            Assert.DoesNotContain("Star Trek: First Contact", titles);
            Assert.DoesNotContain("Vulcan First Contact", titles);
        }

        [Fact]
        public async Task YearsPage_IncludesLotRWhenMiddleEarthSelected()
        {
            var page = new ASP_site.Pages.Years.IndexModel(_context)
            {
                SelectedCalendars = new List<string> { nameof(SettingCalendar.MiddleEarth) }
            };
            await page.OnGetAsync();

            var titles = page.TimelineEntries.Select(e => e.Title).ToList();
            Assert.Contains("The Fellowship of the Ring", titles);
            Assert.Contains("The Lord of the Rings: The Rings of Power season 1", titles);
            Assert.Contains("The Hobbit", titles);
            Assert.DoesNotContain("Halo: Combat Evolved", titles);
            Assert.DoesNotContain("Star Trek: First Contact", titles);
            Assert.DoesNotContain("Dune", titles);
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
        public async Task DunePage_ListsExpandedNovelsCollectionsAndAgYears()
        {
            var page = new UniverseModel(_context);
            await page.OnGetAsync("dune");

            AssertWork(page.Works, "Dune: House Atreides", FranchiseWorkKind.Book, "Novels", "/Books/Book", "Dune: House Atreides");
            AssertWork(page.Works, "Dune: The Butlerian Jihad", FranchiseWorkKind.Book, "Novels", "/Books/Book", "Dune: The Butlerian Jihad");
            AssertWork(page.Works, "Hunters of Dune", FranchiseWorkKind.Book, "Novels", "/Books/Book", "Hunters of Dune");
            AssertWork(page.Works, "Princess of Dune", FranchiseWorkKind.Book, "Novels", "/Books/Book", "Princess of Dune");

            Assert.Contains("Collection: Prelude to Dune", page.AllCollections.Keys);
            Assert.Contains("Collection: Legends of Dune", page.AllCollections.Keys);
            Assert.Contains("Collection: Great Schools of Dune", page.AllCollections.Keys);
            Assert.Contains("Collection: Caladan Trilogy", page.AllCollections.Keys);
            Assert.Contains("Collection: Heroes of Dune", page.AllCollections.Keys);
            Assert.Contains("Collection: Dune Sequels", page.AllCollections.Keys);

            var titles = page.Works.Select(w => w.Title).ToList();
            Assert.True(titles.IndexOf("Dune: The Butlerian Jihad") < titles.IndexOf("Dune: Prophecy season 1"));
            Assert.True(titles.IndexOf("Dune: Prophecy season 1") < titles.IndexOf("Dune"));
            Assert.True(titles.IndexOf("Dune") < titles.IndexOf("Hunters of Dune"));

            var jihad = Assert.Single(page.Works, w => w.Title == "Dune: The Butlerian Jihad");
            Assert.Equal(SettingCalendar.AfterGuild, jihad.SettingCalendar);
            Assert.Equal(-200, jihad.SettingYear);
            Assert.Equal("200 BG", ViewHelper.FormatSettingYear(jihad.SettingYear, jihad.SettingCalendar));
            Assert.False(string.IsNullOrEmpty(jihad.Description));

            var duneBook = Assert.Single(page.Works, w => w.Title == "Dune" && w.Kind == FranchiseWorkKind.Book);
            Assert.Equal("10191 AG", ViewHelper.FormatSettingYear(duneBook.SettingYear, duneBook.SettingCalendar));
        }

        [Fact]
        public async Task Index_ListsHaloUniverse()
        {
            var page = new IndexModel(_context);
            await page.OnGetAsync();

            var halo = Assert.Single(page.Universes, f => f.Id == "halo");
            Assert.Equal("Halo", halo.Name);
            Assert.True(halo.WorkCount >= 10, $"Expected a starter catalog, found {halo.WorkCount} works");
        }

        [Fact]
        public async Task HaloPage_ListsMoviesTvGamesAndBooksInSettingOrder()
        {
            var page = new UniverseModel(_context);
            await page.OnGetAsync("halo");

            Assert.NotNull(page.Universe);
            var kinds = page.Works.Select(w => w.Kind).Distinct().ToList();
            Assert.Contains(FranchiseWorkKind.Movie, kinds);
            Assert.Contains(FranchiseWorkKind.TVShow, kinds);
            Assert.Contains(FranchiseWorkKind.Game, kinds);
            Assert.Contains(FranchiseWorkKind.Book, kinds);

            AssertWork(page.Works, "Halo Legends", FranchiseWorkKind.Movie, "Legends", "/Media/Details", "media-halo-legends");
            AssertWork(page.Works, "Halo season 1", FranchiseWorkKind.TVShow, "Silver", "/Media/Details", "media-halo-s1");
            AssertWork(page.Works, "Halo: Combat Evolved", FranchiseWorkKind.Game, "Games", "/Games/Game", "halo");
            AssertWork(page.Works, "Halo: The Fall of Reach", FranchiseWorkKind.Book, "Novels", "/Books/Book", "Halo: The Fall of Reach");

            var titles = page.Works.Select(w => w.Title).ToList();
            Assert.True(titles.IndexOf("Halo: Contact Harvest") < titles.IndexOf("Halo: Combat Evolved"));
            Assert.True(titles.IndexOf("Halo: Combat Evolved") < titles.IndexOf("Halo Infinite"));

            var settingYears = page.Works
                .Where(w => w.SettingYear.HasValue)
                .Select(w => w.SettingYear!.Value)
                .ToList();
            Assert.True(settingYears.Count > 1, "Expected setting years so chronology sort can work");
            Assert.Equal(settingYears.OrderBy(y => y).ToList(), settingYears);
        }

        [Fact]
        public async Task HaloPage_FiltersBySilverBranch()
        {
            var page = new UniverseModel(_context)
            {
                SelectedBranches = new List<string> { "Silver" },
                SelectedKinds = new List<string>
                {
                    nameof(FranchiseWorkKind.Movie),
                    nameof(FranchiseWorkKind.TVShow),
                    nameof(FranchiseWorkKind.Game),
                    nameof(FranchiseWorkKind.Book)
                }
            };
            await page.OnGetAsync("halo");

            var titles = page.Works.Select(w => w.Title).ToList();
            Assert.Contains("Halo season 1", titles);
            Assert.Contains("Halo season 2", titles);
            Assert.DoesNotContain("Halo: Combat Evolved", titles);
            Assert.DoesNotContain("Halo Legends", titles);
        }

        [Fact]
        public async Task Index_ListsLordOfTheRingsUniverse()
        {
            var page = new IndexModel(_context);
            await page.OnGetAsync();

            var lotr = Assert.Single(page.Universes, f => f.Id == "lord-of-the-rings");
            Assert.Equal("Lord of the Rings", lotr.Name);
            Assert.True(lotr.WorkCount >= 10, $"Expected a starter catalog, found {lotr.WorkCount} works");
        }

        [Fact]
        public async Task LordOfTheRingsPage_ListsMoviesTvGamesAndBooksInSettingOrder()
        {
            var page = new UniverseModel(_context);
            await page.OnGetAsync("lord-of-the-rings");

            Assert.NotNull(page.Universe);
            var kinds = page.Works.Select(w => w.Kind).Distinct().ToList();
            Assert.Contains(FranchiseWorkKind.Movie, kinds);
            Assert.Contains(FranchiseWorkKind.TVShow, kinds);
            Assert.Contains(FranchiseWorkKind.Game, kinds);
            Assert.Contains(FranchiseWorkKind.Book, kinds);

            AssertWork(page.Works, "The Lord of the Rings: The Fellowship of the Ring", FranchiseWorkKind.Movie, "Jackson", "/Media/Details", "media-lotr-fellowship");
            AssertWork(page.Works, "The Lord of the Rings: The Rings of Power season 1", FranchiseWorkKind.TVShow, "Rings of Power", "/Media/Details", "media-rings-of-power-s1");
            AssertWork(page.Works, "The Lord of the Rings: The Battle for Middle-earth", FranchiseWorkKind.Game, "Games", "/Games/Game", "lotrbfme");
            AssertWork(page.Works, "The Fellowship of the Ring", FranchiseWorkKind.Book, "Books", "/Books/Book", "The Fellowship of the Ring");

            var titles = page.Works.Select(w => w.Title).ToList();
            Assert.True(titles.IndexOf("The Lord of the Rings: The Rings of Power season 1") < titles.IndexOf("The Hobbit"));
            Assert.True(titles.IndexOf("The Hobbit") < titles.IndexOf("The Fellowship of the Ring"));

            var fellowship = Assert.Single(page.Works, w => w.Title == "The Fellowship of the Ring" && w.Kind == FranchiseWorkKind.Book);
            Assert.Equal(SettingCalendar.MiddleEarth, fellowship.SettingCalendar);
            Assert.Equal(3018, fellowship.SettingYear);
            Assert.Equal("3018 TA", ViewHelper.FormatSettingYear(fellowship.SettingYear, fellowship.SettingCalendar));

            var ringsOfPower = Assert.Single(page.Works, w => w.Title == "The Lord of the Rings: The Rings of Power season 1");
            Assert.Equal(-1600, ringsOfPower.SettingYear);
            Assert.Equal("1600 SA", ViewHelper.FormatSettingYear(ringsOfPower.SettingYear, ringsOfPower.SettingCalendar));

            var settingYears = page.Works
                .Where(w => w.SettingYear.HasValue)
                .Select(w => w.SettingYear!.Value)
                .ToList();
            Assert.True(settingYears.Count > 1, "Expected setting years so chronology sort can work");
            Assert.Equal(settingYears.OrderBy(y => y).ToList(), settingYears);
        }

        [Fact]
        public async Task LordOfTheRingsPage_FiltersByJacksonBranch()
        {
            var page = new UniverseModel(_context)
            {
                SelectedBranches = new List<string> { "Jackson" },
                SelectedKinds = new List<string>
                {
                    nameof(FranchiseWorkKind.Movie),
                    nameof(FranchiseWorkKind.TVShow),
                    nameof(FranchiseWorkKind.Game),
                    nameof(FranchiseWorkKind.Book)
                }
            };
            await page.OnGetAsync("lord-of-the-rings");

            var titles = page.Works.Select(w => w.Title).ToList();
            Assert.Contains("The Lord of the Rings: The Fellowship of the Ring", titles);
            Assert.Contains("The Hobbit: An Unexpected Journey", titles);
            Assert.DoesNotContain("The Fellowship of the Ring", titles);
            Assert.DoesNotContain("The Lord of the Rings: The Rings of Power season 1", titles);
        }

        [Fact]
        public void FormatSettingYear_UsesCalendarSuffixes()
        {
            Assert.Equal("10191 AG", ViewHelper.FormatSettingYear(10191, SettingCalendar.AfterGuild));
            Assert.Equal("200 BG", ViewHelper.FormatSettingYear(-200, SettingCalendar.AfterGuild));
            Assert.Equal("0 AG", ViewHelper.FormatSettingYear(0, SettingCalendar.AfterGuild));
            Assert.Equal("3018 TA", ViewHelper.FormatSettingYear(3018, SettingCalendar.MiddleEarth));
            Assert.Equal("1600 SA", ViewHelper.FormatSettingYear(-1600, SettingCalendar.MiddleEarth));
            Assert.Equal("0 TA", ViewHelper.FormatSettingYear(0, SettingCalendar.MiddleEarth));
            Assert.Equal("200 BC", ViewHelper.FormatSettingYear(-200, SettingCalendar.Gregorian));
            Assert.Equal("43", ViewHelper.FormatSettingYear(43, SettingCalendar.Gregorian));
            Assert.Equal("—", ViewHelper.FormatSettingYear(null, SettingCalendar.AfterGuild));
        }

        [Fact]
        public void GetEra_UsesDuneLabelForAfterGuild()
        {
            Assert.Equal("Dune", ASP_site.Pages.Years.IndexModel.GetEra(43, SettingCalendar.AfterGuild));
            Assert.Equal("Dune", ASP_site.Pages.Years.IndexModel.GetEra(-200, SettingCalendar.AfterGuild));
            Assert.Equal("Latter Classical", ASP_site.Pages.Years.IndexModel.GetEra(43, SettingCalendar.Gregorian));
            Assert.Equal("Third Age", ASP_site.Pages.Years.IndexModel.GetEra(3018, SettingCalendar.MiddleEarth));
            Assert.Equal("Second Age", ASP_site.Pages.Years.IndexModel.GetEra(-1600, SettingCalendar.MiddleEarth));
        }

        [Fact]
        public async Task BookDetails_ShowsUniverseBackLink()
        {
            var page = new ASP_site.Pages.Books.BookModel(_context);
            await page.OnGetAsync("Dune");

            Assert.NotNull(page.Book);
            var universe = Assert.Single(page.Universes);
            Assert.Equal("dune", universe.FranchiseID);
        }

        [Fact]
        public async Task FoundationPage_ListsRobotEmpireAndFoundationBooksInSettingOrder()
        {
            var page = new UniverseModel(_context);
            await page.OnGetAsync("foundation");

            Assert.NotNull(page.Universe);
            Assert.Equal("Foundation Universe", page.Universe!.Name);
            Assert.Contains(FranchiseWorkKind.Book, page.Works.Select(w => w.Kind));

            AssertWork(page.Works, "Robbie", FranchiseWorkKind.Book, "Robot", "/Books/Book", "Robbie");
            AssertWork(page.Works, "The Caves of Steel", FranchiseWorkKind.Book, "Robot", "/Books/Book", "The Caves of Steel");
            AssertWork(page.Works, "Pebble in the Sky", FranchiseWorkKind.Book, "Empire", "/Books/Book", "Pebble in the Sky");
            AssertWork(page.Works, "Prelude to Foundation", FranchiseWorkKind.Book, "Foundation", "/Books/Book", "Prelude to Foundation");

            var titles = page.Works.Select(w => w.Title).ToList();
            Assert.True(titles.IndexOf("Robbie") < titles.IndexOf("The Caves of Steel"));
            Assert.True(titles.IndexOf("The Caves of Steel") < titles.IndexOf("Prelude to Foundation"));

            var robbie = Assert.Single(page.Works, w => w.Title == "Robbie");
            Assert.Equal(1998, robbie.SettingYear);
            var caves = Assert.Single(page.Works, w => w.Title == "The Caves of Steel");
            Assert.Equal(3421, caves.SettingYear);
            var prelude = Assert.Single(page.Works, w => w.Title == "Prelude to Foundation");
            Assert.Equal(23604, prelude.SettingYear);

            var settingYears = page.Works
                .Where(w => w.SettingYear.HasValue)
                .Select(w => w.SettingYear!.Value)
                .ToList();
            Assert.True(settingYears.Count > 1, "Expected setting years so chronology sort can work");
            Assert.Equal(settingYears.OrderBy(y => y).ToList(), settingYears);
        }

        [Fact]
        public async Task FoundationPage_FiltersByRobotBranch()
        {
            var page = new UniverseModel(_context)
            {
                SelectedBranches = new List<string> { "Robot" },
                SelectedKinds = new List<string> { nameof(FranchiseWorkKind.Book) }
            };
            await page.OnGetAsync("foundation");

            var titles = page.Works.Select(w => w.Title).ToList();
            Assert.Contains("The Caves of Steel", titles);
            Assert.Contains("I, Robot", titles);
            Assert.DoesNotContain("Prelude to Foundation", titles);
            Assert.DoesNotContain("Pebble in the Sky", titles);
        }

        [Fact]
        public async Task BookDetails_ShowsFoundationUniverseBackLink()
        {
            var page = new ASP_site.Pages.Books.BookModel(_context);
            await page.OnGetAsync("The Caves of Steel");

            Assert.NotNull(page.Book);
            var universe = Assert.Single(page.Universes);
            Assert.Equal("foundation", universe.FranchiseID);
        }

        [Fact]
        public async Task AsimovAuthorPage_ListsUniverseBranchesAsTags()
        {
            var page = new ASP_site.Pages.Books.Asimov.IndexModel(_context);
            await page.OnGetAsync();

            Assert.Contains("Foundation Universe", page.AllTags.Keys);
            Assert.Contains("Robot", page.AllTags.Keys);
            Assert.Contains("Empire", page.AllTags.Keys);
            Assert.Contains("Foundation", page.AllTags.Keys);

            var caves = Assert.Single(page.Books, b => b.Title == "The Caves of Steel");
            Assert.Contains(caves.Tags, t => t.Name == "Robot");
            Assert.Contains(caves.Tags, t => t.Name == "Foundation Universe");
        }

        [Fact]
        public async Task AsimovAuthorPage_FiltersByRobotUniverseTag()
        {
            var page = new ASP_site.Pages.Books.Asimov.IndexModel(_context)
            {
                SelectedTags = new List<string> { "Robot" }
            };
            await page.OnGetAsync();

            var titles = page.Books.Select(b => b.Title).ToList();
            Assert.Contains("The Caves of Steel", titles);
            Assert.Contains("I, Robot", titles);
            Assert.DoesNotContain("Prelude to Foundation", titles);
            Assert.DoesNotContain("Pebble in the Sky", titles);
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
