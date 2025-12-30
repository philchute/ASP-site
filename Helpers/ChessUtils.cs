using ASP_site.Models.Chess;
using System.Text.RegularExpressions;

namespace ASP_site.Helpers
{
    public static class ChessUtils
    {
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }

    public class MoveVector
    {
        public int Dx { get; set; }
        public int Dy { get; set; }
        public bool IsSlide { get; set; } // true = slide (arrow), false = jump (dot)
        public bool IsCapture { get; set; } = true;
        public bool IsMove { get; set; } = true;
        public int Range { get; set; } = 0; // 0 = infinite (if IsSlide)
        public bool IsLame { get; set; } // n modifier (Lame leaper)
        public int SkipCount { get; set; } // j modifier (Skip first N)
        public bool IsHopper { get; set; } // p modifier (Cannon-like)
        public bool IsGrasshopper { get; set; } // g modifier (Grasshopper-like)
        public bool IsInitial { get; set; } // i modifier
        public bool IsCylindrical { get; set; } // o modifier
        public bool IsCrooked { get; set; } // z modifier (Zigzag)
        public bool IsCircular { get; set; } // q modifier (Circular/Curve)
        public bool IsExplode { get; set; } // x modifier
        public bool IsPowerTransfer { get; set; } // w modifier
        public bool IsEnPassant { get; set; } // e modifier
        public HashSet<string> Attributes { get; set; } = new HashSet<string>();
        public List<MoveVector> Components { get; set; } = new List<MoveVector>(); // For sequences
    }

    public class MoveTrajectory
    {
        public int TargetRank { get; set; }
        public int TargetFile { get; set; }
        public List<(int r, int f)> Path { get; set; } = new();
        public bool IsCapture { get; set; }
        public bool IsMove { get; set; }
        public bool IsSlide { get; set; }
        public bool IsHopper { get; set; }
        public bool IsLame { get; set; }
        public int SkipCount { get; set; }
        public bool IsCrooked { get; set; }
        public bool IsCircular { get; set; }
        public bool IsExplode { get; set; }
        public bool IsPowerTransfer { get; set; }
        public bool IsEnPassant { get; set; }
        public HashSet<string> Attributes { get; set; } = new();

        public int StartRank { get; set; }
        public int StartFile { get; set; }
    }

    public static class BetzaParser
    {
        // Parses Betza notation (simplified).
        // Supports:
        // Atoms: W, F, D, N, A, C, Z, G, H, R, B, K (alias for WF), Q (alias for RB, but preferably explicit)
        // Modifiers: f (forward), b (backward), r (right), l (left), m (move only), c (capture only), v (vertical), s (sideways)
        //            ff/bb/rr/ll (steep/flat variants)
        //            n (lame), j (jump), p (hopper), g (grasshopper), i (initial), o (cylindrical)
        //            z (crooked/zigzag), q (circular)
        // Structure: 
        //   - Concatenation (Union): B R (Bishop and Rook)
        //   - Sequence: N-W (Knight step then Wazir step)
        //   - Grouping: f(NB) (Forward Knight and Forward Bishop)
        //   - Range: R4 (Rook max 4 steps)
        //   - Repetition: WW (Rider)

        public static List<MoveVector> Parse(string notation)
        {
            if (string.IsNullOrEmpty(notation)) return new List<MoveVector>();
            
            // Remove whitespace for parsing
            var cleanNotation = notation.Replace(" ", "");
            
            // Note: Normalization logic below might need update if we keep brackets, 
            // but for now we trust the clean string.
            
            var parser = new RecursiveParser(cleanNotation);
            var moves = parser.Parse();

            // Post-processing: Merge identical atomic moves into sliders (Riders)
            // e.g. WW -> Wazir + Wazir -> Wazir Rider (Rook)
            moves = MergeRepeatedMoves(moves);

            return moves;
        }

        public static string NormalizeNotation(string notation)
        {
            if (string.IsNullOrWhiteSpace(notation)) return "";

            // If notation contains complex structure (brackets, dashes), fallback to simple trimming
            // to avoid breaking the structure with simple sorting.
            if (notation.Contains('(') || notation.Contains(')') || notation.Contains('-'))
            {
                return notation.Trim();
            }

            // Legacy normalization for simple strings: sort atoms
            var matches = Regex.Matches(notation, @"([a-z]*)([A-Z])([0-9]*)");
            var tokens = new List<string>();

            foreach (Match match in matches)
            {
                tokens.Add(match.Value);
            }

            tokens.Sort();
            return string.Join("", tokens);
        }

