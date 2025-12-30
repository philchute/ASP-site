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
            var army = new ChessVariant
            {
                VariantID = "TestArmy",
                Name = "Test Army",
                Placements = new List<ChessArmyPlacement>
                {
                    new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                    new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 }
                }
            };

            // Basic sanity checks
            Assert.Equal(2, army.Placements.Count);
            Assert.DoesNotContain(army.Placements, p => p.Rank < 0 || p.Rank > 7);
            Assert.DoesNotContain(army.Placements, p => p.File < 0 || p.File > 7);
            
            // Ensure no overlaps
            var overlaps = army.Placements
                .GroupBy(p => new { p.Rank, p.File })
                .Where(g => g.Count() > 1);
            Assert.Empty(overlaps);
        }

        [Fact]
        public void TestArmy_OverlapDetection()
        {
            var army = new ChessVariant
            {
                VariantID = "OverlapArmy",
                Name = "Overlap Army",
                Placements = new List<ChessArmyPlacement>
                {
                    new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                    new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 } // Overlap!
                }
            };

            var groups = army.Placements
                .GroupBy(p => new { p.Rank, p.File })
                .Where(g => g.Count() > 1);

            Assert.NotEmpty(groups); // Should find overlap
        }
    }
}

