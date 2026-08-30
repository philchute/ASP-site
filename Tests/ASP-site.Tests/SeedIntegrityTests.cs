using System.Text.RegularExpressions;
using ASP_site.Data;
using ASP_site.Data.Initializers;
using ASP_site.Helpers;
using ASP_site.Models;
using ASP_site.Models.Gunpla;
using Microsoft.EntityFrameworkCore;

namespace ASP_site.Tests
{
    public class SeedFixture
    {
        public GameContext Context { get; }

        public SeedFixture()
        {
            var options = new DbContextOptionsBuilder<GameContext>()
                .UseInMemoryDatabase("SeedIntegrity-" + Guid.NewGuid())
                .Options;
            Context = new GameContext(options);
            Context.Database.EnsureCreated();
            DbInitializer.Initialize(Context);
        }
    }

    public class SeedIntegrityTests : IClassFixture<SeedFixture>
    {
        private readonly GameContext _context;

        public SeedIntegrityTests(SeedFixture fixture)
        {
            _context = fixture.Context;
        }

        [Fact]
        public void ComicIssueIds_AreUnique()
        {
            var dupes = DuplicateKeys(ComicInitializer.GetComicIssues().Select(i => i.IssueID));
            Assert.True(dupes.Count == 0, FormatDupes("ComicIssue.IssueID", dupes));
        }

        [Fact]
        public void StoryArcIds_AreUnique()
        {
            var dupes = DuplicateKeys(ComicInitializer.GetStoryArcs().Select(a => a.ArcID));
            Assert.True(dupes.Count == 0, FormatDupes("StoryArc.ArcID", dupes));
        }

        [Fact]
        public void CollectedEditionIds_AreUnique()
        {
            var dupes = DuplicateKeys(ComicInitializer.GetCollectedEditions().Select(e => e.EditionID));
            Assert.True(dupes.Count == 0, FormatDupes("CollectedEdition.EditionID", dupes));
        }

        [Fact]
        public void MediaIds_AreUnique()
        {
            var dupes = DuplicateKeys(
                ComicInitializer.GetMedia()
                    .Concat(StarTrekInitializer.GetMedia())
                    .Concat(DuneInitializer.GetMedia())
                    .Concat(HaloInitializer.GetMedia())
                    .Concat(LordOfTheRingsInitializer.GetMedia())
                    .Select(m => m.MediaID));
            Assert.True(dupes.Count == 0, FormatDupes("Media.MediaID", dupes));
        }

        [Fact]
        public void GameIds_AreUnique()
        {
            var dupes = DuplicateKeys(GameInitializer.GetGames().Select(g => g.GameID));
            Assert.True(dupes.Count == 0, FormatDupes("Game.GameID", dupes));
        }

        [Fact]
        public void ThreeNetworksGameIds_MatchMasterSlugRules()
        {
            var invalid = GameInitializer.GetGames()
                .Where(g => g.ServerConfig?.UsesThreeNetworks == true)
                .Select(g => new
                {
                    g.GameID,
                    Slug = g.ServerConfig!.GetMasterGameName(g.GameID)
                })
                .Where(x => string.IsNullOrWhiteSpace(x.Slug) ||
                            x.Slug.Length > 20 ||
                            x.Slug.Any(c => !(char.IsLetterOrDigit(c) || c == '_')))
                .Select(x => $"{x.GameID} -> '{x.Slug}'")
                .ToList();

            Assert.True(invalid.Count == 0,
                "333networks slugs must be 1-20 word characters (GameID or MasterGameName):\n" +
                string.Join("\n", invalid));
        }

        [Fact]
        public void SteamApiBrowserGames_HaveSteamId()
        {
            var missing = GameInitializer.GetGames()
                .Where(g => g.ServerConfig?.UsesSteamApi == true && g.SteamID is null or 0)
                .Select(g => g.GameID)
                .ToList();

            Assert.True(missing.Count == 0,
                "Steam Web API browser games need a SteamID (HL1 mods use 70):\n" +
                string.Join("\n", missing));
        }