        private static List<MoveVector> MergeRepeatedMoves(List<MoveVector> moves)
        {
            // Group by direction and core properties
            // We only merge if they are "jumps" (IsSlide=false). 
            // If we have multiple jumps to the same square with same modifiers, we promote to Slide.
            // Note: This logic assumes the repetition implies "range extension" (Rider).
            
            var result = new List<MoveVector>();
            
                // Grouping key: Direction (Dx, Dy) + Modifiers (Capture, Move, Lame, etc) + Attributes
                // We use a custom key for grouping to handle the Set properly
                var groups = moves.GroupBy(m => new { 
                    m.Dx, m.Dy, 
                    m.IsCapture, m.IsMove, 
                    m.IsLame, m.SkipCount, m.IsHopper, m.IsGrasshopper, m.IsInitial, m.IsCylindrical, m.IsCrooked, m.IsCircular,
                    m.IsExplode, m.IsPowerTransfer, m.IsEnPassant,
                    AttrSignature = string.Join("|", m.Attributes.OrderBy(x => x))
                });

            foreach (var group in groups)
            {
                var first = group.First();
                var count = group.Count();
                
                // If we have duplicates and it's not already a slide, promote to slide
                // Also promote if we have a single entry but it specifies a range > 1 (e.g. W4 -> Wazir Rider 4)
                if ((count > 1 || (count == 1 && first.Range > 1)) && !first.IsSlide)
                {
                    // Create a slide version
                    var slide = CloneMove(first);
                    slide.IsSlide = true;
                    // Use the maximum range specified in the group, or 0 (infinite) if any is 0 or unassigned?
                    // Usually atoms have range 0. If W4 is present, range is 4.
                    // If WW4 is present, we have W(0) and W(4).
                    // Logic: If any component implies infinite (0), result is infinite (0).
                    // Else use max range.
                    // Wait, standard atoms have range 0. Does 0 mean infinite for a LEAPER? No, it means 1 step.
                    // But our parser sets Range=0 by default.
                    
                    // Let's look at the group members.
                    int maxRange = 0;
                    bool hasInfinite = false;
                    
                    foreach(var m in group)
                    {
                        if (m.Range == 0) hasInfinite = true; 
                        else if (m.Range > maxRange) maxRange = m.Range;
                    }

                    // If we are promoting leaper to slider:
                    // W (Range 0) -> Means "Unit step". When promoted to slider, 0 usually means infinite.
                    // W4 (Range 4) -> Means "Unit step, but limit to 4?" No, W4 means Wazir Rider 4.
                    
                    // If we have W (0) and W4 (4).
                    // W(0) -> infinite rider? Yes, WW = R.
                    // So if any is 0, it's infinite.
                    if (hasInfinite) slide.Range = 0;
                    else slide.Range = maxRange;
                    
                    result.Add(slide);
                }
                else
                {
                    // Keep original(s) - if it was already slide, or just single jump
                    // If it was already slide, duplicates are redundant, just keep one? 
                    // Betza: R R -> R. So yes, keep one.
                    result.Add(first);
                }
            }

            return result;
        }

        private static MoveVector CloneMove(MoveVector m)
        {
            return new MoveVector
            {
                Dx = m.Dx, Dy = m.Dy,
                IsSlide = m.IsSlide, IsCapture = m.IsCapture, IsMove = m.IsMove,
                Range = m.Range, IsLame = m.IsLame, SkipCount = m.SkipCount, IsHopper = m.IsHopper, 
                IsGrasshopper = m.IsGrasshopper, IsInitial = m.IsInitial, IsCylindrical = m.IsCylindrical,
                IsCrooked = m.IsCrooked, IsCircular = m.IsCircular,
                IsExplode = m.IsExplode, IsPowerTransfer = m.IsPowerTransfer, 
                IsEnPassant = m.IsEnPassant,
                Attributes = new HashSet<string>(m.Attributes),
                Components = new List<MoveVector>(m.Components)
            };
        }

        // --- Recursive Parser Class ---
        private class RecursiveParser
        {
            private readonly string _input;
            private int _pos;

            public RecursiveParser(string input)
            {
                _input = input;
                _pos = 0;
            }

            public List<MoveVector> Parse()
            {
                var moves = new List<MoveVector>();
                // Stop at ) or ] (since both are now closers for their respective openers)
                while (_pos < _input.Length && _input[_pos] != ')' && _input[_pos] != ']')
                {
                    int startPos = _pos;
                    moves.AddRange(ParseTerm());
                    
                    // Safety check: ensure we are advancing
                    if (_pos == startPos)
                    {
                        // Encountered unexpected character or stuck
                        // Advance to avoid infinite loop
                        _pos++; 
                    }
                }
                return moves;
            }

            private List<MoveVector> ParseTerm()
            {
                // A term might be a sequence connected by '-' or 'a' (again)
                // First parse the first element
                var left = ParseElement();

                // Check for optional modifier '?' (0 or 1)
                if (_pos < _input.Length && _input[_pos] == '?')
                {
                    _pos++;
                    // Add a Null move (Identity) to the set
                    // This allows the move to effectively be skipped in a sequence (A?B -> AB | B)
                    left.Add(new MoveVector { Dx = 0, Dy = 0, IsMove = false, IsCapture = false, IsSlide = false });
                }

                // Check for sequence operator
                // Supports '-' (standard Betza 2.0) and 'a' (XBetza "again")
                if (_pos < _input.Length)
                {
                    bool isSequence = false;
                    bool isRelative = false;

                    if (_input[_pos] == '-')
                    {
                        _pos++; // consume '-'
                        isSequence = true;
                    }
                    else if (_input[_pos] == 'a')
                    {
                        _pos++; // consume 'a'
                        isSequence = true;
                        isRelative = true;
                    }

                    if (isSequence)
                    {
                        var right = ParseTerm(); // Recurse for right side (chains: a-b-c)
                        return CombineSequence(left, right, isRelative);
                    }
                }

                return left;
            }

