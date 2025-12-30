using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_site.Models.Chess
{
    public class BoardSquare
    {
        public int Rank { get; set; }
        public int File { get; set; }
    }

    public class PromotionRule
    {
        // 1. Zone Definition
        
        // Specific squares.
        public List<BoardSquare> PromotionZones { get; set; } = new();
        
        // Shortcut: Whole Ranks (0-based indices).
        // e.g. [0, 7] for standard promotion on first and last ranks.
        public List<int> PromotionRanks { get; set; } = new();

        // 2. Piece Constraints (Optional)
        
        // Which pieces does this rule apply to?
        // Empty = All pieces that have a 'PromotesTo' set (or are Pawns).
        public List<string> PromotablePieceIds { get; set; } = new();

        // 3. Target Overrides (Optional)
        
        // What can they promote to?
        // Empty = Use the piece's defined 'PromotesTo' target (or standard game rules).
        // Populated = Override the target (e.g. promoting on a specific square gives a different piece).
        public List<string> PromotionTargetPieceIds { get; set; } = new();
    }

    public class ChessVariant
    {
        [Key]
        public required string VariantID { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Year { get; set; }
        
        public List<string> ParentIDs { get; set; } = new List<string>();

        public int BoardWidth { get; set; } = 8;
        public int BoardHeight { get; set; } = 8;

        public List<BoardSquare> DeadZones { get; set; } = new();
        public List<BoardSquare> RiverZones { get; set; } = new();
        
        public List<PromotionRule> PromotionRules { get; set; } = new();

        public List<ChessArmyPlacement> Placements { get; set; } = new();

        // Flag to distinguish Equal Strength Armies from Variants
        public bool IsArmy { get; set; } = false;

        // Computed property for Unique Pieces
        [NotMapped]
        public IEnumerable<ChessPiece> Pieces => Placements
            .Select(p => p.Piece)
            .OfType<ChessPiece>() // Filters out nulls
            .Distinct();
    }
}
