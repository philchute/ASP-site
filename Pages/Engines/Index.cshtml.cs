using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using ASP_site.Data;

namespace ASP_site.Pages.Engines
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;
        public IndexModel(GameContext context)
        {
            _context = context;
        }

        public List<Engine>? Engines { get; set; }
        public List<Engine> Roots { get; set; } = new();
        public Engine? Engine { get; set; }
        public List<Engine> Ancestry { get; set; } = new();
        public Dictionary<string, string> GameNames { get; set; } = new();
        public string? EngineID { get; set; }

        [BindProperty(SupportsGet = true)] public string? SearchString { get; set; }
        [BindProperty(SupportsGet = true)] public string SortField { get; set; } = "Year";

        public async Task OnGetAsync(string? engineID)
        {
            ViewData["ActivePage"] = "Engines";
            EngineID = engineID;

            var allEngines = await _context.Engines.ToListAsync();
            var allGames = await _context.Games.ToListAsync();
            GameNames = allGames.ToDictionary(g => g.GameID, g => g.Name);
            ViewData["GameNames"] = GameNames;

            var gamesByEngine = allGames
                .Where(g => !string.IsNullOrEmpty(g.EngineID))
                .GroupBy(g => g.EngineID!)
                .ToDictionary(
                    g => g.Key,
                    g => g.OrderBy(x => x.Year ?? 9999).ThenBy(x => x.Name).ToList());

            foreach (var engine in allEngines)
            {
                if (gamesByEngine.TryGetValue(engine.EngineID, out var games))
                {
                    engine.Games = games;
                }
            }

            var engineDict = allEngines.ToDictionary(e => e.EngineID);

            if (!string.IsNullOrEmpty(EngineID) && engineDict.TryGetValue(EngineID, out var selected))
            {
                Engine = selected;
                Ancestry = Models.Engine.GetAncestry(selected, engineDict);
            }

            if (!string.IsNullOrWhiteSpace(SearchString))
            {
                Engines = allEngines.Where(e =>
                    e.Name.Contains(SearchString, StringComparison.OrdinalIgnoreCase)
                    || (!string.IsNullOrEmpty(e.Developer) && e.Developer.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                ).ToList();

                switch (SortField)
                {
                    case "Name":
                        Engines = Engines.OrderBy(e => e.Name).ThenBy(e => e.EngineID).ToList();
                        break;
                    default:
                        Engines = Engines.OrderBy(e => e.Year ?? 9999).ThenBy(e => e.EngineID).ToList();
                        break;
                }
                return;
            }

            foreach (var engine in allEngines)
            {
                if (!string.IsNullOrEmpty(engine.ParentID) && engineDict.TryGetValue(engine.ParentID, out var parent))
                {
                    if (!parent.Children.Any(c => c.EngineID == engine.EngineID))
                    {
                        parent.Children.Add(engine);
                    }
                }
                else
                {
                    Roots.Add(engine);
                }
            }

            SortTree(Roots);
            Engines = null;
        }

        private void SortTree(List<Engine> nodes)
        {
            if (SortField == "Name")
                nodes.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));
            else
                nodes.Sort((a, b) => (a.Year ?? 9999).CompareTo(b.Year ?? 9999));

            foreach (var node in nodes)
            {
                if (node.Children != null && node.Children.Count > 0)
                {
                    SortTree(node.Children);
                }
            }
        }

        public string EngineClass(Engine engine)
        {
            return "d-flex";
        }
    }
}
