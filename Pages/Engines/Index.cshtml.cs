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

    public string? FavoriteEngine { get; set; }
    public List<Engine>? Engines { get; set; }
    public SelectList? SelectGames { get; set; }
    public SelectList? SelectStates { get; set; }
    public SelectList? SelectEngines { get; set; }
    //public SelectList Games { get; set; }
    //public SelectList States { get; set; }
    [BindProperty(SupportsGet = true)] public string? SearchString { get; set; }
    [BindProperty(SupportsGet = true)] public string? SelectedEngine { get; set; }
    [BindProperty(SupportsGet = true)] public bool? SelectedState { get; set; }
    [BindProperty(SupportsGet = true)] public string SortField { get; set; } = "Engine";

    public async Task OnGetAsync()
    {
      ViewData["ActivePage"] = "Engines";
      // read the favorite team from a cookie
      FavoriteEngine = HttpContext.Session.GetString("_Favorite");

      // make select lists for the filter dropdowns
      IQueryable<string> gameQuery = from g in _context.Games
                                     orderby g.GameID
                                     select g.GameID;
      SelectGames = new SelectList(await gameQuery.ToListAsync());
      IQueryable<bool?> stateQuery = from g in _context.Games
                                     orderby g.IsFree
                                     select g.IsFree;
      SelectStates = new SelectList(await gameQuery.Distinct().ToListAsync());
      IQueryable<string> engineQuery = from e in _context.Engines
                                         orderby e.EngineID
                                         select e.EngineID;
      SelectEngines = new SelectList(await engineQuery.Distinct().ToListAsync());

      // create a base query that retrieves all players
      var engines = from e in _context.Engines select e;
      // modify the query if the user is searching or filtering
      if (!string.IsNullOrEmpty(SearchString)) { engines = engines.Where(g => g.Name.Contains(SearchString)); }
      if (!string.IsNullOrEmpty(SelectedEngine)) { engines = engines.Where(g => g.EngineID == SelectedEngine); }
      //if (!string.IsNullOrEmpty("SelectedState")) { engines = engines.Where(g => g.GamePlayable == SelectedState); } //TODO
      // modify the query if the user is sorting
      switch (SortField) {
        case "Year": engines = engines.OrderBy(e => e.Year).ThenBy(e => e.EngineID); break;
        case "Name": engines = engines.OrderBy(e => e.Name).ThenBy(e => e.EngineID); break;
        //case "Engine": engines = engines.OrderBy(g => g.EngineID).ThenBy(g => g.GameID); break;
      }
      Engines = await engines.ToListAsync();
    }

    // return a string for the class of each game <a> tag, bold for playable, gold for favorite
    public string EngineClass(Engine engine)
    {
      string Class = "d-flex";
      // if (Game.GamePlayable == GamePlayable.DeveloperMaintained || Game.GamePlayable == GamePlayable.StillPlayable)
      //   Class += " playable";
      // if (engine.EngineID == FavoriteEngine)
      //   Class += " favorite";
      return Class;
    }
  }
}