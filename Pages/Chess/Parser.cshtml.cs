using ASP_site.Data;
using ASP_site.Helpers;
using ASP_site.Models.Chess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP_site.Pages.Chess
{
    public class ParserModel : PageModel
    {
        private readonly GameContext _context;

        public ParserModel(GameContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string? Notation { get; set; }

        public List<MoveTrajectory> Trajectories { get; set; } = new();
        
        public ChessPiece? MatchingPiece { get; set; }

        public void OnGet()
        {
            ProcessNotation();
        }

        public void OnPost()
        {
            ProcessNotation();
        }

        private void ProcessNotation()
        {
            if (string.IsNullOrWhiteSpace(Notation)) return;

            // normalize input string for comparison (legacy trimming)
            Notation = Notation.Trim();

            // Parse input moves once
            var inputMoves = BetzaParser.Parse(Notation);

            // Find matching piece by comparing move sets
            // Note: This iterates all pieces and parses their notation. 
            // For a large DB, we should cache the parsed moves or canonical signatures.
            MatchingPiece = _context.ChessPieces
                .AsEnumerable() 
                .FirstOrDefault(p => {
                    var pieceMoves = BetzaParser.Parse(p.Notation ?? "");
                    return BetzaParser.AreMovesEquivalent(inputMoves, pieceMoves);
                });

            // If no exact match, maybe look for a superset/subset?
            // The user requested "ideally even ones that are subsets".
            // Let's store potential partial matches if exact match fails?
            // For now, let's just stick to exact match for the "Success" alert, 
            // but we could populate a "RelatedPieces" list property.
            
            // Generate moves for visualization using the parsed input
            Trajectories = BetzaParser.GetValidTrajectories(inputMoves);
        }
    }
}
