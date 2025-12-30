using ASP_site.Helpers;

namespace ASP_site.Models.ViewModels
{
    public class ArmyPieceData
    {
        public string Symbol { get; set; } = "?";
        public string Name { get; set; } = "";
        public string ImagePath { get; set; } = ""; // Added for SVG support
        public List<MoveTrajectory> Trajectories { get; set; } = new();
    }

    public class ArmyBoardViewModel
    {
        // Primary Army (usually White, at bottom)
        public Dictionary<(int r, int f), ArmyPieceData> Pieces { get; set; } = new();
        
        // Opposing Army (usually Black, at top)
        public Dictionary<(int r, int f), ArmyPieceData> BlackPieces { get; set; } = new();

        // Hand pieces: Pieces that are "in hand" (Rank < 0)
        public List<ArmyPieceData> HandPieces { get; set; } = new();

        // Promotion Zones
        public HashSet<(int r, int f)> PromotionZones { get; set; } = new();
    }
}
