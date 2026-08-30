using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Models;

namespace ASP_site.Pages.Books
{
    public abstract class AuthorIndexModelBase : PageModel
    {
        private readonly GameContext _context;

        protected AuthorIndexModelBase(GameContext context)
        {
            _context = context;
            SortOptions = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Value = "Year", Text = "Year" },
                new SelectListItem { Value = "Title", Text = "Title" }
            }, "Value", "Text");
        }

        protected abstract string AuthorName { get; }

        protected virtual bool ListAllBookTypes => false;
        protected virtual bool ExcludePoemFromTypeList => false;

        protected virtual IEnumerable<string> DefaultSelectedTypeKeys(IEnumerable<string> existingTypeKeys) =>
            existingTypeKeys.Where(k => k != nameof(BookType.Forward));

        public IList<Book> Books { get; set; } = new List<Book>();
        public IList<Link> AllLinks { get; set; } = new List<Link>();

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedBookTypes { get; set; } = new List<string>();

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedCollections { get; set; } = new List<string>();

        [BindProperty(SupportsGet = true)]
        public List<string> SelectedTags { get; set; } = new List<string>();

        public Dictionary<string, string> AllBookTypes { get; private set; } = new Dictionary<string, string>();
        public Dictionary<string, string> AllCollections { get; private set; } = new Dictionary<string, string>();
        public Dictionary<string, string> AllTags { get; private set; } = new Dictionary<string, string>();

        [BindProperty(SupportsGet = true)]
        public string SortField { get; set; } = "Year";
        public SelectList SortOptions { get; set; }

        public async Task OnGetAsync()
        {
            var booksIQ = _context.Books
                .Where(b => b.Author == AuthorName)
                .Include(b => b.Tags)
                .AsQueryable();

            var allBooks = await booksIQ.AsNoTracking().ToListAsync();
            AllLinks = await _context.Links.Where(l => l.BookTitle != null).AsNoTracking().ToListAsync();
            await ApplyUniverseTagsAsync(allBooks);

            var existingTypes = allBooks.Select(b => b.Type).Distinct().ToList();
            IEnumerable<BookType> typeSource = Enum.GetValues<BookType>();
            if (ExcludePoemFromTypeList)
            {
                typeSource = typeSource.Where(t => t != BookType.Poem);
            }
            if (!ListAllBookTypes)
            {
                typeSource = typeSource.Where(t => existingTypes.Contains(t));
            }
            AllBookTypes = typeSource.ToDictionary(e => e.ToString(), e => e.ToString());

            if (!SelectedBookTypes.Any())
            {
                SelectedBookTypes = DefaultSelectedTypeKeys(AllBookTypes.Keys).ToList();
            }

            AllCollections = allBooks
                .SelectMany(b => b.Tags)
                .Where(t => t.Name.StartsWith("Collection: "))
                .Select(t => t.Name)
                .Distinct()
                .OrderBy(t => t)
                .ToDictionary(t => t, t => t.Replace("Collection: ", ""));

            AllTags = allBooks
                .SelectMany(b => b.Tags)
                .Where(t => !t.Name.StartsWith("Collection: "))
                .Select(t => t.Name)
                .Distinct()
                .OrderBy(t => t)
                .ToDictionary(t => t, t => t);

            IEnumerable<Book> filtered = allBooks;

            if (!string.IsNullOrEmpty(SearchString))
            {
                filtered = filtered.Where(s =>
                    s.Title.Contains(SearchString, StringComparison.OrdinalIgnoreCase)
                    || (s.Description != null && s.Description.Contains(SearchString, StringComparison.OrdinalIgnoreCase)));
            }

            if (SelectedBookTypes.Any())
            {
                filtered = filtered.Where(x => SelectedBookTypes.Contains(x.Type.ToString()));
            }

            if (SelectedCollections.Any())
            {
                filtered = filtered.Where(b => b.Tags.Any(t => SelectedCollections.Contains(t.Name)));
            }

            if (SelectedTags.Any())
            {
                filtered = filtered.Where(b => b.Tags.Any(t => SelectedTags.Contains(t.Name)));
            }

            Books = (SortField == "Title"
                ? filtered.OrderBy(b => b.Title)
                : filtered.OrderBy(b => b.PublicationYear).ThenBy(b => b.PublicationMonth).ThenBy(b => b.Title))
                .ToList();
        }

        private async Task ApplyUniverseTagsAsync(List<Book> books)
        {
            if (books.Count == 0)
            {
                return;
            }

            var titles = books.Select(b => b.Title).ToList();
            var works = await _context.FranchiseWorks
                .AsNoTracking()
                .Where(w => w.BookTitle != null && titles.Contains(w.BookTitle))
                .Select(w => new { w.BookTitle, w.Branch, w.FranchiseID })
                .ToListAsync();

            if (works.Count == 0)
            {
                return;
            }

            var franchiseIds = works.Select(w => w.FranchiseID).Distinct().ToList();
            var franchiseNames = await _context.Franchises
                .AsNoTracking()
                .Where(f => franchiseIds.Contains(f.FranchiseID))
                .ToDictionaryAsync(f => f.FranchiseID, f => f.Name);

            var tagsByTitle = works
                .GroupBy(w => w.BookTitle!, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(
                    g => g.Key,
                    g => g.SelectMany(w => UniverseTagNames(w.Branch, franchiseNames.GetValueOrDefault(w.FranchiseID)))
                        .Distinct(StringComparer.OrdinalIgnoreCase)
                        .ToList(),
                    StringComparer.OrdinalIgnoreCase);

            foreach (var book in books)
            {
                if (!tagsByTitle.TryGetValue(book.Title, out var names))
                {
                    continue;
                }

                var existing = book.Tags
                    .Select(t => t.Name)
                    .ToHashSet(StringComparer.OrdinalIgnoreCase);

                foreach (var name in names)
                {
                    if (existing.Add(name))
                    {
                        book.Tags.Add(new Tag { Name = name });
                    }
                }
            }
        }

        private static IEnumerable<string> UniverseTagNames(string branch, string? franchiseName)
        {
            if (!string.IsNullOrWhiteSpace(franchiseName))
            {
                yield return franchiseName;
            }

            if (!string.IsNullOrWhiteSpace(branch))
            {
                yield return branch;
            }
        }
    }
}