            private List<MoveVector> ParseElement()
            {
                // Parse Attributes and Modifiers (prefixes)
                // We loop to allow mixed sequence like [Attr]f[Attr2]b
                // Though standard Betza puts modifiers first, we allow flexibility.
                
                var attributes = new HashSet<string>();
                string modifiers = "";

                while (_pos < _input.Length)
                {
                    if (_input[_pos] == '[')
                    {
                        attributes.Add(ParseAttribute());
                    }
                    else if (char.IsLower(_input[_pos]) && _input[_pos] != 'a')
                    {
                        modifiers += ParseModifiers();
                    }
                    else
                    {
                        // Not an attribute start and not a modifier start -> Atom or other token
                        break;
                    }
                }

                List<MoveVector> baseMoves = new List<MoveVector>();
                int range = 0;

                // Check for Branching/Grouping ( )
                if (_pos < _input.Length && _input[_pos] == '(')
                {
                    if (IsCoordinateNext())
                    {
                        // Coordinate syntax: (x,y)
                        _pos++; // consume '('
                        baseMoves = ParseCoordinate();
                        if (_pos < _input.Length && _input[_pos] == ')') _pos++;
                    }
                    else
                    {
                        // Branching / Option syntax: (A|B) means A OR B
                        _pos++; // consume '('
                        baseMoves = ParseOptions(); // Parses options separated by |
                        if (_pos < _input.Length && _input[_pos] == ')') _pos++; // consume ')'
                    }
                }
                else if (_pos < _input.Length && char.IsUpper(_input[_pos]))
                {
                    // Atom
                    string atom = _input[_pos].ToString();
                    _pos++;
                    baseMoves = GetAtomMoves(atom);
                    
                    // Check for Range (digits immediately following atom)
                    range = ParseRange();
                }

                // Apply modifiers
                var result = ApplyModifiers(baseMoves, modifiers, range);
                
                // Apply attributes
                if (attributes.Count > 0)
                {
                    foreach (var m in result)
                    {
                        foreach (var attr in attributes)
                        {
                            m.Attributes.Add(attr);
                        }
                    }
                }
                
                return result;
            }

            private bool IsCoordinateNext()
            {
                if (_pos + 1 >= _input.Length) return false;
                char c = _input[_pos + 1];
                return char.IsDigit(c) || c == '-' || c == '+';
            }

            private List<MoveVector> ParseCoordinate()
            {
                int start = _pos;
                while (_pos < _input.Length && _input[_pos] != ',' && _input[_pos] != ')') _pos++;
                if (_pos == start) return new List<MoveVector>();

                if (!int.TryParse(_input.Substring(start, _pos - start), out int x)) return new List<MoveVector>();

                if (_pos < _input.Length && _input[_pos] == ',') _pos++;
                
                start = _pos;
                while (_pos < _input.Length && _input[_pos] != ')') _pos++;
                if (_pos == start) return new List<MoveVector>();

                if (!int.TryParse(_input.Substring(start, _pos - start), out int y)) return new List<MoveVector>();

                return GetArbitraryLeapMoves(x, y);
            }

            private string ParseAttribute()
            {
                // Assumes starts with '['
                _pos++; // consume '['
                int start = _pos;
                while (_pos < _input.Length && _input[_pos] != ']')
                {
                    _pos++;
                }
                string attr = _input.Substring(start, _pos - start);
                if (_pos < _input.Length) _pos++; // consume ']'
                return attr;
            }

            private List<MoveVector> ParseOptions()
            {
                // Parses content inside (...) 
                // Previously split by | but now implicit union (concatenation) is preferred per spec.
                // We basically consume terms until ')'
                var moves = new List<MoveVector>();
                var seenSignatures = new HashSet<string>();

                while (_pos < _input.Length && _input[_pos] != ')')
                {
                    // Skip legacy pipe if present, though spec says "take it out"
                    if (_pos < _input.Length && _input[_pos] == '|')
                    {
                        _pos++; 
                    }
                    
                    var termMoves = ParseTerm();
                    foreach (var m in termMoves)
                    {
                        var sig = GetMoveSignature(m);
                        if (seenSignatures.Add(sig))
                        {
                            moves.Add(m);
                        }
                    }
                }
                
                return moves;
            }

            private string ParseModifiers()
            {
                int start = _pos;
                // Parse modifiers (lowercase letters)
                // Stop at 'a' because it is now a sequence operator (again), not a modifier.
                while (_pos < _input.Length && char.IsLower(_input[_pos]) && _input[_pos] != 'a')
                {
                    _pos++;
                }
                return _input.Substring(start, _pos - start);
            }

            private int ParseRange()
            {
                int start = _pos;
                while (_pos < _input.Length && char.IsDigit(_input[_pos]))
                {
                    _pos++;
                }
                if (start == _pos) return 0;
                if (int.TryParse(_input.Substring(start, _pos - start), out int result))
                {
                    return result;
                }
                return 0;
            }

