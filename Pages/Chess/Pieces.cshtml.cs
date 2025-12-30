using ASP_site.Data;
using ASP_site.Models.Chess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP_site.Pages.Chess
{
        public class PiecesModel : PageModel
    {
        private readonly GameContext _context;

        public PiecesModel(GameContext context)
        {
            _context = context;
        }

        public IList<PieceViewModel> DisplayPieces { get; set; } = new List<PieceViewModel>();

        public class PieceViewModel
        {
            public required ChessPiece Piece { get; set; }
            public required string DisplayName { get; set; }
            public List<VariantLink> Variants { get; set; } = new();
            public List<VariantLink> Armies { get; set; } = new();
        }

        public class VariantLink 
        {
            public required string Id { get; set; }
            public required string Name { get; set; }
        }

        public string? NameSort { get; set; }
        public string? SymbolSort { get; set; }
        public string? NotationSort { get; set; }
        public string? ValueSort { get; set; }
        public string? CurrentSort { get; set; }

        public Microsoft.AspNetCore.Mvc.Rendering.SelectList? GameOptions { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string? SelectedGame { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool HideDuplicates { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            CurrentSort = sortOrder;
            NameSort = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            SymbolSort = sortOrder == "Symbol" ? "symbol_desc" : "Symbol";
            NotationSort = sortOrder == "Notation" ? "notation_desc" : "Notation";
            ValueSort = sortOrder == "Value" ? "value_desc" : "Value";

            // 1. Fetch all pieces
            var allPieces = await _context.ChessPieces
                // .Include(p => p.Armies) // Removed as Armies merged into Placements
                .AsNoTracking()
                .ToListAsync();

            // 2. Fetch all placements with Variant info
            var variantPlacements = await _context.ArmyPlacements
                .Include(p => p.Variant)
                .Where(p => p.VariantId != null)
                .AsNoTracking()
                .ToListAsync();

            // 3. (Removed explicit Army placements fetch as they are now in Variant placements)

            // 4. Build comprehensive list of Variant Names for the dropdown
            var variantNamesFromPieces = allPieces
                .Where(p => p.Names != null)
                .SelectMany(p => p.Names)
                .Select(n => n.VariantID)
                .Where(v => !string.IsNullOrEmpty(v));
            
            var variantNamesFromPlacements = variantPlacements
                .Select(p => p.Variant?.Name ?? p.VariantId)
                .Where(v => !string.IsNullOrEmpty(v));

            var allVariantNames = variantNamesFromPieces
                .Concat(variantNamesFromPlacements)
                .Distinct()
                .OrderBy(v => v)
                .ToList();
            
            GameOptions = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(allVariantNames);

            // 5. Flatten and Group Logic
            var flattenedList = new List<PieceViewModel>();
            
            foreach (var piece in allPieces)
            {
                // -- A. Gather all Name-Context pairs --
                // ContextType: 0=Variant, 1=Army
                var nameContextPairs = new List<(string Name, string Id, string ContextName, int ContextType)>();

                // A1. From ChessPiece.Names (Manual Variants)
                if (piece.Names != null)
                {
                    foreach (var n in piece.Names)
                    {
                        nameContextPairs.Add((n.Name, n.VariantID, n.VariantID, 0)); // 0=Variant
                    }
                }

                // A2. From Placements (Dynamic)
                var vPlacements = variantPlacements.Where(p => p.PieceId == piece.PieceID).ToList();
                foreach (var p in vPlacements)
                {
                    var name = !string.IsNullOrEmpty(p.Name) ? p.Name : piece.DisplayName;
                    var vId = p.VariantId ?? "";
                    var vName = p.Variant?.Name ?? vId;
                    
                    if (p.Variant != null && p.Variant.IsArmy)
                    {
                        nameContextPairs.Add((name, vId, vName, 1)); // 1=Army
                    }
                    else
                    {
                        nameContextPairs.Add((name, vId, vName, 0)); // 0=Variant
                    }
                }

                // (Removed A3 block)
                
                // If no names at all, add default
                if (!nameContextPairs.Any())
                {
                    nameContextPairs.Add((piece.DisplayName, "", "", -1));
                }

                // -- B. Group by Name --
                var groups = nameContextPairs
                    .GroupBy(x => x.Name, StringComparer.OrdinalIgnoreCase)
                    .ToList();

                foreach (var group in groups)
                {
                    var name = group.Key;
                    
                    // Extract Variants
                    var variants = group
                        .Where(x => x.ContextType == 0 && !string.IsNullOrEmpty(x.Id))
                        .Select(x => new VariantLink { Id = x.Id, Name = x.ContextName })
                        .GroupBy(v => v.Id)
                        .Select(g => g.First())
                        .OrderBy(v => v.Name)
                        .ToList();

                    // Extract Armies
                    var armies = group
                        .Where(x => x.ContextType == 1 && !string.IsNullOrEmpty(x.Id))
                        .Select(x => new VariantLink { Id = x.Id, Name = x.ContextName })
                        .GroupBy(v => v.Id)
                        .Select(g => g.First())
                        .OrderBy(v => v.Name)
                        .ToList();

                    // -- C. Filter Logic --
                    
                    // C1. Search String
                    bool matchesSearch = true;
                    if (!string.IsNullOrEmpty(SearchString))
                    {
                        bool baseMatch = (piece.Symbol?.Contains(SearchString, StringComparison.OrdinalIgnoreCase) ?? false) ||
                                         (piece.Notation?.Contains(SearchString, StringComparison.OrdinalIgnoreCase) ?? false) ||
                                         (piece.History?.Contains(SearchString, StringComparison.OrdinalIgnoreCase) ?? false) ||
                                         (piece.MoveDescription?.Contains(SearchString, StringComparison.OrdinalIgnoreCase) ?? false);
                        
                        bool nameMatch = name.Contains(SearchString, StringComparison.OrdinalIgnoreCase);
                        
                        bool variantMatch = variants.Any(v => v.Name.Contains(SearchString, StringComparison.OrdinalIgnoreCase));
                        bool armyMatch = armies.Any(a => a.Name.Contains(SearchString, StringComparison.OrdinalIgnoreCase));

                        matchesSearch = baseMatch || nameMatch || variantMatch || armyMatch;
                    }

                    // C2. Selected Game (Variant)
                    bool matchesGame = true;
                    if (!string.IsNullOrEmpty(SelectedGame))
                    {
                        matchesGame = variants.Any(v => 
                            v.Id.Equals(SelectedGame, StringComparison.OrdinalIgnoreCase) || 
                            v.Name.Equals(SelectedGame, StringComparison.OrdinalIgnoreCase));
                    }

                    if (matchesSearch && matchesGame)
                    {
                        flattenedList.Add(new PieceViewModel
                        {
                            Piece = piece,
                            DisplayName = name,
                            Variants = variants,
                            Armies = armies
                        });
                    }
                }
            }

            // -- D. Hide Duplicates --
            if (HideDuplicates)
            {
                var pieceGroups = flattenedList.GroupBy(p => p.Piece.PieceID);
                var distinctList = new List<PieceViewModel>();
                
                foreach(var pg in pieceGroups)
                {
                    // Prefer the one that matches Piece.DisplayName
                    var primary = pg.FirstOrDefault(p => p.DisplayName == p.Piece.DisplayName) ?? pg.First();
                    distinctList.Add(primary);
                }
                flattenedList = distinctList;
            }

            // -- E. Sorting --
            switch (sortOrder)
            {
                case "Symbol":
                    flattenedList = flattenedList.OrderBy(p => p.Piece.Symbol).ToList();
                    break;
                case "symbol_desc":
                    flattenedList = flattenedList.OrderByDescending(p => p.Piece.Symbol).ToList();
                    break;
                case "Notation":
                    flattenedList = flattenedList.OrderBy(p => p.Piece.Notation).ToList();
                    break;
                case "notation_desc":
                    flattenedList = flattenedList.OrderByDescending(p => p.Piece.Notation).ToList();
                    break;
                case "Value":
                    flattenedList = flattenedList.OrderBy(p => p.Piece.Value).ToList();
                    break;
                case "value_desc":
                    flattenedList = flattenedList.OrderByDescending(p => p.Piece.Value).ToList();
                    break;
                case "name_desc":
                     flattenedList = flattenedList.OrderByDescending(p => p.DisplayName).ToList();
                     break;
                default:
                     flattenedList = flattenedList.OrderBy(p => p.DisplayName).ToList();
                     break;
            }

            DisplayPieces = flattenedList;
        }
    }
}
