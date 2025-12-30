using Xunit;
using ASP_site.Helpers;
using System.Linq;

namespace ASP_site.Tests
{
    public class BetzaParserTests
    {
        [Theory]
        [InlineData("RB", "Q")]
        [InlineData("RB", "BR")]
        [InlineData("WW", "R")]
        [InlineData("W3", "R3")]
        public void TestBetzaEquivalence(string notation1, string notation2)
        {
            var moves1 = BetzaParser.Parse(notation1);
            var moves2 = BetzaParser.Parse(notation2);

            // Using helper method logic for equivalence
            bool areEquivalent = BetzaParser.AreMovesEquivalent(moves1, moves2);
            
            Assert.True(areEquivalent, $"{notation1} should be equivalent to {notation2}");
        }

        [Fact]
        public void TestSequence_NW()
        {
            // N-W: Knight then Wazir
            var moves = BetzaParser.Parse("N-W");

            Assert.NotNull(moves);
            Assert.NotEmpty(moves);
            Assert.True(moves.Count > 0);
        }

        [Fact]
        public void TestAgain_FaF_ShouldNotBeSlider()
        {
            // Fers again Fers (FaF)
            // Should be a set of jumps (Alfil + Dabbaba squares), not sliders.
            // (1,1)+(1,1) = (2,2)
            // (1,1)+(-1,1) = (0,2) - This happens twice! (1,1)+(-1,1) and (-1,1)+(1,1)
            // If the parser merges these into a slider, this test will fail.
            var moves = BetzaParser.Parse("FaF");

            // Check if any are sliders
            var sliders = moves.Where(m => m.IsSlide).ToList();
            
            Assert.Empty(sliders); 
        }

        [Fact]
        public void TestModifiers_ZigzagAndCircular()
        {
            // zR = Crooked Rook (Zigzag)
            var zigzag = BetzaParser.Parse("zR");
            Assert.Contains(zigzag, m => m.IsCrooked);
            
            // qN = Circular Knight (Rose)
            var circular = BetzaParser.Parse("qN");
            Assert.Contains(circular, m => m.IsCircular);
        }

        [Fact]
        public void TestAttributes_Parsing()
        {
            // [Immune]K -> King moves with "Immune" attribute
            var moves = BetzaParser.Parse("[Immune]K");
            Assert.NotEmpty(moves);
            Assert.All(moves, m => Assert.Contains("Immune", m.Attributes));

            // [Power]f[Safe]R -> Forward Rook with "Power" and "Safe"
            var complex = BetzaParser.Parse("[Power]f[Safe]R");
            Assert.NotEmpty(complex);
            Assert.All(complex, m => 
            {
                Assert.Contains("Power", m.Attributes);
                Assert.Contains("Safe", m.Attributes);
                Assert.True(m.Dy > 0); // Forward check
            });
        }
    }
}
