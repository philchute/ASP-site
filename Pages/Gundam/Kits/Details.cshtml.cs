using ASP_site.Models.Gunpla;
using ASP_site.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_site.Pages.Gunpla.Kits
{
    public class DetailsModel : PageModel
    {
        private readonly GunplaCollectionService _service;

        public DetailsModel(GunplaCollectionService service)
        {
            _service = service;
        }

        public GunplaKit Kit { get; set; } = null!;
        public List<GunplaKit> RelatedAccessories { get; set; } = new();
        public List<GunplaKit> IncludedKits { get; set; } = new();
        public List<GunplaKit> IncludedInKits { get; set; } = new();
        public List<GunplaKit> RemixedFrom { get; set; } = new();
        public List<GunplaKit> RemixedInto { get; set; } = new();
        public List<GunplaKit> Recolors { get; set; } = new();
        public List<GunplaKit> PartSwaps { get; set; } = new();
        public List<GunplaKit> CombinesWith { get; set; } = new();
        public List<GunplaKit> Requires { get; set; } = new();
        public List<GunplaKit> RequiredBy { get; set; } = new();
        public UserKitEntry? UserEntry { get; set; }
        
        [BindProperty]
        public UserKitEntry InputEntry { get; set; } = null!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var kit = await _service.GetKitAsync(id);
            if (kit == null) return NotFound();
            Kit = kit;

            // Fetch relationships
            var relationships = await _service.GetKitRelationshipsAsync(id);

            // 1. Included Kits (Outgoing Includes)
            IncludedKits = relationships
                .Where(r => r.KitId == id && r.Type == KitRelationshipType.Includes)
                .Select(r => r.RelatedKit)
                .ToList();

            // 2. Parent Kits (Incoming Includes)
            IncludedInKits = relationships
                .Where(r => r.RelatedKitId == id && r.Type == KitRelationshipType.Includes)
                .Select(r => r.Kit)
                .ToList();

            // 3. Remixed From (Outgoing Remix)
            RemixedFrom = relationships
                .Where(r => r.KitId == id && r.Type == KitRelationshipType.Remix )
                .Select(r => r.RelatedKit)
                .ToList();

            // 4. Remixed Into (Incoming Remix)
            RemixedInto = relationships
                .Where(r => r.RelatedKitId == id && r.Type == KitRelationshipType.Remix)
                .Select(r => r.Kit)
                .ToList();

            // 5. Combines With (Bidirectional)
            CombinesWith = relationships
                .Where(r => (r.KitId == id || r.RelatedKitId == id) && r.Type == KitRelationshipType.CombinesWith)
                .Select(r => r.KitId == id ? r.RelatedKit : r.Kit)
                .ToList();

            // 6. Part Swaps (Bidirectional)
            PartSwaps = relationships
                .Where(r => (r.KitId == id || r.RelatedKitId == id) && r.Type == KitRelationshipType.PartSwap)
                .Select(r => r.KitId == id ? r.RelatedKit : r.Kit)
                .ToList();
            
            // 7. Recolors (Bidirectional)
            Recolors = relationships
                .Where(r => (r.KitId == id || r.RelatedKitId == id) && r.Type == KitRelationshipType.Recolor)
                .Select(r => r.KitId == id ? r.RelatedKit : r.Kit)
                .ToList();

            // 8. Requires (Outgoing Requires)
            Requires = relationships
                .Where(r => r.KitId == id && r.Type == KitRelationshipType.Requires)
                .Select(r => r.RelatedKit)
                .ToList();

            // 9. Required By (Incoming Requires)
            RequiredBy = relationships
                .Where(r => r.RelatedKitId == id && r.Type == KitRelationshipType.Requires)
                .Select(r => r.Kit)
                .ToList();

            // Fetch related accessories
            var accessoryGrades = new[] 
            { 
                GunplaGrade.WaterSlide, 
                GunplaGrade.Sticker, 
                GunplaGrade.MetalSticker, 
                GunplaGrade.Part, 
                GunplaGrade.ActionBase 
            };

            var relatedKits = new List<GunplaKit>();

            // Add explicitly required kits
            var requiredKits = relationships
                .Where(r => r.KitId == id && r.Type == KitRelationshipType.Requires)
                .Select(r => r.RelatedKit);
            relatedKits.AddRange(requiredKits);

            foreach (var gundam in Kit.Gundams)
            {
                var kits = await _service.GetKitsForGundamAsync(gundam.ModelNumber);
                relatedKits.AddRange(kits);
            }
            foreach (var faction in Kit.Factions)
            {
                var kits = await _service.GetKitsForFactionAsync(faction);
                relatedKits.AddRange(kits);
            }

            RelatedAccessories = relatedKits
                .Where(k => (accessoryGrades.Contains(k.Grade) || requiredKits.Any(rk => rk.Id == k.Id))
                            && k.Id != Kit.Id
                            && (k.Grade == GunplaGrade.ActionBase 
                                || k.Scale == Kit.Scale 
                                || k.Scale == ScaleConverterService.NonScale.Name))
                .GroupBy(k => k.Id) // Deduplicate
                .Select(g => g.First())
                .OrderBy(k => k.ReleaseYear)
                .ToList();

            UserEntry = await _service.GetUserEntryAsync(id);
            InputEntry = UserEntry ?? new UserKitEntry { KitId = id, Status = KitStatus.Want };
            
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var entry = new UserKitEntry
            {
                KitId = InputEntry.KitId,
                Status = InputEntry.Status,
                PricePaid = InputEntry.PricePaid,
                Notes = InputEntry.Notes
            };

            await _service.AddOrUpdateEntryAsync(entry);
            
            return RedirectToPage(new { id = InputEntry.KitId });
        }
    }
}
