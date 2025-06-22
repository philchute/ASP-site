using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using ASP_site.Data;

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
    [BindProperty(SupportsGet = true)] public List<int> SelectedPlayerCounts { get; set; } = new List<int>();

    public async Task OnGetAsync()
    {
      ViewData["ActivePage"] = "Games";
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
      if (!string.IsNullOrEmpty(SearchString)) { games = games.Where(g => g.Name.ToUpper().Contains(SearchString.ToUpper())); }
      if (!string.IsNullOrEmpty(SelectedEngine)) { games = games.Where(g => g.EngineID == SelectedEngine); }
      if (!string.IsNullOrEmpty(SelectedGenre)) { games = games.Where(g => g.Genre.ToString() == SelectedGenre); }

      // IMPORTANT: Player count filter will be applied *after* fetching from DB for compatibility with EF Core

      // modify the query if the user is sorting
      switch (SortField) {
        case "Year": games = games.OrderBy(g => g.Year).ThenBy(g => g.GameID); break;
        case "Name": games = games.OrderBy(g => g.Name).ThenBy(g => g.GameID); break;
        case "Engine": games = games.OrderBy(g => g.EngineID).ThenBy(g => g.GameID); break;
      }
      // Fetch games from DB after all DB-translatable filters and sorting
      var filteredGames = await games.ToListAsync();

      // Now, apply player count filter to the in-memory list
      if (SelectedPlayerCounts != null && SelectedPlayerCounts.Any())
      {
        filteredGames = filteredGames.Where(g => g.PlayWith != null && g.PlayWith.Any(p => SelectedPlayerCounts.Contains(p))).ToList();
      }

      Games = filteredGames;
    }

    public string FormatPlayerCounts(List<int>? playWith)
    {
        if (playWith == null || !playWith.Any())
        {
            return "-";
        }

        // Order the counts: S, M, then 2-6 for consistent display
        var orderedCounts = playWith.OrderBy(p => p == 1 ? -2 : (p == 0 ? -1 : p)).ToList();

        var displayParts = new List<string>();
        foreach (var count in orderedCounts)
        {
            switch (count)
            {
                case 1: displayParts.Add("S"); break;
                case 0: displayParts.Add("M"); break;
                default: displayParts.Add(count.ToString()); break;
            }
        }
        return string.Join(", ", displayParts);
    }

    // return a string for the class of each game <a> tag, bold for playable, gold for favorite
    public string GameClass(Game Game)
    {
      string Class = "d-flex";
      return Class;
    }
  }
}