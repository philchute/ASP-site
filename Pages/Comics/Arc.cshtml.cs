using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Models;

namespace ASP_site.Pages.Comics
{
    public class ArcModel : PageModel
    {
        private readonly GameContext _context;

        public ArcModel(GameContext context)
        {
            _context = context;
        }

        public StoryArc? Arc { get; set; }
        public List<ComicIssue> Issues { get; set; } = new();

        public async Task OnGetAsync(string id)
        {
            Arc = await _context.StoryArcs
                .Include(a => a.AdaptedMedia)
                .Include(a => a.AdaptedGames)
                .Include(a => a.AdaptedBooks)
                .FirstOrDefaultAsync(a => a.ArcID == id);

            if (Arc != null && Arc.IssueIDs.Any())
            {
                Issues = await _context.ComicIssues
                    .Where(i => Arc.IssueIDs.Contains(i.IssueID))
                    .ToListAsync();
            }
        }
    }
}
