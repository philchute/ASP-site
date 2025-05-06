using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using ASP_site.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASP_site.Pages.Maps
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;
        public IndexModel(GameContext context) { _context = context; }
        public List<Map> CSMaps { get; set; } = new();
        public List<Map> TFMaps { get; set; } = new();
        [BindProperty(SupportsGet = true)] public string? GameType { get; set; } = "All";
        [BindProperty(SupportsGet = true)] public string? Competitive { get; set; } = "All";
        [BindProperty(SupportsGet = true)] public string? SearchString { get; set; }
        [BindProperty(SupportsGet = true)] public string SortField { get; set; } = "Name";

        public async Task OnGetAsync()
        {
            ViewData["ActivePage"] = "Maps";
            
            // Get all maps
            var maps = await _context.Maps.ToListAsync();
            
            // Apply filters
            if (!string.IsNullOrEmpty(SearchString))
            {
                maps = maps.Where(m => m.MapID.Contains(SearchString) || 
                                     (m.Description != null && m.Description.Contains(SearchString))).ToList();
            }
            
            if (Competitive != "All")
            {
                bool isComp = Competitive == "Yes";
                maps = maps.Where(m => m.IsCompetitive == isComp).ToList();
            }
            
            // Apply sorting
            switch (SortField)
            {
                case "Name":
                    maps = maps.OrderBy(m => m.MapID).ToList();
                    break;
                case "Competitive":
                    maps = maps.OrderByDescending(m => m.IsCompetitive).ThenBy(m => m.MapID).ToList();
                    break;
                case "Description":
                    maps = maps.OrderBy(m => m.Description).ThenBy(m => m.MapID).ToList();
                    break;
            }
            
            // Filter by game type
            if (GameType == "Counterstrike")
            {
                CSMaps = maps.Where(m => m.GameInfo.Any(g => 
                    g.GameID == "CS16" || g.GameID == "CSCZ" || g.GameID == "CSS" || 
                    g.GameID == "CSGO" || g.GameID == "CS2")).ToList();
                TFMaps = new();
            }
            else if (GameType == "Team Fortress")
            {
                TFMaps = maps.Where(m => m.GameInfo.Any(g => 
                    g.GameID == "QWTF" || g.GameID == "TFC" || g.GameID == "FF")).ToList();
                CSMaps = new();
            }
            else
            {
                // Filter CS maps
                CSMaps = maps.Where(m => m.GameInfo.Any(g => 
                    g.GameID == "CS16" || g.GameID == "CSCZ" || g.GameID == "CSS" || 
                    g.GameID == "CSGO" || g.GameID == "CS2")).ToList();
                
                // Filter TF maps
                TFMaps = maps.Where(m => m.GameInfo.Any(g => 
                    g.GameID == "QWTF" || g.GameID == "TFC" || g.GameID == "FF")).ToList();
            }
        }
    }
} 