using Microsoft.AspNetCore.Mvc.RazorPages;
using ASP_site.Models;
using ASP_site.Data;

namespace ASP_site.Pages.Games
{
  public class GamesModel : PageModel
  {
    // inject the Entity Framework context
    private readonly GameContext _context;
    public GamesModel(GameContext context)
    {
      _context = context;
    }

    // load a game based on GameID
    public Game? Game { get; set; }
    public async Task OnGetAsync(string GameID)
    {
      Game = await _context.Games.FindAsync(GameID);
    }
  }
}