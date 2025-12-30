using ASP_site.Data;
using ASP_site.Models.Chess;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP_site.Pages.Chess
{
    public class HistoryModel : PageModel
    {
        private readonly GameContext _context;

        public HistoryModel(GameContext context)
        {
            _context = context;
        }

        public IList<HistoryItem> Timeline { get; set; } = new List<HistoryItem>();

        public class HistoryItem
        {
            public required string Year { get; set; }
            public required string Name { get; set; }
            public string? Description { get; set; }
            public required string Id { get; set; }
            public bool IsArmy { get; set; }
            public string? Author { get; set; }
        }

        public async Task OnGetAsync()
        {
            // Fetch all variants (including armies) that have a Year defined
            var items = await _context.Variants
                .Where(v => v.Year != null && v.Year != "")
                .AsNoTracking()
                .ToListAsync();

            Timeline = items
                .Select(v => new HistoryItem
                {
                    Year = v.Year!,
                    Name = v.Name,
                    Description = v.Description,
                    Id = v.VariantID,
                    IsArmy = v.IsArmy,
                    Author = v.Author
                })
                .OrderBy(x => ParseYear(x.Year))
                .ToList();
        }

        private int ParseYear(string year)
        {
            // Simple parser for "1920", "c. 1600", "2000s"
            // Extract first sequence of digits
            var digits = new string(year.Where(char.IsDigit).ToArray());
            if (int.TryParse(digits, out int result))
            {
                // Heuristic: if year is short (e.g. 1, 2 digits), it might be century? 
                // But typically users enter 4 digits.
                return result;
            }
            return 9999; // Unknown/Future
        }
    }
}

