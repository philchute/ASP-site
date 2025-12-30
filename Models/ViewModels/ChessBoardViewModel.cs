using ASP_site.Helpers;

namespace ASP_site.Models.ViewModels
{
    public class ChessBoardViewModel
    {
        public List<MoveTrajectory> Trajectories { get; set; } = new();
        public string CenterPieceSymbol { get; set; } = "X";
        public string CenterPieceNotation { get; set; } = "";
        
        // Optional: Hurdles/Ghost pieces
        public HashSet<(int r, int f)> Hurdles { get; set; } = new();

        // Support for multiple pieces on board
        public List<(int r, int f, string symbol, string style)> Pieces { get; set; } = new();

        // New visual properties
        public HashSet<(int r, int f)> Threats { get; set; } = new();
        public string AnimationFramesJson { get; set; } = "";
    }
}
