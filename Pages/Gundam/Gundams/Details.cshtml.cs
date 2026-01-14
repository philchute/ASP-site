using ASP_site.Models.Gunpla;
using ASP_site.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_site.Pages.Gunpla.Gundams
{
    public class DetailsModel : PageModel
    {
        private readonly GunplaCollectionService _service;

        public DetailsModel(GunplaCollectionService service)
        {
            _service = service;
        }

        public Models.Gunpla.Gundam Gundam { get; set; } = null!;
        public List<GunplaKit> Kits { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null) return NotFound();

            var gundam = await _service.GetGundamAsync(id);
            if (gundam == null) return NotFound();
            Gundam = gundam;

            Kits = await _service.GetKitsForGundamAsync(id);
            return Page();
        }
    }
}
