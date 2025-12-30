using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using ASP_site.Data;

namespace ASP_site.Pages.Engines
{
  public class IndexModel : PageModel
  {
    // inject the Entity Framework context
    private readonly GameContext _context;
    public IndexModel(GameContext context)
    {
      _context = context;
    }

    public List<Engine>? Engines { get; set; }
    public List<Engine> Roots { get; set; } = new();
    public SelectList? SelectEngines { get; set; }
    [BindProperty(SupportsGet = true)] public string? SearchString { get; set; }
    [BindProperty(SupportsGet = true)] public string? SelectedEngine { get; set; }
    [BindProperty(SupportsGet = true)] public string SortField { get; set; } = "Year";

    public async Task OnGetAsync()
    {
      ViewData["ActivePage"] = "Engines";

      // make select lists for the filter dropdowns
      IQueryable<string> engineQuery = from e in _context.Engines
                                         orderby e.EngineID
                                         select e.EngineID;
      SelectEngines = new SelectList(await engineQuery.Distinct().ToListAsync());

      // create a base query that retrieves all engines
      var enginesQuery = from e in _context.Engines select e;
      // modify the query if the user is searching or filtering
      if (!string.IsNullOrEmpty(SearchString)) { enginesQuery = enginesQuery.Where(e => e.Name.Contains(SearchString)); }
      if (!string.IsNullOrEmpty(SelectedEngine)) { enginesQuery = enginesQuery.Where(g => g.EngineID == SelectedEngine); }
      
      // Fetch all engines to build tree in memory
      var allEngines = await enginesQuery.ToListAsync();
      
      // If filtering is active, just show flat list or filter logic?
      // User requested "Engines page like that" (Evolution tree).
      // Assuming tree view is desired by default, but if searching, maybe flat list is better?
      // Or we can try to show hierarchy if possible. 
      // Let's stick to the tree view if no search is active, or perhaps always build tree but filter roots?
      
      if (!string.IsNullOrEmpty(SearchString) || !string.IsNullOrEmpty(SelectedEngine))
      {
          // Flat list behavior when searching/filtering for specific items
          Engines = allEngines;
          
          switch (SortField) {
            case "Year": Engines = Engines.OrderBy(e => e.Year).ThenBy(e => e.EngineID).ToList(); break;
            case "Name": Engines = Engines.OrderBy(e => e.Name).ThenBy(e => e.EngineID).ToList(); break;
          }
      }
      else
      {
          // Tree view behavior
          var engineDict = allEngines.ToDictionary(e => e.EngineID);
          
          foreach (var engine in allEngines)
          {
              if (!string.IsNullOrEmpty(engine.ParentID) && engineDict.TryGetValue(engine.ParentID, out var parent))
              {
                  if (parent.Children == null) parent.Children = new List<Engine>();
                  // Check if already added to avoid duplicates if EF tracking does weird things (though unlikely with fresh query)
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

          // Sort logic for tree
          SortTree(Roots);
          Engines = null; // Signal to view to use Roots
      }
    }

    private void SortTree(List<Engine> nodes)
    {
        // Default sort by Year then Name
        if (SortField == "Name")
            nodes.Sort((a, b) => string.Compare(a.Name, b.Name));
        else
            nodes.Sort((a, b) => (a.Year ?? 9999).CompareTo(b.Year ?? 9999));

        foreach (var node in nodes)
        {
            if (node.Children != null && node.Children.Any())
            {
                SortTree(node.Children);
            }
        }
    }

    // return a string for the class of each engine <a> tag
    public string EngineClass(Engine engine)
    {
      string Class = "d-flex";
      return Class;
    }
  }
}