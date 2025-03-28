using Microsoft.AspNetCore.Mvc.RazorPages;
using ASP_site.Models;
using ASP_site.Data;

namespace ASP_site.Pages.Engines
{
  public class EnginesModel : PageModel
  {
    // inject the Entity Framework context
    private readonly GameContext _context;
    public EnginesModel(GameContext context)
    {
      _context = context;
    }

    // load an engine based on EngineID
    public Engine? Engine { get; set; }
    public async Task OnGetAsync(string EngineID)
    {
      ViewData["ActivePage"] = "Engines";
      if (EngineID == null) return;
      
      Engine = await _context.Engines.FindAsync(EngineID);
      if (Engine != null)
      {
        Engine.Children = Engine.AddChildren(Engine, _context.Engines.ToList());
        Engine.Games = Engine.AddGames(Engine, _context.Games.ToList());
      }
    }
  }
}