            private List<MoveVector> CombineSequence(List<MoveVector> first, List<MoveVector> second, bool isRelative = false)
            {
                // Vector addition of all combinations (Minkowski sum).
                // Standard Betza atoms imply absolute offsets unless specific relative modifiers are used.
                // If isRelative (from 'a' operator), we filter m2 based on m1's direction.
                
                var result = new List<MoveVector>();
                var seenSignatures = new HashSet<string>();

                foreach (var m1 in first)
                {
                    foreach (var m2 in second)
                    {
                        // Relativity check
                        if (isRelative)
                        {
                            // If m1 is a null move (0,0), direction is undefined/neutral, so allow all.
                            // If m2 is a null move, allow.
                            if ((m1.Dx != 0 || m1.Dy != 0) && (m2.Dx != 0 || m2.Dy != 0))
                            {
                                // Dot product heuristic: m1 . m2 > 0 implies "Forward-ish" continuity.
                                // We strictly require > 0 to filter out 90-degree turns if they are orthogonal to diagonal.
                                // Case Aanca: m1=(1,1) [NE]. 
                                // m2=(0,1) [N]. Dot = 1. OK.
                                // m2=(1,0) [E]. Dot = 1. OK.
                                // m2=(-1,0) [W]. Dot = -1. NO.
                                // m2=(-1,1) [NW]. Dot = 0. NO. (90 degree turn).
                                // This matches Aanca perfectly.
                                
                                // Case m1=(0,1) [N].
                                // m2=(0,1) [N]. Dot=1. OK.
                                // m2=(1,0) [E]. Dot=0. NO. (90 degree turn).
                                
                                int dot = (m1.Dx * m2.Dx) + (m1.Dy * m2.Dy);
                                if (dot <= 0) continue;
                            }
                        }

                        var combined = new MoveVector
                        {
                            Dx = m1.Dx + m2.Dx,
                            Dy = m1.Dy + m2.Dy,
                            
                            // Sequence inherently implies a path (Lame), effectively a leap to the final square
                            IsSlide = false, 
                            
                            // Properties are determined by the final leg (m2) usually, 
                            // but for a composite move, capture/move ability depends on the sequence definition.
                            IsCapture = m2.IsCapture,
                            IsMove = m2.IsMove,
                            
                            // A sequence is inherently path-dependent (Lame)
                            IsLame = true,
                            
                            // Inherit special movement types
                            IsHopper = m1.IsHopper || m2.IsHopper,
                            IsGrasshopper = m1.IsGrasshopper || m2.IsGrasshopper,
                            IsCylindrical = m1.IsCylindrical || m2.IsCylindrical,
                            IsInitial = m1.IsInitial || m2.IsInitial,
                            IsCrooked = m1.IsCrooked || m2.IsCrooked,
                            IsCircular = m1.IsCircular || m2.IsCircular,
                            
                            // New fields inheritance (Union logic for flags?)
                            IsExplode = m1.IsExplode || m2.IsExplode,
                            IsPowerTransfer = m1.IsPowerTransfer || m2.IsPowerTransfer,
                            IsEnPassant = m1.IsEnPassant || m2.IsEnPassant,
                            SkipCount = Math.Max(m1.SkipCount, m2.SkipCount), // Heuristic: Max skip?

                            // Union attributes
                            Attributes = new HashSet<string>(m1.Attributes.Concat(m2.Attributes)),
                            // Store components for path tracing
                            Components = new List<MoveVector> { m1, m2 }
                        };

                        var sig = GetMoveSignature(combined);
                        if (seenSignatures.Add(sig))
                        {
                            result.Add(combined);
                        }
                    }
                }
                return result;
            }

            // RotateVector removed as it caused oblique rounding errors and is not needed for absolute sequences.
        }


        // Helper to get all valid target squares for a piece on a board
        public static List<(int r, int f, bool isSlide, bool isCapture, bool isMove, bool isHopper, bool isLame, bool isGrasshopper)> GetValidMoves(ChessPiece piece, int centerRank = 3, int centerFile = 4, int boardHeight = 8, int boardWidth = 8)
        {
            var moves = Parse(piece.Notation ?? "");
            return GetValidMovesFromVectors(moves, centerRank, centerFile, boardHeight, boardWidth);
        }

        public static List<(int r, int f, bool isSlide, bool isCapture, bool isMove, bool isHopper, bool isLame, bool isGrasshopper)> GetValidMovesFromVectors(List<MoveVector> moves, int centerRank = 3, int centerFile = 4, int boardHeight = 8, int boardWidth = 8)
        {
            var trajectories = GetValidTrajectories(moves, centerRank, centerFile, boardHeight, boardWidth);
            return trajectories.Select(t => (t.TargetRank, t.TargetFile, t.IsSlide, t.IsCapture, t.IsMove, t.IsHopper, t.IsLame, false)).ToList();
        }

