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
        public UserKitEntry? UserEntry { get; set; }
        
        [BindProperty]
        public UserKitEntry InputEntry { get; set; } = null!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var kit = await _service.GetKitAsync(id);
            if (kit == null) return NotFound();
            Kit = kit;

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
