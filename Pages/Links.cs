using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_site.Pages
{
  public class LinksModel : PageModel
  {
    private readonly ILogger<LinksModel> _logger;

    public LinksModel(ILogger<LinksModel> logger)
    {
      _logger = logger;
    }

    public void OnGet()
    {
    }
  }
}