        public static List<MoveTrajectory> GetValidTrajectories(List<MoveVector> moves, int centerRank = 3, int centerFile = 4, int boardHeight = 8, int boardWidth = 8)
        {
            var validMoves = new List<MoveTrajectory>();

            foreach (var move in moves)
            {
                if (move.IsCrooked)
                {
                    validMoves.AddRange(GetZigzagTrajectories(move, centerRank, centerFile, boardHeight, boardWidth));
                }
                else if (move.IsCircular)
                {
                    validMoves.AddRange(GetCircularTrajectories(move, centerRank, centerFile, boardHeight, boardWidth));
                }
                else if (move.Components.Any())
                {
                    // Sequence Logic
                    validMoves.AddRange(GetSequenceTrajectories(move, centerRank, centerFile, boardHeight, boardWidth));
                }
                else if (move.IsSlide)
                {
                    // Sliding logic
                    int maxSteps = move.Range > 0 ? move.Range : Math.Max(boardHeight, boardWidth); 
                    int startStep = move.SkipCount > 0 ? move.SkipCount + 1 : ((move.IsHopper || move.IsGrasshopper) ? 2 : 1);

                    var path = new List<(int, int)>();
                    for (int i = 1; i <= maxSteps; i++)
                    {
                        var r = centerRank + (move.Dy * i);
                        var f = centerFile + (move.Dx * i);
                        
                        if (r >= 0 && r < boardHeight && f >= 0 && f < boardWidth)
                        {
                            path.Add((r, f));
                            if (i >= startStep)
                            {
                                validMoves.Add(new MoveTrajectory
                                {
                                    StartRank = centerRank, StartFile = centerFile,
                                    TargetRank = r, TargetFile = f,
                                    Path = new List<(int, int)>(path),
                                    IsSlide = true, IsCapture = move.IsCapture, IsMove = move.IsMove,
                                    IsHopper = move.IsHopper, // Grasshopper implied here if we treat as Hopper
                                    IsLame = move.IsLame, SkipCount = move.SkipCount,
                                    IsExplode = move.IsExplode, IsPowerTransfer = move.IsPowerTransfer,
                                    IsEnPassant = move.IsEnPassant,
                                    Attributes = move.Attributes
                                });
                            }
                        }
                        else break;
                    }
                }
                else
                {
                    // Leaper Logic
                    var r = centerRank + move.Dy;
                    var f = centerFile + move.Dx;
                    
                    if (r >= 0 && r < boardHeight && f >= 0 && f < boardWidth)
                    {
                        var traj = new MoveTrajectory
                        {
                            StartRank = centerRank, StartFile = centerFile,
                            TargetRank = r, TargetFile = f,
                            Path = new List<(int, int)> { (r, f) }, 
                            IsSlide = false, IsCapture = move.IsCapture, IsMove = move.IsMove,
                            IsHopper = move.IsHopper, IsLame = move.IsLame, SkipCount = move.SkipCount,
                            IsExplode = move.IsExplode, IsPowerTransfer = move.IsPowerTransfer,
                            IsEnPassant = move.IsEnPassant,
                            Attributes = move.Attributes
                        };
                        
                        if (move.IsLame && Math.Abs(move.Dx) == 1 && Math.Abs(move.Dy) == 2)
                        {
                            traj.Path.Insert(0, (centerRank + Math.Sign(move.Dy), centerFile));
                        }
                        else if (move.IsLame && Math.Abs(move.Dx) == 2 && Math.Abs(move.Dy) == 1)
                        {
                            traj.Path.Insert(0, (centerRank, centerFile + Math.Sign(move.Dx)));
                        }

                        validMoves.Add(traj);
                    }
                }
            }
            return validMoves;
        }

        private static IEnumerable<MoveTrajectory> GetZigzagTrajectories(MoveVector move, int centerRank, int centerFile, int boardHeight = 8, int boardWidth = 8)
        {
            var result = new List<MoveTrajectory>();
            // Use the same logic as before but package into Trajectories
            
            // Path 1: Right Turns
            var path = new List<(int, int)>();
            int curR = centerRank;
            int curF = centerFile;
            int dx = move.Dx;
            int dy = move.Dy;
            int maxSteps = move.Range > 0 ? move.Range : Math.Max(boardHeight, boardWidth);

            for (int i = 0; i < maxSteps; i++)
            {
                if (i % 2 == 0) { curR += dy; curF += dx; }
                else { curR += -dx; curF += dy; }
                
                if (curR >= 0 && curR < boardHeight && curF >= 0 && curF < boardWidth)
                {
                    path.Add((curR, curF));
                    result.Add(new MoveTrajectory
                    {
                        StartRank = centerRank, StartFile = centerFile,
                        TargetRank = curR, TargetFile = curF,
                        Path = new List<(int, int)>(path),
                        IsSlide = true, IsCapture = move.IsCapture, IsMove = move.IsMove,
                        IsCrooked = true, 
                        IsExplode = move.IsExplode, IsPowerTransfer = move.IsPowerTransfer,
                        IsEnPassant = move.IsEnPassant,
                        Attributes = move.Attributes
                    });
                }
                else break;
            }

            // Path 2: Left Turns
            path.Clear();
            curR = centerRank; curF = centerFile;
            
            for (int i = 0; i < maxSteps; i++)
            {
                if (i % 2 == 0) { curR += dy; curF += dx; }
                else { curR += dx; curF += -dy; }
                
                if (curR >= 0 && curR < boardHeight && curF >= 0 && curF < boardWidth)
                {
                    path.Add((curR, curF));
                    result.Add(new MoveTrajectory
                    {
                        StartRank = centerRank, StartFile = centerFile,
                        TargetRank = curR, TargetFile = curF,
                        Path = new List<(int, int)>(path),
                        IsSlide = true, IsCapture = move.IsCapture, IsMove = move.IsMove,
                        IsCrooked = true, 
                        IsExplode = move.IsExplode, IsPowerTransfer = move.IsPowerTransfer,
                        IsEnPassant = move.IsEnPassant,
                        Attributes = move.Attributes
                    });
                }
                else break;
            }
            return result;
        }

