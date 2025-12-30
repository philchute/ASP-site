using ASP_site.Helpers;
using ASP_site.Models.Chess;

namespace ASP_site.Models.ViewModels
{
    public enum PieceColor
    {
        White,
        Black
    }

    public class VariantPieceData
    {
        public string Symbol { get; set; } = "?";
        public string Name { get; set; } = "";
        public string Notation { get; set; } = "";
        public PieceColor Color { get; set; } = PieceColor.White;
        public List<MoveTrajectory> Trajectories { get; set; } = new();
    }

    public class VariantBoardViewModel
    {
        public int Width { get; set; } = 8;
        public int Height { get; set; } = 8;
        
        public IEnumerable<ChessArmyPlacement> Placements { get; set; } = new List<ChessArmyPlacement>(); // Keeping original list for simple rendering or fallback
        
        // Interactive data
        public Dictionary<(int r, int f), VariantPieceData> Pieces { get; set; } = new();
        
        public HashSet<(int r, int f)> DeadZones { get; set; } = new();
        public HashSet<(int r, int f)> RiverZones { get; set; } = new();
        public HashSet<(int r, int f)> PromotionZones { get; set; } = new();
        
        // Hand pieces: Pieces that are "in hand" (Rank < 0)
        public List<VariantPieceData> HandPieces { get; set; } = new();

        public bool ShowCoordinates { get; set; } = true;
    }
}
