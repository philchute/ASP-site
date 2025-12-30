using ASP_site.Data;
using ASP_site.Models.Chess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP_site.Pages.Chess.Variants
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;

        public IndexModel(GameContext context)
        {
            _context = context;
        }

        public List<EvolutionNode> Nodes { get; set; } = new();
        
        // Flattened list for graph rendering logic (e.g. layers)
        public List<List<EvolutionNode>> Layers { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public List<ChessVariant> SearchResults { get; set; } = new();

        public class EvolutionNode
        {
            public required string Id { get; set; }
            public required string Name { get; set; }
            public List<string> ParentIds { get; set; } = new();
            public bool IsArmy { get; set; }
            public string? Year { get; set; }
            public int ParsedYear { get; set; }
            public int BoardWidth { get; set; }
            public int BoardHeight { get; set; }
            
            // For layout
            public int LayerIndex { get; set; }
            public double XIndex { get; set; } // Horizontal position
            public List<EvolutionNode> Parents { get; set; } = new();
            public List<EvolutionNode> Children { get; set; } = new();
        }

        public async Task OnGetAsync()
        {
            if (!string.IsNullOrEmpty(SearchString))
            {
                // Search Mode
                SearchResults = await _context.Variants
                    .AsNoTracking()
                    .Where(v => !v.IsArmy && v.Name.Contains(SearchString))
                    .OrderBy(v => v.Year).ThenBy(v => v.Name)
                    .ToListAsync();
                return; // Skip graph generation
            }

            var variants = await _context.Variants
                .AsNoTracking()
                .Where(v => !v.IsArmy)
                .ToListAsync();

            // Create nodes map
            var nodeDict = variants.Select(v => new EvolutionNode
            {
                Id = v.VariantID,
                Name = v.Name,
                ParentIds = v.ParentIDs ?? new List<string>(),
                IsArmy = v.IsArmy,
                Year = v.Year,
                ParsedYear = ParseYear(v.Year),
                BoardWidth = v.BoardWidth, // Map BoardWidth
                BoardHeight = v.BoardHeight // Map BoardHeight
            }).ToDictionary(n => n.Id);

            Nodes = nodeDict.Values.ToList();

            // Build graph connections
            foreach (var node in Nodes)
            {
                foreach (var pid in node.ParentIds)
                {
                    if (nodeDict.TryGetValue(pid, out var parent))
                    {
                        node.Parents.Add(parent);
                        parent.Children.Add(node);
                    }
                }
            }

            // Simple Layering by Year (Topological Sort approximation)
            var sortedYears = Nodes.Select(n => n.ParsedYear).Distinct().OrderBy(y => y).ToList();
            
            // Assign Layers
            foreach(var y in sortedYears)
            {
                // Order by Board Size (Width * Height) then Name
                var layer = Nodes.Where(n => n.ParsedYear == y)
                                 .OrderBy(n => (n.BoardWidth * n.BoardHeight))
                                 .ThenBy(n => n.Name)
                                 .ToList();
                Layers.Add(layer);
                foreach(var node in layer) node.LayerIndex = Layers.Count - 1;
            }

            // Find global min and max board size for normalization
            int minSize = int.MaxValue;
            int maxSize = int.MinValue;
            if (Nodes.Any())
            {
                minSize = Nodes.Min(n => n.BoardWidth * n.BoardHeight);
                maxSize = Nodes.Max(n => n.BoardWidth * n.BoardHeight);
            }
            // Ensure we have a range
            if (maxSize == minSize) { minSize = 0; maxSize = Math.Max(maxSize, 100); }
            double sizeRange = maxSize - minSize;
            if (sizeRange == 0) sizeRange = 1;

            // Normalize X positions
            foreach (var node in Nodes)
            {
                int size = node.BoardWidth * node.BoardHeight;
                // Map to 10% - 90% range to avoid edge clipping
                node.XIndex = 10.0 + ((size - minSize) / sizeRange) * 80.0;
            }
            
            // Resolve Collisions within each layer
            foreach (var layer in Layers)
            {
                // Sort by XIndex
                var sortedLayer = layer.OrderBy(n => n.XIndex).ToList();
                
                // Simple sweep to push overlapping nodes apart
                // Min distance between centers in % (e.g. 12% width for a card)
                double minSpacing = 12.0; 
                
                // We might need multiple passes or a center-out approach.
                // Let's do a simple left-to-right sweep.
                for (int i = 1; i < sortedLayer.Count; i++)
                {
                    var prev = sortedLayer[i-1];
                    var curr = sortedLayer[i];
                    
                    if (curr.XIndex < prev.XIndex + minSpacing)
                    {
                        // Push current right
                        curr.XIndex = prev.XIndex + minSpacing;
                    }
                }
                
                // If we pushed too far right (> 95%), shift the whole group back left?
                if (sortedLayer.Any() && sortedLayer.Last().XIndex > 95.0)
                {
                    double overshoot = sortedLayer.Last().XIndex - 95.0;
                    foreach(var n in sortedLayer) n.XIndex -= overshoot;
                }
            }
            
            // Center the whole graph?
            // Optional: Propagate UP again to center parents over children? (Iterative refinement)
            // For now, simple top-down is better than random.
        }

        // Helper methods for distribution removed as logic changed
        private int ParseYear(string? year)
        {
            if (string.IsNullOrEmpty(year)) return 9999;
            var digits = new string(year.Where(char.IsDigit).ToArray());
            if (int.TryParse(digits, out int result)) return result;
            return 9999;
        }
    }
}
