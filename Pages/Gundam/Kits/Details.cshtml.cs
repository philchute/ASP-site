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
        public UserKitEntry? UserEntry { get; set; }
        
        [BindProperty]
        public UserKitEntry InputEntry { get; set; } = null!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var kit = await _service.GetKitAsync(id);
            if (kit == null) return NotFound();
            Kit = kit;

            // Fetch related accessories
            var accessoryGrades = new[] 
            { 
                GunplaGrade.WaterSlide, 
                GunplaGrade.Sticker, 
                GunplaGrade.MetalSticker, 
                GunplaGrade.MetalParts, 
                GunplaGrade.ActionBase 
            };

            var relatedKits = new List<GunplaKit>();
            foreach (var gundam in Kit.Gundams)
            {
                var kits = await _service.GetKitsForGundamAsync(gundam.ModelNumber);
                relatedKits.AddRange(kits);
            }

            RelatedAccessories = relatedKits
                .Where(k => accessoryGrades.Contains(k.Grade) 
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
