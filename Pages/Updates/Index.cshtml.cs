using ASP_site.Data;
using ASP_site.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_site.Pages.Updates
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;

        public IndexModel(GameContext context)
        {
            _context = context;
        }

        public IList<UpdatePost> UpdatePosts { get; set; } = new List<UpdatePost>();
        public IDictionary<int, string> AllTags { get; set; } = new Dictionary<int, string>();

        [Microsoft.AspNetCore.Mvc.BindProperty(SupportsGet = true)]
        public List<int> SelectedTagIds { get; set; } = new List<int>();

        public async Task OnGetAsync()
        {
            ViewData["ActivePage"] = "Updates";

            // Load all available tags for filtering UI
            AllTags = await _context.Tags.OrderBy(t => t.Name).ToDictionaryAsync(t => t.Id, t => t.Name);

            IQueryable<UpdatePost> postsQuery = _context.UpdatePosts
                                                 .Include(p => p.Tags)
                                                 .OrderByDescending(p => p.PostedDate);

            if (SelectedTagIds.Any())
            {
                // Filter posts that have AT LEAST ONE of the selected tags.
                // This requires postsQuery to be IQueryable for EF to translate.
                postsQuery = postsQuery.Where(p => p.Tags.Any(t => SelectedTagIds.Contains(t.Id)));
            }

            UpdatePosts = await postsQuery.ToListAsync();
        }
    }
} 