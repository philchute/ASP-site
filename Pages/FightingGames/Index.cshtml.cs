using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_site.Pages.FightingGames
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPagePermanent("/Genres/Genre", new { genre = "Fighting" });
        }
    }
}
