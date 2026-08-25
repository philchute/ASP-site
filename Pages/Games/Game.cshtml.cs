using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using ASP_site.Data;

namespace ASP_site.Pages.Games
{
  public class GamesModel : PageModel
  {
    private readonly GameContext _context;
    public GamesModel(GameContext context)
    {
      _context = context;
    }

    public Game? Game { get; set; }
    public List<Link> GameLinks { get; set; } = new List<Link>();

    public async Task OnGetAsync(string GameID)
    {
      ViewData["ActivePage"] = "Games";
      Game = await _context.Games
        .Include(g => g.AdaptedFromArcs)
        .FirstOrDefaultAsync(g => g.GameID == GameID);
      if (Game != null)
      {
        Game.Mods = await _context.Games.Where(g => g.ModForGameID == GameID).ToListAsync();
        GameLinks = await _context.Links.Where(l => l.GameID == GameID).ToListAsync();
        Game.Servers = await _context.Servers.Where(s => s.GameID == GameID).ToListAsync();
      }
    }
  }
}