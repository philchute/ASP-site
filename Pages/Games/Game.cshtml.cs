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
    public List<Link> GameLinks { get; set; } = new List<Link>();

    public async Task OnGetAsync(string GameID)
    {
      ViewData["ActivePage"] = "Games";
      Game = await _context.Games.FindAsync(GameID);
      if (Game != null)
      {
        Game.Mods = Game.AddMods(Game, _context.Games.ToList());
        GameLinks = Game.GetLinks(Game, _context.Links.ToList());
        Game.Servers = Game.GetServers(Game, _context.Servers.ToList());
      }
    }
  }
}