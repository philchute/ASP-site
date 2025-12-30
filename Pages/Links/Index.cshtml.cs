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
        [BindProperty(SupportsGet = true)] public bool ShowWikiLinks { get; set; }
        [BindProperty(SupportsGet = true)] public bool ShowStoreLinks { get; set; }
        [BindProperty(SupportsGet = true)] public bool ShowSteamDBLinks { get; set; }
        [BindProperty(SupportsGet = true)] public string SortField { get; set; } = "Topic";

        public async Task OnGetAsync()
        {
            ViewData["ActivePage"] = "Links";

            // 1. Base query for links
            IQueryable<Link> interestingLinksQuery = _context.Links;

            if (!ShowWikiLinks)
            {
                interestingLinksQuery = interestingLinksQuery.Where(l => l.LinkType != LinkType.Wiki);
            }
            if (!ShowStoreLinks)
            {
                interestingLinksQuery = interestingLinksQuery.Where(l => l.LinkType != LinkType.Store);
            }
            if (!ShowSteamDBLinks)
            {
                interestingLinksQuery = interestingLinksQuery.Where(l => l.LinkType != LinkType.SteamDB);
            }

            // 2. Get all distinct topic identifiers from the links in one query
            var activeLinkTopics = await interestingLinksQuery
                .Select(l => new { l.GameID, l.BookTitle, l.ArmyID, l.VariantID })
                .Distinct()
                .ToListAsync();

            var activeGameIds = activeLinkTopics
                .Where(l => !string.IsNullOrEmpty(l.GameID))
                .Select(l => l.GameID)
                .Distinct();

            var activeBookTitles = activeLinkTopics
                .Where(l => !string.IsNullOrEmpty(l.BookTitle))
                .Select(l => l.BookTitle)
                .Distinct();
            
            // Consolidate ArmyID and VariantID into one list of Variant IDs
            var activeVariantIds = activeLinkTopics
                .SelectMany(l => new[] { l.ArmyID, l.VariantID })
                .Where(id => !string.IsNullOrEmpty(id))
                .Distinct();

            // 3. Look up Game Names (since we only have IDs)
            var gameTopics = await _context.Games
                                         .Where(g => activeGameIds.Contains(g.GameID))
                                         .Select(g => new SelectListItem { Value = g.GameID, Text = g.Name })
                                         .ToListAsync();

            // 4. Create Book items directly (Title is both ID and Text)
            var bookTopics = activeBookTitles
                                         .Select(t => new SelectListItem { Value = t, Text = t });
            
            // 5. Look up Variant Names (includes Armies)
            var variantTopics = await _context.Variants
                                          .Where(v => activeVariantIds.Contains(v.VariantID))
                                          .Select(v => new SelectListItem { Value = v.VariantID, Text = v.Name })
                                          .ToListAsync();

            var allTopics = gameTopics.Concat(bookTopics).Concat(variantTopics).OrderBy(t => t.Text);

            Topics = new SelectList(allTopics, "Value", "Text");

            // 4. Build the Link Types dropdown (excluding boring types unless shown)
            var linkTypesList = Enum.GetValues(typeof(LinkType))
                .Cast<LinkType>()
                .Where(lt => 
                    (ShowWikiLinks || lt != LinkType.Wiki) && 
                    (ShowStoreLinks || lt != LinkType.Store) && 
                    (ShowSteamDBLinks || lt != LinkType.SteamDB))
                .Select(lt => lt.ToString());
            LinkTypes = new SelectList(linkTypesList);
            
            // 5. Initialize the main query for the page using the base interesting query
            var linksQuery = interestingLinksQuery;

            if (!string.IsNullOrEmpty(SearchString))
            {
                linksQuery = linksQuery.Where(l => 
                    (l.Label != null && l.Label.Contains(SearchString)) || 
                    (l.Description != null && l.Description.Contains(SearchString)) ||
                    (l.GameID != null && l.GameID.Contains(SearchString)) ||
                    (l.BookTitle != null && l.BookTitle.Contains(SearchString)) ||
                    (l.ArmyID != null && l.ArmyID.Contains(SearchString)) ||
                    (l.VariantID != null && l.VariantID.Contains(SearchString)));
            }
            
            if (!string.IsNullOrEmpty(SelectedTopic))
            {
                linksQuery = linksQuery.Where(l => l.GameID == SelectedTopic || l.BookTitle == SelectedTopic || l.ArmyID == SelectedTopic || l.VariantID == SelectedTopic);
            }
            if (!string.IsNullOrEmpty(SelectedLinkType))
            {
                linksQuery = linksQuery.Where(l => l.LinkType.ToString() == SelectedLinkType);
            }

            var links = await linksQuery.ToListAsync();
            
            var gamesDict = await _context.Games.ToDictionaryAsync(g => g.GameID, g => g.Name);
            
            var relevantVariantIds = links.SelectMany(l => new[] { l.ArmyID, l.VariantID })
                                          .Where(id => !string.IsNullOrEmpty(id))
                                          .Distinct()
                                          .ToList();
            
            var variantsDict = await _context.Variants
                                    .Where(v => relevantVariantIds.Contains(v.VariantID))
                                    .ToDictionaryAsync(v => v.VariantID, v => v.Name);

            var displayLinks = links.Select(l => new LinkViewModel
            {
                Topic = !string.IsNullOrEmpty(l.GameID) ? gamesDict.GetValueOrDefault(l.GameID, l.GameID) : 
                        !string.IsNullOrEmpty(l.VariantID) ? variantsDict.GetValueOrDefault(l.VariantID, l.VariantID) :
                        !string.IsNullOrEmpty(l.ArmyID) ? variantsDict.GetValueOrDefault(l.ArmyID, l.ArmyID) :
                        l.BookTitle,
                TopicUrl = !string.IsNullOrEmpty(l.GameID) ? $"/Games/{l.GameID}" : 
                           !string.IsNullOrEmpty(l.ArmyID) ? $"/Chess/Armies/Army/{l.ArmyID}" : 
                           !string.IsNullOrEmpty(l.VariantID) ? $"/Chess/Variants/Variant/{l.VariantID}" :
                           $"/Books/{l.BookTitle}",
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