using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using ASP_site.Data;

namespace ASP_site.Pages.Maps
{
    public class MapModel : PageModel
    {
        private readonly GameContext _context;
        public MapModel(GameContext context)
        {
            _context = context;
        }

        public Map? Map { get; set; }
        public List<Link> MapLinks { get; set; } = new();
        public List<Game> Games { get; set; } = new();

        public async Task OnGetAsync(string id)
        {
            ViewData["ActivePage"] = "Maps";
            Map = await _context.Maps.FirstOrDefaultAsync(m => m.MapID == id);
            Games = await _context.Games.OrderBy(g => g.Year).ToListAsync();
            
            if (Map != null)
            {
                MapLinks = Map.GetLinks(Map, await _context.Links.ToListAsync());
            }
        }
    }
} 