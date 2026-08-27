using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Models;

namespace ASP_site.Pages.Universe
{
    public class UniverseModel : PageModel
    {
        private static readonly FranchiseWorkKind[] KindOrder =
        [
            FranchiseWorkKind.Movie,
            FranchiseWorkKind.TVShow,
            FranchiseWorkKind.Game,
            FranchiseWorkKind.Book,
            FranchiseWorkKind.ComicArc
        ];

        private readonly GameContext _context;

        public UniverseModel(GameContext context)
        {
            _context = context;
            SortOptions = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Value = "Setting", Text = "Setting year" },
                new SelectListItem { Value = "Released", Text = "Released" },
                new SelectListItem { Value = "Title", Text = "Title" }
            }, "Value", "Text");
        }

        public Franchise? Universe { get; set; }
        public List<FranchiseWork> Works { get; set; } = new();

        public Dictionary<string, string> AllBranches { get; private set; } = new();
        public Dictionary<string, string> AllKinds { get; private set; } = new();
        public Dictionary<string, string> AllCollections { get; private set; } = new();

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedBranches { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedKinds { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedCollections { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string SortField { get; set; } = "Setting";

        public SelectList SortOptions { get; set; }

        public async Task OnGetAsync(string id)
        {
            Universe = await _context.Franchises
                .AsNoTracking()
                .FirstOrDefaultAsync(f => f.FranchiseID == id);

            if (Universe == null)
            {
                return;
            }

            var works = await _context.FranchiseWorks
                .AsNoTracking()
                .Where(w => w.FranchiseID == id)
                .ToListAsync();

            await ResolveCatalogAsync(works);

            AllBranches = works
                .Select(w => w.Branch)
                .Where(b => !string.IsNullOrEmpty(b))
                .Distinct()
                .OrderBy(b => b)
                .ToDictionary(b => b, FranchiseWork.FormatBranch);

            AllKinds = KindOrder
                .Where(k => works.Any(w => w.Kind == k))
                .ToDictionary(k => k.ToString(), FranchiseWork.FormatKind);

            AllCollections = works
                .SelectMany(w => w.CollectionNames)
                .Distinct()
                .OrderBy(t => t)
                .ToDictionary(t => t, t => t.Replace("Collection: ", ""));

            if (!SelectedBranches.Any())
            {
                SelectedBranches = AllBranches.Keys.ToList();
            }

            if (!SelectedKinds.Any())
            {
                SelectedKinds = AllKinds.Keys.ToList();
            }

            IEnumerable<FranchiseWork> filtered = works;

            if (!string.IsNullOrEmpty(SearchString))
            {
                filtered = filtered.Where(w =>
                    w.Title.Contains(SearchString, StringComparison.OrdinalIgnoreCase));
            }

            if (SelectedBranches.Any())
            {
                filtered = filtered.Where(w => SelectedBranches.Contains(w.Branch));
            }

            if (SelectedKinds.Any())
            {
                filtered = filtered.Where(w => SelectedKinds.Contains(w.Kind.ToString()));
            }

            if (SelectedCollections.Any())
            {
                filtered = filtered.Where(w => w.CollectionNames.Any(c => SelectedCollections.Contains(c)));
            }

            Works = (SortField switch
            {
                "Title" => filtered.OrderBy(w => w.Title),
                "Released" => filtered.OrderBy(w => w.ReleasedYear ?? int.MaxValue).ThenBy(w => w.ReleasedMonth ?? 0).ThenBy(w => w.Title),
                _ => filtered.OrderBy(w => w.SettingYear ?? int.MaxValue).ThenBy(w => w.ReleasedYear ?? int.MaxValue).ThenBy(w => w.Title)
            }).ToList();
        }

        private async Task ResolveCatalogAsync(List<FranchiseWork> works)
        {
            var gameIds = works.Select(w => w.GameID).Where(id => !string.IsNullOrEmpty(id)).Distinct().ToList();
            var bookTitles = works.Select(w => w.BookTitle).Where(t => !string.IsNullOrEmpty(t)).Distinct().ToList();
            var mediaIds = works.Select(w => w.MediaID).Where(id => !string.IsNullOrEmpty(id)).Distinct().ToList();
            var arcIds = works.Select(w => w.StoryArcID).Where(id => !string.IsNullOrEmpty(id)).Distinct().ToList();

            var games = (await _context.Games.AsNoTracking()
                    .Where(g => gameIds.Contains(g.GameID))
                    .ToListAsync())
                .ToDictionary(g => g.GameID, StringComparer.OrdinalIgnoreCase);

            var books = (await _context.Books.AsNoTracking()
                    .Include(b => b.Tags)
                    .Where(b => bookTitles.Contains(b.Title))
                    .ToListAsync())
                .ToDictionary(b => b.Title, StringComparer.OrdinalIgnoreCase);

            var media = (await _context.Media.AsNoTracking()
                    .Where(m => mediaIds.Contains(m.MediaID))
                    .ToListAsync())
                .ToDictionary(m => m.MediaID, StringComparer.OrdinalIgnoreCase);

            var arcs = arcIds.Count == 0
                ? new List<StoryArc>()
                : await _context.StoryArcs.AsNoTracking()
                    .Where(a => arcIds.Contains(a.ArcID))
                    .ToListAsync();

            var issueIds = arcs.SelectMany(a => a.IssueIDs).Where(id => !string.IsNullOrWhiteSpace(id)).Distinct().ToList();
            var issuesById = (await _context.ComicIssues.AsNoTracking()
                    .Where(i => issueIds.Contains(i.IssueID))
                    .ToListAsync())
                .ToDictionary(i => i.IssueID, StringComparer.OrdinalIgnoreCase);

            foreach (var work in works)
            {
                if (!string.IsNullOrEmpty(work.GameID) && games.TryGetValue(work.GameID, out var game))
                {
                    work.Title = game.Name;
                    work.SettingYear = game.SettingYear;
                    work.ReleasedYear = game.Year;
                }
                else if (!string.IsNullOrEmpty(work.BookTitle) && books.TryGetValue(work.BookTitle, out var book))
                {
                    work.Title = book.Title;
                    work.SettingYear = book.SettingYear;
                    work.ReleasedYear = book.PublicationYear;
                    work.ReleasedMonth = book.PublicationMonth;
                    work.CollectionNames = book.Tags
                        .Where(t => t.Name.StartsWith("Collection: "))
                        .Select(t => t.Name)
                        .ToList();
                }
                else if (!string.IsNullOrEmpty(work.MediaID) && media.TryGetValue(work.MediaID, out var item))
                {
                    work.Title = item.Title;
                    work.SettingYear = item.SettingYear;
                    work.ReleasedYear = item.ReleaseYear;
                    work.ReleasedMonth = item.ReleaseMonth;
                }
                else if (!string.IsNullOrEmpty(work.StoryArcID))
                {
                    var arc = arcs.FirstOrDefault(a => string.Equals(a.ArcID, work.StoryArcID, StringComparison.OrdinalIgnoreCase));
                    if (arc != null)
                    {
                        work.Title = arc.Title;
                        work.SettingYear = arc.SettingYear;
                        var arcIssues = arc.IssueIDs
                            .Select(id => issuesById.TryGetValue(id, out var issue) ? issue : null)
                            .Where(i => i?.PublishYear != null)
                            .ToList();
                        work.ReleasedYear = arcIssues.Min(i => i!.PublishYear);
                        work.ReleasedMonth = arcIssues
                            .Where(i => i!.PublishYear == work.ReleasedYear)
                            .Min(i => i!.PublishMonth);
                    }
                }

                if (string.IsNullOrEmpty(work.Title))
                {
                    work.Title = work.GameID ?? work.BookTitle ?? work.MediaID ?? work.StoryArcID ?? "(missing)";
                }
            }
        }
    }
}
