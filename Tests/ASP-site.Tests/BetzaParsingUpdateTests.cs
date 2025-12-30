using Xunit;
using ASP_site.Helpers;
using System.Linq;

namespace ASP_site.Tests
{
    public class BetzaParsingUpdateTests
    {
        [Fact]
        public void TestDebugXW()
        {
            var moves = BetzaParser.Parse("xW");
            Assert.NotEmpty(moves);
            Assert.All(moves, m => Assert.False(m.IsSlide));
            Assert.All(moves, m => Assert.True(m.IsExplode));
        }

        [Fact]
        public void TestNewModifiers_Parsing()
        {
            // Test explode (x), power (w), enpassant (e), test (t)
            var moves = BetzaParser.Parse("xWeR");
            
            // Wazir with explode
            var wazir = moves.Where(m => m.Range == 0 && Math.Abs(m.Dx) + Math.Abs(m.Dy) == 1 && !m.IsSlide).ToList();
            Assert.NotEmpty(wazir);
            Assert.All(wazir, m => Assert.True(m.IsExplode));

            // Rook with enpassant
            var rook = moves.Where(m => m.IsSlide).ToList();
            Assert.NotEmpty(rook);
            Assert.All(rook, m => Assert.True(m.IsEnPassant));
        }

        /*
        private string GetSig(MoveVector m) {
             return $"{m.Dx},{m.Dy}";
        }
        */

        [Fact]
        public void TestSkipCount_j()
        {
            // jR = Rook skipping 1
            var jR = BetzaParser.Parse("jR");
            Assert.All(jR, m => Assert.Equal(1, m.SkipCount));

            // jjR = Rook skipping 2
            var jjR = BetzaParser.Parse("jjR");
            Assert.All(jjR, m => Assert.Equal(2, m.SkipCount));
        }

        [Fact]
        public void TestRelativeSequence_FaR()
        {
            // Aanca (Griffon) test: Fers then Rook (outward)
            // FaR -> Fers move (1,1) then Rook move (relative forward)
            // Should contain (1,1)+(0,1)=(1,2) and (1,1)+(1,0)=(2,1)
            // Should NOT contain (1,1)+(-1,0)=(0,1) or (1,1)+(0,-1)=(1,0) [backwards/90deg turn in wrong way]
            
            var moves = BetzaParser.Parse("FaR");
            
            // We expect trajectories/destinations to be consistent with "Outward"
            // Fers (1,1) -> from there, R can go (0,1) or (1,0). 
            // Result vectors: (1,1)+(0,1)=(1,2) and (1,1)+(1,0)=(2,1)
            // (1,1)+(-1,0)=(0,1) should be excluded
            // (1,1)+(0,-1)=(1,0) should be excluded
            
            // Let's check the MoveVectors directly
            // Note: CombineSequence produces vectors that are sums.
            
            var vectors = moves.Select(m => (m.Dx, m.Dy)).ToList();
            
            // Check for expected
            Assert.Contains((1, 2), vectors);
            Assert.Contains((2, 1), vectors);
            Assert.Contains((-1, 2), vectors); // F(-1,1) + R(0,1)
            
            // Check for excluded
            Assert.DoesNotContain((0, 1), vectors);
            Assert.DoesNotContain((1, 0), vectors);
        }

        [Fact]
        public void TestAbsoluteSequence_F_minus_R()
        {
            // F-R (Standard sequence)
            // Should allow all combinations
            var moves = BetzaParser.Parse("F-R");
            var vectors = moves.Select(m => (m.Dx, m.Dy)).ToList();
            
            // Should contain "backward" moves like (1,1)+(-1,0)=(0,1)
            Assert.Contains((0, 1), vectors);
        }

        [Fact]
        public void TestOptional_QuestionMark()
        {
            // W? = Wazir or Null
            var moves = BetzaParser.Parse("W?");
            
            // Should have W moves + (0,0)
            Assert.Contains(moves, m => m.Dx == 0 && m.Dy == 0 && !m.IsMove);
            Assert.Contains(moves, m => Math.Abs(m.Dx) + Math.Abs(m.Dy) == 1);
        }

        [Fact]
        public void TestOptional_Sequence()
        {
            // W?R -> (Null or W) then R -> R or W-R
            var moves = BetzaParser.Parse("W?-R"); // Note: - is needed if explicit sequence? 
            // Or "W?R" (concatenation) = Union(W?, R) = W, Null, R.
            // Wait, BetzaParser parses terms.
            // W? is a term. R is a term.
            // W?R -> Union of W? and R.
            
            // W?-R -> Sequence of W? and R.
            // (Null-R) U (W-R) -> R U (W-R).
            
            var seqMoves = BetzaParser.Parse("W?-R");
            
            // Should contain simple Rook moves (from Null-R)
            var simpleRook = seqMoves.Any(m => m.IsSlide && m.Dx==0 && m.Dy==1 && m.Components.Count == 2);
            // Null move in components might make it look like sequence, but vector is simple R.
            // Verify if we have vectors like (0,1)
            
            var vectors = seqMoves.Select(m => (m.Dx, m.Dy)).ToList();
            Assert.Contains((0, 1), vectors); // R
            Assert.Contains((0, 2), vectors); // W(0,1)+R(0,1)
        }
        [Fact]
        public void TestSequenceDifferentiation_FaR_vs_WaB()
        {
            // FaR (Fers then Rook) = Aanca
            // WaB (Wazir then Bishop) = Similar vectors but different structure?
            // F(1,1)+R(0,1) -> (1,2)
            // W(0,1)+B(1,1) -> (1,2)
            // They produce same displacement vectors, but structurally are different.
            // WaB is Wazir-Bishop (sequence of atoms). FaR is Fers-Rook (sequence of atoms).
            // Previously they were considered equivalent because only displacement matter.
            // Now we check components.
            
            var movesFaR = BetzaParser.Parse("FaR");
            var movesWaB = BetzaParser.Parse("WaB");
            
            Assert.NotEmpty(movesFaR);
            Assert.NotEmpty(movesWaB);
            
            // They should NOT be equivalent now
            bool areEq = BetzaParser.AreMovesEquivalent(movesFaR, movesWaB);
            Assert.False(areEq, "FaR and WaB should be distinct due to different components.");
        }
    }
}