        [Fact]
        public void GoldSourceAndSourceMasterKeys_AreNotUsed()
        {
            var leftover = GameInitializer.GetGames()
                .Where(g => g.ServerConfig?.MasterServerKey is "GoldSource" or "Source")
                .Select(g => g.GameID)
                .ToList();

            Assert.True(leftover.Count == 0,
                "GoldSrc/Source listings should use Steam Web API, not UDP masters:\n" +
                string.Join("\n", leftover));
        }

        [Fact]
        public void IdTech3BrowserGames_HaveMasterKeyAndProtocols()
        {
            var invalid = GameInitializer.GetGames()
                .Where(g => g.ServerConfig?.UsesIdTech3 == true)
                .Select(g => new
                {
                    g.GameID,
                    g.ServerConfig!.MasterServerKey,
                    Queries = g.ServerConfig.GetMasterProtocolQueries().ToList()
                })
                .Where(x => string.IsNullOrWhiteSpace(x.MasterServerKey) || x.Queries.Count == 0)
                .Select(x => x.GameID)
                .ToList();

            Assert.True(invalid.Count == 0,
                "IdTech3 browser games need MasterServerKey and MasterProtocols:\n" +
                string.Join("\n", invalid));
        }

        [Fact]
        public void EngineIds_AreUnique()
        {
            var dupes = DuplicateKeys(EngineInitializer.GetEngines().Select(e => e.EngineID));
            Assert.True(dupes.Count == 0, FormatDupes("Engine.EngineID", dupes));
        }

