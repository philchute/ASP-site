using ASP_site.Models;
using ASP_site.Models.Gunpla;
using ASP_site.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_site.Pages.Gundam
{
    public class TimelineModel : PageModel
    {
        private readonly GunplaCollectionService _service;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly MarkdownService _markdownService;

        public TimelineModel(GunplaCollectionService service, IWebHostEnvironment webHostEnvironment, MarkdownService markdownService)
        {
            _service = service;
            _webHostEnvironment = webHostEnvironment;
            _markdownService = markdownService;
        }

        public string TimelineName { get; set; } = "";
        public List<GunplaKit> Kits { get; set; } = new();
        public List<string> AllTimelines { get; set; } = new();
        public BlogPost? TimelineInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                // List all timelines mode
                AllTimelines = await _service.GetAllTimelinesAsync();
                
                // Load Markdown Info
                var path = Path.Combine(_webHostEnvironment.WebRootPath, "markdown", "gunpla-timelines.md");
                if (System.IO.File.Exists(path))
                {
                    var content = await System.IO.File.ReadAllTextAsync(path);
                    TimelineInfo = new BlogPost
                    {
                        Title = "Gunpla Timelines",
                        Content = _markdownService.Parse(content)
                    };
                }
                
                return Page();
            }

            TimelineName = name;
            Kits = await _service.GetKitsByTimelineAsync(name);
            return Page();
        }
    }
}
