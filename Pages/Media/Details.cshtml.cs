using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Models;

namespace ASP_site.Pages.MediaPages
{
    public class DetailsModel : PageModel
    {
        private readonly GameContext _context;

        public DetailsModel(GameContext context)
        {
            _context = context;
        }

        public Media? Item { get; set; }

        public async Task OnGetAsync(string id)
        {
            Item = await _context.Media
                .Include(m => m.AdaptedFromArcs)
                .FirstOrDefaultAsync(m => m.MediaID == id);
        }
    }
}
