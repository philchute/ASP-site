using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP_site.Pages.Books.Rand
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;

        public IndexModel(GameContext context)
        {
            _context = context;
            SortOptions = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Value = "Year", Text = "Year" },
                new SelectListItem { Value = "Title", Text = "Title" }
            }, "Value", "Text");
        }

        public IList<Book> Books { get; set; } = new List<Book>();
        public IList<Link> AllLinks { get; set; } = new List<Link>();

        // Filter & Search Properties
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
        
        // Sorting Properties
        [BindProperty(SupportsGet = true)]
        public string SortField { get; set; } = "Year";
        public SelectList SortOptions { get; set; }

        public async Task OnGetAsync()
        {
            var booksIQ = _context.Books
                .Where(b => b.Author == "Ayn Rand")
                .Include(b => b.Tags)
                .AsQueryable();

            // Populate filter options from the full set of Rand's books
            var allBooks = await booksIQ.ToListAsync();
            AllLinks = await _context.Links.Where(l => l.BookTitle != null).ToListAsync();
            
            var existingTypes = allBooks.Select(b => b.Type).Distinct().ToList();
            AllBookTypes = Enum.GetValues(typeof(BookType))
                .Cast<BookType>()
                .Where(t => existingTypes.Contains(t))
                .ToDictionary(e => e.ToString(), e => e.ToString());

            if (!SelectedBookTypes.Any())
            {
                SelectedBookTypes = AllBookTypes.Keys.Where(k => k != BookType.Forward.ToString()).ToList();
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

            // Apply filters to the query
            if (!string.IsNullOrEmpty(SearchString))
            {
                booksIQ = booksIQ.Where(s => s.Title.Contains(SearchString, StringComparison.OrdinalIgnoreCase) || (s.Description != null && s.Description.Contains(SearchString, StringComparison.OrdinalIgnoreCase)));
            }

            if (SelectedBookTypes.Any())
            {
                booksIQ = booksIQ.Where(x => SelectedBookTypes.Contains(x.Type.ToString()));
            }

            if (SelectedCollections.Any())
            {
                booksIQ = booksIQ.Where(b => b.Tags.Any(t => SelectedCollections.Contains(t.Name)));
            }

            if (SelectedTags.Any())
            {
                booksIQ = booksIQ.Where(b => b.Tags.Any(t => SelectedTags.Contains(t.Name)));
            }
            
            // Apply Sorting
            switch (SortField)
            {
                case "Title":
                    booksIQ = booksIQ.OrderBy(b => b.Title);
                    break;
                default: // "Year"
                    booksIQ = booksIQ.OrderBy(b => b.PublicationYear).ThenBy(b => b.PublicationMonth).ThenBy(b => b.Title);
                    break;
            }

            Books = await booksIQ.ToListAsync();
        }
    }
}
