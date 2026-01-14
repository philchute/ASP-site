using ASP_site.Models;
using ASP_site.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_site.Pages.Gunpla
{
    public class GradesModel : PageModel
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public GradesModel(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public BlogPost? GradeInfo { get; set; }

        public async Task OnGetAsync()
        {
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "markdown", "gunpla-grades.md");
            if (System.IO.File.Exists(path))
            {
                var content = await System.IO.File.ReadAllTextAsync(path);
                // Simple parsing reused from BlogService logic (simplified here)
                // In a real app we'd expose a Parse method in BlogService or MarkdownService
                GradeInfo = new BlogPost
                {
                    Title = "Gunpla Grades",
                    Content = content // We will render this using a Markdown helper in the view if available, or just raw if no helper
                };
            }
        }
    }
}
