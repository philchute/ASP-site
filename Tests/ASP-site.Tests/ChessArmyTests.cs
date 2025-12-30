using Xunit;
using ASP_site.Models.Chess;
using System.Collections.Generic;
using System.Linq;

namespace ASP_site.Tests
{
    public class ChessArmyTests
    {
        [Fact]
        public void TestArmy_WithValidPlacements_ShouldBeValid()
        {
            var army = new ChessArmy
            {
                ArmyID = "TestArmy",
                Name = "Test Army",
                StartingPosition = new List<ChessArmyPlacement>
                {
                    new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                    new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 }
                }
            };

            // Basic sanity checks
            Assert.Equal(2, army.StartingPosition.Count);
            Assert.DoesNotContain(army.StartingPosition, p => p.Rank < 0 || p.Rank > 7);
            Assert.DoesNotContain(army.StartingPosition, p => p.File < 0 || p.File > 7);
            
            // Ensure no overlaps
            var overlaps = army.StartingPosition
                .GroupBy(p => new { p.Rank, p.File })
                .Where(g => g.Count() > 1);
            Assert.Empty(overlaps);
        }

        [Fact]
        public void TestArmy_OverlapDetection()
        {
            var army = new ChessArmy
            {
                ArmyID = "OverlapArmy",
                Name = "Overlap Army",
                StartingPosition = new List<ChessArmyPlacement>
                {
                    new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                    new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 } // Overlap!
                }
            };

            var groups = army.StartingPosition
                .GroupBy(p => new { p.Rank, p.File })
                .Where(g => g.Count() > 1);

            Assert.NotEmpty(groups); // Should find overlap
        }
    }
}

