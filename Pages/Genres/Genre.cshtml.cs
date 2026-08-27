using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Helpers;
using ASP_site.Models;
using ASP_site.Services;

namespace ASP_site.Pages.Genres
{
    public class GenreModel : PageModel
    {
        private readonly GameContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly MarkdownService _markdownService;

        public GenreModel(
            GameContext context,
            IWebHostEnvironment hostingEnvironment,
            MarkdownService markdownService)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            _markdownService = markdownService;
        }

        public Genre Genre { get; private set; }
        public string DisplayName { get; private set; } = "";
        public string? MarkdownHtml { get; private set; }
        public List<Game> Games { get; private set; } = [];

        public async Task<IActionResult> OnGetAsync(string genre)
        {
            if (!Enum.TryParse<Genre>(genre, ignoreCase: true, out var parsed))
            {
                return NotFound();
            }

            Genre = parsed;
            DisplayName = GenreHub.DisplayName(parsed);
            ViewData["Title"] = DisplayName;
            ViewData["ActivePage"] = "Games";

            var markdownPath = Path.Combine(_hostingEnvironment.WebRootPath, GenreHub.MarkdownRelativePath(parsed));
            if (System.IO.File.Exists(markdownPath))
            {
                var markdownContent = await System.IO.File.ReadAllTextAsync(markdownPath);
                MarkdownHtml = _markdownService.Parse(markdownContent);
            }

            Games = await _context.Games
                .Where(g => g.Genre == parsed)
                .OrderBy(g => g.Year)
                .ThenBy(g => g.Name)
                .ToListAsync();

            return Page();
        }
    }
}
