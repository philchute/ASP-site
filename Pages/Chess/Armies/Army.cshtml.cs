using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Models.Chess;

namespace ASP_site.Pages.Chess.Armies
{
    public class ArmyModel : PageModel
    {
        private readonly GameContext _context;

        public ArmyModel(GameContext context)
        {
            _context = context;
        }

        public ChessVariant Variant { get; set; } = default!;

        public List<ASP_site.Models.Link> RelatedLinks { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(string armyId)
        {
            if (armyId == null)
            {
                return NotFound();
            }

            var army = await _context.Variants
                .Include(a => a.Placements)
                .ThenInclude(sp => sp.Piece)
                .FirstOrDefaultAsync(m => m.VariantID == armyId && m.IsArmy);

            if (army == null)
            {
                return NotFound();
            }

            Variant = army;

            // Load related links
            // Assuming data migration moves ArmyID links to VariantID links, or we check both if needed.
            // For now, trusting user to migrate data, but since Link model has both, we might need to check VariantID.
            // If the user migrates data, they will likely populate VariantID for these entries.
            RelatedLinks = await _context.Links
                .Where(l => l.VariantID == armyId || l.ArmyID == armyId) 
                .ToListAsync();

            return Page();
        }
    }
}
