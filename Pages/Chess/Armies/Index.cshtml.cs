using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Models.Chess;
using Microsoft.AspNetCore.Mvc;

namespace ASP_site.Pages.Chess.Armies
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;

        public IndexModel(GameContext context)
        {
            _context = context;
        }

        public IList<ChessVariant> Armies { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public string? NameSort { get; set; }
        public string? AuthorSort { get; set; }
        public string? CurrentSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            CurrentSort = sortOrder;
            NameSort = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            AuthorSort = sortOrder == "Author" ? "author_desc" : "Author";

            if (_context.Variants != null)
            {
                var armiesIQ = _context.Variants
                    .Where(v => v.IsArmy)
                    .Include(a => a.Placements)
                    .ThenInclude(sp => sp.Piece)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(SearchString))
                {
                    armiesIQ = armiesIQ.Where(a => a.Name.Contains(SearchString) || 
                                                 (a.Description != null && a.Description.Contains(SearchString)) ||
                                                 (a.Author != null && a.Author.Contains(SearchString)));
                }

                switch (sortOrder)
                {
                    case "name_desc":
                        armiesIQ = armiesIQ.OrderByDescending(a => a.Name);
                        break;
                    case "Author":
                        armiesIQ = armiesIQ.OrderBy(a => a.Author);
                        break;
                    case "author_desc":
                        armiesIQ = armiesIQ.OrderByDescending(a => a.Author);
                        break;
                    default:
                        armiesIQ = armiesIQ.OrderBy(a => a.Name);
                        break;
                }

                Armies = await armiesIQ.ToListAsync();
            }
        }
    }
}
