using ASP_site.Models;
using ASP_site.Services;
using MarkedNet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_site.Pages.Blog
{
    public class PostModel : PageModel
    {
        private readonly BlogService _blogService;

        public BlogPost? Post { get; set; }
        public string HtmlContent { get; set; } = string.Empty;

        public PostModel(BlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IActionResult> OnGetAsync(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                return RedirectToPage("./Index");
            }

            Post = await _blogService.GetPostAsync(slug);

            if (Post == null)
            {
                return NotFound();
            }

            var marked = new Marked();
            HtmlContent = marked.Parse(Post.Content);
            
            // Basic Bootstrap table styling
            HtmlContent = HtmlContent.Replace("<table>", "<table class=\"table table-dark table-striped\">");

            return Page();
        }
    }
}

