using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASP_site.Models.Chess
{
    public class ChessPieceName
    {
        public string Name { get; set; } = "";
        public string VariantID { get; set; } = "";
    }

    public class ChessPiece
    {
        [Key] public required string PieceID { get; set; } // Unique identifier for the piece
        public string? Symbol { get; set; } // e.g. "P", "K", "R", "N" etc or SVG path
        public string? Notation { get; set; } // Betza notation
        public string? MoveDescription { get; set; } // Text description of how it moves
        public string? History { get; set; } // Historical background, lore, origins
        public int? Value { get; set; } // Approximate piece value (Pawn=1)
        
        // Default promotion target (PieceID or "Any"). If null, assumes no promotion.
        public string? PromotesTo { get; set; }

        public List<ChessPieceName> Names { get; set; } = new List<ChessPieceName>();
        [JsonIgnore] public string DisplayName => Names?.FirstOrDefault()?.Name ?? PieceID;
        [JsonIgnore] public List<ChessArmyPlacement> Placements { get; set; } = new List<ChessArmyPlacement>();
    }
}