        private static IEnumerable<MoveTrajectory> GetCircularTrajectories(MoveVector move, int centerRank, int centerFile, int boardHeight = 8, int boardWidth = 8)
        {
            var result = new List<MoveTrajectory>();
            var path = new List<(int, int)>();
            
            int curR = centerRank;
            int curF = centerFile;
            int x = move.Dx;
            int y = move.Dy;

            int[][] sequence = new int[][]
            {
                new[] { x, y }, new[] { y, x }, new[] { y, -x }, new[] { x, -y },
                new[] { -x, -y }, new[] { -y, -x }, new[] { -y, x }, new[] { -x, y }
            };

            int maxSteps = move.Range > 0 ? move.Range : Math.Max(boardHeight, boardWidth); 
            if (maxSteps > 8) maxSteps = 8;

            for (int i = 0; i < maxSteps; i++)
            {
                var step = sequence[i % 8];
                curR += step[1]; curF += step[0];
                
                if (curR >= 0 && curR < boardHeight && curF >= 0 && curF < boardWidth)
                {
                    path.Add((curR, curF));
                    result.Add(new MoveTrajectory
                    {
                        StartRank = centerRank, StartFile = centerFile,
                        TargetRank = curR, TargetFile = curF,
                        Path = new List<(int, int)>(path),
                        IsSlide = true, IsCapture = move.IsCapture, IsMove = move.IsMove,
                        IsCircular = true, 
                        IsExplode = move.IsExplode, IsPowerTransfer = move.IsPowerTransfer,
                        IsEnPassant = move.IsEnPassant,
                        Attributes = move.Attributes
                    });
                }
                else break;
            }
            return result;
        }

        private static IEnumerable<MoveTrajectory> GetSequenceTrajectories(MoveVector move, int centerRank, int centerFile, int boardHeight = 8, int boardWidth = 8)
        {
            // A simple sequence A-B (stored in Components)
            // Trace A, then from A's target trace B.
            // This needs to handle recursion if Components[0] has components.
            // For now, assume 2-level flat or recursive logic.
            
            var result = new List<MoveTrajectory>();
            
            if (move.Components.Count != 2) return result; // Should generally be 2 for CombineSequence
            
            var m1 = move.Components[0];
            var m2 = move.Components[1];

            // Get path for first leg
            // Note: m1 itself might be a sequence or slide, so we get its trajectories.
            var leg1Trajs = GetValidTrajectories(new List<MoveVector> { m1 }, centerRank, centerFile, boardHeight, boardWidth);

            foreach (var leg1 in leg1Trajs)
            {
                // Validate leg1? Usually yes, unless we have conditions.
                // For "Move Wazir then Move Fers", the Wazir square must be valid (empty/capture?).
                // Sequence implies passage, so intermediate squares must be valid board squares.
                
                // Now from leg1 target, apply m2
                var leg2Trajs = GetValidTrajectories(new List<MoveVector> { m2 }, leg1.TargetRank, leg1.TargetFile, boardHeight, boardWidth);
                
                foreach (var leg2 in leg2Trajs)
                {
                    // Combine paths
                    var fullPath = new List<(int, int)>(leg1.Path);
                    fullPath.AddRange(leg2.Path);
                    
                    result.Add(new MoveTrajectory
                    {
                        StartRank = leg1.StartRank, StartFile = leg1.StartFile,
                        TargetRank = leg2.TargetRank,
                        TargetFile = leg2.TargetFile,
                        Path = fullPath,
                        IsSlide = false, // Sequence is generally Leaper-like finality, but has path.
                        IsCapture = move.IsCapture, IsMove = move.IsMove,
                        IsLame = true, // By definition
                        IsExplode = move.IsExplode, IsPowerTransfer = move.IsPowerTransfer,
                        IsEnPassant = move.IsEnPassant,
                        Attributes = move.Attributes
                    });
                }
            }
            return result;
        }

        // --- Comparison Helpers ---

        public static bool AreMovesEquivalent(List<MoveVector> movesA, List<MoveVector> movesB)
        {
            var setA = GetCanonicalSet(movesA);
            var setB = GetCanonicalSet(movesB);
            return setA.SetEquals(setB);
        }

        public static bool IsSubset(List<MoveVector> subset, List<MoveVector> superset)
        {
            var setSub = GetCanonicalSet(subset);
            var setSuper = GetCanonicalSet(superset);
            return setSub.IsSubsetOf(setSuper);
        }

        private static HashSet<string> GetCanonicalSet(List<MoveVector> moves)
        {
            var set = new HashSet<string>();
            foreach (var m in moves)
            {
                // Create a unique signature for the move
                set.Add(GetMoveSignature(m));
            }
            return set;
        }

