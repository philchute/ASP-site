using ASP_site.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace ASP_site.Pages
{
  public class IndexModel : PageModel
  {
    private readonly ILogger<IndexModel> _logger;
    private readonly SiteMapService _siteMapService;

    public string SiteMapJson { get; private set; } = "{}";

    public IndexModel(ILogger<IndexModel> logger, SiteMapService siteMapService)
    {
        _logger = logger;
        _siteMapService = siteMapService;
    }

    public void OnGet()
    {
      ViewData["ActivePage"] = "Home";
      var siteMap = _siteMapService.GetSiteMap();
      
      var options = new JsonSerializerOptions 
      { 
          PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
          WriteIndented = false 
      };
      SiteMapJson = JsonSerializer.Serialize(siteMap, options);
    }
  }
}
