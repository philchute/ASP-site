using ASP_site.Models.Gunpla;
using ASP_site.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_site.Pages.Gundam.Grades
{
    public class ListModel : PageModel
    {
        private readonly GunplaCollectionService _service;

        public ListModel(GunplaCollectionService service)
        {
            _service = service;
        }

        public GunplaGrade Grade { get; set; }
        public List<GunplaKit> Kits { get; set; } = new();
        public List<UserKitEntry> UserCollection { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(GunplaGrade grade)
        {
            Grade = grade;
            Kits = await _service.GetKitsByGradeAsync(grade);
            UserCollection = await _service.GetUserCollectionAsync();
            return Page();
        }
    }
}