        private static string GetMoveSignature(MoveVector m)
        {
            var attrSig = string.Join("|", m.Attributes.OrderBy(a => a));
            
            // Recursively include components in signature to distinguish different structures (e.g. Aanca vs WaB)
            var compSig = "";
            if (m.Components != null && m.Components.Any())
            {
                compSig = "{" + string.Join(";", m.Components.Select(GetMoveSignature)) + "}";
            }

            return $"{m.Dx},{m.Dy},{m.IsSlide},{m.IsCapture},{m.IsMove},{m.Range},{m.IsLame},{m.SkipCount},{m.IsHopper},{m.IsGrasshopper},{m.IsInitial},{m.IsCylindrical},{m.IsCrooked},{m.IsCircular},{m.IsExplode},{m.IsPowerTransfer},{m.IsEnPassant},[{attrSig}]{compSig}";
        }


        private static List<MoveVector> GetAtomMoves(string atom)
        {
            var moves = new List<MoveVector>();
            switch (atom)
            {
                case "A": moves.AddRange(GetAlfilMoves()); break; // (2,2)
                case "B": // Bishop = Fers Slider (Fers Rider)
                    var bishopMoves = GetFersMoves().ToList();
                    bishopMoves.ForEach(m => m.IsSlide = true);
                    moves.AddRange(bishopMoves);
                    break;
                case "C": moves.AddRange(GetCamelMoves()); break; // (1,3)
                case "D": moves.AddRange(GetDabbabaMoves()); break; // (0,2)
                case "E": moves.AddRange(GetPademelonMoves()); break; // (4,4)
                case "F": moves.AddRange(GetFersMoves()); break; // (1,1)
                case "G": moves.AddRange(GetTripperMoves()); break; // (3,3)
                case "H": moves.AddRange(GetThreeleaperMoves()); break; // (3,0)
                case "I": moves.AddRange(GetIbisMoves()); break; // (5,1)
                case "J": moves.AddRange(GetBonoboMoves()); break; // (5,5)
                case "K": // King = Wazir + Fers
                    moves.AddRange(GetWazirMoves());
                    moves.AddRange(GetFersMoves());
                    break;
                case "L": moves.AddRange(GetLancerMoves()); break; // (4,2)
                case "N": moves.AddRange(GetKnightMoves()); break; // (1,2)
                case "O": moves.AddRange(GetFourleaperMoves()); break; // (4,0)
                case "P": // Pawn (Legacy fallback) -> Standard White Pawn
                    moves.AddRange(new[] {
                        new MoveVector { Dx=0, Dy=1, IsSlide=false, IsCapture=false, IsMove=true },
                        new MoveVector { Dx=1, Dy=1, IsSlide=false, IsCapture=true, IsMove=false },
                        new MoveVector { Dx=-1, Dy=1, IsSlide=false, IsCapture=true, IsMove=false }
                    });
                    break;
                case "Q": // Queen = Rook + Bishop (R+B)
                    var qW = GetWazirMoves().ToList(); qW.ForEach(m => m.IsSlide = true);
                    var qF = GetFersMoves().ToList(); qF.ForEach(m => m.IsSlide = true);
                    moves.AddRange(qW);
                    moves.AddRange(qF);
                    break;
                case "R": // Rook = Wazir Slider (Wazir Rider)
                    var rookMoves = GetWazirMoves().ToList();
                    rookMoves.ForEach(m => m.IsSlide = true);
                    moves.AddRange(rookMoves);
                    break;
                case "S": moves.AddRange(GetSpringbokMoves()); break; // (5,2)
                case "T": moves.AddRange(GetAntelopeMoves()); break; // (4,3)
                case "U": moves.AddRange(GetZurafaMoves()); break; // (4,1)
                case "V": moves.AddRange(GetFiveleaperMoves()); break; // (5,0)
                case "W": moves.AddRange(GetWazirMoves()); break; // (1,0)
                case "X": moves.AddRange(GetIbexMoves()); break; // (5,4)
                case "Y": moves.AddRange(GetWallabyMoves()); break; // (5,3)
                case "Z": moves.AddRange(GetZebraMoves()); break; // (2,3)
            }
            return moves;
        }