        [Fact]
        public void GameEngineIds_ResolveToEngines()
        {
            var engineIds = _context.Engines.Select(e => e.EngineID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = _context.Games
                .Where(g => !string.IsNullOrEmpty(g.EngineID) && !engineIds.Contains(g.EngineID!))
                .Select(g => $"{g.GameID}: {g.EngineID}")
                .Distinct()
                .ToList();
            Assert.True(missing.Count == 0, "Game.EngineID values with no matching Engine:\n" + string.Join("\n", missing));
        }

        [Fact]
        public void EngineParentIds_ResolveToEngines()
        {
            var engineIds = _context.Engines.Select(e => e.EngineID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = _context.Engines
                .Where(e => !string.IsNullOrEmpty(e.ParentID) && !engineIds.Contains(e.ParentID))
                .Select(e => $"{e.EngineID}: {e.ParentID}")
                .ToList();
            Assert.True(missing.Count == 0, "Engine.ParentID values with no matching Engine:\n" + string.Join("\n", missing));
        }

        [Fact]
        public void EngineDebutGameIds_ResolveToGames()
        {
            var gameIds = _context.Games.Select(g => g.GameID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = _context.Engines
                .Where(e => !string.IsNullOrEmpty(e.DebutGameID) && !gameIds.Contains(e.DebutGameID!))
                .Select(e => $"{e.EngineID}: {e.DebutGameID}")
                .ToList();
            Assert.True(missing.Count == 0, "Engine.DebutGameID values with no matching Game:\n" + string.Join("\n", missing));
        }

        [Fact]
        public void YearEntryGameIds_ResolveToGames()
        {
            var gameIds = _context.Games.Select(g => g.GameID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = _context.YearEntries
                .Where(e => !string.IsNullOrEmpty(e.GameID) && !gameIds.Contains(e.GameID!))
                .Select(e => $"{e.Title}: {e.GameID}")
                .ToList();

            Assert.True(missing.Count == 0, "YearEntry.GameID values with no matching Game:\n" + string.Join("\n", missing));
        }

        [Fact]
        public void YearEntry_DoesNotUseLegacyAoe1Id()
        {
            var leftover = YearEntryInitializer.GetYearEntries()
                .Where(e => e.GameID == "aoe1")
                .Select(e => e.Title)
                .ToList();
            Assert.True(leftover.Count == 0, "YearEntry still uses GameID aoe1 (should be aoe):\n" + string.Join("\n", leftover));
        }

        [Fact]
        public void Games_WithSettingYear_HaveAge()
        {
            var missing = _context.Games
                .Where(g => g.SettingYear.HasValue && g.Age == null)
                .Select(g => g.GameID)
                .ToList();
            Assert.True(missing.Count == 0, "Games with SettingYear but no Age:\n" + string.Join("\n", missing));
        }

        [Fact]
        public void YearEntry_TypeGame_DoesNotDuplicateCatalogSettingYear()
        {
            var gamesWithSettingYear = _context.Games
                .Where(g => g.SettingYear.HasValue)
                .Select(g => g.GameID)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            var dupes = YearEntryInitializer.GetYearEntries()
                .Where(e => e.Type == ContentType.Game
                    && !string.IsNullOrEmpty(e.GameID)
                    && gamesWithSettingYear.Contains(e.GameID!))
                .Select(e => $"{e.Title}: {e.GameID}")
                .ToList();

            Assert.True(dupes.Count == 0, "Type=Game YearEntries that duplicate a Game.SettingYear row:\n" + string.Join("\n", dupes));
        }

        [Fact]
        public void AdaptedFromArcIds_ResolveToStoryArcs()
        {
            var arcIds = _context.StoryArcs.Select(a => a.ArcID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = new List<string>();

            foreach (var media in _context.Media.Include(m => m.AdaptedFromArcs).ToList())
            {
                foreach (var arc in media.AdaptedFromArcs)
                {
                    if (!arcIds.Contains(arc.ArcID))
                    {
                        missing.Add($"Media {media.MediaID}: {arc.ArcID}");
                    }
                }
            }

            foreach (var game in _context.Games.Include(g => g.AdaptedFromArcs).ToList())
            {
                foreach (var id in game.AdaptedFromArcIDs)
                {
                    if (!arcIds.Contains(id))
                    {
                        missing.Add($"Game {game.GameID}: {id}");
                    }
                }
            }

            foreach (var book in _context.Books.ToList())
            {
                foreach (var id in book.AdaptedFromArcIDs)
                {
                    if (!arcIds.Contains(id))
                    {
                        missing.Add($"Book {book.Title}: {id}");
                    }
                }
            }

            Assert.True(missing.Count == 0, "AdaptedFromArcIDs with no matching StoryArc:\n" + string.Join("\n", missing));
        }

        [Fact]
        public void StoryArcIssueIds_ResolveToComicIssues()
        {
            var issueIds = _context.ComicIssues.Select(i => i.IssueID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = _context.StoryArcs
                .AsEnumerable()
                .SelectMany(arc => arc.IssueIDs
                    .Where(id => !string.IsNullOrWhiteSpace(id) && !issueIds.Contains(id))
                    .Select(id => $"{arc.ArcID}: {id}"))
                .ToList();

            Assert.True(missing.Count == 0, "StoryArc.IssueIDs with no matching ComicIssue:\n" + string.Join("\n", missing));
        }

        [Fact]
        public void CollectedEditionIssueIds_ResolveToComicIssues()
        {
            var issueIds = _context.ComicIssues.Select(i => i.IssueID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = _context.CollectedEditions
                .AsEnumerable()
                .SelectMany(ed => ed.CollectedIssueIDs
                    .Where(id => !string.IsNullOrWhiteSpace(id) && !issueIds.Contains(id))
                    .Select(id => $"{ed.EditionID}: {id}"))
                .ToList();

            Assert.True(missing.Count == 0, "CollectedEdition.CollectedIssueIDs with no matching ComicIssue:\n" + string.Join("\n", missing));
        }

        [Fact]
        public void ChessPlacements_PieceIdsResolve()
        {
            var pieceIds = _context.ChessPieces.Select(p => p.PieceID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = _context.Variants
                .Include(v => v.Placements)
                .AsEnumerable()
                .SelectMany(v => v.Placements
                    .Where(p => !pieceIds.Contains(p.PieceId))
                    .Select(p => $"{v.VariantID}: {p.PieceId}"))
                .Distinct()
                .ToList();

            Assert.True(missing.Count == 0, "Chess placements with no matching PieceID:\n" + string.Join("\n", missing));
        }

        [Fact]
        public void Gundam_MsgSeriesMapsToUniversalCentury()
        {
            Assert.Equal(GunplaConstants.Timelines.UC, GundamHelpers.GetTimeline("MSG"));
            Assert.Equal(GunplaConstants.Timelines.UC, GundamHelpers.GetTimeline(GunplaConstants.Series.MSG));
        }

        [Fact]
        public void Gundam_GetAllTimelines_IncludesMoreThanUcAndOther()
        {
            var timelines = _context.Gundams
                .AsEnumerable()
                .SelectMany(g => g.Series)
                .Select(GundamHelpers.GetTimeline)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            Assert.Contains(GunplaConstants.Timelines.UC, timelines);
            Assert.True(timelines.Count > 2, "Expected more than UC/Other after resolving series keys. Got: " + string.Join(", ", timelines));
        }

        [Fact]
        public void BookSlugs_AreUniqueAndPopulated()
        {
            var books = _context.Books.ToList();
            Assert.All(books, b => Assert.False(string.IsNullOrWhiteSpace(b.Slug), $"Missing slug for '{b.Title}'"));
            var dupes = DuplicateKeys(books.Select(b => b.Slug!));
            Assert.True(dupes.Count == 0, FormatDupes("Book.Slug", dupes));
        }

        [Fact]
        public void Links_DoNotUseLegacyAoe1Id()
        {
            var leftover = LinkInitializer.GetLinks()
                .Where(l => l.GameID == "aoe1")
                .Select(l => l.Label)
                .ToList();
            Assert.True(leftover.Count == 0, "Links still use GameID aoe1 (should be aoe):\n" + string.Join("\n", leftover));
        }

        [Fact]
        public void LinkGameIds_ResolveToGames()
        {
            var gameIds = _context.Games.Select(g => g.GameID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = _context.Links
                .Where(l => !string.IsNullOrEmpty(l.GameID) && !gameIds.Contains(l.GameID!))
                .Select(l => $"{l.Label}: {l.GameID}")
                .Distinct()
                .ToList();
            Assert.True(missing.Count == 0, "Link.GameID values with no matching Game:\n" + string.Join("\n", missing));
        }

        [Fact]
        public void FranchiseIds_AreUnique()
        {
            var (franchises, _) = FranchiseInitializer.GetData();
            var dupes = DuplicateKeys(franchises.Select(f => f.FranchiseID));
            Assert.True(dupes.Count == 0, FormatDupes("Franchise.FranchiseID", dupes));
        }

        [Fact]
        public void FranchiseWorkForeignKeys_Resolve()
        {
            var franchiseIds = _context.Franchises.Select(f => f.FranchiseID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var gameIds = _context.Games.Select(g => g.GameID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var bookTitles = _context.Books.Select(b => b.Title).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var mediaIds = _context.Media.Select(m => m.MediaID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var arcIds = _context.StoryArcs.Select(a => a.ArcID).ToHashSet(StringComparer.OrdinalIgnoreCase);

            var missing = new List<string>();
            foreach (var work in _context.FranchiseWorks.ToList())
            {
                if (!franchiseIds.Contains(work.FranchiseID))
                {
                    missing.Add($"Work {work.Id}: FranchiseID {work.FranchiseID}");
                }

                var populated = new[] { work.GameID, work.BookTitle, work.MediaID, work.StoryArcID }
                    .Count(id => !string.IsNullOrEmpty(id));
                if (populated != 1)
                {
                    missing.Add($"Work {work.Id} ({work.Kind}): expected exactly one catalog key, found {populated}");
                }

                if (!string.IsNullOrEmpty(work.GameID) && !gameIds.Contains(work.GameID))
                {
                    missing.Add($"Work {work.Id}: GameID {work.GameID}");
                }
                if (!string.IsNullOrEmpty(work.BookTitle) && !bookTitles.Contains(work.BookTitle))
                {
                    missing.Add($"Work {work.Id}: BookTitle {work.BookTitle}");
                }
                if (!string.IsNullOrEmpty(work.MediaID) && !mediaIds.Contains(work.MediaID))
                {
                    missing.Add($"Work {work.Id}: MediaID {work.MediaID}");
                }
                if (!string.IsNullOrEmpty(work.StoryArcID) && !arcIds.Contains(work.StoryArcID))
                {
                    missing.Add($"Work {work.Id}: StoryArcID {work.StoryArcID}");
                }
            }

            Assert.True(missing.Count == 0, "FranchiseWork keys that do not resolve:\n" + string.Join("\n", missing));
        }

        [Fact]
        public void GenreMarkdownGameLinks_ResolveToGames()
        {
            var markdownDir = Path.Combine(FindWebRoot(), "markdown", "genres");
            Assert.True(Directory.Exists(markdownDir), $"Genre markdown directory not found: {markdownDir}");

            var gameIds = _context.Games.Select(g => g.GameID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = new List<string>();
            var gameLink = new Regex(@"\]\(/Games/([^)\s#]+)\)");
            var linkedCount = 0;

            foreach (var file in Directory.GetFiles(markdownDir, "*.md"))
            {
                var text = File.ReadAllText(file);
                var fileName = Path.GetFileName(file);
                foreach (Match match in gameLink.Matches(text))
                {
                    linkedCount++;
                    var id = match.Groups[1].Value;
                    if (!gameIds.Contains(id))
                    {
                        missing.Add($"{fileName}: {id}");
                    }
                }
            }

            Assert.True(linkedCount >= 20, $"Expected genre essays to link to catalog games, found {linkedCount} /Games/{{id}} links");
            Assert.True(missing.Count == 0, "Genre markdown /Games/{id} links with no matching Game:\n" + string.Join("\n", missing));
        }

        private static string FindWebRoot()
        {
            var dir = new DirectoryInfo(AppContext.BaseDirectory);
            while (dir != null)
            {
                var wwwroot = Path.Combine(dir.FullName, "wwwroot");
                if (Directory.Exists(wwwroot) && File.Exists(Path.Combine(dir.FullName, "ASP-site.csproj")))
                {
                    return wwwroot;
                }
                dir = dir.Parent;
            }

            throw new DirectoryNotFoundException("Could not locate wwwroot from " + AppContext.BaseDirectory);
        }

        private static Dictionary<string, int> DuplicateKeys(IEnumerable<string> ids)
        {
            return ids
                .Where(id => !string.IsNullOrWhiteSpace(id))
                .GroupBy(id => id, StringComparer.OrdinalIgnoreCase)
                .Where(g => g.Count() > 1)
                .ToDictionary(g => g.Key, g => g.Count(), StringComparer.OrdinalIgnoreCase);
        }

        private static string FormatDupes(string label, Dictionary<string, int> dupes)
        {
            if (dupes.Count == 0) return "";
            return $"{label} duplicates:\n" + string.Join("\n", dupes.Select(kv => $"  {kv.Key} x{kv.Value}"));
        }

        private static IEnumerable<string> SplitArcIds(IEnumerable<string>? ids)
        {
            if (ids == null) yield break;
            foreach (var raw in ids)
            {
                foreach (var part in raw.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
                {
                    yield return part;
                }
            }
        }
    }
}
