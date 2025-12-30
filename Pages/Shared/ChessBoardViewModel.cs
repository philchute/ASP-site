using ASP_site.Helpers;

namespace ASP_site.Pages.Shared
{
    public class ChessBoardViewModel
    {
        public List<MoveTrajectory> Trajectories { get; set; } = new();
        public int CenterRank { get; set; } = 3;
        public int CenterFile { get; set; } = 4;
        public string PieceSymbol { get; set; } = "X";
        public bool IsImmune { get; set; } = false;
        public HashSet<(int r, int f)> HurdleSquares { get; set; } = new();
    }
}