        private static List<MoveVector> ApplyModifiers(List<MoveVector> moves, string modifiers, int range)
        {
            if (range > 0)
            {
                moves.ForEach(m => m.Range = range);
            }

            if (string.IsNullOrEmpty(modifiers)) return moves;
            
            var dirConstraints = new List<Func<MoveVector, bool>>();

            if (modifiers.Contains("ff")) dirConstraints.Add(m => m.Dy > Math.Abs(m.Dx));
            else if (modifiers.Contains('f')) dirConstraints.Add(m => m.Dy > 0);

            if (modifiers.Contains("bb")) dirConstraints.Add(m => m.Dy < -Math.Abs(m.Dx));
            else if (modifiers.Contains('b')) dirConstraints.Add(m => m.Dy < 0);

            if (modifiers.Contains("rr")) dirConstraints.Add(m => m.Dx > Math.Abs(m.Dy));
            else if (modifiers.Contains('r')) dirConstraints.Add(m => m.Dx > 0);

            if (modifiers.Contains("ll")) dirConstraints.Add(m => m.Dx < -Math.Abs(m.Dy));
            else if (modifiers.Contains('l')) dirConstraints.Add(m => m.Dx < 0);
          
            if (modifiers.Contains('v')) dirConstraints.Add(m => Math.Abs(m.Dy) > Math.Abs(m.Dx));
            if (modifiers.Contains('s')) dirConstraints.Add(m => Math.Abs(m.Dx) > Math.Abs(m.Dy));

            if (dirConstraints.Any())
            {
                var intersection = moves.Where(m => dirConstraints.All(c => c(m))).ToList();
                if (intersection.Any())
                {
                    moves = intersection;
                }
                else
                {
                    // Union
                    moves = moves.Where(m => dirConstraints.Any(c => c(m))).ToList();
                }
            }

            // Modalities (In-place updates)
            if (modifiers.Contains('m')) moves.ForEach(m => m.IsCapture = false);
            if (modifiers.Contains('c')) moves.ForEach(m => m.IsMove = false);
            if (modifiers.Contains('n')) moves.ForEach(m => m.IsLame = true);
            
            // j modifier: Count occurrences
            int jCount = modifiers.Count(x => x == 'j');
            if (jCount > 0)
            {
                moves.ForEach(m => { m.SkipCount = jCount; m.IsLame = false; });
            }

            if (modifiers.Contains('p')) moves.ForEach(m => m.IsHopper = true);
            if (modifiers.Contains('g')) moves.ForEach(m => m.IsGrasshopper = true);
            if (modifiers.Contains('i')) moves.ForEach(m => m.IsInitial = true);
            if (modifiers.Contains('o')) moves.ForEach(m => m.IsCylindrical = true);
            if (modifiers.Contains('z')) moves.ForEach(m => m.IsCrooked = true);
            if (modifiers.Contains('q')) moves.ForEach(m => m.IsCircular = true);
            if (modifiers.Contains('x')) moves.ForEach(m => m.IsExplode = true);
            if (modifiers.Contains('w')) moves.ForEach(m => m.IsPowerTransfer = true);
            if (modifiers.Contains('e')) moves.ForEach(m => m.IsEnPassant = true);         

            return moves;
        }

        // --- Atoms Definitions ---
        private static IEnumerable<MoveVector> GetWazirMoves() => GetArbitraryLeapMoves(0, 1); // W atom
        private static IEnumerable<MoveVector> GetFersMoves() => GetArbitraryLeapMoves(1, 1); // F atom
        private static IEnumerable<MoveVector> GetDabbabaMoves() => GetArbitraryLeapMoves(0, 2); // D atom
        private static IEnumerable<MoveVector> GetAlfilMoves() => GetArbitraryLeapMoves(2, 2); // A atom
        private static IEnumerable<MoveVector> GetThreeleaperMoves() => GetArbitraryLeapMoves(0, 3); // H atom
        private static IEnumerable<MoveVector> GetTripperMoves() => GetArbitraryLeapMoves(3, 3); // G atom
        private static IEnumerable<MoveVector> GetKnightMoves() => GetArbitraryLeapMoves(1, 2); // N atom
        private static IEnumerable<MoveVector> GetCamelMoves() => GetArbitraryLeapMoves(1, 3); // C atom
        private static IEnumerable<MoveVector> GetZebraMoves() => GetArbitraryLeapMoves(2, 3); // Z atom
        private static IEnumerable<MoveVector> GetFourleaperMoves() => GetArbitraryLeapMoves(4, 0); // O atom
        private static IEnumerable<MoveVector> GetZurafaMoves() => GetArbitraryLeapMoves(4, 1); // U atom
        private static IEnumerable<MoveVector> GetLancerMoves() => GetArbitraryLeapMoves(4, 2); // L atom
        private static IEnumerable<MoveVector> GetAntelopeMoves() => GetArbitraryLeapMoves(4, 3); // T atom
        private static IEnumerable<MoveVector> GetPademelonMoves() => GetArbitraryLeapMoves(4, 4); // E atom
        private static IEnumerable<MoveVector> GetFiveleaperMoves() => GetArbitraryLeapMoves(5, 0); // V atom
        private static IEnumerable<MoveVector> GetIbisMoves() => GetArbitraryLeapMoves(5, 1); // I atom
        private static IEnumerable<MoveVector> GetSpringbokMoves() => GetArbitraryLeapMoves(5, 2); // S atom
        private static IEnumerable<MoveVector> GetWallabyMoves() => GetArbitraryLeapMoves(5, 3); // Y atom
        private static IEnumerable<MoveVector> GetIbexMoves() => GetArbitraryLeapMoves(5, 4); // X atom
        private static IEnumerable<MoveVector> GetBonoboMoves() => GetArbitraryLeapMoves(5, 5); // J atom

        private static List<MoveVector> GetArbitraryLeapMoves(int x, int y)
        {
            var moves = new List<MoveVector>();
            x = Math.Abs(x);
            y = Math.Abs(y);

            var set = new HashSet<(int, int)>();
            set.Add((x, y));
            set.Add((x, -y));
            set.Add((-x, y));
            set.Add((-x, -y));
            set.Add((y, x));
            set.Add((y, -x));
            set.Add((-y, x));
            set.Add((-y, -x));

            foreach (var (dx, dy) in set)
            {    
                moves.Add(new MoveVector 
                { 
                    Dx = dx, Dy = dy, 
                    IsSlide = false, IsCapture = true, IsMove = true 
                });
            }
            return moves;
        }
    }
}
