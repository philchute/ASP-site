using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using ASP_site.Data;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_site.Pages.Links
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;
        public IndexModel(GameContext context)
        {
            _context = context;
        }

        public List<Link> Links { get; set; } = new();
        public SelectList Topics { get; set; } = new SelectList(new List<SelectListItem>());
        public SelectList LinkTypes { get; set; } = new SelectList(new List<string>());
        [BindProperty(SupportsGet = true)] public string? SearchString { get; set; }
        [BindProperty(SupportsGet = true)] public string? SelectedTopic { get; set; }
        [BindProperty(SupportsGet = true)] public string? SelectedLinkType { get; set; }
        [BindProperty(SupportsGet = true)] public string SortField { get; set; } = "Topic";

        public async Task OnGetAsync()
        {
            ViewData["ActivePage"] = "Links";

            // Create unified topic list for filter dropdown
            var gameTopics = await _context.Games
                                         .OrderBy(g => g.Name)
                                         .Select(g => new { ID = g.GameID, Name = g.Name })
                                         .ToListAsync();
            var bookTopics = await _context.Books
                                         .OrderBy(b => b.Title)
                                         .Select(b => new { ID = b.Title, Name = b.Title })
                                         .ToListAsync();

            var allTopics = gameTopics.Select(g => new SelectListItem { Value = g.ID, Text = g.Name })
                                    .Concat(bookTopics.Select(b => new SelectListItem { Value = b.ID, Text = b.Name }))
                                    .OrderBy(t => t.Text);

            Topics = new SelectList(allTopics, "Value", "Text");

            // Create select list for link types
            var linkTypesList = Enum.GetValues(typeof(LinkType))
                .Cast<LinkType>()
                .Where(lt => lt != LinkType.Wiki)
                .Select(lt => lt.ToString());
            LinkTypes = new SelectList(linkTypesList);

            // Create base query for links, excluding Wiki links
            var links = _context.Links.AsQueryable();

            if (!string.IsNullOrEmpty(SearchString))
            {
                links = links.Where(l => 
                    (l.Label != null && l.Label.Contains(SearchString)) || 
                    (l.Description != null && l.Description.Contains(SearchString)) ||
                    (l.GameID != null && l.GameID.Contains(SearchString)) ||
                    (l.BookTitle != null && l.BookTitle.Contains(SearchString)));
            }
            
            if (!string.IsNullOrEmpty(SelectedTopic))
            {
                links = links.Where(l => l.GameID == SelectedTopic || l.BookTitle == SelectedTopic);
            }
            if (!string.IsNullOrEmpty(SelectedLinkType))
            {
                links = links.Where(l => l.LinkType.ToString() == SelectedLinkType);
            }

            // Apply sorting
            switch (SortField)
            {
                case "Topic":
                    links = links.OrderBy(l => l.GameID ?? l.BookTitle).ThenBy(l => l.Label);
                    break;
                case "Type":
                    links = links.OrderBy(l => l.LinkType).ThenBy(l => l.Label);
                    break;
                case "Label":
                    links = links.OrderBy(l => l.Label).ThenBy(l => l.GameID ?? l.BookTitle);
                    break;
                case "Description":
                    links = links.OrderBy(l => l.Description).ThenBy(l => l.GameID ?? l.BookTitle);
                    break;
            }

            Links = await links.Where(l => l.LinkType != LinkType.Wiki).ToListAsync();
        }
    }
} 