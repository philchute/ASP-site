using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Models.Chess;
using ASP_site.Models.ViewModels;
using ASP_site.Helpers;

namespace ASP_site.Pages.Chess
{
    public class PieceModel : PageModel
    {
        private readonly GameContext _context;

        public PieceModel(GameContext context)
        {
            _context = context;
        }

        public ChessPiece Piece { get; set; } = default!;
        public ChessBoardViewModel BoardViewModel { get; set; } = default!;

        // Grouped aliases for display
        public List<AliasViewModel> Aliases { get; set; } = new();

        public class AliasViewModel
        {
            public required string Name { get; set; }
            public List<VariantLink> Variants { get; set; } = new();
        }

        public class VariantLink
        {
            public required string Id { get; set; }
            public required string Name { get; set; }
            public bool IsArmy { get; set; }
        }

        public async Task<IActionResult> OnGetAsync(string pieceId)
        {
            if (pieceId == null)
            {
                return NotFound();
            }

            var piece = await _context.ChessPieces
                .Include(p => p.Placements)
                .ThenInclude(pl => pl.Variant)
                .FirstOrDefaultAsync(m => m.PieceID == pieceId);

            if (piece == null)
            {
                return NotFound();
            }

            // Placements are already loaded via Include
            
            Piece = piece;

            // --- Board Visualization Logic ---
            // Calculate moves from center (e4 -> rank 3, file 4)
            var centerRank = 3;
            var centerFile = 4;
            var moves = BetzaParser.Parse(Piece.Notation ?? "");
            
            // Generate visual data using the same logic as before, but encapsulated in the ViewModel construction if possible
            // Reusing logic from previous Razor view block:
            var validMoves = BetzaParser.GetValidMovesFromVectors(moves, centerRank, centerFile);
            var hurdleSquares = new HashSet<(int r, int f)>();
            var filteredMoves = new List<(int r, int f, bool isSlide, bool isCapture, bool isMove, bool isHopper, bool isLame, bool isGrasshopper)>();
            
            var groups = validMoves.GroupBy(m => {
                int dr = m.r - centerRank;
                int df = m.f - centerFile;
                if (dr == 0 && df == 0) return (0, 0); 
                int gcd = ChessUtils.GCD(Math.Abs(dr), Math.Abs(df));
                return (dr / gcd, df / gcd);
            });

            foreach (var group in groups)
            {
                var dir = group.Key;
                var dirMoves = group.OrderBy(m => Math.Abs(m.r - centerRank) + Math.Abs(m.f - centerFile)).ToList();
                
                var hopperMoves = dirMoves.Where(m => m.isHopper || m.isGrasshopper).ToList();
                var normalMoves = dirMoves.Where(m => !m.isHopper && !m.isGrasshopper).ToList();
                
                filteredMoves.AddRange(normalMoves);
                
                if (hopperMoves.Any())
                {
                    // Heuristic: Pick a representative move at distance >= 3 to illustrate the jump/hop
                    var demoMove = hopperMoves.FirstOrDefault(m => Math.Abs(m.r - centerRank) >= 3);
                    if (demoMove == default) demoMove = hopperMoves.FirstOrDefault();
                                
                    if (demoMove != default)
                    {
                         (int hr, int hf) hurdlePos = (0,0);
                         
                         if (demoMove.isGrasshopper)
                         {
                             // Hurdle is adjacent (Target - 1 step)
                             hurdlePos = (demoMove.r - dir.Item1, demoMove.f - dir.Item2);
                         }
                         else // isHopper (p)
                         {
                             // Hurdle at dist 1
                             hurdlePos = (centerRank + dir.Item1, centerFile + dir.Item2);
                         }
                         
                         hurdleSquares.Add(hurdlePos);
                         
                         if (demoMove.isGrasshopper)
                         {
                             filteredMoves.Add(demoMove);
                         }
                         else
                         {
                             // Add all hopper moves that are beyond the hurdle
                             foreach(var hm in hopperMoves)
                             {
                                 if (Math.Abs(hm.r - centerRank) > Math.Abs(hurdlePos.hr - centerRank) ||
                                     Math.Abs(hm.f - centerFile) > Math.Abs(hurdlePos.hf - centerFile))
                                 {
                                     filteredMoves.Add(hm);
                                 }
                             }
                         }
                    }
                }
            }
            
            BoardViewModel = new ChessBoardViewModel
            {
                Trajectories = BetzaParser.GetValidTrajectories(moves, centerRank, centerFile),
                CenterPieceSymbol = Piece.Symbol ?? "X",
                CenterPieceNotation = Piece.Notation ?? "",
                Hurdles = hurdleSquares
            };


            // --- Populate Aliases Logic ---
            // Re-using loaded placements or querying fresh if simpler for this logic block
            var placements = piece.Placements.Where(p => p.VariantId != null).ToList();

            var nameVariantPairs = new List<(string Name, string VariantId, string VariantName, bool IsArmy)>();

            if (piece.Names != null)
            {
                foreach (var n in piece.Names)
                {
                    nameVariantPairs.Add((n.Name, n.VariantID, n.VariantID, false)); // Manual names assumed to be variants? Or check?
                    // Usually Manual names are just aliases for Variants, not necessarily checked against IsArmy unless we fetch them.
                    // For now, assume false or "unknown".
                }
            }

            foreach (var p in placements)
            {
                var name = !string.IsNullOrEmpty(p.Name) ? p.Name : piece.DisplayName;
                var vId = p.VariantId ?? "";
                var vName = p.Variant?.Name ?? vId;
                var isArmy = p.Variant?.IsArmy ?? false;
                nameVariantPairs.Add((name, vId, vName, isArmy));
            }

            Aliases = nameVariantPairs
                .GroupBy(x => x.Name, StringComparer.OrdinalIgnoreCase)
                .Select(g => new AliasViewModel 
                { 
                    Name = g.Key, 
                    Variants = g.Where(x => !string.IsNullOrEmpty(x.VariantId))
                                .Select(x => new VariantLink { Id = x.VariantId, Name = x.VariantName, IsArmy = x.IsArmy })
                                .GroupBy(v => v.Id)
                                .Select(gv => gv.First()) 
                                .OrderBy(v => v.Name)
                                .ToList() 
                })
                .OrderBy(a => a.Name)
                .ToList();

            return Page();
        }
    }
}
