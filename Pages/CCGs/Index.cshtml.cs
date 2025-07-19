using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using MarkedNet;

namespace ASP_site.Pages.CCGs
{
    public class IndexModel : PageModel
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public string? Content { get; private set; }

        public IndexModel(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task OnGetAsync()
        {
            var markdownFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "markdown", "ccgs.md");
            if (System.IO.File.Exists(markdownFilePath))
            {
                var markdownContent = await System.IO.File.ReadAllTextAsync(markdownFilePath);
                var marked = new Marked();
                var html = marked.Parse(markdownContent);
                Content = html.Replace("<table>", "<table class=\"table\">");
            }
            else
            {
                Content = "<p>Markdown file not found.</p>";
            }
        }
    }
} 