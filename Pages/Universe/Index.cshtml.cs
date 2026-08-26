using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Models;

namespace ASP_site.Pages.Universe
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;

        public IndexModel(GameContext context)
        {
            _context = context;
        }

        public IList<UniverseListItem> Universes { get; set; } = new List<UniverseListItem>();

        public async Task OnGetAsync()
        {
            var universes = await _context.Franchises
                .Include(f => f.Works)
                .AsNoTracking()
                .OrderBy(f => f.Name)
                .ToListAsync();

            Universes = universes.Select(f => new UniverseListItem
            {
                Id = f.FranchiseID,
                Name = f.Name,
                Description = f.Description,
                WorkCount = f.Works.Count
            }).ToList();
        }
    }

    public class UniverseListItem
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int WorkCount { get; set; }
    }
}
