using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_site.Models;
using ASP_site.Data;

namespace ASP_site.Pages.Servers
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;
        public IndexModel(GameContext context)
        {
            _context = context;
        }

        public List<Server> Servers { get; set; } = new();
        public SelectList? Games { get; set; }
        public SelectList? ServerTypes { get; set; }
        [BindProperty(SupportsGet = true)] public string? SearchString { get; set; }
        [BindProperty(SupportsGet = true)] public string? SelectedGame { get; set; }
        [BindProperty(SupportsGet = true)] public string? SelectedServerType { get; set; }
        [BindProperty(SupportsGet = true)] public string SortField { get; set; } = "Game";

        public async Task OnGetAsync()
        {
            ViewData["ActivePage"] = "Servers";
            // Create select list for games filter
            IQueryable<string> gameQuery = from g in _context.Games
                                         orderby g.Name
                                         select g.Name;
            Games = new SelectList(await gameQuery.Distinct().ToListAsync());

            // Create select list for server types filter
            var serverTypesList = Enum.GetValues(typeof(ServerType))
                .Cast<ServerType>()
                .Select(st => st.ToString());
            ServerTypes = new SelectList(serverTypesList);

            // Create base query for servers
            var servers = from s in _context.Servers
                         select s;

            // Apply search if provided
            if (!string.IsNullOrEmpty(SearchString))
            {
                servers = servers.Where(s => 
                    (s.Name ?? "").Contains(SearchString) || 
                    (s.Description ?? "").Contains(SearchString) ||
                    (s.GameID ?? "").Contains(SearchString));
            }

            // Apply filters if selected
            if (!string.IsNullOrEmpty(SelectedGame))
            {
                servers = servers.Where(s => s.GameID == SelectedGame);
            }
            if (!string.IsNullOrEmpty(SelectedServerType))
            {
                servers = servers.Where(s => s.ServerType.ToString() == SelectedServerType);
            }

            // Apply sorting
            switch (SortField)
            {
                case "Game":
                    servers = servers.OrderBy(s => s.GameID).ThenBy(s => s.Name);
                    break;
                case "Type":
                    servers = servers.OrderBy(s => s.ServerType).ThenBy(s => s.Name);
                    break;
                case "Name":
                    servers = servers.OrderBy(s => s.Name).ThenBy(s => s.GameID);
                    break;
                case "Description":
                    servers = servers.OrderBy(s => s.Description).ThenBy(s => s.GameID);
                    break;
            }

            Servers = await servers.ToListAsync();
        }
    }
}