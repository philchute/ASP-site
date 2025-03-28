using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using ASP_site.Data;
using System.Linq;

namespace ASP_site.Pages.Games
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
    public List<Game>? Games { get; set; }
    public SelectList? SelectGames { get; set; }
    public SelectList? SelectGenres { get; set; }
    public SelectList? Engines { get; set; }
    [BindProperty(SupportsGet = true)] public string? SearchString { get; set; } = null;
    [BindProperty(SupportsGet = true)] public string? SelectedEngine { get; set; } = null;
    [BindProperty(SupportsGet = true)] public string? SelectedGenre { get; set; } = null;
    [BindProperty(SupportsGet = true)] public string SortField { get; set; } = "Name";

    public async Task OnGetAsync()
    {
      ViewData["ActivePage"] = "Games";
      // read the favorite team from a cookie
      FavoriteEngine = HttpContext.Session.GetString("_Favorite");

      // make select lists for the filter dropdowns
      IQueryable<string> gameQuery = from g in _context.Games
                                     orderby g.GameID
                                     select g.GameID;
      SelectGames = new SelectList(await gameQuery.ToListAsync());

      IQueryable<Genre?> genreQuery = from g in _context.Games
                                     where g.Genre != null
                                     orderby g.Genre
                                     select g.Genre;
      SelectGenres = new SelectList(await genreQuery.Distinct().ToListAsync());

      IQueryable<string> engineQuery = from e in _context.Engines
                                     orderby e.EngineID
                                     select e.EngineID;
      Engines = new SelectList(await engineQuery.Distinct().ToListAsync());

      // create a base query that retrieves all players
      var games = from g in _context.Games select g;
      // modify the query if the user is searching or filtering
      if (!string.IsNullOrEmpty(SearchString)) { games = games.Where(g => g.Name.Contains(SearchString)); }
      if (!string.IsNullOrEmpty(SelectedEngine)) { games = games.Where(g => g.EngineID == SelectedEngine); }
      if (!string.IsNullOrEmpty(SelectedGenre)) { games = games.Where(g => g.Genre.ToString() == SelectedGenre); }
      // modify the query if the user is sorting
      switch (SortField) {
        case "Year": games = games.OrderBy(g => g.Year).ThenBy(g => g.GameID); break;
        case "Name": games = games.OrderBy(g => g.Name).ThenBy(g => g.GameID); break;
        case "Engine": games = games.OrderBy(g => g.EngineID).ThenBy(g => g.GameID); break;
      }
      Games = await games.ToListAsync();
    }

    // return a string for the class of each game <a> tag, bold for playable, gold for favorite
    public string GameClass(Game Game)
    {
      string Class = "d-flex";
      // if (Game.GamePlayable == GamePlayable.DeveloperMaintained || Game.GamePlayable == GamePlayable.StillPlayable)
      //   Class += " playable";
      // if (Game.EngineID == FavoriteEngine)
      //   Class += " favorite";
      return Class;
    }
  }
}