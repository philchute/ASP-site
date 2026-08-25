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
                .UseInMemoryDatabase("SeedIntegrity")
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
            var dupes = DuplicateKeys(ComicInitializer.GetMedia().Select(m => m.MediaID));
            Assert.True(dupes.Count == 0, FormatDupes("Media.MediaID", dupes));
        }

        [Fact]
        public void GameIds_AreUnique()
        {
            var dupes = DuplicateKeys(GameInitializer.GetGames().Select(g => g.GameID));
            Assert.True(dupes.Count == 0, FormatDupes("Game.GameID", dupes));
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
        public void AdaptedFromArcIds_ResolveToStoryArcs()
        {
            var arcIds = _context.StoryArcs.Select(a => a.ArcID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = new List<string>();

            foreach (var media in ComicInitializer.GetMedia())
            {
                foreach (var id in SplitArcIds(media.AdaptedFromArcIDs))
                {
                    if (!arcIds.Contains(id))
                    {
                        missing.Add($"Media {media.MediaID}: {id}");
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
            var knownUncatalogued = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "prey", "kof" };
            var gameIds = _context.Games.Select(g => g.GameID).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var missing = _context.Links
                .Where(l => !string.IsNullOrEmpty(l.GameID)
                    && !gameIds.Contains(l.GameID!)
                    && !knownUncatalogued.Contains(l.GameID!))
                .Select(l => $"{l.Label}: {l.GameID}")
                .Distinct()
                .ToList();
            Assert.True(missing.Count == 0, "Link.GameID values with no matching Game:\n" + string.Join("\n", missing));
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
