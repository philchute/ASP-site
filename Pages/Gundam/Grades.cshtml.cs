using ASP_site.Models;
using ASP_site.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_site.Pages.Gunpla
{
    public class GradesModel : PageModel
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly MarkdownService _markdownService;

        public GradesModel(IWebHostEnvironment webHostEnvironment, MarkdownService markdownService)
        {
            _webHostEnvironment = webHostEnvironment;
            _markdownService = markdownService;
        }

        public BlogPost? GradeInfo { get; set; }

        public async Task OnGetAsync()
        {
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "markdown", "gunpla-grades.md");
            if (System.IO.File.Exists(path))
            {
                var content = await System.IO.File.ReadAllTextAsync(path);
                GradeInfo = new BlogPost
                {
                    Title = "Gunpla Grades",
                    Content = _markdownService.Parse(content)
                };
            }
        }
    }
}
