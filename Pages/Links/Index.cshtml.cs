using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using ASP_site.Data;

namespace ASP_site.Pages.Links
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;
        public IndexModel(GameContext context)
        {
            _context = context;
        }

        public List<Link>? Links { get; set; }
        public SelectList? Games { get; set; }
        public SelectList? LinkTypes { get; set; }
        [BindProperty(SupportsGet = true)] public string? SearchString { get; set; }
        [BindProperty(SupportsGet = true)] public string? SelectedGame { get; set; }
        [BindProperty(SupportsGet = true)] public string? SelectedLinkType { get; set; }
        [BindProperty(SupportsGet = true)] public string SortField { get; set; } = "Game";

        public async Task OnGetAsync()
        {
            ViewData["ActivePage"] = "Links";
            // Create select list for games filter
            IQueryable<string> gameQuery = from g in _context.Games
                                         orderby g.Name
                                         select g.Name;
            Games = new SelectList(await gameQuery.Distinct().ToListAsync());

            // Create select list for link types filter (excluding Steam and SteamDB)
            var linkTypesList = Enum.GetValues(typeof(LinkType))
                .Cast<LinkType>()
                .Where(lt => lt != LinkType.StoreLink && lt != LinkType.SteamDB)
                .Select(lt => lt.ToString());
            LinkTypes = new SelectList(linkTypesList);

            // Create base query for links, excluding Steam and SteamDB links
            var links = from l in _context.Links
                       where l.LinkType != LinkType.StoreLink && l.LinkType != LinkType.SteamDB
                       select l;

            // Apply search if provided
            if (!string.IsNullOrEmpty(SearchString))
            {
                links = links.Where(l => 
                    l.Label.Contains(SearchString) || 
                    l.Description.Contains(SearchString) ||
                    l.GameID.Contains(SearchString));
            }

            // Apply filters if selected
            if (!string.IsNullOrEmpty(SelectedGame))
            {
                links = links.Where(l => l.GameID == SelectedGame);
            }
            if (!string.IsNullOrEmpty(SelectedLinkType))
            {
                links = links.Where(l => l.LinkType.ToString() == SelectedLinkType);
            }

            // Apply sorting
            switch (SortField)
            {
                case "Game":
                    links = links.OrderBy(l => l.GameID).ThenBy(l => l.Label);
                    break;
                case "Type":
                    links = links.OrderBy(l => l.LinkType).ThenBy(l => l.Label);
                    break;
                case "Label":
                    links = links.OrderBy(l => l.Label).ThenBy(l => l.GameID);
                    break;
                case "Description":
                    links = links.OrderBy(l => l.Description).ThenBy(l => l.GameID);
                    break;
            }

            Links = await links.ToListAsync();
        }
    }
} 