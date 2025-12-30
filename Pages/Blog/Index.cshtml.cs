using ASP_site.Models;
using ASP_site.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_site.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private readonly BlogService _blogService;

        public List<BlogPost> Posts { get; set; } = new();

        public IndexModel(BlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task OnGetAsync()
        {
            Posts = await _blogService.GetPostsAsync();
        }
    }
}

