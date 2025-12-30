using System.ComponentModel.DataAnnotations;

namespace ASP_site.Models.Chess
{
    public class ChessArmyPlacement
    {
        public int Id { get; set; }
        
        public string? VariantId { get; set; }
        public ChessVariant? Variant { get; set; }

        // PieceId is required to define what is placed.
        public required string PieceId { get; set; }
        public ChessPiece? Piece { get; set; }
        
        // Name override for this piece in this specific context
        public string? Name { get; set; }

        // Promotion override: What this specific piece promotes to (PieceID or "Any")
        public string? PromotesTo { get; set; }

        // Coordinates (0-7 for standard 8x8)
        public int Rank { get; set; }
        public int File { get; set; }
    }
}
