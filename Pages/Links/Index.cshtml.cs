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

        public class LinkViewModel
        {
            public string? Topic { get; set; }
            public string? TopicUrl { get; set; }
            public LinkType LinkType { get; set; }
            public string? Url { get; set; }
            public string? Label { get; set; }
            public string? Description { get; set; }
        }

        public IndexModel(GameContext context)
        {
            _context = context;
        }

        public List<LinkViewModel> DisplayLinks { get; set; } = new();
        public SelectList Topics { get; set; } = new SelectList(new List<SelectListItem>());
        public SelectList LinkTypes { get; set; } = new SelectList(new List<string>());
        [BindProperty(SupportsGet = true)] public string? SearchString { get; set; }
        [BindProperty(SupportsGet = true)] public string? SelectedTopic { get; set; }
        [BindProperty(SupportsGet = true)] public string? SelectedLinkType { get; set; }
        [BindProperty(SupportsGet = true)] public string SortField { get; set; } = "Topic";

        public async Task OnGetAsync()
        {
            ViewData["ActivePage"] = "Links";

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

            var linkTypesList = Enum.GetValues(typeof(LinkType))
                .Cast<LinkType>()
                .Where(lt => lt != LinkType.Wiki && lt != LinkType.Store && lt != LinkType.SteamDB)
                .Select(lt => lt.ToString());
            LinkTypes = new SelectList(linkTypesList);

            var linksQuery = _context.Links.Where(l => l.LinkType != LinkType.Wiki && l.LinkType != LinkType.Store && l.LinkType != LinkType.SteamDB);

            if (!string.IsNullOrEmpty(SearchString))
            {
                linksQuery = linksQuery.Where(l => 
                    (l.Label != null && l.Label.Contains(SearchString)) || 
                    (l.Description != null && l.Description.Contains(SearchString)) ||
                    (l.GameID != null && l.GameID.Contains(SearchString)) ||
                    (l.BookTitle != null && l.BookTitle.Contains(SearchString)));
            }
            
            if (!string.IsNullOrEmpty(SelectedTopic))
            {
                linksQuery = linksQuery.Where(l => l.GameID == SelectedTopic || l.BookTitle == SelectedTopic);
            }
            if (!string.IsNullOrEmpty(SelectedLinkType))
            {
                linksQuery = linksQuery.Where(l => l.LinkType.ToString() == SelectedLinkType);
            }

            var links = await linksQuery.ToListAsync();
            
            var gamesDict = await _context.Games.ToDictionaryAsync(g => g.GameID, g => g.Name);

            var displayLinks = links.Select(l => new LinkViewModel
            {
                Topic = !string.IsNullOrEmpty(l.GameID) ? gamesDict.GetValueOrDefault(l.GameID, l.GameID) : l.BookTitle,
                TopicUrl = !string.IsNullOrEmpty(l.GameID) ? $"/Games/Game?GameID={l.GameID}" : $"/Books/Book?BookTitle={l.BookTitle}",
                LinkType = l.LinkType,
                Url = l.Url,
                Label = l.Label,
                Description = l.Description
            }).ToList();

            switch (SortField)
            {
                case "Topic":
                    displayLinks = displayLinks.OrderBy(l => l.Topic).ThenBy(l => l.Label).ToList();
                    break;
                case "Type":
                    displayLinks = displayLinks.OrderBy(l => l.LinkType).ThenBy(l => l.Label).ToList();
                    break;
                case "Label":
                    displayLinks = displayLinks.OrderBy(l => l.Label).ThenBy(l => l.Topic).ToList();
                    break;
                case "Description":
                    displayLinks = displayLinks.OrderBy(l => l.Description).ThenBy(l => l.Topic).ToList();
                    break;
            }

            DisplayLinks = displayLinks;
        }
    }
} 