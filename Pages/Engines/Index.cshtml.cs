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
    public SelectList? SelectEngines { get; set; }
    [BindProperty(SupportsGet = true)] public string? SearchString { get; set; }
    [BindProperty(SupportsGet = true)] public string? SelectedEngine { get; set; }
    [BindProperty(SupportsGet = true)] public string SortField { get; set; } = "Name";

    public async Task OnGetAsync()
    {
      ViewData["ActivePage"] = "Engines";

      // make select lists for the filter dropdowns
      IQueryable<string> engineQuery = from e in _context.Engines
                                         orderby e.EngineID
                                         select e.EngineID;
      SelectEngines = new SelectList(await engineQuery.Distinct().ToListAsync());

      // create a base query that retrieves all engines
      var engines = from e in _context.Engines select e;
      // modify the query if the user is searching or filtering
      if (!string.IsNullOrEmpty(SearchString)) { engines = engines.Where(e => e.Name.Contains(SearchString)); }
      if (!string.IsNullOrEmpty(SelectedEngine)) { engines = engines.Where(g => g.EngineID == SelectedEngine); }
      // modify the query if the user is sorting
      switch (SortField) {
        case "Year": engines = engines.OrderBy(e => e.Year).ThenBy(e => e.EngineID); break;
        case "Name": engines = engines.OrderBy(e => e.Name).ThenBy(e => e.EngineID); break;
      }
      Engines = await engines.ToListAsync();
    }

    // return a string for the class of each engine <a> tag
    public string EngineClass(Engine engine)
    {
      string Class = "d-flex";
      return Class;
    }
  }
}