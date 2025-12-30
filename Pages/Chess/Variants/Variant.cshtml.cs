using ASP_site.Data;
using ASP_site.Helpers;
using ASP_site.Models.Chess;
using ASP_site.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP_site.Pages.Chess.Variants
{
    public class VariantModel : PageModel
    {
        private readonly GameContext _context;

        public VariantModel(GameContext context)
        {
            _context = context;
        }

        public ChessVariant Variant { get; set; } = default!;
        public List<ASP_site.Models.Link> RelatedLinks { get; set; } = new();
        public VariantBoardViewModel BoardViewModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Variants == null)
            {
                return NotFound();
            }

            var variant = await _context.Variants
                .Include(v => v.Placements)
                .ThenInclude(p => p.Piece)
                .FirstOrDefaultAsync(m => m.VariantID == id);

            if (variant == null)
            {
                return NotFound();
            }

            Variant = variant;

            // Load related links
            RelatedLinks = await _context.Links
                .Where(l => l.VariantID == id)
                .ToListAsync();

            BoardViewModel = new VariantBoardViewModel
            {
                Width = Variant.BoardWidth,
                Height = Variant.BoardHeight,
                Placements = Variant.Placements,
                DeadZones = Variant.DeadZones.Select(z => (z.Rank, z.File)).ToHashSet(),
                RiverZones = Variant.RiverZones.Select(z => (z.Rank, z.File)).ToHashSet()
            };

            // Calculate Promotion Zones
            // Default: If no rules, all squares on Rank 0 and Rank Height-1
            if (Variant.PromotionRules == null || !Variant.PromotionRules.Any())
            {
                for (int f = 0; f < Variant.BoardWidth; f++)
                {
                    BoardViewModel.PromotionZones.Add((0, f));
                    BoardViewModel.PromotionZones.Add((Variant.BoardHeight - 1, f));
                }
            }
            else
            {
                foreach (var rule in Variant.PromotionRules)
                {
                    // Add specific zones
                    foreach (var z in rule.PromotionZones)
                    {
                        BoardViewModel.PromotionZones.Add((z.Rank, z.File));
                    }
                    
                    // Add whole ranks
                    foreach (var r in rule.PromotionRanks)
                    {
                        if (r >= 0 && r < Variant.BoardHeight)
                        {
                            for (int f = 0; f < Variant.BoardWidth; f++)
                            {
                                BoardViewModel.PromotionZones.Add((r, f));
                            }
                        }
                    }
                }
            }
            
            // Populate interactive pieces
            // We assume Placements define ONE side (White/South).
            // We will automatically generate the opponent (Black/North) by mirroring.
            
            foreach (var p in Variant.Placements)
            {
                if (p.Piece != null)
                {
                    var pieceName = !string.IsNullOrEmpty(p.Name) ? p.Name : p.Piece.DisplayName;

                    // 1. Add Original Piece (White)
                    if (p.Rank < 0)
                    {
                        // Piece in Hand
                        BoardViewModel.HandPieces.Add(new VariantPieceData
                        {
                            Symbol = p.Piece.Symbol ?? "?",
                            Name = pieceName,
                            Notation = p.Piece.Notation ?? "",
                            Color = PieceColor.White,
                            Trajectories = new List<MoveTrajectory>() 
                        });
                    }
                    else
                    {
                        // Piece on Board (White)
                        var moves = BetzaParser.Parse(p.Piece.Notation ?? "");
                        var trajs = BetzaParser.GetValidTrajectories(moves, p.Rank, p.File, Variant.BoardHeight, Variant.BoardWidth);
                        
                        BoardViewModel.Pieces[(p.Rank, p.File)] = new VariantPieceData
                        {
                            Symbol = p.Piece.Symbol ?? "?",
                            Name = pieceName,
                            Notation = p.Piece.Notation ?? "",
                            Color = PieceColor.White,
                            Trajectories = trajs
                        };

                        // 2. Add Mirror Piece (Black)
                        // Mirror Rank: (Height - 1) - Rank
                        var mirrorRank = (Variant.BoardHeight - 1) - p.Rank;
                        var mirrorFile = p.File; 

                        // Don't overwrite if something is manually placed there
                        if (!BoardViewModel.Pieces.ContainsKey((mirrorRank, mirrorFile)))
                        {
                            // Calculate trajectories for Black
                            // 1. Parse original moves (white perspective)
                            var blackMovesRaw = BetzaParser.Parse(p.Piece.Notation ?? "");
                            
                            // 2. Invert vectors (dy -> -dy) to simulate "Forward" being "Down"
                            foreach(var m in blackMovesRaw)
                            {
                                m.Dy = -m.Dy; // Invert rank direction
                            }
                            
                            var blackTrajs = BetzaParser.GetValidTrajectories(blackMovesRaw, mirrorRank, mirrorFile, Variant.BoardHeight, Variant.BoardWidth);
                            
                            BoardViewModel.Pieces[(mirrorRank, mirrorFile)] = new VariantPieceData
                            {
                                Symbol = p.Piece.Symbol ?? "?",
                                Name = pieceName, 
                                Notation = p.Piece.Notation ?? "",
                                Color = PieceColor.Black,
                                Trajectories = blackTrajs
                            };
                        }
                    }
                }
            }

            return Page();
        }
    }
}
