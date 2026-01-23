using ASP_site.Data;
using ASP_site.Models.Gunpla;
using ASP_site.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP_site.Pages.Gundam
{
    public class StatsModel : PageModel
    {
        private readonly GunplaCollectionService _service;
        private readonly GameContext _context;

        public StatsModel(GunplaCollectionService service, GameContext context)
        {
            _service = service;
            _context = context;
        }

        public Dictionary<string, int> FactionCounts { get; set; } = new();
        public List<GundamKitStat> GundamStats { get; set; } = new();

        public async Task OnGetAsync()
        {
            // 1. Faction Counts
            // Need to flat map all factions from all Gundams
            var allGundams = await _context.Gundams.ToListAsync();
            
            var factions = allGundams
                .SelectMany(g => g.Factions)
                .GroupBy(f => f)
                .Select(g => new { Faction = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .ToDictionary(x => x.Faction, x => x.Count);

            FactionCounts = factions;

            // 2. Gundam Kit Counts
            // Get all kits and their gundams to count relation
            var allKits = await _context.GunplaKits.Include(k => k.Gundams).ToListAsync();

            // Initialize stats with 0 for all known Gundams
            var stats = allGundams.Select(g => new GundamKitStat 
            { 
                Gundam = g, 
                KitCount = 0 
            }).ToList();

            // Count kits
            foreach (var kit in allKits)
            {
                foreach (var gundam in kit.Gundams)
                {
                    var stat = stats.FirstOrDefault(s => s.Gundam.ModelNumber == gundam.ModelNumber);
                    if (stat != null)
                    {
                        stat.KitCount++;
                    }
                }
            }

            GundamStats = stats.OrderBy(s => s.KitCount).ThenBy(s => s.Gundam.CommonName).ToList();
        }

        public class GundamKitStat
        {
            public Models.Gunpla.Gundam Gundam { get; set; } = null!;
            public int KitCount { get; set; }
        }
    }
}
