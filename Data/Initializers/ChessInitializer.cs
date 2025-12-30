using System.Reflection.PortableExecutable;
using ASP_site.Models.Chess;
using Microsoft.EntityFrameworkCore;

namespace ASP_site.Data.Initializers
{
    public static class ChessInitializer
    {
        public static void Initialize(GameContext context)
        {
            // Ensure database is created
            context.Database.EnsureCreated();

            // 1. Define Pieces with Values
            var pieces = new List<ChessPiece>
            {
                new ChessPiece { PieceID = "Immobile", Symbol = "I",
                    Notation = "()", MoveDescription = "Cannot move.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Immobile" },
                    } 
                },
                new ChessPiece { PieceID = "Nullleaper", Symbol = "N",
                    Notation = "(0,0)", MoveDescription = "Jumps to its own square.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Null Leaper" },
                    } 
                },
                new ChessPiece { PieceID = "Wazir", Symbol = "W",
                    History = "Originally 'Luxm', 'sea monster', in Persian)", Value = 1, 
                    Notation = "W", MoveDescription = "Jumps one square orthogonally. A 1,0 jumper.", 
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Wazir" }, 
                        new ChessPieceName { Name = "General", VariantID = "Xiangqi" }, 
                        new ChessPieceName { Name = "Vizir", VariantID = "Persian Chess" },
                        new ChessPieceName { Name = "Fox", VariantID = "Renn Chess" },
                    }
                },
                new ChessPiece { PieceID = "Clobber", Symbol = "C",
                    Notation = "cW", MoveDescription = "Can only capture like a Wazir moves. A 1,1 jumper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Clobber"} 
                    } 
                },
                new ChessPiece { PieceID = "ShogiPawn", Symbol = "P", PromotesTo = "GoldGeneral",
                    Notation = "fW", MoveDescription = "Moves one square forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Shogi Pawn" },
                        new ChessPieceName { Name = "Pawn before crossing the river", VariantID = "Xiangqi" },
                        new ChessPieceName { Name = "Soldier" },
                        new ChessPieceName { Name = "Fish", VariantID = "Shattrong" },
                        new ChessPieceName { Name = "Sparrow Pawn", VariantID = "Wa shōgi" },
                        new ChessPieceName { Name = "Swallow", VariantID = "Tori shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Porpoise", Symbol = "P",
                    Notation = "sW", MoveDescription = "Moves one square sideways.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Porpoise" },
                    } 
                },
                new ChessPiece { PieceID = "Soldier", Symbol = "S",
                    Notation = "sfW", MoveDescription = "Moves one square forward or sideways.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Soldier" },
                        new ChessPieceName { Name = "Pawn", VariantID = "Janggi (Korean chess)" },
                        new ChessPieceName { Name = "Pawn", VariantID = "Xiangqi (Chinese chess)" },
                        new ChessPieceName { Name = "Drunken Soldier" },
                    } 
                },
                new ChessPiece { PieceID = "GoBetween", Symbol = "vW",
                    Notation = "vW", MoveDescription = "Moves one square diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Go Between" },
                        new ChessPieceName { Name = "Adjutant" },
                    } 
                },
                new ChessPiece { PieceID = "ViolentOx", Symbol = "W2",
                    Notation = "W2", MoveDescription = "Equivalent to R2. Slides 2 squares orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Violent Ox" },
                    } 
                },
                new ChessPiece { PieceID = "W3", Symbol = "W3", Value = 3,
                    Notation = "W3", MoveDescription = "Equivalent to R3. Slides 3 squares orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "W3" },
                    } 
                },
                new ChessPiece { PieceID = "ShortRook", Symbol = "W4",
                    Notation = "W4", MoveDescription = "Equivalent to R4. Slides 4 squares orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Short Rook" },
                    } 
                },
                new ChessPiece { PieceID = "N2R4", Symbol = "N2R4",
                    Notation = "N2R4", MoveDescription = "Moves up to 4 spaces as rook, or makes up to 2 consecutive knight moves in the same direction. Can jump for knight moves, but the first must end on an empty space to be able to make a second one.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "N2R4" },
                    } 
                },
                new ChessPiece { PieceID = "R5", Symbol = "R5", Value = 4,
                    Notation = "WW5", MoveDescription = "Moves up to 5 spaces as rook.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "R5" },
                    } 
                },
                new ChessPiece { PieceID = "Rook", Symbol = "R", Value = 5,
                    Notation = "WW", MoveDescription = "Slides any number of squares orthogonally.",
                    Names = new List<ChessPieceName> {
                        new ChessPieceName { Name = "Rook" },
                        new ChessPieceName { Name = "Gliding Swallow", VariantID = "Taikyoku shōgi" },
                        new ChessPieceName { Name = "Gliding Swallow", VariantID = "Wa shōgi" },
                        new ChessPieceName { Name = "Wazirrider" },
                        new ChessPieceName { Name = "Castle" },
                        new ChessPieceName { Name = "Rook", VariantID = "Xiangqi" },
                        new ChessPieceName { Name = "Rook", VariantID = "Janggi" },
                        new ChessPieceName { Name = "Rook", VariantID = "Taikyoku shōgi" },
                        new ChessPieceName { Name = "Rook", VariantID = "Wa shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Lance", Symbol = "L", PromotesTo = "GoldGeneral",
                    Notation = "fR", MoveDescription = "A Rook that can only move forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Lance" },
                        new ChessPieceName { Name = "Forward Rook", VariantID = "Checkers Chess" },
                        new ChessPieceName { Name = "Oxcart", VariantID = "Taiyoku shōgi" },
                        new ChessPieceName { Name = "Wa shōgi", VariantID = "Wa shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "ReverseChariot", Symbol = "vR", PromotesTo = "GoldGeneral",
                    Notation = "vR", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Reverse Chariot" },
                    } 
                },
                new ChessPiece { PieceID = "Cannon", Symbol = "CC",
                    Notation = "mRcpR", MoveDescription = "Moves like a Rook, captures by leaping over a piece.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Cannon", VariantID = "Shako" },
                        new ChessPieceName { Name = "Pao", VariantID = "Akenhead's Chess (1947)" },
                        new ChessPieceName { Name = "Cannon", VariantID = "Xiangqi (Chinese chess)" },
                    } 
                },
                new ChessPiece { PieceID = "Mammoth", Symbol = "M",
                    Notation = "cR", MoveDescription = "Mammoth",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Mammoth", VariantID = "Enlarged & Improved Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Faro", Symbol = "cRmpR",
                    Notation = "cRmpR", MoveDescription = "Captures as a Rook but needs to jump over a hurdle for non-capturing moves",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Faro", VariantID = "Enlarged & Improved Chess" },
                        new ChessPieceName { Name = "Argentinian Rook" },
                    } 
                },
                new ChessPiece { PieceID = "Rookhopper", Symbol = "gR",
                    Notation = "gR", MoveDescription = "Rookhopper (Rook-hopper)",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Rookhopper", VariantID = "Enlarged & Improved Chess" },
                    } 
                },
                new ChessPiece { PieceID = "JanggiCannon", Symbol = "pR",
                    Notation = "pR", MoveDescription = "Janggi Cannon, Rion, Rook Lion, Rook-line-hopper",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Janggi Cannon", VariantID = "Janggi" },
                        new ChessPieceName { Name = "Rion", VariantID = "Janggi" },
                        new ChessPieceName { Name = "Rook Lion", VariantID = "Janggi" },
                        new ChessPieceName { Name = "Rook-line-hopper", VariantID = "Janggi" },
                    } 
                },
                new ChessPiece { PieceID = "Girlscout", Symbol = "zR",
                    Notation = "zR", MoveDescription = "Girlscout, Crooked Rook, in Jupiter.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Girlscout" },
                        new ChessPieceName { Name = "Crooked Rook", VariantID = "Jupiter" },
                    } 
                },
                new ChessPiece { PieceID = "Forfnifurlrurking", Symbol = "fhNfrlRK", Value = 9,
                    Notation = "fhNfrlRK", MoveDescription = "Forfnifurlrurking",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Forfnifurlrurking" },
                    } 
                },
                new ChessPiece { PieceID = "Falcon", Symbol = "F",
                    Notation = "fBbR", MoveDescription = "Moves forward as a Bishop, and backward as a Rook.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Falcon" },
                        new ChessPieceName { Name = "Free Tile", VariantID = "Maka dai dai shōgi" },
                        new ChessPieceName { Name = "Free Tile", VariantID = "Tai shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Eagle", Symbol = "fBbRWbB2",
                    Notation = "fBbRWbB2", MoveDescription = "Combination of Bishop/Rook-hunter (Falcon), Mann, and a backward Bishop restricted to 2 squares.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Eagle", VariantID = "Tori shōgi" },
                        new ChessPieceName { Name = "Eagle", VariantID = "Other large Shōgi variants" },
                    } 
                },
                new ChessPiece { PieceID = "GreatHorse", Symbol = "fBvRsF2",
                    Notation = "fBvRsF2", MoveDescription = "Moves as a forward Bishop, vertical Rook, or up to 2 squares sidewards.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Great Horse", VariantID = "Taikyoku shōgi" },
                        new ChessPieceName { Name = "Horseman", VariantID = "Taikyoku shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Hunter", Symbol = "fRbB",
                    History = "First proposed in Spanish Chess (Germany,1739) as Archer.",
                    Notation = "fRbB", MoveDescription = "Moves forward as Rook, and backward as Bishop.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Hunter" },
                        new ChessPieceName { Name = "Archer", VariantID = "Spanish Chess" },
                        new ChessPieceName { Name = "Multi General", VariantID = "Tenjiku shōgi" },
                        new ChessPieceName { Name = "Multi General", VariantID = "Taikyoku shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "RightQuail", Symbol = "RQ",
                    Notation = "fRblBbrF", MoveDescription = "Combination of Lance, Ferz and a backward Bishop restricted to left side.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Right Quail", VariantID = "Tori shōgi" },
                        new ChessPieceName { Name = "Right Quail", VariantID = "Other large Shōgi variants" },
                    } 
                },
                new ChessPiece { PieceID = "LeftQuail", Symbol = "LQ",
                    Notation = "fRbrBblF", MoveDescription = "Combination of Lance, Ferz and a backward Bishop restricted to right side.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Left Quail", VariantID = "Wa shōgi" },
                        new ChessPieceName { Name = "Left Quail", VariantID = "Other large Shōgi variants" },
                    } 
                },
                new ChessPiece { PieceID = "LiberatedHorse", Symbol = "LH",
                    Notation = "fRbR2", MoveDescription = "Moves forward as a Rook or one or two squares orthogonally backward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Liberated Horse", VariantID = "Wa shōgi" },
                        new ChessPieceName { Name = "Liberated Horse", VariantID = "Other large Shōgi variants" },
                    } 
                },
                new ChessPiece { PieceID = "RunningRabbit", Symbol = "RR",
                    Notation = "fRFbW", MoveDescription = "Combination of Lance and Old Monkey.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Running Rabbit", VariantID = "Taikyoku shōgi" },
                        new ChessPieceName { Name = "Running Rabbit", VariantID = "Wa shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "SoaringEagle", Symbol = "SE",
                    Notation = "RbBfFfA", MoveDescription = "Moves as a Rook, backwards as a Bishop, or as a Lion (Japanese) up to 2 squares diagonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Soaring Eagle", VariantID = "Chu shōgi" },
                        new ChessPieceName { Name = "Soaring Eagle", VariantID = "Other large Shōgi variants" },
                    } 
                },
                new ChessPiece { PieceID = "HornedFalcon", Symbol = "HF",
                    Notation = "BsbRfWfD", MoveDescription = "Horned Falcon in Chu shōgi and other large Shōgi variants.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Horned Falcon", VariantID = "Chu shōgi" },
                        new ChessPieceName { Name = "Horned Falcon", VariantID = "Other large Shōgi variants" },
                    } 
                },
                new ChessPiece { PieceID = "Reaper", Symbol = "Re", Value = 14,
                    Notation = "R(FaR)", MoveDescription = "Combination of Rook and Gryphon.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Reaper", VariantID = "Tripunch Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Ancress", Symbol = "An",
                    Notation = "R(WaB)", MoveDescription = "Combination of Manticore and Rook.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Ancress", VariantID = "Conclave Ecumenical chess" },
                    } 
                },
                new ChessPiece { PieceID = "Knave", Symbol = "Kn",
                    Notation = "sDffbbN", MoveDescription = "A six-directional piece, moving sidewards as a Dabbaba and forwards and backwards as a Knight. Also see Debtor.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Knave", VariantID = "Knavish Chess" },
                    } 
                },
                new ChessPiece { PieceID = "GiraffeRook", Symbol = "GR",
                    Notation = "UaR", MoveDescription = "Old historic piece. Starts with a (1,4) leap (like the modern Giraffe) and may continue moving outwards as a Rook.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Giraffe (Zurafa)", VariantID = "Tamerlane Chess" },
                    }
                },
                new ChessPiece { PieceID = "Ostrich", Symbol = "O",
                    Notation = "AaR", MoveDescription = "Leaps to the second square diagonally, and then slides outward as a Rook. Counterpart of the Osprey.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Ostrich", VariantID = "Fairy chess" },
                    }
                },
                new ChessPiece { PieceID = "DukeRenn", Symbol = "Du",
                    Notation = "(BaW)(WaB)", MoveDescription = "Either one square horizontal or vertical followed by a diagonal slide outwards or a diagonal slide followed by one square horizontal or vertical outwards. Compare with Manticore.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Duke (Renn)", VariantID = "Renn Chess" },
                    }
                },
                new ChessPiece { PieceID = "Astrologer", Symbol = "As",
                    Notation = "CaB", MoveDescription = "Moves as a Camel followed by moving any number of spaces diagonally outwards like a Bishop.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Astrologer", VariantID = "Tiger Chess" },
                    }
                },
                new ChessPiece { PieceID = "Osprey", Symbol = "Os",
                    Notation = "DaB", MoveDescription = "Leaps to the second square on the same rank or file, and then slides outward as a Bishop. Compare with Manticore.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Osprey", VariantID = "Expanded Chess" },
                    }
                },
                new ChessPiece { PieceID = "Aanca", Symbol = "Aa", Value = 8,
                    History = "A giant eagle mistaken for a Gryphon by Murray (1913). Aanca borrowed from the Persian/Arabic legendary anka, an elephant bird (a giant eagle preying elephants), see Gryphon. A name erroneously applied by some modern chess variant inventors to a piece moving t[WB] in Betza's notation and also called Manticore, creating confusion.",
                    Notation = "FaR", MoveDescription = "Moves one square diagonally followed by moving any number of spaces like a Rook outwards (moving away from where it started). See Gryphon.",
                    Names = new List<ChessPieceName> {
                        new ChessPieceName { Name = "Aanca" },
                        new ChessPieceName { Name = "Eagle", VariantID = "Terachess" },
                        new ChessPieceName { Name = "Gryphon" },
                    }
                },
                new ChessPiece { PieceID = "LeftAanca", Symbol = "LA",
                    Notation = "(fWaflB)(rWafrB)(bWabrB)(lWablB)", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Left Aanca" },
                    }
                },
                new ChessPiece { PieceID = "RightAanca", Symbol = "RA",
                    Notation = "(fWafrB)(rWabrB)(bWablB)(lWaflB)", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Right Aanca" },
                    }
                },
                new ChessPiece { PieceID = "LeftGriffon", Symbol = "LG",
                    Notation = "(flFalR)(frFafR)(blFabR)(brFarR)", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Left Griffon" },
                    }
                },
                new ChessPiece { PieceID = "RightGriffon", Symbol = "RG",
                    Notation = "(flFafR)(frFarR)(blFalR)(brFabR)", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Right Griffon" },
                    }
                },
                new ChessPiece { PieceID = "Metropolitan", Symbol = "Me",
                    Notation = "B(FaR)", MoveDescription = "Metropolitan in Conclave Ecumenical chess.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Metropolitan", VariantID = "Conclave Ecumenical chess" },
                    }
                },
                new ChessPiece { PieceID = "Dragon2", Symbol = "Aa", Value = 5,
                    Notation = "(FaR)DA", MoveDescription = "",
                    Names = new List<ChessPieceName> {
                        new ChessPieceName { Name = "Dragon 2" },
                    }
                },
                new ChessPiece { PieceID = "Godzilla", Symbol = "Gz", Value = 11,
                    Notation = "(FaR)(WaB)", MoveDescription = "Double bent-rider. Combines Gryphon and Manticore.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Godzilla" },
                    }
                },
                new ChessPiece { PieceID = "Ship", Symbol = "Sh",
                    History = "Also called Twin Tower by Betza due the pattern of its move. Compare with Gryphon or Eagle.",
                    Notation = "FavR", MoveDescription = "Moves one square diagonally followed by moving any number of spaces like a rook vertically outwards (moving away from where it started).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Ship" },
                        new ChessPieceName { Name = "Twin Tower" },
                    }
                },
                new ChessPiece { PieceID = "Unicornio", Symbol = "Un",
                    History = "Originally Unicornio in ancient Spanish, obviously designating a Rhinoceros. For Murray's interpretation, see Unicorn.",
                    Notation = "(NaB)", MoveDescription = "Maybe t[NfB]? Moves as a Knight followed by moving any number of spaces diagonally outwards (most probably, or forwards?).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Unicornio" },
                    }
                },
                new ChessPiece { PieceID = "PegasusZacharias", Symbol = "P",
                    History = "Moves as a Knight followed by moving any number of spaces outwards like a Rook. Compare with Gryphon.",
                    Notation = "(NaR)", MoveDescription = "Moves as a Knight followed by moving any number of spaces outwards like a Rook. Compare with Gryphon.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Pegasus (Zacharias)", VariantID = "Tiger Chess" },
                    }
                },
                new ChessPiece { PieceID = "Cavalier", Symbol = "C",
                    History = "More powerful than the Gryphon. (Note that a Cavalier is a Knight in French).",
                    Notation = "(RaF)(FaR)", MoveDescription = "Either one square diagonal followed by an orthogonal slide outwards or an orthogonal slide followed by one square diagonal outwards.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Cavalier", VariantID = "Mideast Chess" },
                        new ChessPieceName { Name = "Cavalier", VariantID = "Renn Chess" },
                    }
                },
                new ChessPiece { PieceID = "Snake", Symbol = "S",
                    History = "Originally called Snaketongue by Betza due to the pattern of its move.",
                    Notation = "vWaB", MoveDescription = "Moves vertically one step and continues as a Bishop outwards.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Snake", VariantID = "Modern Variants" },
                    }
                },
                new ChessPiece { PieceID = "Vivi", Symbol = "V",
                    History = "So called for the pattern of its move.",
                    Notation = "vWafB", MoveDescription = "Moves vertically forward or backward one step and continues as a Bishop forwards.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Vivi", VariantID = "Modern Variants" },
                    }
                },
                new ChessPiece { PieceID = "ElephantKorean", Symbol = "E",
                    History = "Sang in Korean.",
                    Notation = "WanA", MoveDescription = "Non-leaping Zebra.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Elephant (Korean)", VariantID = "Janggi (Korean chess)" },
                    }
                },
                new ChessPiece { PieceID = "Tiger", Symbol = "T",
                    Notation = "ZaB", MoveDescription = "Moves as a Zebra followed by moving any number of spaces diagonally outwards like a Bishop.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Tiger", VariantID = "Tiger Chess" },
                    }
                },
                new ChessPiece { PieceID = "GoldenBird", Symbol = "G",
                    Notation = "vRlrW2F3", MoveDescription = "Slides and jumps the first 3 squares along the forward diagonals.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Golden Bird", VariantID = "Taikyoku shōgi" },
                        new ChessPieceName { Name = "Golden Bird", VariantID = "Other large Shōgi variants" },
                    }
                },
                new ChessPiece { PieceID = "RaidingFalcon", Symbol = "R",
                    Notation = "vRWfF", MoveDescription = "Combination of Vertical Mover and Stone General (Reverse Chariot and Flying Cock). Occurs in Taikyoku shōgi with a different move.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Raiding Falcon", VariantID = "Wa shōgi" },
                    }
                },
                new ChessPiece { PieceID = "Superpawn", Symbol = "S", PromotesTo = "Any",
                    Notation = "mfRcfB", MoveDescription = "Moves without capture any number of fields forward, captures diagonally forwards like a Bishop. Promotes on the 8th rank. May be placed in the first rank. By Werner Speckmann (1967).[49]",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Superpawn", VariantID = "Fairy Chess problems" },
                    }
                },
                new ChessPiece { PieceID = "CongoSuperpawn", Symbol = "C",
                    Notation = "sfWfFmbQ2", MoveDescription = "Congo Pawn that can move and capture one step straight sideways, and move (but not capture) one or two steps straight or diagonally backward without jumping.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Congo Superpawn", VariantID = "Congo" },
                    }
                },
                new ChessPiece { PieceID = "Eighteen", Symbol = "E", Value = 18,
                    Notation = "Q(FaR)(WaB)", MoveDescription = "Eighteen.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Eighteen"},
                    }
                },
                new ChessPiece { PieceID = "HowlingDog", Symbol = "fRbW",
                    Notation = "fRbW", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Howling Dog", VariantID = "Dai dai Shōgi" },
                        new ChessPieceName { Name = "Howling Dog", VariantID = "Other large Shōgi variants" },
                    } 
                },
                new ChessPiece { PieceID = "SideMover", Symbol = "SM", PromotesTo = "GoldGeneral",
                    Notation = "WsR", MoveDescription = "Combination of a Rook restricted to sideways and Wazir.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Side Mover" },
                        new ChessPieceName { Name = "Swallow's Wings", VariantID = "Wa shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Fers", Symbol = "F",
                    History = "The word ferz, Ферзь, is the regular Queen in Russian.",
                    Notation = "F", MoveDescription = "Moves one square diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Fers" },
                        new ChessPieceName { Name = "Ferz" },
                        new ChessPieceName { Name = "Advisor", VariantID = "Xiangqi (Chinese chess)" },
                        new ChessPieceName { Name = "Fox", VariantID = "Fox and Geese" },
                        new ChessPieceName { Name = "Counsellor", VariantID = "Dai Dai Shōgi"  },
                        new ChessPieceName { Name = "Mandarin", VariantID = "Dai Dai Shōgi"  },
                        new ChessPieceName { Name = "Guard", VariantID = "Dai Dai Shōgi"  },
                        new ChessPieceName { Name = "Officer", VariantID = "Dai Dai Shōgi"  },
                        new ChessPieceName { Name = "Scholar", VariantID = "Dai Dai Shōgi"  },
                        new ChessPieceName { Name = "Decurion", VariantID = "Archchess" },
                        new ChessPieceName { Name = "Martian Pawn", VariantID = "Burroughs' Martian chess" },
                    } 
                },
                new ChessPiece { PieceID = "IronGuard", Symbol = "IG",
                    Notation = "[Immune]F", MoveDescription = "Moves one square diagonally and is immune to capture.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Iron Guard" },
                    } 
                },
                new ChessPiece { PieceID = "StoneGeneral", Symbol = "SG",
                    Notation = "fF", MoveDescription = "Moves one square diagonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Stone General" },
                        new ChessPieceName { Name = "Goose", VariantID = "Fox and Geese" },
                    } 
                },
                new ChessPiece { PieceID = "Fn", Symbol = "SB",
                    Notation = "Fn", MoveDescription = "Equivalent to B1. Moves one square diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Short Bishop", VariantID = "Dai Dai Shōgi" } 
                    } 
                },
                new ChessPiece { PieceID = "F2", Symbol = "FD",
                    Notation = "F2", MoveDescription = "Moves two squares diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Flying Dragon" } 
                    } 
                },
                new ChessPiece { PieceID = "fF2", Symbol = "WG",
                    Notation = "fF2", MoveDescription = "Moves 2 squares diagonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Wood General", VariantID = "Dai dai Shōgi" },
                        new ChessPieceName { Name = "Wood General", VariantID = "Other large Shōgi variants" },
                    } 
                },
                new ChessPiece { PieceID = "F3", Symbol = "BD",
                    Notation = "F3", MoveDescription = "Moves three squares diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Bishop's dog", VariantID = "Typhoon" } 
                    } 
                },
                new ChessPiece { PieceID = "Bishop", Symbol = "B", Value = 3,
                    History = "Originally 'Courier' piece from Courier Chess, German: Kurrier. Spanish: Alfieri, French: Fou",
                    Notation = "FF", MoveDescription = "Moves any number of squares diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Bishop" },
                        new ChessPieceName { Name = "Courier", VariantID = "Reformed Courier Chess" },
                        new ChessPieceName { Name = "Ferzrider" },
                    } 
                },
                new ChessPiece { PieceID = "Brontosaur", Symbol = "cB",
                    Notation = "cB", MoveDescription = "Brontosaur in Megasaur Chess",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Brontosaur", VariantID = "Megasaur Chess" },
                    } 
                },
                new ChessPiece { PieceID = "ForwardBishop", Symbol = "FB",
                    Notation = "fB", MoveDescription = "Moves any number of squares diagonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Forward Bishop" },
                    } 
                },
                new ChessPiece { PieceID = "Bishopper", Symbol = "gB",
                    Notation = "gB", MoveDescription = "Bishopper, Bishop-hopper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Bishopper", VariantID = "Bishopper" },
                        new ChessPieceName { Name = "Bishop-hopper", VariantID = "Bishop-hopper" },
                    } 
                },
                new ChessPiece { PieceID = "SkipBishop", Symbol = "SB",
                    Notation = "jB", MoveDescription = "Bishop that cannot capture the first square.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Skip Bishop" },
                    } 
                },
                new ChessPiece { PieceID = "Vao", Symbol = "V",
                    Notation = "mBcpB", MoveDescription = "Moves as a Bishop, captures by leaping over a piece.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Vao", VariantID = "Akenhead's Chess (1947)" },
                        new ChessPieceName { Name = "Crocodile", VariantID = "Zanzibar Chess" },
                        new ChessPieceName { Name = "Terachess", VariantID = "Terachess (Cazaux, 2008)" },
                    } 
                },
                new ChessPiece { PieceID = "Loco", Symbol = "cBmpB",
                    Notation = "cBmpB", MoveDescription = "Loco, Argentinian Bishop",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Loco", VariantID = "Loco" },
                        new ChessPieceName { Name = "Argentinian Bishop" },
                    } 
                },
                new ChessPiece { PieceID = "CylindricalBishop", Symbol = "CB",
                    Notation = "oB", MoveDescription = "Moves and captures like a Bishop that can wrap around the board.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Cylindrical Bishop" },
                    } 
                },
                new ChessPiece { PieceID = "Bion", Symbol = "pB",
                    Notation = "pB", MoveDescription = "Bion, Bishlion, Bishop-lion-hopper",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Bion" },
                        new ChessPieceName { Name = "Bishlion" },
                        new ChessPieceName { Name = "Bishop-lion-hopper" },
                    } 
                },
                new ChessPiece { PieceID = "Boyscout", Symbol = "zB", Value = 6,
                    Notation = "zB", MoveDescription = "Boyscout",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Boyscout" },
                    } 
                },
                new ChessPiece { PieceID = "ZigzagDragonHorse", Symbol = "zBW", Value = 8,
                    Notation = "zBW", MoveDescription = "Zigzag Dragon Horse",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Zigzag Dragon Horse" },
                    } 
                },
                new ChessPiece { PieceID = "BuffaloMusketeer", Symbol = "B",
                    Notation = "B2W", MoveDescription = "Wazir and Bishop limited to two squares.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Buffalo (Musketeer Chess)" },
                    } 
                },
                new ChessPiece { PieceID = "DragonHorse", Symbol = "BW",
                    Notation = "BW", MoveDescription = "Combination of Bishop and Wazir",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dragon Horse", VariantID = "Quintessential Chess" },
                        new ChessPieceName { Name = "Missionary", VariantID = "Sac Chess" },
                        new ChessPieceName { Name = "Missionary", VariantID = "Heavy/Very Heavy Chess" },
                        new ChessPieceName { Name = "Crowned Bishop" },
                    } 
                },
                new ChessPiece { PieceID = "Onyx", Symbol = "O",
                    Notation = "jBW", MoveDescription = "Combination Wazir and Skip-Bishop.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Onyx" },
                    } 
                },
                new ChessPiece { PieceID = "FlyingFalcon", Symbol = "BfW",
                    Notation = "BfW", MoveDescription = "Combination of Bishop and a forward Wazir move.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Flying Falcon", VariantID = "Wa shōgi" },
                        new ChessPieceName { Name = "Flying Falcon", VariantID = "Taikyoku shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Warrior", Symbol = "W",
                    Notation = "cfB2msbWmfR2", MoveDescription = "Captures forward as bishop, moves two squares forward or one square backwards or sideways.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Warrior" },
                    } 
                },
                new ChessPiece { PieceID = "FlyingStag", Symbol = "FS",
                    Notation = "vRK", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Flying Stag" },
                    } 
                },
                new ChessPiece { PieceID = "Wizard", Symbol = "W",
                    Notation = "R2FD", MoveDescription = "Moves up to 2 squares orthogonally or one square diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Wizard" },
                    } 
                },
                new ChessPiece { PieceID = "DragonKing", Symbol = "DK",
                    Notation = "RF", MoveDescription = "Combination of Rook and Ferz (or Rook and King/Man).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dragon King" },
                        new ChessPieceName { Name = "Dragon" },
                        new ChessPieceName { Name = "Bers" },
                        new ChessPieceName { Name = "Baras", VariantID = "Traditional shatar Mongolian chess" },
                        new ChessPieceName { Name = "SuperRook", VariantID = "Pocket Mutation chess" },
                        new ChessPieceName { Name = "Admiral", VariantID = "Heavy/Very Heavy Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Lionness", Symbol = "L",
                    Notation = "RFD", MoveDescription = "Combination of King and Fers and Dabbaba.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Lionness" },
                    } 
                },
                new ChessPiece { PieceID = "LameDuck", Symbol = "LD",
                    Notation = "jRF", MoveDescription = "Moves like a Fers and a Skip-Rook.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Lame Duck" },
                    } 
                },
                new ChessPiece { PieceID = "Rhubarb", Symbol = "RF3",
                    Notation = "RF3", MoveDescription = "Rhubarb",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Rhubarb" },
                    } 
                },
                new ChessPiece { PieceID = "Rutabaga", Symbol = "BR2",
                    Notation = "BR2", MoveDescription = "Rutabaga in Chess with different armies",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Rutabaga", VariantID = "Chess with different armies" },
                    } 
                },
                new ChessPiece { PieceID = "Forfer", Symbol = "FR4",
                    Notation = "FR4", MoveDescription = "Moves as ferz, or up to 4 spaces as rook.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Forfer" },
                    } 
                },
                new ChessPiece { PieceID = "Hyena", Symbol = "Hy",
                    Notation = "fbQ2", MoveDescription = "Two squares forward or backward or diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Hyena" },
                    } 
                },
                new ChessPiece { PieceID = "LionDog", Symbol = "Q3",
                    Notation = "Q3", MoveDescription = "Moves like a Queen but can only slide three squares.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Lion Dog", VariantID = "Dai dai Shōgi" },
                        new ChessPieceName { Name = "Lion Dog", VariantID = "Other large Shōgi variants" },
                    } 
                },
                new ChessPiece { PieceID = "HeavenlyTetrarch", Symbol = "Q4",
                    Notation = "Q4", MoveDescription = "Moves like a Queen but can only slide four squares.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Heavenly Tetrarch", VariantID = "Taikyoku shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Q6", Symbol = "Q6", Value = 8,
                    Notation = "Q6", MoveDescription = "Moves like a Queen but can only slide six squares.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Q6" },
                    } 
                },
                new ChessPiece { PieceID = "Queen", Symbol = "Q", Value = 9,
                    Notation = "Q", MoveDescription = "Combines Rook and Bishop movement.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Queen" },
                        new ChessPieceName { Name = "Dame" },
                        new ChessPieceName { Name = "Nobleman", VariantID = "Chu shōgi" },
                        new ChessPieceName { Name = "Honno", VariantID = "Chu shōgi" },
                        new ChessPieceName { Name = "Free King" },
                    } 
                },
                new ChessPiece { PieceID = "Dinosaur", Symbol = "D",
                    Notation = "cQ", MoveDescription = "Cannot move without capturing, but captures as a Queen.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dinosaur" },
                    } 
                },
                new ChessPiece { PieceID = "ForwardQueen", Symbol = "FQ",
                    Notation = "fQ", MoveDescription = "Moves and captures like a Queen but can only slide forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Forward Queen" },
                    } 
                },
                new ChessPiece { PieceID = "Grasshopper", Symbol = "G",
                    History = "Introduced by T. R. Dawson in 1913 in problems published in the Cheltenham Examiner newspaper.",
                    Notation = "gQ", MoveDescription = "Moves and captures like a Queen but must hop over another piece to the square next beyond that piece.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Grasshopper" },
                        new ChessPieceName { Name = "Queen-Hopper" },
                        new ChessPieceName { Name = "Sprinkhaan", VariantID = "Dutch" },
                        new ChessPieceName { Name = "Sauterelle", VariantID = "French" },
                        new ChessPieceName { Name = "Saltamonte", VariantID = "Spanish" },
                    } 
                },
                new ChessPiece { PieceID = "DamateKing", Symbol = "G",
                    History = "",
                    Notation = "KcgQ2", MoveDescription = "A King that can capture by hopping over other pieces.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "King" },
                    } 
                },
                new ChessPiece { PieceID = "DamatePawn", Symbol = "P",
                    Notation = "mfWimfW2cfgQ2", MoveDescription = "A Pawn that can capture by hopping over other pieces.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Damate Pawn" },
                    } 
                },
                new ChessPiece { PieceID = "Whale", Symbol = "vRbB",
                    Notation = "vRbB", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Whale", VariantID = "Chu shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "WhiteHorse", Symbol = "vRfB",
                    Notation = "vRfB", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "White Horse", VariantID = "Chu shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "CloudEagle", Symbol = "vRKfB3",
                    Notation = "vRKfB3", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Cloud Eagle", VariantID = "Wa shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "FlyingOx", Symbol = "vRB",
                    Notation = "vRB", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Flying Ox", VariantID = "Chu shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "FreeBoar", Symbol = "sRB",
                    Notation = "sRB", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Free Boar", VariantID = "Chu shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "FreeBear", Symbol = "sRBfA",
                    Notation = "sRBfA", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Free Bear", VariantID = "Dai dai shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Bishroo", Symbol = "mBcR",
                    Notation = "mBcR", MoveDescription = "Bishroo (a sniper), Ensign in Enlarged & Improved Chess, Gr. Fähnrich, Biok in Chess Curiouser & Curiouser.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Bishroo", VariantID = "Enlarged & Improved Chess" },
                        new ChessPieceName { Name = "Ensign", VariantID = "Enlarged & Improved Chess" },
                        new ChessPieceName { Name = "Gr. Fähnrich", VariantID = "Enlarged & Improved Chess" },
                        new ChessPieceName { Name = "Biok", VariantID = "Chess Curiouser & Curiouser" },
                    } 
                },
                new ChessPiece { PieceID = "Roobi", Symbol = "mRcB",
                    Notation = "mRcB", MoveDescription = "Roobi (a sniper) Roshop in Enlarged & Improved Chess, Parton's Chess, Guard, Gr. Trabant(en)",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Roobi", VariantID = "Enlarged & Improved Chess" },
                        new ChessPieceName { Name = "Roshop", VariantID = "Enlarged & Improved Chess" },
                        new ChessPieceName { Name = "Parton's Chess", VariantID = "Parton's Chess" },
                        new ChessPieceName { Name = "Guard", VariantID = "Enlarged & Improved Chess" },
                        new ChessPieceName { Name = "Gr. Trabant(en)", VariantID = "Enlarged & Improved Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Amazon", Symbol = "QN", Value = 11,
                    History = "German: Peguilhen",
                    Notation = "QN", MoveDescription = "Moves and captures like a Queen and a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Amazon" },
                        new ChessPieceName { Name = "Empress", },
                        new ChessPieceName { Name = "Knighted Queen" },
                        new ChessPieceName { Name = "Angel", VariantID = "Angel Chess (Autremont 1914)" },
                        new ChessPieceName { Name = "Commander", VariantID = "Feldherr" },
                        new ChessPieceName { Name = "Wyvern", VariantID = "Parton" },
                        new ChessPieceName { Name = "Queen", VariantID = "Pacific Chess" },
                        new ChessPieceName { Name = "Prince", VariantID = "Renn Chess" },
                        new ChessPieceName { Name = "Superqueen" },
                    } 
                },
                new ChessPiece { PieceID = "Squire", Symbol = "S",
                    Notation = "jQN", MoveDescription = "Combination Knight and Skip-Queen.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Squire" },
                    } 
                },
                new ChessPiece { PieceID = "Megasaur", Symbol = "M",
                    Notation = "cQcN", MoveDescription = "Cannot move without capturing, but captures as a Queen and a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Megasaur" },
                    } 
                },
                new ChessPiece { PieceID = "QueenOfTheNight", Symbol = "QNN", Value = 15,
                    Notation = "QNN", MoveDescription = "Moves and captures like a Queen and a Knightrider.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Queen of the Night" },
                        new ChessPieceName { Name = "Amazonrider", VariantID = "Pocket Mutation Chess" },
                        new ChessPieceName { Name = "Elephant", VariantID = "Wolf" },
                    } 
                },
                new ChessPiece { PieceID = "Quight", Symbol = "Qu",
                    Notation = "mQcN", MoveDescription = "Moves like a Queen but captures like a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Quight", VariantID = "Parton's Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Actress", Symbol = "QNC",
                    Notation = "QNC", MoveDescription = "Moves like a Queen and a Knight and a Camel.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Actress", VariantID = "Overkill Ecumenical Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Scorpion", Symbol = "KgQ",
                    Notation = "KgQ", MoveDescription = "Moves and captures like a Queen and a Grasshopper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Scorpion" },
                    }
                },
                new ChessPiece { PieceID = "Pegasus", Symbol = "NNgQ",
                    Notation = "NNgQ", MoveDescription = "Moves like a Knightrider and a Grasshopper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Pegasus" },
                    } 
                },
                new ChessPiece { PieceID = "FairyLion", Symbol = "pQ",
                    Notation = "pQ", MoveDescription = "Moves and captures like a Cannon on in any direction like a Queen.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Fairy Lion" },
                        new ChessPieceName { Name = "Queen-Line-Hopper" },
                    } 
                },
                new ChessPiece { PieceID = "Señora", Symbol = "cQmpQ",
                    Notation = "cQmpQ", MoveDescription = "Captures like a Queen but needs a hurdle for non-capturing moves, combination of Faro and Loco.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Señora", VariantID = "Fairy Chess problems" },
                        new ChessPieceName { Name = "Argentinian Queen" },
                    } 
                },
                new ChessPiece { PieceID = "Forequeen", Symbol = "fsQbhNbK",
                    Notation = "fsQbhNbK", MoveDescription = "Moves and captures like a Queen forward or sideways, but like a Mann or a Knight backwards.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Forequeen", VariantID = "Chess with different armies" },
                    } 
                },
                new ChessPiece { PieceID = "Kneen", Symbol = "mNcQ",
                    History = "First proposed by V.R. Parton in Chess Curiouser & Curiouser (1961). See also Quight.",
                    Notation = "mNcQ", MoveDescription = "Moves like a Knight but captures like a Queen.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Kneen", VariantID = "Parton's Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Star", Symbol = "S",
                    Notation = "mQcpQ", MoveDescription = "Moves like a Queen but captures by leaping over an intervening piece and taking the piece on the Sorceress's destination square (the captured piece can be any number of squares beyond the hurdle).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Star", VariantID = "Fairy Chess problems" },
                        new ChessPieceName { Name = "Sorceress", VariantID = "Akenhead's Chess (1947)" },
                        new ChessPieceName { Name = "Sorceress", VariantID = "Terachess (Cazaux, 2008)" },
                        new ChessPieceName { Name = "Leo", VariantID = "Akenhead's Chess (1947)" },
                        new ChessPieceName { Name = "Leo", VariantID = "Dawson (1914)" },

                    } 
                },
                new ChessPiece { PieceID = "King", Symbol = "K", Value = 3,
                    Notation = "K", MoveDescription = "Moves one square in any direction. Game is lost if the King is captured.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "King" },
                        new ChessPieceName { Name = "Jeweled General (King)", VariantID = "Shogi" },
                        new ChessPieceName { Name = "Prince (Promoted Pawn of Kings)", VariantID = "Tamerlane Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Man", Symbol = "M", Value = 3,
                    Notation = "K", MoveDescription = "Moves like a King, but capture does not loes the game.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Man" },
                        new ChessPieceName { Name = "Commoner" },
                        new ChessPieceName { Name = "Mann" },
                        new ChessPieceName { Name = "Ratgeber" },
                        new ChessPieceName { Name = "Fool" },
                        new ChessPieceName { Name = "Guard" },
                        new ChessPieceName { Name = "ErlKing" },
                        new ChessPieceName { Name = "Spy", VariantID = "Waterloo and Amsterdam Medieval Chess" },
                        new ChessPieceName { Name = "Phoenix", VariantID = "Tori shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "KingAcedrex", Symbol = "K",
                    Notation = "Ki(AD)", MoveDescription = "Moves like a King and has an initial two square jump.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "King (Acedrex)" },
                    } 
                },
                new ChessPiece { PieceID = "Prince", Symbol = "M", Value = 3,
                    Notation = "KimfW2", MoveDescription = "Moves like a King and has an initial two square move forwards.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Prince" },
                    } 
                },
                new ChessPiece { PieceID = "PrinceMetamachy", Symbol = "P", PromotesTo = "Any",
                    Notation = "KmfW2", MoveDescription = "Moves as a Man (non-royal King) or as a Metamachy Pawn, can be promoted like a Pawn.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Prince" },
                    } 
                },
                new ChessPiece { PieceID = "ForwardKing", Symbol = "K",
                    Notation = "fK", MoveDescription = "A King, restricted to the forward moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Forward King" },
                    } 
                },
                new ChessPiece { PieceID = "IronGeneral", Symbol = "IG", PromotesTo = "GoldGeneral",
                    Notation = "fK", MoveDescription = "Moves one square forward or diagonally forward (Combines the powers of the Berolina Pawn and the standard Pawn without the initial double move).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Iron General", VariantID = "Tenjiku shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "EvilWolf", Symbol = "sfK",
                    Notation = "sfK", MoveDescription = "Moves one square sideways or forward or diagonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Evil Wolf" },
                        new ChessPieceName { Name = "Pathan" },
                        new ChessPieceName { Name = "Jetan Pawn", VariantID = "Burroughs' Martian chess" },
                        new ChessPieceName { Name = "Pikeman" },
                        new ChessPieceName { Name = "Drunken Pawn" },
                    } 
                },
                new ChessPiece { PieceID = "Atlantosaur", Symbol = "cK",
                    Notation = "cK", MoveDescription = "Captures as the king, no other moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Atlantosaur" },
                    } 
                },
                new ChessPiece { PieceID = "FlyingCock", Symbol = "FC",
                    Notation = "sWfF", MoveDescription = "Moves one square sideways or diagonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Flying Cock", VariantID = "Wa Shōgi" },
                        new ChessPieceName { Name = "Flying Cock", VariantID = "Taikyoku Shōgi" },
                        new ChessPieceName { Name = "Sidewinder" },
                    } 
                },
                new ChessPiece { PieceID = "ViolentBear", Symbol = "VB",
                    Notation = "sWfF2", MoveDescription = "Moves one square sideways or up to two squares diagonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Violent Bear", VariantID = "Dai dai Shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "BlindDog", Symbol = "BD",
                    Notation = "sbWfF", MoveDescription = "Combination of Flying Cock and Backslider. Moves one square sideways or backward or diagonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Blind Dog", VariantID = "Wa Shōgi" },
                        new ChessPieceName { Name = "Blind Dog", VariantID = "Taikyoku Shōgi" },
                        new ChessPieceName { Name = "Yen" },
                    } 
                },
                new ChessPiece { PieceID = "FerociousLeopard", Symbol = "FL",
                    Notation = "FvW", MoveDescription = "Moves one square in any adjacent direction except orthogonally sideways.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Ferocious Leopard" },
                        new ChessPieceName { Name = "Crane", VariantID = "Tori shōgi" },
                        new ChessPieceName { Name = "Horrible Panther" },
                    } 
                },
                new ChessPiece { PieceID = "OldMonkey", Symbol = "OM",
                    Notation = "FbW", MoveDescription = "Moves one square diagonally or one square orthogonally backward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Old Monkey", VariantID = "Maka dai Shōgi" },
                        new ChessPieceName { Name = "Old Monkey", VariantID = "Other large Shōgi variants" },
                        new ChessPieceName { Name = "Inverted Silver" },
                        new ChessPieceName { Name = "Backward Elephant" },
                    } 
                },
                new ChessPiece { PieceID = "BlindMonkey", Symbol = "BM",
                    Notation = "FsW", MoveDescription = "Moves one square diagonally or one square sideways.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Blind Monkey", VariantID = "Dai dai Shōgi" },
                        new ChessPieceName { Name = "Blind Monkey", VariantID = "Other large Shōgi variants" },
                        new ChessPieceName { Name = "Drunken Ferz" },
                        new ChessPieceName { Name = "Diabolo" },
                        new ChessPieceName { Name = "Blind Bear", VariantID = "Taikyoku Shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "DrunkElephant", Symbol = "DE",
                    Notation = "FsfW", MoveDescription = "Moves one square in any adjacent direction except orthogonally backward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Drunk Elephant", VariantID = "Tori shōgi" },
                        new ChessPieceName { Name = "Drunk Elephant", VariantID = "Wa shōgi" },
                        new ChessPieceName { Name = "Falcon", VariantID = "Tori Shōgi" },
                        new ChessPieceName { Name = "Roaming Boar", VariantID = "Wa shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Yawn", Symbol = "Y", Value = 1,
                    Notation = "fFbW", MoveDescription = "Moves one square diagonally forward or one square orthogonally backward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Yawn" },
                    } 
                },
                new ChessPiece { PieceID = "ChargingRook", Symbol = "CR",
                    History = "Betza originally called this piece 'frlRrlbakking' from the notation 'frlRrlbK'",
                    Notation = "fsRbK", MoveDescription = "Moves forward and sideways as a rook, or backward as a king.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Charging Rook" },
                        new ChessPieceName { Name = "Turret" },
                    } 
                },
                new ChessPiece { PieceID = "PawnWithoutInitialMove", Symbol = "P", Value = 1, PromotesTo = "Any",
                    Notation = "mfWcfF", MoveDescription = "Moves forward one square, captures diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Pawn Without Initial Move" },
                        new ChessPieceName { Name = "Pawn", VariantID = "Makruk (Thai chess)" },
                        new ChessPieceName { Name = "Pawn", VariantID = "Shatar (Mongolian chess)" },
                        new ChessPieceName { Name = "Pawn", VariantID = "Senterej (Ethiopian chess)" },
                        new ChessPieceName { Name = "Pawn", VariantID = "Ouk Chatrang (Cambodian chess)" },
                        new ChessPieceName { Name = "Pawn", VariantID = "Chaturaji (4 player Indian chess)" },
                        new ChessPieceName { Name = "Baidaq (Persian Pawn)" },
                    } 
                },
                new ChessPiece { PieceID = "Pawn", Symbol = "P", Value = 1, PromotesTo = "Any",
                    Notation = "mfWcfFimfnD", MoveDescription = "Moves forward one square, captures diagonally, except on its first move, when it may move two squares.",
                    History = "Pawn (German: Bauer)",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Pawn" },
                        new ChessPieceName { Name = "Pawn", VariantID = "Chadarangam (Telugu chess)" },
                    } 
                },
                new ChessPiece { PieceID = "BerolinaPawn", Symbol = "BP", PromotesTo = "Any",
                    History = "Was invented by Edmund Nebermann in 1926, who named it after the city of Berlin in which he worked",
                    Notation = "mfFcefWimfnA", MoveDescription = "Moves one square diagonally forward (except on its first move, when it may move two), but captures by moving one square straight forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Berolina Pawn" },
                        new ChessPieceName { Name = "Berlin Pawn" },
                        new ChessPieceName { Name = "Anti-Pawn" },
                    } 
                },
                new ChessPiece { PieceID = "BerolinaPlusPawn", Symbol = "BP", PromotesTo = "Any",
                    Notation = "mfFcsfWimfF2", MoveDescription = "Berolina Pawn which can also capture one step orthogonally to the side.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Berolina Plus Pawn" },
                    } 
                },
                new ChessPiece { PieceID = "GrazPawn", Symbol = "GP", PromotesTo = "Any",
                    Notation = "fWfFifmW2ifmF2", MoveDescription = "Combines the powers of the Berolina Pawn and the standard Pawn.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Graz Pawn", VariantID = "Fairy Chess problems" },
                    } 
                },
                new ChessPiece { PieceID = "Yaksha", Symbol = "Y",
                    Notation = "fFbWsW3", MoveDescription = "Moves as a Yaksha in Taikyoku shōgi.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Yaksha", VariantID = "Taikyoku shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "QuangTrungRook", Symbol = "QR",
                    Notation = "mRcpR", MoveDescription = "Moves as a Rook (Quang Trung) in Quang Trung Chess.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Rook (Quang Trung)", VariantID = "Quang Trung Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Lama", Symbol = "La",
                    History = "Combination of Camel and Pawn. Invented by Pierre Monréal and Jean-Pierre Boyer (1965).",
                    Notation = "CmfWcfFimfW2", MoveDescription = "Combination of Camel and Pawn.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Lama", VariantID = "Fairy Chess problems" },
                    } 
                },
                new ChessPiece { PieceID = "AngryBoar", Symbol = "AB",
                    Notation = "fF2fsW", MoveDescription = "Moves forward and sideward as a Wazir and can make up to two Ferz moves forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Angry Boar" },
                    } 
                },
                new ChessPiece { PieceID = "TreacherousFox", Symbol = "TF",
                    Notation = "FfbWAfbD", MoveDescription = "Ferocious Leopard that can move forward or backward as Alibaba. Occurs in Taikyoku shōgi with a different move.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Treacherous Fox", VariantID = "Wa shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Sergeant", Symbol = "S",
                    Notation = "fKimfnD", MoveDescription = "Extended Pawn, combining the regular Pawn and the Berolina Pawn that is, it can move to, or capture on, any of the three squares immediately in front. Generally, it cannot make the initial diagonal double-step from Berolina Pawn, only that straight double-step of the regular Pawn. Originally Vogt (Sergeant, Inspector) in German.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Sergeant" },
                    } 
                },
                new ChessPiece { PieceID = "BlindTiger", Symbol = "BT", PromotesTo = "FlyingStag",
                    Notation = "FsbW", MoveDescription = "Moves one square in any direction except orthogonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Blind Tiger" },
                    } 
                },
                new ChessPiece { PieceID = "Spy", Symbol = "S",
                    Notation = "fsDfF", MoveDescription = "The spy can move two spaces forwards or sideways, or can move like a knight one forward and then one horizontally or vice versa.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Spy", VariantID = "Chess Empire" },
                    } 
                },
                new ChessPiece { PieceID = "RightGeneral", Symbol = "RG",
                    Notation = "FvlW", MoveDescription = "Asymmetrical combination of Ferocious Leopard and left Wazir.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Right General", VariantID = "Dai dai shōgi" },
                        new ChessPieceName { Name = "Right General", VariantID = "Other large Shōgi variants" },
                    } 
                },
                new ChessPiece { PieceID = "LeftGeneral", Symbol = "LG",
                    Notation = "FvrW", MoveDescription = "Asymmetrical combination of Ferocious Leopard and right Wazir.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Left General", VariantID = "Dai dai shōgi" },
                        new ChessPieceName { Name = "Left General", VariantID = "Other large Shōgi variants" },
                    } 
                },
                new ChessPiece { PieceID = "CopperGeneral", Symbol = "CG", PromotesTo = "GoldGeneral",
                    Notation = "fFvW", MoveDescription = "Moves to the three spaces forward or one space backward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Copper General", VariantID = "Taikyoku shōgi" },
                        new ChessPieceName { Name = "Copper General", VariantID = "Wa shōgi" },
                        new ChessPieceName { Name = "Climbing Monkey" },
                        new ChessPieceName { Name = "Yale" },
                    } 
                },
                new ChessPiece { PieceID = "SilverGeneral", Symbol = "SG", PromotesTo = "GoldGeneral",
                    Notation = "FfW", MoveDescription = "Pawn like",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Silver General" },
                        new ChessPieceName { Name = "Silver Elephant", VariantID = "Indian Chess" },
                        new ChessPieceName { Name = "Khon (Thai Chess)" },
                        new ChessPieceName { Name = "Burmese Elephant" },
                        new ChessPieceName { Name = "Hsin in sittuyin (Burmese chess)" },
                        new ChessPieceName { Name = "Violent Stag", VariantID = "Taikyoku shōgi" },
                        new ChessPieceName { Name = "Violent Stag", VariantID = "Wa shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "ChickenGeneral", Symbol = "CG",
                    Notation = "fW4bF", MoveDescription = "Can move up to four steps forward or one step diagonally backward. The Pup General in Taikyoku shōgi has the same moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Chicken General", VariantID = "Taikyoku shōgi" },
                        new ChessPieceName { Name = "Pup General", VariantID = "Taikyoku shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Dog", Symbol = "D",
                    Notation = "fWbF", MoveDescription = "Moves one square directly forward (as Wazir), or diagonally backward (as a Ferz). Also called Strutting Crow (Taikyoku shōgi and Wa shōgi), Swooping Owl, or Wazir/Ferz-Hunter.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dog", VariantID = "Taikyoku shōgi" },
                        new ChessPieceName { Name = "Dog", VariantID = "Tenjiku shōgi" },
                        new ChessPieceName { Name = "Dog", VariantID = "Wa shōgi" },
                        new ChessPieceName { Name = "Strutting Cow", VariantID = "Taikyoku shōgi" },
                        new ChessPieceName { Name = "Swooping Owl" },
                        new ChessPieceName { Name = "Wazir/Ferz-Hunter"},
                    } 
                },
                new ChessPiece { PieceID = "CheckerKing", Symbol = "CK",
                    Notation = "mFcgA", MoveDescription = "Promoted Checker at American Checkers that can move diagonally backward. Note that in International Draughts, the King is flying (it can move any distance): mBcgA.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Checker King", VariantID = "American Checkers" },
                    } 
                },
                new ChessPiece { PieceID = "CheckerMan", Symbol = "CM", PromotesTo = "CheckerKing",
                    Notation = "mfFcfgA", MoveDescription = "Moves forward one diagonal square without capturing, or captures by jumping diagonally over an opponent's piece. Note that in other Checkers or Draughts, the Man can jump backward (mfFcgA).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Checker Man", VariantID = "American Checkers" },
                    } 
                },
                new ChessPiece { PieceID = "Basilisk", Symbol = "B",
                    Notation = "mfFfbWcfK", MoveDescription = "Bound to lower board. 3D movement: Can freeze any opposing piece on the cell directly above it automatically until the Basilisk moves away or is captured.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Basilisk", VariantID = "Dragonchess" },
                    } 
                },
                new ChessPiece { PieceID = "Corporal", Symbol = "C",
                    Notation = "mfKcfFimfnD", MoveDescription = "Improved Pawn that can also move without capture diagonally forward. Compare with Pawn and Sergeant.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Corporal" },
                    } 
                },
                new ChessPiece { PieceID = "TorpedoPawn", Symbol = "TP",
                    Notation = "mfW2cefF", MoveDescription = "Moves two square straight forward, but captures one square diagonally forward. Can capture a Torpedo Pawn en passant if the other Torpedo Pawn moves two squares forwards to the immediate square left or right of the Torpedo Pawn. Simply called Pawn in many chess variants.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Torpedo Pawn", VariantID = "Torpedo Chess" },
                        new ChessPieceName { Name = "Torpedo Pawn", VariantID = "Terachess" },
                    } 
                },
                new ChessPiece { PieceID = "ScorpionWinther", Symbol = "S",
                    Notation = "mfWcefFimfnDmfsN", MoveDescription = "A boosted Pawn which moves and captures as a standard Pawn or can make a non-capturing Knight jump on 2 position: east-north-east and west-north-west.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Scorpion (Winther)", VariantID = "Scorpion Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Troll", Symbol = "T",
                    Notation = "mfWcfFGH", MoveDescription = "Amphibian piece combining Threeleaper, Tripper with the simple moves of the Pawn (no e.p., no double step) in order to be able to reach all squares of the board. Used in modern chessvariants played with AI AI. (http://mrraow.com/index.php/aiai-home/aiai/)",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Troll" },
                    } 
                },
                new ChessPiece { PieceID = "HiashatarPawn", Symbol = "P",
                    Notation = "mfWcfFimfW3", MoveDescription = "Pawn (Hiashatar) in Hiashatar (Mongolian decimal chess) Orthodox Pawn with a triple step on first move.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Hiashatar Pawn", VariantID = "Hiashatar (Mongolian decimal chess)" },
                        new ChessPieceName { Name = "Küü", VariantID = "Mongolian" },

                    } 
                },
                new ChessPiece { PieceID = "SoldierSilberschmidt", Symbol = "S",
                    Notation = "mfWmsWcfF", MoveDescription = "Extended Pawn, moves one square orthogonally forward, left or right, and captures diagonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Soldier (Silberschmidt)", VariantID = "Hiashatar (Mongolian decimal chess)" },
                        new ChessPieceName { Name = "Extended Pawn" },
                    } 
                },
                new ChessPiece { PieceID = "Breakthrough", Symbol = "B",
                    Notation = "fmWfF", MoveDescription = "Moves forward one square orthogonally, captures or moves diagonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Breakthrough" },
                    } 
                },
                new ChessPiece { PieceID = "ArrowPawn", Symbol = "mW2cF",
                    Notation = "mW2cF", MoveDescription = "Moves orthogonally one or two squares and captures diagonally one square.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Arrow Pawn (Persson)", VariantID = "Arrow Pawn Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Fusilier", Symbol = "mWcF",
                    Notation = "mWcF", MoveDescription = "Extended Pawn, moves one square orthogonally in all four directions, and captures diagonally in all four directions; Swetart has fD move?",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Fusilier", VariantID = "Jeu de la Guerre" },
                        new ChessPieceName { Name = "Fusilier", VariantID = "Centennial Chess" },
                        new ChessPieceName { Name = "Extended Pawn" },
                        new ChessPieceName { Name = "Quadrapawn" },
                        new ChessPieceName { Name = "Steward (Brown)" },
                        new ChessPieceName { Name = "Hobbit", VariantID = "Jeu de la Guerre" },
                        new ChessPieceName { Name = "Hobbit", VariantID = "Hobbit Chess" },
                        new ChessPieceName { Name = "Steward", VariantID = "Jeu de la Guerre" },
                        new ChessPieceName { Name = "Steward", VariantID = "Centennial Chess" },
                    } 
                },
                new ChessPiece { PieceID = "VerticalMover", Symbol = "VM",
                    Notation = "WfbR", MoveDescription = "Combination of Reverse Chariot and Wazir (or Drunk Elephant).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Vertical Mover" },
                    } 
                },
                new ChessPiece { PieceID = "Assassin", Symbol = "A",
                    Notation = "WFcAcD", MoveDescription = "Assassin.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Assassin", VariantID = "Stealth chess" },
                    } 
                },
                new ChessPiece { PieceID = "GoldGeneral", Symbol = "G",
                    Notation = "WfF", MoveDescription = "Moves one square orthogonally, or one square diagonally forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Gold General" },
                        new ChessPieceName { Name = "Promoted Silver" },
                        new ChessPieceName { Name = "Promoted Shogi Knight" },
                        new ChessPieceName { Name = "Tokin (Promoted Shogi Pawn)" },
                        new ChessPieceName { Name = "Hen", VariantID = "DobutsuShogi" },
                        new ChessPieceName { Name = "Golden Bird", VariantID = "Taikyoku shōgi" },
                        new ChessPieceName { Name = "Violent Wolf", VariantID = "Wa shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "Dabbada", Symbol = "D",
                    Notation = "D", MoveDescription = "Jumps two squares orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dabbada" },
                    } 
                },
                new ChessPiece { PieceID = "Dabbabante", Symbol = "D",
                    Notation = "nD", MoveDescription = "Non-jumping Dabbaba.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dabbabante", VariantID = "Dabbabante Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Dabbabarider", Symbol = "DD",
                    Notation = "DD", MoveDescription = "Makes repeated Dabbaba moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dabbabarider" },
                    } 
                },
                new ChessPiece { PieceID = "DabbabaChecker", Symbol = "DC",
                    Notation = "DcgD", MoveDescription = "A Dabbaba that can also capture an enemy piece by leaping over it. This piece can potentially capture 2 enemy pieces at a time, one by jumping over it and the other by landing on it.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dabbaba Checker" },
                    } 
                },
                new ChessPiece { PieceID = "Diamond", Symbol = "FD", Value = 3,
                    Notation = "FD", MoveDescription = "Moves and captures like a Diamond. Can jump for all moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Diamond" },
                        new ChessPieceName { Name = "Kylin" },
                        new ChessPieceName { Name = "Fortress", VariantID = "Pacific Chess" },
                        new ChessPieceName { Name = "Duke", VariantID = "Jelliss" },
                        new ChessPieceName { Name = "Egret" },
                    } 
                },
                new ChessPiece { PieceID = "B4nD", Symbol = "B4nD",
                    Notation = "B4nD", MoveDescription = "Moves and captures like a Bishop for up to 4 squares diagonally, and exactly 2 squares orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "B4nD" },
                        new ChessPieceName { Name = "F4nD" },
                    } 
                },
                new ChessPiece { PieceID = "Pheasant", Symbol = "P",
                    Notation = "fDbF", MoveDescription = "Moves forward 2 squares or backwards diagonally one square.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Pheasant", VariantID = "Tori shōgi" },
                        new ChessPieceName { Name = "Pheasant", VariantID = "Other large Shōgi variants" },
                    }
                },
                new ChessPiece { PieceID = "Machine", Symbol = "WD",
                    Notation = "WD", MoveDescription = "Moves as dabbaba or as wazir. Can jump for all moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Machine" },
                        new ChessPieceName { Name = "Wazaba" },
                        new ChessPieceName { Name = "War Machine" },
                        new ChessPieceName { Name = "Machine", VariantID = "Terachess" },
                        new ChessPieceName { Name = "Machine", VariantID = "Zanzibar Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Wader", Symbol = "WDD",
                    Notation = "WDD", MoveDescription = "Moves and captures like a Wazir and a Dabbabarider.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Wader" },
                    } 
                },
                new ChessPiece { PieceID = "Narwhal", Symbol = "fDrlbW",
                    Notation = "fDrlbW", MoveDescription = "Moves and captures forward two spaces or one space sideways or backwards.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Narwhal" },
                    } 
                },
                new ChessPiece { PieceID = "TileGeneral", Symbol = "TG",
                    Notation = "bWfD", MoveDescription = "backwards one square or leaps two squares forward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Tile General" },
                    } 
                },
                new ChessPiece { PieceID = "FlyingSwallow", Symbol = "FS",
                    Notation = "bWfDD", MoveDescription = "backwards one square or leaps two squares forward repeatedly.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Flying Swallow" },
                    } 
                },
                new ChessPiece { PieceID = "Donkey", Symbol = "sWfbD",
                    Notation = "sWfbD", MoveDescription = "Jumps 1 square sideways, or 2 squares forwards and backwards.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Donkey", VariantID = "Maka dai dai Shōgi" },
                        new ChessPieceName { Name = "Donkey", VariantID = "Other large Shōgi variants" },
                    }
                },
                new ChessPiece { PieceID = "ChampionBegnis", Symbol = "KD",
                    Notation = "KD", MoveDescription = "WFD. Moves and captures one square diagonally or up to 2 squares orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Champion (Begnis)", VariantID = "Reformed Courier Chess" },
                    }
                },
                new ChessPiece { PieceID = "Bede", Symbol = "BD", Value = 5,
                    Notation = "BD", MoveDescription = "Moves as bishop or dabbaba. Can jump for dabbaba moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Bede" },
                        new ChessPieceName { Name = "Leaping Bishop" },
                    } 
                },
                new ChessPiece { PieceID = "CiccoliniGeneral", Symbol = "G",
                    Notation = "BDD", MoveDescription = "General in Ciccolini's Chess",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "General in Ciccolini's Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Manticore", Symbol = "M", Value = 7,
                    Notation = "WaB", MoveDescription = "Wazir move followed by Bishop move.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Manticore" },
                        new ChessPieceName { Name = "Anchorite", VariantID = "Conclave Ecumenical chess" },  
                        new ChessPieceName { Name = "Acromantula", VariantID = "H. G. Muller" },
                        new ChessPieceName { Name = "Anchorite", VariantID = "C. Gilman" },
                        new ChessPieceName { Name = "Rhinoceros", VariantID = "Cazaux" },
                        new ChessPieceName { Name = "Spider", VariantID = "A. King" },
                        new ChessPieceName { Name = "Unicorn" },
                    } 
                },
                new ChessPiece { PieceID = "Harvester", Symbol = "H", Value = 10,
                    Notation = "(B)(WaB)", MoveDescription = "Combination of Bishop and Manticore.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Harvester", VariantID = "Tripunch Chess (Betza, 2002)" },
                    } 
                },
                new ChessPiece { PieceID = "Knight", Symbol = "N", Value = 3,
                    Notation = "N", MoveDescription = "Jumps one square diagonally and then one square orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Knight" , VariantID = "European Chess" },
                        new ChessPieceName { Name = "Cavalier", VariantID = "French" },
                        new ChessPieceName { Name = "Zebra" , VariantID = "Congo" },
                    } 
                },
                new ChessPiece { PieceID = "ChineseHorse", Symbol = "nN",
                    Notation = "nN", MoveDescription = "Moves like a Knight except that it does not leap. It steps one square orthogonally in any direction, then continues one square diagonally in the same general direction. The square stepped to orthogonally must be vacant.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Chinese Horse" },
                        new ChessPieceName { Name = "Mao" , VariantID = "Xiangqi (Chinese chess)" },
                        new ChessPieceName { Name = "Horse" , VariantID = "Akenhead's Chess (1947)" },
                    } 
                },
                new ChessPiece { PieceID = "ShogiKnight", Symbol = "fN", PromotesTo = "GoldGeneral",
                    Notation = "ffN", MoveDescription = "Moves like a classical Knight but limted to the two most forward moves. Shogi Knight promotes to Gold General. Wooden Horse promotes to regular Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Shogi Knight" },      
                    } 
                },
                new ChessPiece { PieceID = "HeavenlyHorse", Symbol = "ffbbN",
                    Notation = "ffbbN", MoveDescription = "Moves forwards and backwards like a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Heavenly Horse" , VariantID = "Wa shōgi" },
                        new ChessPieceName { Name = "Narrow Knight" }
                    } 
                },
                new ChessPiece { PieceID = "Crab", Symbol = "ffNbsN",
                    Notation = "ffNbsN", MoveDescription = "Moves forwards and backwards like a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Crab" },
                    } 
                },
                new ChessPiece { PieceID = "Barc", Symbol = "fsNbbN",
                    Notation = "fsNbbN", MoveDescription = "Backwards Crab.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Barc" },
                    } 
                },
                new ChessPiece { PieceID = "Hipposaur", Symbol = "cN",
                    Notation = "cN", MoveDescription = "Captures like a Knight, cannot otherwise move.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Hipposaur" },
                        new ChessPieceName { Name = "Hippopotamus" },
                    } 
                },
                new ChessPiece { PieceID = "Saltador", Symbol = "cnNmpN",
                    Notation = "cnNmpN", MoveDescription = "captures like a Knight when one of the intermediate squares is unoccupied, and moves without capturing as a Knight when one of the intermediate squares is occupied",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Saltador", VariantID = "Fairy Chess problems (M. Rittirsch, 2016)" },
                        new ChessPieceName { Name = "Argentinian Knight" },
                    } 
                },
                new ChessPiece { PieceID = "CylindricalKnight", Symbol = "oN",
                    Notation = "oN", MoveDescription = "Moves and captures like a Knight that can wrap around the board.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Cylindrical Knight" },
                    } 
                },
                new ChessPiece { PieceID = "Marquis", Symbol = "NW", Value = 6,
                    Notation = "NW", MoveDescription = "Moves like a Knight and a Wazir.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Marquis", VariantID = "Scirocco" },
                        new ChessPieceName { Name = "Emperor", VariantID = "Jelliss" },
                    } 
                },
                new ChessPiece { PieceID = "Duke", Symbol = "D",
                    Notation = "NW2", MoveDescription = "Moves like a Knight and a Rook limited to 2 squares.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Duke" },
                    } 
                },
                new ChessPiece { PieceID = "Chancellor", Symbol = "C", Value = 9,
                    History = "In 1617 Pietro Carrera named this piece the 'Campione', Italian for 'Champion'. Capablanca later named it the 'Chancellor'.",
                    Notation = "RN", MoveDescription = "Moves as rook or knight. Can jump for knight moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Chancellor" },
                        new ChessPieceName { Name = "Knighted Rook" },
                        new ChessPieceName { Name = "Knook" },
                        new ChessPieceName { Name = "Impératrice" , VariantID = "French" },
                        new ChessPieceName { Name = "Kaiserin" , VariantID = "German" },
                        new ChessPieceName { Name = "Admiral" },
                        new ChessPieceName { Name = "Cannon" },
                        new ChessPieceName { Name = "Colonel" },
                        new ChessPieceName { Name = "Count" },
                        new ChessPieceName { Name = "Dabbabah", VariantID = "Great Chess (India)" },
                        new ChessPieceName { Name = "War Machine", VariantID = "Great Chess (India)" },
                        new ChessPieceName { Name = "Duke" },
                        new ChessPieceName { Name = "Lambeth" },
                        new ChessPieceName { Name = "Lord Chancellor" },
                        new ChessPieceName { Name = "Marshall" },
                        new ChessPieceName { Name = "Nobleman", VariantID = "Greenwood's Chess" },
                        new ChessPieceName { Name = "Princess" },
                        new ChessPieceName { Name = "Samurai" },
                        new ChessPieceName { Name = "Superrook" },
                        new ChessPieceName { Name = "Tank" },
                        new ChessPieceName { Name = "Visier" }
                    } 
                },
                new ChessPiece { PieceID = "Rookni", Symbol = "R", Value = 4,
                    History = "A sniper piece.",
                    Notation = "mRcN", MoveDescription = "Captures like a Knight but moves like a Rook.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Rookni", VariantID = "Enlarged & Improved Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Kniroo", Symbol = "K", Value = 4,
                    History = "A sniper piece.",
                    Notation = "cRmN", MoveDescription = "Captures like a Rook but moves like a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Kniroo", VariantID = "Enlarged & Improved Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Dragonfly", Symbol = "sNvR",
                    Notation = "sNvR", MoveDescription = "Moves vertically as rook or sideways as knight. Can jump for knight moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dragonfly" },
                    } 
                },
                new ChessPiece { PieceID = "CylindricalChancellor", Symbol = "oRN",
                    Notation = "oWWoN", MoveDescription = "Moves and captures like a Chancellor that can wrap around the board.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Cylindrical Chancellor" },
                    } 
                },
                new ChessPiece { PieceID = "Raven", Symbol = "RNN",
                    Notation = "RNN", MoveDescription = "Raven, Waran, Varan",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Raven" },
                        new ChessPieceName { Name = "Waran" },
                        new ChessPieceName { Name = "Varan" },
                    } 
                },
                new ChessPiece { PieceID = "Aiwok", Symbol = "RNF",
                    Notation = "RNF", MoveDescription = "Aiwok, Archchancellor, Heroine, Superchancellor in Pocket Mutation Chess, Octopus Gr. Krake, Crowned Chancellor, Gr. Erzkanzler, Ship in Very Heavy Chess",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Aiwok" },
                        new ChessPieceName { Name = "Archchancellor" },
                        new ChessPieceName { Name = "Heroine" },
                        new ChessPieceName { Name = "Superchancellor" },
                    } 
                },
                new ChessPiece { PieceID = "Dullahan", Symbol = "FN", Value = 6,
                    History = "Named Dullahan in Fearful Fairies to be a male counterpart of the female Banshee",
                    Notation = "FN", MoveDescription = "Moves like a Knight and a Ferz.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dullahan" },
                        new ChessPieceName { Name = "Prince" },
                        new ChessPieceName { Name = "Priest" , VariantID = "Scirocco" },
                    } 
                },
                new ChessPiece { PieceID = "Leopard", Symbol = "F2N",
                    Notation = "F2N", MoveDescription = "Moves like a Knight and a Bishop limited to 2 squares.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Leopard" },
                    } 
                },
                new ChessPiece { PieceID = "Abbot", Symbol = "B4N",
                    Notation = "B4N", MoveDescription = "Moves like a Knight and a Bishop limited to 4 squares.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Abbot", VariantID = "Typhoon chess" },
                        new ChessPieceName { Name = "Scirocco" },
                    } 
                },
                new ChessPiece { PieceID = "Archbishop", Symbol = "BN", Value = 7,
                    History = "In 1617 Pietro Carrera named this piece the 'Centauro', Italian for 'centaur'. Capablanca later named it the 'Archbishop'.",
                    Notation = "BN", MoveDescription = "Moves as bishop or knight. Can jump for knight moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Archbishop", VariantID = "Quintessential Chess" },
                        new ChessPieceName { Name = "Archbishop", VariantID = "Sac Chess" },
                        new ChessPieceName { Name = "Knighted Bishop" },
                        new ChessPieceName { Name = "Adjutant", VariantID = "Kaiserspiel" },
                        new ChessPieceName { Name = "Paladin", VariantID = "Cavalier Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Unicorn", Symbol = "U", Value = 3,
                    History = "Grant Acedrex interpreted by H.J.R. Murray, 1913",
                    Notation = "BimN", MoveDescription = "Bishop with an initial move as a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Unicorn", VariantID = "Grant Acedrex" },
                    } 
                },
                new ChessPiece { PieceID = "Bishight", Symbol = "Bk", Value = 3,
                    Notation = "fBbN", MoveDescription = "Moves forward as a bishop and backward as a knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Bishight" },
                    } 
                },
                new ChessPiece { PieceID = "Knishop", Symbol = "Kb", Value = 3,
                    Notation = "fNbB", MoveDescription = "Moves forward as a knight and backward as a bishop.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Knishop" },
                    } 
                },
                new ChessPiece { PieceID = "Bishkni", Symbol = "B", Value = 4,
                    History = "A sniper piece.",
                    Notation = "mBcN", MoveDescription = "Captures like a Knight but moves like a Bishop.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Bishkni" },
                    } 
                },
                new ChessPiece { PieceID = "Knibi", Symbol = "K", Value = 4,
                    History = "A sniper piece.",
                    Notation = "mNcB", MoveDescription = "Captures like a Bishop but moves like a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Knibi" },
                    } 
                },
                new ChessPiece { PieceID = "CrownPrincess", Symbol = "BNW", Value = 7,
                    History = "Kronprinzessin is the German name for the Crown Princess.",
                    Notation = "BNW", MoveDescription = "Moves and captures like a Bishop, Knight and Wazir.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Crown Princess", VariantID = "Teutonic Knight's Chess" },
                        new ChessPieceName { Name = "Popess", VariantID = "Very Heavy Chess" },
                        new ChessPieceName { Name = "Supercardinal", VariantID = "Pocket Mutation Chess" },
                        new ChessPieceName { Name = "Freemason" },
                    } 
                },
                new ChessPiece { PieceID = "Crabinal", Symbol = "C",
                    Notation = "ffNbsNB2", MoveDescription = "Combination of a Crab and B2.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Crabinal" },
                    } 
                },
                new ChessPiece { PieceID = "Colonel", Symbol = "Co",
                    History = "Betza originally called this piece 'forfnifurlrurking'.",
                    Notation = "fhNfrlRK", MoveDescription = "Combination of Charging Knight and Charging Rook: moves forward as Knight or Rook, sideways as Rook, or backwards as King.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Colonel" },
                    } 
                },
                new ChessPiece { PieceID = "Horse", Symbol = "H", Value = 3,
                    Notation = "ffbbNF", MoveDescription = "Moves as ferz, or as a knight for its two vertically longest forward and backward moves. Can jump for knight moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Horse" },
                    } 
                }, 
                new ChessPiece { PieceID = "DrunkenKnight", Symbol = "DK",
                    History = "The Drunken Night is a toned down version of the Charging Knight to restore the balance. The name Drunken Night is inspired by the Suizo (Drunk Elephant) of Chu shōgi who moves like a King without the backwards Wazir move.",
                    Notation = "fhNsWbF", MoveDescription = "moves forwards as a Knight, sidewards as a Wazir, and backwards as a Ferz. It lacks the backwards Wazir move of the Charging Knight, taking away the can-mate property and toning down this piece.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Drunken Knight" },
                    } 
                },
                new ChessPiece { PieceID = "ChargingKnight", Symbol = "CK",
                    History = "Betza originally called this piece 'forfnibakking' from the original notation fhNrlbK.",
                    Notation = "fNsbK", MoveDescription = "Moves as king backward and sideways or as a knight forward. Can jump for all moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Charging Knight" },
                    } 
                },
                new ChessPiece { PieceID = "Centaur", Symbol = "KN", Value = 7,
                    Notation = "KN", MoveDescription = "Combination of a Knight and a King.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Centaur" },
                        new ChessPieceName { Name = "Crowned Knight" },
                        new ChessPieceName { Name = "Page", VariantID = "Renn chess" },
                        new ChessPieceName { Name = "Paladin", VariantID = "Reformed Courier Chess" },
                        new ChessPieceName { Name = "Judge", VariantID = "Sac Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Dragoon", Symbol = "D",
                    Notation = "KivmN", MoveDescription = "Moves as king or, on its initial move, vertically and without capturing as a knight. Can jump for knight moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dragoon" },
                    } 
                },
                new ChessPiece { PieceID = "Bear", Symbol = "B",
                    Notation = "W2FnN", MoveDescription = "Moves up to 2 squares orthogonally or one square diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Bear" },
                    } 
                },
                new ChessPiece { PieceID = "Banshee", Symbol = "BNN", Value = 9,
                    Notation = "BNN", MoveDescription = "Moves and captures like a Bishop and a Knightrider.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Banshee" },
                        new ChessPieceName { Name = "Unicorn", VariantID = "Unicorn Chess" },
                        new ChessPieceName { Name = "Cardinalrider", VariantID = "Pocket Mutation Chess" },
                        new ChessPieceName { Name = "Cardirider" },
                    } 
                },
                new ChessPiece { PieceID = "Knightrider", Symbol = "NN", Value = 5,
                    Notation = "NN", MoveDescription = "Moves like a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Knightrider" },
                    } 
                },
                new ChessPiece { PieceID = "ChineseNightrider", Symbol = "Nao",
                    Notation = "mNNcpNN", MoveDescription = "Moves as a Nightrider when not capturing, captures by leaping over a piece and capturing the piece on its destination.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Chinese Nightrider" },
                        new ChessPieceName { Name = "Nao" , VariantID = "Chinese" },
                    } 
                },
                new ChessPiece { PieceID = "Nightriderhopper", Symbol = "gNN",
                    Notation = "gNN", MoveDescription = "Moves like a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Nightriderhopper" },
                    } 
                },
                new ChessPiece { PieceID = "Rose", Symbol = "R",
                    Notation = "qNN", MoveDescription = "Pseudo-circular shape (e.g. e1-g2-h4-g6-e7-c6-b4-c2-e1). A piece on any of these squares can be captured but prevents the rose from progressing any further. It may return to its starting point if its path is unblocked, effectively passing a turn.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Rose" , VariantID = "Chess on a Really Big Board" },
                    } 
                },
                new ChessPiece { PieceID = "Boa", Symbol = "zNN",
                    Notation = "zNN", MoveDescription = "Straight wide crooked Knightrider.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Boa" },
                        new ChessPieceName { Name = "Straight wide crooked Knightrider" },
                    } 
                },
                new ChessPiece { PieceID = "Pancake", Symbol = "pNNK",
                    Notation = "pNNK", MoveDescription = "Moves like a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Pancake", VariantID = "Chess with different armies" },
                    } 
                },
                new ChessPiece { PieceID = "Ouroboros", Symbol = "O", Value = 6,
                    Notation = "ND", MoveDescription = "Combination of a Knight and a Dabbaba.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Ouroboros" },
                    } 
                },
                new ChessPiece { PieceID = "Taurus", Symbol = "T",
                    Notation = "sDffNsN", MoveDescription = "Jumps two squares sideways or knight moves forwards or sideways.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Taurus" },
                    } 
                },
                new ChessPiece { PieceID = "Debtor", Symbol = "D",
                    Notation = "vDsN", MoveDescription = "Moves and captures two squares forward or backward, and like a Knight sideways.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Debtor", VariantID = "Knavish Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Spider", Symbol = "S",
                    Notation = "F2DN", MoveDescription = "Moves and captures up to two squares diagonally, exactly two squares orthogonally, and like a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Spider" },
                    } 
                },
                new ChessPiece { PieceID = "Fortress", Symbol = "Fo",
                    Notation = "B3DvN", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Fortress" },
                    } 
                },
                new ChessPiece { PieceID = "LeftSastik", Symbol = "LS",
                    Notation = "DfflNbllNbbrNfrrN", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Left Sastik" },
                    }
                },
                new ChessPiece { PieceID = "RightSastik", Symbol = "RS",
                    Notation = "DffrNfllNbblNbrrN", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Right Sastik" },
                    }
                },
                new ChessPiece { PieceID = "Minister", Symbol = "M",
                    Notation = "WDN", MoveDescription = "Moves and captures one or two squares orthogonally and like a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Minister", VariantID = "Large Shatranj variants" },
                    } 
                },
                new ChessPiece { PieceID = "Wyvern", Symbol = "vNsjRB",
                    Notation = "vNsjRB", MoveDescription = "Moves as bishop, vertically as knight, or at least 2 steps horizontally as a rook. Can jump for knight moves and jumps over the first square for rook moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Wyvern" },
                    } 
                },
                new ChessPiece { PieceID = "DragonPawn", Symbol = "fWcfFimfnDN",
                    Notation = "fWcfFimfnDN", MoveDescription = "Combination of a Knight and a Pawn.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dragon Pawn" },
                    } 
                },
                new ChessPiece { PieceID = "CannonMusketeer", Symbol = "DWFsN",
                    Notation = "DWFsN", MoveDescription = "Moves like a Mann, Dabbaba and limited Knight sideways.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Cannon (Musketeer)" },
                    } 
                },
                new ChessPiece { PieceID = "Alfil", Symbol = "A",
                    History = "Spanish for bishop",
                    Notation = "A", MoveDescription = "Jumps two squares diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Alfil" },
                        new ChessPieceName { Name = "Gaja" },
                        new ChessPieceName { Name = "Hasty" },
                    } 
                },
                new ChessPiece { PieceID = "Alfilrider", Symbol = "AA", Value = 2,
                    History = "Alfilrider",
                    Notation = "AA", MoveDescription = "Jumps two squares diagonally as many times as wanted.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Alfilrider" },
                    } 
                },
                new ChessPiece { PieceID = "Elephant", Symbol = "nA",
                    History = "Elephant: A (2,2) leaper, but it cannot jump over an intervening piece, like the mao. In Chinese Chess, the elephant is restricted to its half of the board.",
                    Notation = "nA", MoveDescription = "Jumps two squares diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Elephant" },
                    } 
                },
                new ChessPiece { PieceID = "Waffle", Symbol = "WA", Value = 3,
                    Notation = "WA", MoveDescription = "Moves as wazir or alfil, hence the name. Can jump for all moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Waffle" },
                        new ChessPieceName { Name = "Elephant" },
                        new ChessPieceName { Name = "Caliph", VariantID = "Jelliss" },
                    } 
                },
                new ChessPiece { PieceID = "CylindricalWaffle", Symbol = "oWoA",
                    Notation = "oWoA", MoveDescription = "Moves and captures like a Waffle that can wrap around the board.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Cylindrical Waffle" },
                    } 
                },
                new ChessPiece { PieceID = "FlyingHorse", Symbol = "WnfA",
                    Notation = "WnfA", MoveDescription = "Combination of Wazir and Wood General.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Flying Horse", VariantID = "Dai dai shōgi" },
                    } 
                },
                new ChessPiece { PieceID = "mAW", Symbol = "mAW", Value = 2,
                    History = "mAW",
                    Notation = "mAW", MoveDescription = "Move as an Alfil, Move and Capture as a Wazir.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "mAW" },
                    } 
                },
                new ChessPiece { PieceID = "WarElephant", Symbol = "WE",
                    Notation = "R4A", MoveDescription = "Combination of a Alfil and R4.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "War Elephant" },
                    } 
                },
                new ChessPiece { PieceID = "ModernElephant", Symbol = "FA",
                    Notation = "FA", MoveDescription = "Jumps one or two squares diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Modern Elephant" },
                        new ChessPieceName { Name = "Ferfil" },
                        new ChessPieceName { Name = "Archer", VariantID = "Reformed Courier Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Faalcon", Symbol = "FAA",
                    Notation = "FAA", MoveDescription = "Moves as ferz, or makes consecutive alfil moves. Can jump between alfil moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Faalcon" },
                    } 
                },
                new ChessPiece { PieceID = "Hospitaller", Symbol = "NA", Value = 6,
                    Notation = "NA", MoveDescription = "Moves like a Knight and a Alfil.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Hospitaller" },
                        new ChessPieceName { Name = "Kangaroo", VariantID = "Outback Chess" },
                    } 
                },
                new ChessPiece { PieceID = "HighPriestess", Symbol = "FAN",
                    Notation = "FAN", MoveDescription = "Moves like a Knight and a Ferz and a Alfil.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "High Priestess", VariantID = "Large Shatranj variants" },
                    } 
                },
                new ChessPiece { PieceID = "Alibaba", Symbol = "AD", Value = 2,
                    Notation = "AD", MoveDescription = "Moves and captures 2 squares in any direction.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Alibaba" },
                    }
                },
                new ChessPiece { PieceID = "Alibabarider", Symbol = "AR",
                    Notation = "AADD", MoveDescription = "Makes repeated Dabbaba or Alfil moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Alibabarider" },
                    } 
                },
                new ChessPiece { PieceID = "FlyingKingfisher", Symbol = "FKF",
                    Notation = "KAADD", MoveDescription = "Moves and captures like a King/Man and an Alibabarider.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Flying Kingfisher" },
                    } 
                },
                new ChessPiece { PieceID = "ChampionOmega", Symbol = "C",
                    Notation = "WAD", MoveDescription = "Moves and captures like a Wazir and Alibaba.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Champion" },
                    } 
                },
                new ChessPiece { PieceID = "WAAmD", Symbol = "WAAmD", Value = 4,
                    Notation = "WAAmD", MoveDescription = "Moves and captures like a Wazir and Alfilrider and can move like a Dabbaba.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "WAAmD" },
                    } 
                },
                new ChessPiece { PieceID = "Goose", Symbol = "G",
                    Notation = "fAbD", MoveDescription = "Jumps two squares diagonally forward or orthogonally backward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Goose", VariantID = "Tori shōgi" },
                    }
                },
                new ChessPiece { PieceID = "ItoGoose", Symbol = "G",
                    Notation = "fObD", MoveDescription = "Jumps four squares forward or orthogonally backward.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Ito Goose" },
                    }
                },
                new ChessPiece { PieceID = "FAD", Symbol = "FAD", Value = 4,
                    Notation = "FAD", MoveDescription = "Moves as ferz, alfil or dabbaba, hence the name. Can jump for all moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "FAD" },
                    } 
                },
                new ChessPiece { PieceID = "Mastodon", Symbol = "Ma",
                    Notation = "KAD", MoveDescription = "WFAD. Moves and captures one or two sqares in any direction.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Mastodon", VariantID = "Paulovits Game" },
                        new ChessPieceName { Name = "Pasha", VariantID = "Paulovits Game" },
                        new ChessPieceName { Name = "Squire", VariantID = "Renn Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Lion-Murray", Symbol = "L", Value = 4,
                    Notation = "ADcK", MoveDescription = "Moves and captures one square in any direction, captures two squares in any direction.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Lion-Murray" },
                    } 
                },
                new ChessPiece { PieceID = "Lion", Symbol = "L",
                    Notation = "NADaK", MoveDescription = "Moves and captures three squares in any direction.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Lion" },
                    } 
                },
                new ChessPiece { PieceID = "GiraffeCongo", Symbol = "G", Value = 4,
                    Notation = "ADmK", MoveDescription = "Moves and captures one square in any direction, moves two squares in any direction.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Giraffe", VariantID = "Congo Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Pepperoni", Symbol = "P",
                    History = "Featured in John Lawson's Pizza Kings Army",
                    Notation = "sDfAvWF", MoveDescription = "Moves as ferz, horizontally as dabbaba, vertically as wazir or forward as alfil. Can jump for all moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Pepperoni" },
                    } 
                },
                new ChessPiece { PieceID = "Meatball", Symbol = "MB",
                    History = "Featured in John Lawson's Pizza Kings Army.",
                    Notation = "FWADffN.", MoveDescription = "Moves as King, Alfil, Dabbaba or as Knight for its 2 longest forward moves. Can jump for all moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Meatball" },
                    } 
                },
                new ChessPiece { PieceID = "Darter", Symbol = "D",
                    Notation = "fNWbAA", MoveDescription = "Moves as wazir, as Knight for its 2 most forward moves and can make repeated Alfil moves backwards.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Darter" },
                    } 
                },
                new ChessPiece { PieceID = "FlyingRook", Symbol = "FR",
                    Notation = "RAsD", MoveDescription = "A Rook that can additionally jump 2 squares diagonally or sideways.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Flying Rook" },
                    } 
                },
                new ChessPiece { PieceID = "Squirrel", Symbol = "S",
                    Notation = "NAD", MoveDescription = "Moves and captures like a Squirrel and can move like a Nand Dabbaba.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Squirrel" },
                        new ChessPieceName { Name = "Castle", VariantID = "Mideast Chess" },
                        new ChessPieceName { Name = "Castle", VariantID = "Pacific Chess" },
                        new ChessPieceName { Name = "Castle", VariantID = "Renn Chess" },
                        new ChessPieceName { Name = "Bear", VariantID = "Sosnovsky Chess" },
                        new ChessPieceName { Name = "Centurion", VariantID = "Quintessential Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Centurion", Symbol = "C",
                    Notation = "NnAnD", MoveDescription = "Like a Squirrel, but cannot jump over an intermediate piece when jumping like Alfil or Dabbaba.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Centurion", VariantID = "Arciscacchiere (Archchess, Francesco Piacenza, 1683)" },
                    } 
                },
                new ChessPiece { PieceID = "ModernLion", Symbol = "L",
                    Notation = "KAND", MoveDescription = "WFAND. Combines King/Man and Squirrel moves. Can jump to any square one or two squares away.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Modern Lion" },
                        new ChessPieceName { Name = "Joker", VariantID = "Waterloo Chess" },
                        new ChessPieceName { Name = "Joker", VariantID = "Amsterdam Medieval Chess" },
                        new ChessPieceName { Name = "Lion (Modern)", VariantID = "Terachess" },
                        new ChessPieceName { Name = "Lioness (Scirocco)", VariantID = "Scirocco Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Threeleaper", Symbol = "H",
                    Notation = "H", MoveDescription = "Jumps three squares orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Threeleaper" },
                        new ChessPieceName { Name = "Trébuchet" },
                    } 
                },
                new ChessPiece { PieceID = "Threerider", Symbol = "HH",
                    Notation = "HH", MoveDescription = "Moves and captures like a Threerider.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Threerider" },
                    } 
                },
                new ChessPiece { PieceID = "HHWD", Symbol = "HHWD",
                    Notation = "HHWD", MoveDescription = "HHWD.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "HHWD" },
                    } 
                },
                new ChessPiece { PieceID = "Frog", Symbol = "FH",
                    Notation = "FH", MoveDescription = "The smallest Amphibian.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Frog" },
                    } 
                },
                new ChessPiece { PieceID = "Toad", Symbol = "DH",
                    Notation = "DH", MoveDescription = "A simple amphibian.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Toad" },
                    } 
                },
                new ChessPiece { PieceID = "HalfDuck", Symbol = "HFD", Value = 5,
                    Notation = "HFD", MoveDescription = "Moves and captures like one square diagonally or two or three squares orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "HalfDuck" },
                    } 
                },
                new ChessPiece { PieceID = "Dolphin", Symbol = "D",
                    Notation = "R3mDmH", MoveDescription = "Moves and captures up to 3 squares orthogonally, or can jump move two or three squares orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dolphin" },
                    } 
                },
                new ChessPiece { PieceID = "Sausage", Symbol = "S",
                    History = "Featured in John Lawson's Pizza Kings Army",
                    Notation = "sWFvNvH", MoveDescription = "Moves as Ferz, horizontally as Wazir, as Knight for its longest moves or jumps 3 squares vertically. Can jump for all moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Sausage" },
                    } 
                },
                new ChessPiece { PieceID = "Newt", Symbol = "AH",
                    Notation = "AH", MoveDescription = "A simple Amphibian.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Newt" },
                    } 
                },
                new ChessPiece { PieceID = "Camel", Symbol = "C",
                    History = "Originally notated as L",
                    Notation = "C", MoveDescription = "Jumps one square diagonally and then two squares orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Camel", VariantID = "Terachess" },
                        new ChessPieceName { Name = "Jamel", VariantID = "Persian" },
                        new ChessPieceName { Name = "Chevalier", VariantID = "Mideast Chess" },
                        new ChessPieceName { Name = "General", VariantID = "Renn Chess" },
                        new ChessPieceName { Name = "Sage", VariantID = "Devingt Chess (Labrousse, 2005)" },
                        new ChessPieceName { Name = "Giraffe", VariantID = "Giraffe Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Canvasser", Symbol = "RC",
                    Notation = "RC", MoveDescription = "Canvasser in Ecumenical Chess",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Canvasser", VariantID = "Ecumenical Chess" },
                    } 
                },
                new ChessPiece { PieceID = "WizardOmega", Symbol = "W",
                    Notation = "FC", MoveDescription = "Combination of a Ferz and a Camel.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Wizard" },
                    } 
                },
                new ChessPiece { PieceID = "FalconryFalcon", Symbol = "F",
                    Notation = "CF3", MoveDescription = "Combination of a Camel and a Bishop limited to 3 squares.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Falcon", VariantID = "Falconry" },
                    } 
                },
                new ChessPiece { PieceID = "General", Symbol = "KC",
                    Notation = "KC", MoveDescription = "Combination of a non-royal King or Mann and a Camel.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "General", VariantID = "Paulovits's Game" },
                    } 
                },
                new ChessPiece { PieceID = "Roc", Symbol = "AC",
                    Notation = "AC", MoveDescription = "Combination of a Camel and a Alfil. Colorbound.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Roc", VariantID = "Beastmaster Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Gnu", Symbol = "NC",
                    Notation = "NC", MoveDescription = "Combination of a Camel and a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Gnu" },
                    },
                },
                new ChessPiece { PieceID = "TeutonicKnight", Symbol = "N",
                    History = "German: Ordensritter",
                    Notation = "WNC", MoveDescription = "Combination of a Camel and a Knight and a Wazir.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Teutonic Knight" , VariantID = "Teutonic Knight's Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Acropolis", Symbol = "A",
                    Notation = "RNC", MoveDescription = "Acropolis in Overkill Ecumenical Chess",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Acropolis", VariantID = "Overkill Ecumenical Chess" },
                    } 
                },
                new ChessPiece { PieceID = "BC", Symbol = "BC",
                    Notation = "BC", MoveDescription = "Combination of Bishop and Camel.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Caliph", VariantID = "Ecumenical Chess" },
                        new ChessPieceName { Name = "Flying Dragon", VariantID = "Ganymede Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Actor", Symbol = "A",
                    Notation = "BNC", MoveDescription = "Combination of Bishop, Knight, and Camel.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Actor", VariantID = "Overkill Ecumenical Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Vouivre", Symbol = "V",
                    Notation = "DNAC", MoveDescription = "Combines the moves of Roc and Ouroboros.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Vouivre" },
                    } 
                },
                new ChessPiece { PieceID = "Governor", Symbol = "Go",
                    Notation = "RAsC", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Governor" },
                    } 
                },
                new ChessPiece { PieceID = "Mushroom", Symbol = "M",
                    History = "Featured in John Lawson's Pizza Kings Army",
                    Notation = "vNfsCbF", MoveDescription = "Moves forwards as Knight for its longest moves, backwards as Ferz or as Camel for its shortest forward moves. Can jump for all moves.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Mushroom" },
                    } 
                },
                new ChessPiece { PieceID = "Camelrider", Symbol = "CC",
                    Notation = "CC", MoveDescription = "Can make repeated moves like a Camel.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Camelrider" },
                        new ChessPieceName { Name = "Mehari" },
                    } 
                },
                new ChessPiece { PieceID = "Gnurider", Symbol = "NNCC",
                    Notation = "NNCC", MoveDescription = "Combination of a Camelrider and a Nightrider.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Gnurider" },
                    } 
                },
                new ChessPiece { PieceID = "Leon", Symbol = "CH",
                    History = "Spanish for lion",
                    Notation = "CH", MoveDescription = "Combination of a Camel and a Threeleaper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Leon" } ,
                    } 
                },
                new ChessPiece { PieceID = "Zebra", Symbol = "Z",
                    Notation = "Z", MoveDescription = "Formally notated as J. Jumps two squares diagonally and then one square orthogonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Zebra" },
                        new ChessPieceName { Name = "Giraffe", VariantID = "Zanzibar Terrachess" },
                        new ChessPieceName { Name = "Elephant", VariantID = "Ciccolini's Chess" },
                        new ChessPieceName { Name = "Courtier", VariantID = "Mideast Chess" },
                    } 
                },
                new ChessPiece { PieceID = "JanggiElephant", Symbol = "nZ",
                    Notation = "nZ", MoveDescription = "Zebra that can be blocked.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Janggi Elephant", VariantID = "Janggi (Korean chess)" },
                    } 
                },
                new ChessPiece { PieceID = "Okapi", Symbol = "NZ",
                    Notation = "NZ", MoveDescription = "Combination of a Zebra and a Knight.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Okapi", VariantID = "Musketeer Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Zebrarider", Symbol = "ZZ",
                    Notation = "ZZ", MoveDescription = "Can make repeated moves like a Zebra.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Zebrarider" },
                    } 
                },
                new ChessPiece { PieceID = "Lynx", Symbol = "RNZ",
                    Notation = "RNZ", MoveDescription = "Lynx",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Lynx" },
                    } 
                },
                new ChessPiece { PieceID = "Bison", Symbol = "CZ",
                    Notation = "CZ", MoveDescription = "Combination of a Camel and a Zebra.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Bison" },
                    } 
                },
                new ChessPiece { PieceID = "Falcon(Falcon Chess)", Symbol = "F",
                    Notation = "nCnZ", MoveDescription = "A non-jumping Bison with multiple paths consisting of three straight or diagonal steps towards its endpoints. It can be blocked by two pieces and it can create a double pin.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Falcon(Falcon Chess)" , VariantID = "Falcon Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Buffalo", Symbol = "NCZ", Value = 12,
                    Notation = "NCZ", MoveDescription = "Combination of a Camel and a Knight and a Zebra.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Buffalo" , VariantID = "Cavalry Chess" },
                        new ChessPieceName { Name = "Buffalo" , VariantID = "Terachess" },
                    } 
                },
                new ChessPiece { PieceID = "Witch", Symbol = "W",
                    Notation = "QNNCCZZ", MoveDescription = "Combination of a Queen, Knightrider, Camelrider and a Zebrarider.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Witch" },
                    } 
                },
                new ChessPiece { PieceID = "Tripper", Symbol = "G",
                    Notation = "G", MoveDescription = "Jumps three squares diagonally.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Tripper" },
                        new ChessPieceName { Name = "Sentinel"  },
                    } 
                },
                new ChessPiece { PieceID = "ScorpionKing", Symbol = "KG",
                    Notation = "KG", MoveDescription = "Combination of a Tripper and a King.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Scorpion" },
                    } 
                },
                new ChessPiece { PieceID = "Harpoon", Symbol = "Ha",
                    Notation = "GH", MoveDescription = "Jumpes three squares in any direction.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Harpoon" },
                    } 
                },
                new ChessPiece { PieceID = "Shepard", Symbol = "Sh",
                    Notation = "jBAGR2", MoveDescription = "jBAGR2.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Shepard" },
                    } 
                },
                new ChessPiece { PieceID = "Tzar", Symbol = "Tz",
                    Notation = "QDAvZ", MoveDescription = "QDAvZ.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Tzar" },
                    } 
                },
                new ChessPiece { PieceID = "Hippopotamus", Symbol = "Wa",
                    Notation = "B2vWvnN", MoveDescription = "B2vWvnN.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Hippopotamus" },
                    } 
                },
                new ChessPiece { PieceID = "WardenWhite", Symbol = "Wa",
                    Notation = "BDA(FaF)", MoveDescription = "BDA(FaF).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Warden (White)" },
                    } 
                },
                new ChessPiece { PieceID = "WardenBlack", Symbol = "Wb",
                    Notation = "RDA", MoveDescription = "RDA.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Warden (Black)" },
                    } 
                },
                new ChessPiece { PieceID = "Tyrannosaurus", Symbol = "Ty",
                    Notation = "fsQbW2(fFafR)", MoveDescription = "fsQbW2(fFafR).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Tyrannosaurus" },
                    } 
                },
                new ChessPiece { PieceID = "Kangaroo", Symbol = "Ka",
                    Notation = "sWsNvDvC", MoveDescription = "sWsNvDvC.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Kangaroo" },
                    } 
                },
                new ChessPiece { PieceID = "NameraWhite", Symbol = "Na",
                    Notation = "WNA", MoveDescription = "WNA.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Namara (White)" },
                    } 
                },  
                new ChessPiece { PieceID = "NameraBlack", Symbol = "Na",
                    Notation = "WnNDA", MoveDescription = "WnNDA",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Namara (Black)" },
                    } 
                },
                new ChessPiece { PieceID = "ZebraMusketeer", Symbol = "Z",
                    Notation = "DvN", MoveDescription = "DvN.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Zebra" },
                    } 
                },
                new ChessPiece { PieceID = "Buzzard", Symbol = "Bz",
                    Notation = "DAHvZ", MoveDescription = "DAHvZ.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Buzzard" },
                    } 
                },
                new ChessPiece { PieceID = "UnicornMusketeer", Symbol = "U",
                    Notation = "FNC", MoveDescription = "FNC.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Unicorn" },
                    } 
                },
                new ChessPiece { PieceID = "WolfMusketeer", Symbol = "Wz",
                    Notation = "B2vW", MoveDescription = "B2vW.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Wolf" },
                    } 
                },
                new ChessPiece { PieceID = "DogMusketeer", Symbol = "Dz",
                    Notation = "B2sW", MoveDescription = "B2sW.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Dog" },
                    } 
                },
                new ChessPiece { PieceID = "CamelMusketeer", Symbol = "Cz",
                    Notation = "WvNvZ", MoveDescription = "WvNvZ.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Camel" },
                    } 
                },
                new ChessPiece { PieceID = "Bombard", Symbol = "B",
                    Notation = "RDNA", MoveDescription = "RDNA.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Bombard" },
                    } 
                },
                new ChessPiece { PieceID = "Glider", Symbol = "Gl",
                    Notation = "mfB2mbR2csWcfR2", MoveDescription = "mfB2mbR2csWcfR2.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Glider" },
                    } 
                },
                new ChessPiece { PieceID = "Citadel", Symbol = "C",
                    Notation = "WD(fDafB)(rDarB)(bDabB)(lDalB)", MoveDescription = "WD(fDafB)(rDarB)(bDabB)(lDalB).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Citadel" },
                    } 
                },
                new ChessPiece { PieceID = "Aquila", Symbol = "A",
                    Notation = "WDGAH", MoveDescription = "WDGAH.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Aquila" },
                    } 
                },
                new ChessPiece { PieceID = "MammothMusketeer", Symbol = "M",
                    Notation = "R3fB2", MoveDescription = "R3fB2.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Mammoth (Musketeer)" },
                    } 
                },
                new ChessPiece { PieceID = "Emperor", Symbol = "E",
                    Notation = "QAG", MoveDescription = "QAG.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Emperor" },
                    } 
                },
                new ChessPiece { PieceID = "WildebeestMusketeer", Symbol = "Wb",
                    Notation = "sD(fWafB)(bWabB)", MoveDescription = "sD(fWafB)(bWabB).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Wildebeest" },
                    } 
                },
                new ChessPiece { PieceID = "Rhino", Symbol = "Rh",
                    Notation = "B2sR2snN", MoveDescription = "B2sR2snN.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Rhino" },
                    } 
                },
                new ChessPiece { PieceID = "TigerMusketeer", Symbol = "Ti",
                    Notation = "FvNAGvZ", MoveDescription = "",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Tiger" },
                    } 
                },
                new ChessPiece { PieceID = "Hawk", Symbol = "ADGH",
                    Notation = "ADGH", MoveDescription = "Jumps two or three squares in any direction.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Hawk", VariantID = "Chess on an Infinite Plane" },
                    } 
                },
                new ChessPiece { PieceID = "Sabertooth", Symbol = "NADCZGH",
                    Notation = "NADCZGH", MoveDescription = "NADCZGH.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Sabertooth" },
                    } 
                },
                new ChessPiece { PieceID = "Fourleaper", Symbol = "FO",
                    Notation = "O", MoveDescription = "A (0,4) leaper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Fourleaper" },
                    } 
                },
                new ChessPiece { PieceID = "Root25Leaper", Symbol = "FI",
                    Notation = "VT", MoveDescription = "A (0,5)(3,4) leaper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Root-25-Leaper" },
                        new ChessPieceName { Name = "Bucephalus" },
                    } 
                },
                new ChessPiece { PieceID = "Zufara", Symbol = "U",
                    Notation = "U", MoveDescription = "A (1,4) leaper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Zurafa", VariantID = "Grant Acedrex" },
                        new ChessPieceName { Name = "Giraffe", VariantID = "Grant Acedrex murray" },
                    } 
                },
                new ChessPiece { PieceID = "Giraffe", Symbol = "G",
                    Notation = "nU", MoveDescription = "A non-jumping (1,4).",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Giraffe" },
                    } 
                },
                new ChessPiece { PieceID = "Ibis", Symbol = "I",
                    Notation = "I", MoveDescription = "A (1,5) leaper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Ibis" },
                    } 
                },
                new ChessPiece { PieceID = "Flamingo", Symbol = "FL",
                    Notation = "(1,6)", MoveDescription = "A (1,6) leaper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Flamingo" },
                    } 
                },
                new ChessPiece { PieceID = "Root50Leaper", Symbol = "RL",
                    Notation = "(1,7)J", MoveDescription = "A (1,7)(5,5) leaper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Root-50-leaper" },
                        new ChessPieceName { Name = "Root-fifty-leaper" },
                    } 
                },
                new ChessPiece { PieceID = "Lancer", Symbol = "L",
                    Notation = "L", MoveDescription = "A (2,4) leaper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Lancer" },
                        new ChessPieceName { Name = "Stag" },
                        new ChessPieceName { Name = "Hare" },
                    } 
                },
                new ChessPiece { PieceID = "Antelope", Symbol = "T",
                    Notation = "T", MoveDescription = "A (3,4) leaper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Antelope" },
                    } 
                },
                new ChessPiece { PieceID = "Pademelon", Symbol = "P",
                    Notation = "P", MoveDescription = "A (4,4) leaper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Pademelon" },
                        new ChessPieceName { Name = "Commuter" },
                    } 
                },
                new ChessPiece { PieceID = "WyvernBeastmaster", Symbol = "W",
                    Notation = "GIL", MoveDescription = "Combination of a Giraffe, a Stag and an Ibis.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Wyvern (Beastmaster)", VariantID = "Beastmaster Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Impala", Symbol = "I",
                    Notation = "NT", MoveDescription = "Combination of a Knight and an Antelope.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Impala" },
                    } 
                },
                new ChessPiece { PieceID = "StarRider", Symbol = "S",
                    Notation = "CCNT", MoveDescription = "Combination of a Camelrider, a Knight and an Antelope.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Star-rider" },
                    } 
                },
                new ChessPiece { PieceID = "Camelopard", Symbol = "CL",
                    Notation = "CCV", MoveDescription = "Combination of a Camelrider and a Fiveleaper.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Camelopard" },
                    } 
                },
                new ChessPiece { PieceID = "Auroch", Symbol = "A",
                    Notation = "NU", MoveDescription = "Combination of a Knight and a Zufara.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Auroch" },
                    } 
                },
                new ChessPiece { PieceID = "PegasusBeastmaster", Symbol = "P",
                    Notation = "ZU", MoveDescription = "Combination of a Zebra and a Zufara.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Pegasus (Beastmaster)", VariantID = "Beastmaster Chess" },
                    } 
                },
                new ChessPiece { PieceID = "Zebu", Symbol = "Z",
                    Notation = "CU", MoveDescription = "Combination of a Camel and a Zufara.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "Zebu" },
                    } 
                },
                new ChessPiece { PieceID = "ZurafaRook", Symbol = "Z",
                    Notation = "ZaR", MoveDescription = "Zurafa leap followed by Rook move.",
                    Names = new List<ChessPieceName> { 
                        new ChessPieceName { Name = "ZurafaRpok" },
                    } 
                },
            };
            // Add all pieces
            context.ChessPieces.AddRange(pieces);
            context.SaveChanges();

            // 2. Define Armies and their pieces
            // Helper structure to simplify definitions
            var armyDefinitions = new List<ChessVariant>
            {
                new ChessVariant { 
                    VariantID = "FIDE", Name = "The Fabulous FIDEs", Author = "FIDE",
                    Description = "The standard chess army we all know and love.", 
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant { 
                    VariantID = "Maharajah", Name = "Maharajah and the Sepoys", Author = "Edward Falkener", Year = "1892",
                    Description = "This is actually solved with a forced win for Black using the Sepoys (default Army), but is still interesting to play and listed here for completeness.", 
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Amazon", Rank = 0, File = 3, Name = "Maharajah" },
                    },
                },
                new ChessVariant { 
                    VariantID = "Emperor", Name = "Emperor Chess", Author = "Musketeer", Year = "2017",
                    Description = "The Emperor piece is about balanced with the classic army and Musketeer provides this as a variant.", 
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Emperor", Rank = 0, File = 3 },
                    },
                },
                new ChessVariant { 
                    VariantID = "SortofAlmost", Name = "Sort of Almost Chess", Author = "Ralph Betza",
                    Description = "The standard chess army with the Queen replaced by a Chancellor (Rook+Knight moves rather than the Queen's Rook+Bishop moves).", 
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant { 
                    VariantID = "IronGuard", Name = "Iron Guard Chess", Author = "Ed Friedlander",
                    Description = "The standard chess army with the Queen replaced by an Iron Guard (Moves one square diagonally and is immune to capture).", 
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "IronGuard", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant { 
                    VariantID = "NearChess", Name = "Near Chess", Author = "Tony Paletta",
                    Description = "Near Chess starts all the pieces one rank closer. Pawns cannot move two squares on their first move.", 
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 0 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 1 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "PawnHordeChess", Name = "Pawn Horde Chess", Author = "Chess.com",
                    Description = "A giant horde of 36 pawns. Black must destroy them all to win.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 0 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 1 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 7 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 3, File = 0 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 3, File = 1 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 3, File = 2 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 3, File = 3 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 3, File = 4 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 3, File = 5 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 3, File = 6 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 3, File = 7 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 1 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 2 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 5 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 6 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "WoodenHorseHerd", Name = "Wooden Horse Herd", Author = "Couch Potato",
                    Description = "A giant herd of 23 Wooden Horses (Knights which only have their two most forward moves, and promote to regular Knights).",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 0, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 1, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 2, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 3, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 5, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 6, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 7, Name = "Wooden Horse", PromotesTo = "Knight"},
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 1, File = 0, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 1, File = 1, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 1, File = 2, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 1, File = 3, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 1, File = 4, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 1, File = 5, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 1, File = 6, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 1, File = 7, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 2, File = 0, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 2, File = 1, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 2, File = 2, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 2, File = 3, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 2, File = 4, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 2, File = 5, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 2, File = 6, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 2, File = 7, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 3, File = 0, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 3, File = 1, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 3, File = 2, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 3, File = 3, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 3, File = 4, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 3, File = 5, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 3, File = 6, Name = "Wooden Horse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 3, File = 7, Name = "Wooden Horse", PromotesTo = "Knight" },
                    },
                },
                new ChessVariant{ 
                    VariantID = "BunchofQuights", Name = "Bunch of Quights", Author = "Couch Potato",
                    Description = "Eleven Quights (Moves like a Queen but captures like a Knight).",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Quight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Quight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Quight", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Quight", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Quight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Quight", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Quight", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Quight", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Quight", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Quight", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Quight", Rank = 1, File = 6 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "BunchofKhatuns", Name = "Bunch of Khatuns", Author = "Couch Potato",
                    Description = "Eleven Khatuns (Moves like a Knight but captures like a King).",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Khatun", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Khatun", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Khatun", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Khatun", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Khatun", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Khatun", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Khatun", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Khatun", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Khatun", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Khatun", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Khatun", Rank = 1, File = 6 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "HoppelPoppel", Name = "Hoppel-Poppel", Author = "German Chess Variant",
                    Description = "This is a traditional German Chess Variant where the Knights move like Knights, but capture like Bishops. The Bishops move like Bishops, but capture like Knights.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knibis", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bisknis", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bisknis", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knibis", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{
                    VariantID = "WeakChess", Name = "Weak Chess", Author = "",
                    Description = "Seven Knights and sixteen pawns.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 7 },
                    },
                },
                new ChessVariant{
                    VariantID = "MonsterChess", Name = "Monster Chess", Author = "",
                    Description = "King and four pawns, taking two moves per turn.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "AllAroundAllstars", Name = "All-Around Allstars", Author = "Ralph Betza",
                    Description = "Betza's official All-star army from pieces from his other armies.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "ChargingRook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "ChargingRook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "AllAroundAllstarsII", Name = "All-Around Allstars II", Author = "Ralph Betza",
                    Description = "Betza's second official All-star army from pieces from his other armies.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "ChargingRook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Horse", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishight", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Horse", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "ChargingRook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "AmazonArmy", Name = "Amazon Army", Author = "Ralph Betza",
                    Description = "One of Betza's unofficial armies, this army is themed around a very strong Queen.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "ShortRook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Amazon", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "ShortRook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "AvianAirforce", Name = "Avian Airforce", Author = "Ralph Betza",
                    Description = "One of Betza's unofficial armies, this army is themed around flying pieces.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Wader", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Darter", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Faalcon", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "FlyingKingfisher", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Faalcon", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Darter", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Wader", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{
                    VariantID = "BeautifulBeasts", Name = "Beautiful Beasts", Author = "Jörg Knappen",
                    Description = "This army is themed around the Roc piece from Beastmaster Chess.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Oroboros", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "CopperGeneral", Rank = 0, File = 1, Name = "Flying Goose" },
                        new ChessArmyPlacement { PieceId = "Roc", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Vouivre", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Roc", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Copper General", Rank = 0, File = 6, Name = "Flying Goose" },
                        new ChessArmyPlacement { PieceId = "Oroboros", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "BentBozos", Name = "Bent Bozos", Author = "H. G. Muller",
                    Description = "Bent Bozos, played on a 8x8 board. Distinguishing features include bent pieces that can move like a Rook, Knight, or Bishop.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "LeftGriffon", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "LeftAanca", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "LeftSastik", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Aanca", Rank = 0, File = 3, Name = "Griffon" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "RightSastik", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "RightAanca", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "RightGriffon", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "CastellumChess", Name = "Castellum Chess", Author = "Musketeer",
                    Description = "",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "FlyingRook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Taurus", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Hawk", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Duke", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Hawk", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Taurus", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "FlyingRook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "ColorboundClobberers", Name = "Colorbound Clobberers", Author = "Ralph Betza",
                    Description = "Part of the original Chess With Different Armies, found to be a little weak and corrected with the Colorbound Clobberers II.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Bede", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "FAD", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "FAD", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bede", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "ColorboundClobberersII", Name = "Colorbound Clobberers II", Author = "Ralph Betza",
                    Description = "An improved layout of the Colorbound Clobberers, with the pieces in a more balanced position.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Bede", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "FAD", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "FAD", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bede", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "CrushingConquerors", Name = "Crushing Conquerers", Author = "Ralph Betza",
                    Description = "An improved layout of the Colorbound Clobberers, with the pieces in a more balanced position.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Bede", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "FAD", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "FAD", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bede", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                
                new ChessVariant{ 
                    VariantID = "NuttyKnights", Name = "Nutty Knights", Author = "Ralph Betza",
                    Description = "Part of the original Chess With Different Armies. The Charging Knight is too powerful and so the Army was reworked as the Drunken Nights.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "ChargingRook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Horse", Rank = 0, File = 1, Name = "Fibnif" },
                        new ChessArmyPlacement { PieceId = "ChargingKnight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Colonel", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "ChargingKnight", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Horse", Rank = 0, File = 6, Name = "Fibnif" },
                        new ChessArmyPlacement { PieceId = "ChargingRook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "DrunkenNights", Name = "Drunken Nights", Author = "Jörg Knappen",
                    Description = "The Drunken Knight is a toned down version of the Charging Knight to restore the balance compared to the over-powered Nutty Knights.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "ChargingRook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Horse", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "DrunkenKnight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Colonel", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "DrunkenKnight", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Horse", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "ChargingRook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{
                    VariantID = "DaringDragons", Name = "Daring Dragons", Author = "H. G. Muller",
                    Description = "This army is themed around dragons.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "DragonHorse", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Dragonfly", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Dragoon", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Wyvern", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Dragoon", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "DragonFly", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "DragonHorse", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{
                    VariantID = "FearfulFairies", Name = "Fearful Fairies", Author = "Jörg Knappen",
                    Description = "This army is themed around fairies.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 0, Name = "Phoenix" },
                        new ChessArmyPlacement { PieceId = "Dullahan", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "ModernElephant", Rank = 0, File = 2, Name = "Fearful" },
                        new ChessArmyPlacement { PieceId = "Banshee", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "ModernElephant", Rank = 0, File = 5, Name = "Fearful" },
                        new ChessArmyPlacement { PieceId = "Dullahan", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 7, Name = "Phoenix" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{
                    VariantID = "FrogFairies", Name = "Frog Fairies", Author = "H. G. Muller",
                    Description = "H. G. Muller suggested replacing the Fearful Faeries' Phoenix with the Frog.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Frog", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Dullahan", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "ModernElephant", Rank = 0, File = 2, Name = "Fearful" },
                        new ChessArmyPlacement { PieceId = "Banshee", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "ModernElephant", Rank = 0, File = 5, Name = "Fearful" },
                        new ChessArmyPlacement { PieceId = "Dullahan", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Frog", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "ForwardFIDEs", Name = "Forward FIDEs", Author = "Ralph Betza",
                    Description = "One of Betza's unofficial armies, this group has a focus on moving forward.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "ChargingRook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knishop", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "ForeQueen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishight", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knishop", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "ChargingRook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "JumpersChess", Name = "Jumpers Chess", Author = "Musketeer",
                    Description = "",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Knishop", Rank = 0, File = 0, Name = "Vicar" },
                        new ChessArmyPlacement { PieceId = "Bishight", Rank = 0, File = 1, Name = "Carvi" },
                        new ChessArmyPlacement { PieceId = "Horse", Rank = 0, File = 2, Name = "Rhino" },
                        new ChessArmyPlacement { PieceId = "Forequeen", Rank = 0, File = 3, Name = "Vixen" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Horse", Rank = 0, File = 5, Name = "Rhino" },
                        new ChessArmyPlacement { PieceId = "Bishight", Rank = 0, File = 6, Name = "Carvi" },
                        new ChessArmyPlacement { PieceId = "Knishop", Rank = 0, File = 7, Name = "Vicar" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "MarsupialChess", Name = "Marsupial Chess", Author = "Musketeer",
                    Description = "",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Osprey", Rank = 0, File = 0, Name = "Flying Bishop" },
                        new ChessArmyPlacement { PieceId = "FAD", Rank = 0, File = 1, Name = "Antelope" },
                        new ChessArmyPlacement { PieceId = "BuffaloMusketeer", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "BuffaloMusketeer", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "FAD", Rank = 0, File = 6, Name = "Antelope" },
                        new ChessArmyPlacement { PieceId = "Osprey", Rank = 0, File = 7, Name = "Flying Bishop" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "MeticulousMashers", Name = "Meticulous Mashers", Author = "Ralph Betza",
                    Description = "One of Betza's unofficial armies, this army almost matches the default FIDEs.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Forfer", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Horse", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "B4nD", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "N2R4", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "B4nD", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Horse", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Forfer", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{
                    VariantID = "Orda", Name = "Orda", Author = "Daniel Lee",
                    Description = "Orda Chess was created in 2020 by Daniel Lee (Couch Tomato) as part of his Empire Chess series and is themed around a mounted Mongol horde. No castling. Additional Campmate victory available by moving Khan (King) to the last rank. Pawns can promote to Centaur or Queen.",
                    PromotionRules = new List<PromotionRule> {
                        new PromotionRule {
                            PromotablePieceIds = new List<string> { "PawnWithoutInitialMove" },
                            PromotionTargetPieceIds = new List<string> { "Centaur", "Queen" },
                        },
                    },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Kniroo", Rank = 0, File = 0, Name = "Horse Lancer" },
                        new ChessArmyPlacement { PieceId = "Centaur", Rank = 0, File = 1, Name = "Kheshig" },
                        new ChessArmyPlacement { PieceId = "Knibi", Rank = 0, File = 2, Name = "Horse Archer" },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 3, Name = "Yurt" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4, Name = "Khan" },
                        new ChessArmyPlacement { PieceId = "Knibi", Rank = 0, File = 5, Name = "Horse Archer" },
                        new ChessArmyPlacement { PieceId = "Centaur", Rank = 0, File = 6, Name = "Kheshig" },
                        new ChessArmyPlacement { PieceId = "Kniroo", Rank = 0, File = 7, Name = "Horse Lancer" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 0 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 1 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 2, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "PizzaKings", Name = "Pizza Kings", Author = "John Lawrson",
                    Description = "John Lawson created this army themed around pizza toppings.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Pepperoni", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Mushroom", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Sausage", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Meatball", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Sausage", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Mushroom", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pepperoni", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "RemarkableRookies", Name = "Remarkable Rookies", Author = "Ralph Betza",
                    Description = "Part of the original Chess With Different Armies.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "ShortRook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Machine", Rank = 0, File = 1, Name = "Woody Rook" },
                        new ChessArmyPlacement { PieceId = "HalfDuck", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "HalfDuck", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Machine", Rank = 0, File = 6, Name = "Woody Rook" },
                        new ChessArmyPlacement { PieceId = "ShortRook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{
                    VariantID = "Shinobi", Name = "Shinobi", Author = "Daniel Lee",
                    Description = "Shinobi Chess was created in 2020 by Daniel Lee (Couch Tomato) as part of his Empire Chess series and is themed around ninja warriors and Japanese Shogi Chess pieces. Stalemate is a win. No Castling. Pieces in hand can be dropped on your half of the board as a turn. Additional Campmate victory available by moving the Kage (King) to the last rank.",
                    PromotionRules = new List<PromotionRule> {
                        new PromotionRule {
                            PromotionRanks = new List<int> { 6, 7 },
                            },
                        },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 0, PromotesTo = "Rook" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 1, Name = "WoodenHorse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "Man", Rank = 0, File = 3, Name = "Captain" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4, Name = "Kage" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 6, Name = "WoodenHorse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 7, PromotesTo = "Rook" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0, PromotesTo = "Captain" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1, PromotesTo = "Captain" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2, PromotesTo = "Captain" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3, PromotesTo = "Captain" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4, PromotesTo = "Captain" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5, PromotesTo = "Captain" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6, PromotesTo = "Captain" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7, PromotesTo = "Captain" },
                        new ChessArmyPlacement { PieceId = "Lance", Rank = -1 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = -1, Name = "WoodenHorse", PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "Fers", Rank = -1, Name = "Monk", PromotesTo = "Bishop" },
                        new ChessArmyPlacement { PieceId = "Fers", Rank = -1, Name = "Monk", PromotesTo = "Bishop" },
                        new ChessArmyPlacement { PieceId = "DragonKing", Rank = -1, Name = "Dragon" },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = -1, Name = "Ninja" },
                    },
                },
                new ChessVariant{ 
                    VariantID = "SillySliders", Name = "Silly Sliders", Author = "H. G. Muller",
                    Description = "Themed around 'lame ski sliders' or 'skip' pieces.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "LameDuck", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Diamond", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Onyx", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Squire", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Onyx", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Diamond", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "LameDuck", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "BerolinaFIDEs", Name = "Berolina FIDEs", Author = "Edmund Nebermann",
                    Description = "The regular backline with a front line of Berolina Pawns.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },    
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "BerolinaClobberers", Name = "Berolina Clobberers", Author = "Ralph Betza",
                    Description = "The Colorbound Clobberers II with Berolina Pawns.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Bede", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "FAD", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "FAD", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bede", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 7 },
                    },
                },
                new ChessVariant{ 
                    VariantID = "BerolinaRookies", Name = "Berolina Rookies", Author = "Ralph Betza",
                    Description = "The Remarkable Rookies with Berolina Pawns.",
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "ShortRook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Machine", Rank = 0, File = 1, Name = "Woody Rook" },
                        new ChessArmyPlacement { PieceId = "HalfDuck", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "HalfDuck", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Machine", Rank = 0, File = 6, Name = "Woody Rook" },
                        new ChessArmyPlacement { PieceId = "ShortRook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "BerolinaPawn", Rank = 1, File = 7 },
                    },
                },
            };
            foreach (var army in armyDefinitions)
            {
                army.IsArmy = true;
                context.Variants.Add(army);
                foreach (var placement in army.Placements)
                {
                    var piece = context.ChessPieces.Find(placement.PieceId);
                    if (piece != null && !army.Placements.Any(p => p.PieceId == placement.PieceId))
                    {
                        army.Placements.Add(placement);
                    }
                }
            }
            context.SaveChanges();

            // 3. Define Variants
             var variants = new List<ChessVariant>
            {
                new ChessVariant
                {
                    VariantID = "Chaturanga", Name = "Chaturanga (Indian Chess)", Year = "500",
                    Description = "The earliest form of Chess from India, known as Chaturanga.",
                    BoardWidth = 8,
                    BoardHeight = 8,
                    ParentIDs = new List<string> { "Chaturanga" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0, Name = "Chariot" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1, Name = "Horse" },
                        new ChessArmyPlacement { PieceId = "Alfil", Rank = 0, File = 2, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4, Name = "Raja" },
                        new ChessArmyPlacement { PieceId = "Fers", Rank = 0, File = 3, Name = "Minister" },
                        new ChessArmyPlacement { PieceId = "Alfil", Rank = 0, File = 5, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6, Name = "Horse" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7, Name = "Chariot" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 0, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 1, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 2, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 3, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 4, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 5, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 6, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 7, Name = "Foot Soldier" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Shatranj", Name = "Shatranj (Persian Chess)", Year = "800",
                    Description = "Chess as it was played before being introduced to Europe.",
                    BoardWidth = 8,
                    BoardHeight = 8,
                    ParentIDs = new List<string> { "Chaturanga" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0, Name = "Chariot" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1, Name = "Horse" },
                        new ChessArmyPlacement { PieceId = "Alfil", Rank = 0, File = 2, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4, Name = "Shah" },
                        new ChessArmyPlacement { PieceId = "Fers", Rank = 0, File = 3, Name = "Queen" },
                        new ChessArmyPlacement { PieceId = "Alfil", Rank = 0, File = 5, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6, Name = "Horse" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7, Name = "Chariot" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 0, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 1, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 2, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 3, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 4, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 5, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 6, Name = "Foot Soldier" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 7, Name = "Foot Soldier" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Sittuyin", Name = "Sittuyin (Burmese Chess)", Year = "800",
                    Description = "Sittuyin စစ်တုရင် is known as Burmese chess. Players start with the minor pieces in hand and place them on their side of the board in the setup of the game. Rooks must be placed on the back rank. Pawns can only promote to Queen (Fers) if Queen is already captured.",
                    BoardWidth = 8,
                    BoardHeight = 8,
                    ParentIDs = new List<string> { "Chaturanga" },
                    PromotionRules = new List<PromotionRule> { new PromotionRule { 
                        PromotionZones = new List<BoardSquare> { 
                            new BoardSquare { Rank = 7, File = 0 },
                            new BoardSquare { Rank = 6, File = 1 },
                            new BoardSquare { Rank = 5, File = 2 },
                            new BoardSquare { Rank = 4, File = 3 },
                            new BoardSquare { Rank = 4, File = 4 },
                            new BoardSquare { Rank = 5, File = 5 },
                            new BoardSquare { Rank = 6, File = 6 },
                            new BoardSquare { Rank = 7, File = 7 }
                        },
                        PromotionTargetPieceIds = new List<string> { "Fers" }
                     } },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = -1, Name = "Chariot" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = -1, Name = "Horse" },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = -1, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Fers", Rank = -1, Name = "General" },
                        new ChessArmyPlacement { PieceId = "King", Rank = -1 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = -1, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = -1, Name = "Horse" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = -1, Name = "Chariot" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 0, Name = "Feudal Lord" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 1, Name = "Feudal Lord" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 2, Name = "Feudal Lord" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 3, Name = "Feudal Lord" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 3, File = 4, Name = "Feudal Lord" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 3, File = 5, Name = "Feudal Lord" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 3, File = 6, Name = "Feudal Lord" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 3, File = 7, Name = "Feudal Lord" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "WesternChess", Name = "Chess", Year = "1500",
                    Description = "The standard 8x8 chess board and pieces, as we know it today.",
                    BoardWidth = 8,
                    BoardHeight = 8,
                    ParentIDs = new List<string> { "Shatranj" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "LosAlamosChess", Name = "Los Alamos Chess", Year = "1956",
                    Description = "Created for the first chess playing computer MANIAC-I at Los Alamos Labs. No castling.",
                    BoardWidth = 6,
                    BoardHeight = 6,
                    ParentIDs = new List<string> { "WesternChess" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 1, File = 5 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Double", Name = "Double Chess", Author = "Julian S. Grant Hayward", Year = "1916",
                    Description = "Double Chess is double the pieces of standard chess on a 16x12 board.",
                    ParentIDs = new List<string> { "WesternChess" },
                    BoardWidth = 16,
                    BoardHeight = 12,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 10 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 11 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 12 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 13 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 14 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 15 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 10 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 11 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 12 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 13 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 14 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 15 },
                    }
                },

                new ChessVariant
                {
                    VariantID = "Carrera", Year = "1617", Author = "Pietro Carrera", Name = "Carrera's Chess",
                    Description = "Italian Priest Pietro Carrera published a book 'Il Gioco degli Scacchi' 'The Game of Chess' in 1617 which included this variant using a 'Campione' (Champion) Rook+Knight, and a 'Centauro' (Centaur) Bishop+Knight.",
                    ParentIDs = new List<string> { "WesternChess" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 1, Name = "Centaur" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 8, Name = "Champion" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Bird", Year = "1874", Author = "George Bird", Name = "Bird's Chess",
                    Description = "In 1874, British chess player George Bird published an article suggesting this variant as an improvement of Carrera's Chess, giving the central pawns more importance.",
                    ParentIDs = new List<string> { "Carrera" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 3, Name = "Guard" },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 6, Name = "Equerry" },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Capablanca", Year = "1926", Author = "José Raúl Capablanca", Name = "Capablanca Chess",
                    Description = "Chess legend José Raúl Capablanca created this variant around 1926, refining the Carrera's Chess variant.",
                    ParentIDs = new List<string> { "Carrera" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Janus", Year = "1978", Author = "Werner Schöndorf", Name = "Janus Chess",
                    Description = "Janus Chess is a chess variant invented in 1978 by Werner Schöndorf, as another iteration of Carrera's Chess.",
                    ParentIDs = new List<string> { "Carrera" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 1, Name = "Janus" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 8, Name = "Janus" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },  
                new ChessVariant
                {
                    VariantID = "Gothic", Year = "1978", Author = "Ed Trice", Name = "Gothic Chess",
                    Description = "Trice believes this is the ideal setup for the Carrera style of chess variants.",
                    ParentIDs = new List<string> { "Carrera" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },                
                new ChessVariant
                {
                    VariantID = "Grotesque", Year = "2004", Author = "Fergus Duniho", Name = "Grotesque Chess",
                    Description = "",
                    ParentIDs = new List<string> { "Carrera" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },  
                new ChessVariant
                {
                    VariantID = "Univers ", Year = "2006", Author = "Fergus Duniho", Name = "Univers Chess",
                    Description = "An alternative starting position for Carrera Chess adapted from Universal Chess.",
                    ParentIDs = new List<string> { "Carrera" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },                                
                new ChessVariant
                {
                    VariantID = "Ladorean ", Year = "2005", Author = "Bernhard U. Hermes", Name = "Ladorean Chess",
                    Description = "",
                    ParentIDs = new List<string> { "Carrera" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },                                
                new ChessVariant
                {
                    VariantID = "Schoolbook", Year = "2006", Author = "Sam Trenholme", Name = "Schoolbook Chess",
                    Description = "An alternative starting position for Carrera Chess.",
                    ParentIDs = new List<string> { "Carrera" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },         
                new ChessVariant
                {
                    VariantID = "Gemini", Name = "Gemini Chess", Author = "Musketeer", Year = "2017",
                    Description = "Achbishops flank the King and Queen in this Carrera variant.",
                    ParentIDs = new List<string> { "Carrera" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },            
                new ChessVariant
                {
                    VariantID = "21stCentury",  Year = "2001", Name = "21st Century Chess", Author = "Karl Munzlinger", 
                    Description = "Once per game a player may replace an unmoved Pawn with a Jester. Pawns and Jesters may promote to Sorcerers.",
                    ParentIDs = new List<string> { "Carrera" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 3, Name = "Baron" },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 6, Name = "Baron" },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "Breakthrough", Rank = -1, File = 0, Name = "Jester" },
                        new ChessArmyPlacement { PieceId = "Amazon", Rank = -1, File = 0, Name = "Sorcerer" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Musketeer", Year = "2016", Author = "Musketeer", Name = "Musketeer Chess",
                    Description = "Two pieces are used and placed behind two pieces on the back rank. The Cannon and Leopard are used by default but each player has the chance to replace a piece for both players. Pieces enter the board on the back rank when the position in front of them is freed by a move.",
                    ParentIDs = new List<string> { "Seirawan" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Leopard", Rank = -1 },
                        new ChessArmyPlacement { PieceId = "Hawk", Rank = -1 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = -1 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = -1 },
                        new ChessArmyPlacement { PieceId = "Mastodon", Rank = -1, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Gnu", Rank = -1, Name = "Unicorn" },
                        new ChessArmyPlacement { PieceId = "Cannon", Rank = -1 },
                        new ChessArmyPlacement { PieceId = "Amazon", Rank = -1, Name = "Dragon" },
                        new ChessArmyPlacement { PieceId = "Fortress", Rank = -1 },
                        new ChessArmyPlacement { PieceId = "Spider", Rank = -1 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "ChexxChess", Name = "Chexx Chess", Author = "Musketeer", Year = "2018",
                    Description = "White chooses a piece to place on b1 and b8. Black chooses a piece to place on i1 and i8.",
                    ParentIDs = new List<string> { "Musketeer" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Amazon", Rank = -1, File = 0, Name = "Dragon" },
                        new ChessArmyPlacement { PieceId = "Mastodon", Rank = -1, File = 0, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Fortress", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Leopard", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Hawk", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "CannonMusketeer", Rank = -1, File = 0, Name = "Cannon" },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Spider", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Gnu", Rank = -1, File = 0, Name = "Unicorn" },
                        new ChessArmyPlacement { PieceId = "ModernLion", Rank = -1, File = 0, Name = "Lion" },
                        new ChessArmyPlacement { PieceId = "Lionness", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Dragon2", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Wizard", Rank = -1, File = 0},
                        new ChessArmyPlacement { PieceId = "Warrior", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Bear", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "MammothMusketeer", Rank = -1, File = 0, Name = "Mammoth" },
                        new ChessArmyPlacement { PieceId = "Aquila", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Citadel", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Emperor", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Aanca", Rank = -1, File = 0, Name = "Griffin" },
                        new ChessArmyPlacement { PieceId = "WildebeestMusketeer", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Bombard", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "CamelMusketeer", Rank = -1, File = 0, Name = "Camel" },
                        new ChessArmyPlacement { PieceId = "Glider", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "DogMusketeer", Rank = -1, File = 0, Name = "Dog" },
                        new ChessArmyPlacement { PieceId = "WolfMusketeer", Rank = -1, File = 0, Name = "Wolf" },
                        new ChessArmyPlacement { PieceId = "Rhino", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Buzzard", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Man", Rank = -1, File = 0, Name = "Guard" },
                        new ChessArmyPlacement { PieceId = "NameraWhite", Rank = -1, File = 0, Name = "Namera (White)" },
                        new ChessArmyPlacement { PieceId = "NameraBlack", Rank = -1, File = 0, Name = "Namera (Black)" },
                        new ChessArmyPlacement { PieceId = "ZebraMusketeer", Rank = -1, File = 0, Name = "Zebra" },
                        new ChessArmyPlacement { PieceId = "Kangaroo", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Ouroboros", Rank = -1, File = 0, Name = "Giraffe" },
                        new ChessArmyPlacement { PieceId = "General", Rank = -1, File = 0, Name = "Gorilla" },
                        new ChessArmyPlacement { PieceId = "Tyrannosaurus", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "WardenWhite", Rank = -1, File = 0, Name = "Warden (White)" },
                        new ChessArmyPlacement { PieceId = "WardenBlack", Rank = -1, File = 0, Name = "Warden (Black)" },
                        new ChessArmyPlacement { PieceId = "Centaur", Rank = -1, File = 0, Name = "Crowned Knight" },
                        new ChessArmyPlacement { PieceId = "DragonKing", Rank = -1, File = 0, Name = "Crowned Rook" },
                        new ChessArmyPlacement { PieceId = "DragonHorse", Rank = -1, File = 0, Name = "Crowned Bishop" },
                        new ChessArmyPlacement { PieceId = "Hippopotamus", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Tzar", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Shepherd", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Governor", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "TigerMusketeer", Rank = -1, File = 0, Name = "Tiger" },
                        new ChessArmyPlacement { PieceId = "Hyena", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Harpoon", Rank = -1, File = 0 },
                    }
                },  
                new ChessVariant
                {
                    VariantID = "OmegaChess", Year = "1992", Author = "Daniel MacDonald", Name = "Omega Chess",
                    Description = "Pawns can capture en passant. King moves two squares to castle.",
                    ParentIDs = new List<string> { "GreatChess" },
                    BoardWidth = 12,
                    BoardHeight = 12,
                    DeadZones = new List<BoardSquare> {
                        new BoardSquare { Rank = 0, File = 1 },
                        new BoardSquare { Rank = 0, File = 2 },
                        new BoardSquare { Rank = 0, File = 3 },
                        new BoardSquare { Rank = 0, File = 4 },
                        new BoardSquare { Rank = 0, File = 5 },
                        new BoardSquare { Rank = 0, File = 6 },
                        new BoardSquare { Rank = 0, File = 7 },
                        new BoardSquare { Rank = 0, File = 8 },
                        new BoardSquare { Rank = 0, File = 9 },
                        new BoardSquare { Rank = 0, File = 10 },
                        new BoardSquare { Rank = 1, File = 0 },
                        new BoardSquare { Rank = 1, File = 11 },
                        new BoardSquare { Rank = 2, File = 0 },
                        new BoardSquare { Rank = 2, File = 11 },
                        new BoardSquare { Rank = 3, File = 0 },
                        new BoardSquare { Rank = 3, File = 11 },
                        new BoardSquare { Rank = 4, File = 0 },
                        new BoardSquare { Rank = 4, File = 11 },
                        new BoardSquare { Rank = 5, File = 0 },
                        new BoardSquare { Rank = 5, File = 11 },
                        new BoardSquare { Rank = 6, File = 0 },
                        new BoardSquare { Rank = 6, File = 11 },
                        new BoardSquare { Rank = 7, File = 0 },
                        new BoardSquare { Rank = 7, File = 11 },
                        new BoardSquare { Rank = 8, File = 0 },
                        new BoardSquare { Rank = 8, File = 11 },
                        new BoardSquare { Rank = 9, File = 0 },
                        new BoardSquare { Rank = 9, File = 11 },
                        new BoardSquare { Rank = 10, File = 0 },
                        new BoardSquare { Rank = 10, File = 11 },
                        new BoardSquare { Rank = 11, File = 1 },
                        new BoardSquare { Rank = 11, File = 2 },
                        new BoardSquare { Rank = 11, File = 3 },
                        new BoardSquare { Rank = 11, File = 4 },
                        new BoardSquare { Rank = 11, File = 5 },
                        new BoardSquare { Rank = 11, File = 6 },
                        new BoardSquare { Rank = 11, File = 7 },
                        new BoardSquare { Rank = 11, File = 8 },
                        new BoardSquare { Rank = 11, File = 9 },
                        new BoardSquare { Rank = 11, File = 10 },
                    },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "WizardOmega", Rank = 0, File = 0, Name = "Wizard" },
                        new ChessArmyPlacement { PieceId = "ChampionOmega", Rank = 1, File = 1, Name = "Champion" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "ChampionOmega", Rank = 1, File = 10, Name = "Champion" },
                        new ChessArmyPlacement { PieceId = "WizardOmega", Rank = 0, File = 11, Name = "Wizard" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 1, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 2, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 3, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 4, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 5, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 6, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 7, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 8, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 9, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 10, Name = "Pawn"},
                    }
                }, 
                new ChessVariant
                {
                    VariantID = "CerebralChess", Year = "2017", Author = "Keith Williams", Name = "Cerebral Chess",
                    Description = "In the style of Omega Chess with a stronger piece balance. Elephant and Hawk enter on the back rank as a move.",
                    ParentIDs = new List<string> { "OmegaChess" },
                    BoardWidth = 12,
                    BoardHeight = 12,
                    DeadZones = new List<BoardSquare> {
                        new BoardSquare { Rank = 0, File = 1 },
                        new BoardSquare { Rank = 0, File = 2 },
                        new BoardSquare { Rank = 0, File = 3 },
                        new BoardSquare { Rank = 0, File = 4 },
                        new BoardSquare { Rank = 0, File = 5 },
                        new BoardSquare { Rank = 0, File = 6 },
                        new BoardSquare { Rank = 0, File = 7 },
                        new BoardSquare { Rank = 0, File = 8 },
                        new BoardSquare { Rank = 0, File = 9 },
                        new BoardSquare { Rank = 0, File = 10 },
                        new BoardSquare { Rank = 1, File = 0 },
                        new BoardSquare { Rank = 1, File = 11 },
                        new BoardSquare { Rank = 2, File = 0 },
                        new BoardSquare { Rank = 2, File = 11 },
                        new BoardSquare { Rank = 3, File = 0 },
                        new BoardSquare { Rank = 3, File = 11 },
                        new BoardSquare { Rank = 4, File = 0 },
                        new BoardSquare { Rank = 4, File = 11 },
                        new BoardSquare { Rank = 5, File = 0 },
                        new BoardSquare { Rank = 5, File = 11 },
                        new BoardSquare { Rank = 6, File = 0 },
                        new BoardSquare { Rank = 6, File = 11 },
                        new BoardSquare { Rank = 7, File = 0 },
                        new BoardSquare { Rank = 7, File = 11 },
                        new BoardSquare { Rank = 8, File = 0 },
                        new BoardSquare { Rank = 8, File = 11 },
                        new BoardSquare { Rank = 9, File = 0 },
                        new BoardSquare { Rank = 9, File = 11 },
                        new BoardSquare { Rank = 10, File = 0 },
                        new BoardSquare { Rank = 10, File = 11 },
                        new BoardSquare { Rank = 11, File = 1 },
                        new BoardSquare { Rank = 11, File = 2 },
                        new BoardSquare { Rank = 11, File = 3 },
                        new BoardSquare { Rank = 11, File = 4 },
                        new BoardSquare { Rank = 11, File = 5 },
                        new BoardSquare { Rank = 11, File = 6 },
                        new BoardSquare { Rank = 11, File = 7 },
                        new BoardSquare { Rank = 11, File = 8 },
                        new BoardSquare { Rank = 11, File = 9 },
                        new BoardSquare { Rank = 11, File = 10 },
                    },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "UnicornMusketeer", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "CannonMusketeer", Rank = 1, File = 1, Name = "Cannon" },
                        new ChessArmyPlacement { PieceId = "Fortress", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Leopard", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Amazon", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Leopard", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Fortress", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "CannonMusketeer", Rank = 1, File = 10, Name = "Cannon" },
                        new ChessArmyPlacement { PieceId = "UnicornMusketeer", Rank = 0, File = 11 },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 1, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 2, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 3, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 4, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 5, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 6, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 7, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 8, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 9, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 2, File = 10, Name = "Pawn"},
                        new ChessArmyPlacement { PieceId = "Mastodon", Rank = -1, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Hawk", Rank = -1 }
                    }
                }, 
                new ChessVariant
                {
                    VariantID = "Balbo", Year = "1974", Author = "Monsieur G. Balbo", Name = "Balbo's Chess",
                    Description = "",
                    ParentIDs = new List<string> { "WesternChess" },
                    BoardWidth = 11,
                    BoardHeight = 10,
                    PromotionRules = new List<PromotionRule> {
                        new PromotionRule {
                            PromotionZones = new List<BoardSquare> {
                                new BoardSquare { Rank = 9, File = 4 },
                                new BoardSquare { Rank = 9, File = 5 },
                                new BoardSquare { Rank = 9, File = 6 },
                            },
                        },
                        new PromotionRule {
                            PromotionZones = new List<BoardSquare> {
                                new BoardSquare { Rank = 8, File = 3 },
                                new BoardSquare { Rank = 8, File = 7 },
                            },
                            PromotablePieceIds = new List<string> { "Pawn" },
                            PromotionTargetPieceIds = new List<string> { "Bishop", "Knight" },
                        },
                    },
                    DeadZones = new List<BoardSquare> {
                        new BoardSquare { Rank = 0, File = 0 },
                        new BoardSquare { Rank = 0, File = 1 },
                        new BoardSquare { Rank = 0, File = 2 },
                        new BoardSquare { Rank = 0, File = 3 },
                        new BoardSquare { Rank = 0, File = 7 },
                        new BoardSquare { Rank = 0, File = 8 },
                        new BoardSquare { Rank = 0, File = 9 },
                        new BoardSquare { Rank = 0, File = 10 },
                        new BoardSquare { Rank = 1, File = 0 },
                        new BoardSquare { Rank = 1, File = 1 },
                        new BoardSquare { Rank = 1, File = 2 },
                        new BoardSquare { Rank = 1, File = 8 },
                        new BoardSquare { Rank = 1, File = 9 },
                        new BoardSquare { Rank = 1, File = 10 },
                        new BoardSquare { Rank = 2, File = 0 },
                        new BoardSquare { Rank = 2, File = 1 },
                        new BoardSquare { Rank = 2, File = 9 },
                        new BoardSquare { Rank = 2, File = 10 },
                        new BoardSquare { Rank = 3, File = 0 },
                        new BoardSquare { Rank = 3, File = 10 },
                        new BoardSquare { Rank = 6, File = 0 },
                        new BoardSquare { Rank = 6, File = 10 },
                        new BoardSquare { Rank = 7, File = 0 },
                        new BoardSquare { Rank = 7, File = 1 },
                        new BoardSquare { Rank = 7, File = 9 },
                        new BoardSquare { Rank = 7, File = 10 },
                        new BoardSquare { Rank = 8, File = 0 },
                        new BoardSquare { Rank = 8, File = 1 },
                        new BoardSquare { Rank = 8, File = 2 },
                        new BoardSquare { Rank = 8, File = 8 },
                        new BoardSquare { Rank = 8, File = 9 },
                        new BoardSquare { Rank = 8, File = 10 },
                        new BoardSquare { Rank = 9, File = 0 },
                        new BoardSquare { Rank = 9, File = 1 },
                        new BoardSquare { Rank = 9, File = 2 },
                        new BoardSquare { Rank = 9, File = 3 },
                        new BoardSquare { Rank = 9, File = 7 },
                        new BoardSquare { Rank = 9, File = 8 },
                        new BoardSquare { Rank = 9, File = 9 },
                        new BoardSquare { Rank = 9, File = 10 },
                    },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 8 },
                    }
                }, 
                new ChessVariant
                {
                    VariantID = "Courier (German Chess)", Year = "1200", Author = "German", Name = "Courier Chess",
                    Description = "Courier game (German Läufer-spiel) is a chess varient that dates to the 12th Century.",
                    ParentIDs = new List<string> { "Shatranj" },
                    BoardWidth = 12,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Alfil", Rank = 0, File = 2, Name = "Bishop or Archer (Gr. Schütze)" },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 3, Name = "Courier" },
                        new ChessArmyPlacement { PieceId = "Man", Rank = 0, File = 4, Name = "Sage" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Wazir", Rank = 0, File = 7, Name = "Jester (Gr. Schleich)" },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 8, Name = "Courier" },
                        new ChessArmyPlacement { PieceId = "Alfil", Rank = 0, File = 9, Name = "Bishop or Archer (Gr. Schütze)" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 10 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 11 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 10 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 11 },
                    }
                }, 
                new ChessVariant
                {
                    VariantID = "Embassy", Year = "2005", Author = "Kevin Hill", Name = "Embassy Chess",
                    Description = "Embassy Chess is a variant of Grand Chess created in 2005 by Kevin Hill.",
                    ParentIDs = new List<string> { "GrandChess" },
                    BoardWidth = 10,
                    BoardHeight = 8,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 5, Name = "Marshal" },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 6, Name = "Cardinal" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },    
                new ChessVariant
                {
                    VariantID = "Grand", Year = "1984", Author = "Christian Freeling", Name = "Grand Chess",
                    Description = "Grand Chess is a variant of Chess created in 1984 by Christian Freeling. Pawns may only promote to captured pieces. There is no castling.",
                    ParentIDs = new List<string> { "WesternChess" },
                    BoardWidth = 10,
                    BoardHeight = 10,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 1, File = 5, Name = "Marshal" },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 1, File = 6, Name = "Cardinal" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 9 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "GreatChess", Year = "1400", Author = "Timur (Tamerlane)", Name = "Great Chess (Tamerlane's Chess)",
                    Description = "",
                    ParentIDs = new List<string> { "Shatranj" },
                    BoardWidth = 11,
                    BoardHeight = 10,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Afil", Rank = 0, File = 0, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Dabbaba", Rank = 0, File = 4, Name = "War Machine" },
                        new ChessArmyPlacement { PieceId = "Dabbaba", Rank = 0, File = 6, Name = "War Machine" },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Afil", Rank = 0, File = 10, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "SkipBishop", Rank = 1, File = 2, Name = "Picket (Scout)" },
                        new ChessArmyPlacement { PieceId = "Giraffe", Rank = 1, File = 3, Name = "Zurafa (Girafe)" },
                        new ChessArmyPlacement { PieceId = "Fers", Rank = 1, File = 4, Name = "General" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Wazir", Rank = 1, File = 6, Name = "Vizier" },
                        new ChessArmyPlacement { PieceId = "Giraffe", Rank = 1, File = 7, Name = "Zurafa (Girafe)" },
                        new ChessArmyPlacement { PieceId = "SkipBishop", Rank = 1, File = 8, Name = "Picket (Scout)" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 10 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 0, PromotesTo = "Pawn of Pawns" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 1, PromotesTo = "WarEngine" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 2, PromotesTo = "Camel" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 3, PromotesTo = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 4, PromotesTo = "General" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 5, PromotesTo = "King" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 6, PromotesTo = "Wazir" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 7, PromotesTo = "Giraffe" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 8, PromotesTo = "SkipBishop" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 9, PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 10, PromotesTo = "Rook" },
                    }
                },   
                new ChessVariant
                {
                    VariantID = "GreatChessCompleted", Year = "2017", Author = "Jean-Louis Cazaux", Name = "Great Chess Completed",
                    Description = "Tamerlane Chess with the empty spaces filled in with additional pieces.",
                    ParentIDs = new List<string> { "GreatChess" },
                    BoardWidth = 11,
                    BoardHeight = 10,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Alfil", Rank = 0, File = 0, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Threeleaper", Rank = 0, File = 1, Name = "Lion" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Bull", Rank = 0, File = 3, Name = "Bull" },
                        new ChessArmyPlacement { PieceId = "Dabbada", Rank = 0, File = 4, Name = "War Machine" },
                        new ChessArmyPlacement { PieceId = "Tripper", Rank = 0, File = 5, Name = "Revealer" },
                        new ChessArmyPlacement { PieceId = "Dabbada", Rank = 0, File = 6, Name = "War Machine" },
                        new ChessArmyPlacement { PieceId = "Bull", Rank = 0, File = 7, Name = "Bull" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Threeleaper", Rank = 0, File = 9, Name = "Lion" },    
                        new ChessArmyPlacement { PieceId = "Alfil", Rank = 0, File = 10, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "SkipBishop", Rank = 1, File = 2, Name = "Picket (Scout)" },
                        new ChessArmyPlacement { PieceId = "Giraffe", Rank = 1, File = 3, Name = "Zurafa (Girafe)" },
                        new ChessArmyPlacement { PieceId = "Fers", Rank = 1, File = 4, Name = "General" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Wazir", Rank = 1, File = 6, Name = "Luxm (Sea Monster, Crocodile)" },
                        new ChessArmyPlacement { PieceId = "Giraffe", Rank = 1, File = 7, Name = "Zurafa (Girafe)" },
                        new ChessArmyPlacement { PieceId = "SkipBishop", Rank = 1, File = 8, Name = "Picket (Scout)" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 10 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 0, PromotesTo = "Pawn of Pawns" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 1, PromotesTo = "Knight" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 2, PromotesTo = "Camel" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 3, PromotesTo = "Dabbaba" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 4, PromotesTo = "Fers" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 5, PromotesTo = "King" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 6, PromotesTo = "Wazir" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 7, PromotesTo = "Giraffe" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 8, PromotesTo = "SkipBishop" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 9, PromotesTo = "Lion" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 10, PromotesTo = "Rook" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 3, File = 2, PromotesTo = "Bull" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 3, File = 5, PromotesTo = "Revealer" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 3, File = 8, PromotesTo = "Afil" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "TamerlaneII", Year = "1978", Author = "Jean-Louis Cazaux", Name = "Tamerlane II",
                    Description = "This is a variant of Tamerlane Chess (Great Chess) created in 1978 by Jean-Louis Cazaux and last revised in 2000.",
                    ParentIDs = new List<string> { "GreatChess" },
                    BoardWidth = 11,
                    BoardHeight = 11,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "ModernElephant", Rank = 0, File = 0, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Cannon", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Cannon", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "ModernElephant", Rank = 0, File = 10, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Ship", Rank = 1, File = 3, PromotesTo = "Aanca" },
                        new ChessArmyPlacement { PieceId = "Prince", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Prince", Rank = 1, File = 6, },
                        new ChessArmyPlacement { PieceId = "Ship", Rank = 1, File = 7, PromotesTo = "Aanca" },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 10 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 0, PromotesTo = "Queen" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 1, PromotesTo = "Queen"  },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 2, PromotesTo = "Queen"  },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 3, PromotesTo = "Queen"  },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 4, PromotesTo = "Queen"  },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 5, PromotesTo = "Queen"  },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 6, PromotesTo = "Queen"  },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 7, PromotesTo = "Queen"  },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 8, PromotesTo = "Queen"  },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 9, PromotesTo = "Queen"  },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 2, File = 10, PromotesTo = "Queen"  },
                    }
                },
                new ChessVariant
                {
                    VariantID = "GrantAcedrex", Year = "1283", Author = "Jean-Louis Cazaux", Name = "Grant Acedrex",
                    Description = "This is a Medieval Chess game reconstructed by Jean-Louis Cazaux. Murray has Lion as a Threeleaper and Giraffe as a (4,1) leaper. No castling. Stalemate is a win.",
                    ParentIDs = new List<string> { "Shatranj" },
                    BoardWidth = 12,
                    BoardHeight = 12,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Leon", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Unicornio", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Zebra", Rank = 0, File = 3, Name = "Zarafa (Giraffe)" },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 4, Name = "Cockatrice (Crocodile)" },
                        new ChessArmyPlacement { PieceId = "Aanca", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 7, Name = "Cockatrice (Crocodile)" },
                        new ChessArmyPlacement { PieceId = "Zebra", Rank = 0, File = 8, Name = "Zarafa (Giraffe)" },
                        new ChessArmyPlacement { PieceId = "Unicornio", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Leon", Rank = 0, File = 10 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 11 },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 0, PromotesTo = "Rook" },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 1, PromotesTo = "Leon"  },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 2, PromotesTo = "Unicornio"  },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 3, PromotesTo = "Zebra"  },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 4, PromotesTo = "Bishop"  },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 5, PromotesTo = "Aanca"  },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 6, PromotesTo = "Aanca"  },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 7, PromotesTo = "Bishop"  },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 8, PromotesTo = "Zebra"  },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 9, PromotesTo = "Unicornio"  },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 10, PromotesTo = "Leon"  },
                        new ChessArmyPlacement { PieceId = "PawnWithoutInitialMove", Rank = 4, File = 11, PromotesTo = "Rook"  },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Giga", Year = "2001", Author = "Jean-Louis Cazaux", Name = "Gigachess",
                    Description = "Gigachess is a variant of Chess created in 2001 by Jean-Louis Cazaux. No castling.",
                    ParentIDs = new List<string> { "GreatChess" },
                    BoardWidth = 14,
                    BoardHeight = 14,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Vao", Rank = 0, File = 0, Name = "Crossbow" },
                        new ChessArmyPlacement { PieceId = "Cannon", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Ship", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Buffalo", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "ModernLion", Rank = 0, File = 5, Name = "Lion" },
                        new ChessArmyPlacement { PieceId = "Aanca", Rank = 0, File = 6, Name = "Gryphon" },
                        new ChessArmyPlacement { PieceId = "Amazon", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 8, Name = "Marshall" },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 9, Name = "Cardinal" },
                        new ChessArmyPlacement { PieceId = "Ship", Rank = 0, File = 10 },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 11 },
                        new ChessArmyPlacement { PieceId = "Cannon", Rank = 0, File = 12 },
                        new ChessArmyPlacement { PieceId = "Vao", Rank = 0, File = 13, Name = "Crossbow" },
                        new ChessArmyPlacement { PieceId = "Machine", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Elephant", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Man", Rank = 1, File = 5, Name = "Prince" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Man", Rank = 1, File = 8, Name = "Prince" },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 10 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 11 },
                        new ChessArmyPlacement { PieceId = "Elephant", Rank = 1, File = 12 },
                        new ChessArmyPlacement { PieceId = "Machine", Rank = 1, File = 13 },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 0, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 1, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 2, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 3, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "Corporal", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "Corporal", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "Corporal", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "Corporal", Rank = 2, File = 7 },
                        new ChessArmyPlacement { PieceId = "Corporal", Rank = 2, File = 8 },
                        new ChessArmyPlacement { PieceId = "Corporal", Rank = 2, File = 9 },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 10, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 11, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 12, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 13, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 3, File = 4, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 3, File = 5, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 3, File = 6, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 3, File = 7, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 3, File = 8, PromotesTo = "Amazon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 3, File = 9, PromotesTo = "Amazon" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Perfect12", Year = "1999", Author = "Jean-Louis Cazaux", Name = "Perfect 12 Chess",
                    Description = "This game is considered to be a predacessor to Metamachy Chess.",
                    ParentIDs = new List<string> { "GreatChess" },
                    BoardWidth = 12,
                    BoardHeight = 12,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Cannon", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 0, File = 2, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 0, File = 3, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 0, File = 4, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "ModernLion", Rank = 0, File = 5, Name = "Lion" },
                        new ChessArmyPlacement { PieceId = "Aanca", Rank = 0, File = 6, Name = "Gryphon" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 0, File = 7, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 0, File = 8, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 0, File = 9, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 10 },
                        new ChessArmyPlacement { PieceId = "Cannon", Rank = 0, File = 11 },
                        new ChessArmyPlacement { PieceId = "ModernElephant", Rank = 1, File = 0, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Man", Rank = 1, File = 4, Name = "Prince" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Man", Rank = 1, File = 7, Name = "Prince" },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 10 },
                        new ChessArmyPlacement { PieceId = "ModernElephant", Rank = 1, File = 11, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 0, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 1, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 2, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 3, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 4, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 5, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 6, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 7, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 8, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 9, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 10, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 11, PromotesTo = "Queen, ModernLion, Aanca" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Metamachy", Year = "2012", Author = "Jean-Louis Cazaux", Name = "Metamachy Chess",
                    Description = "King, Queen, Lion, and Aanca can be placed anywhere f1-g2 for 12 possible starting positions. King has an inital 2 move jump.",
                    ParentIDs = new List<string> { "Perfect12" },
                    BoardWidth = 12,
                    BoardHeight = 12,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Cannon", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 10 },
                        new ChessArmyPlacement { PieceId = "Cannon", Rank = 0, File = 11 },
                        new ChessArmyPlacement { PieceId = "ModernElephant", Rank = 1, File = 0, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "PrinceMetamachy", Rank = 1, File = 4, Name = "Prince" },
                        new ChessArmyPlacement { PieceId = "PrinceMetamachy", Rank = 1, File = 1, Name = "Prince" },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 10 },
                        new ChessArmyPlacement { PieceId = "ModernElephant", Rank = 1, File = 11, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 0, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 1, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 2, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 3, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 4, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 5, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 6, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 7, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 8, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 9, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 10, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "TorpedoPawn", Rank = 2, File = 11, PromotesTo = "Queen, ModernLion, Aanca" },
                        new ChessArmyPlacement { PieceId = "King", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = -1, File = 0 },
                        new ChessArmyPlacement { PieceId = "ModernLion", Rank = -1, File = 0, Name = "Lion" },
                        new ChessArmyPlacement { PieceId = "Aanca", Rank = -1, File = 0, Name = "Eagle" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Rutland", Year = "1747", Author = "John, third Duke of Rutland", Name = "Rutland Chess",
                    Description = "Stalemate is a win. Castling is four squares.",
                    ParentIDs = new List<string> { "WesternChess" },
                    BoardWidth = 14,
                    BoardHeight = 10,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "CrownedRook", Rank = 0, File = 1, Name = "Crowned Rook" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 5, Name = "Concubine" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 10 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 11 },
                        new ChessArmyPlacement { PieceId = "DragonKing", Rank = 0, File = 12, Name = "Crowned Rook" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 13 },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 0, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 1, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 2, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 3, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 4, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 5, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 6, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 7, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 8, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 9, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 10, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 11, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 12, Name = "Pawn" },
                        new ChessArmyPlacement { PieceId = "HiashatarPawn", Rank = 1, File = 13, Name = "Pawn" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Modern", Year = "1968", Author = "Gabriel Vicente Maura", Name = "Modern Chess",
                    Description = "Modern Chess is a more symetrical 9x9 Chess variant.",
                    ParentIDs = new List<string> { "WesternChess" },
                    BoardWidth = 9,
                    BoardHeight = 9,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 3, Name = "Prime Minister" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Chancellor", Year = "1887", Author = "Benjamin R. Foster", Name = "Chancellor Chess",
                    Description = "Chancellor Chess is played on a 9x9 with the additional Chancellor piece.",
                    ParentIDs = new List<string> { "WesternChess", "Carrera" },
                    BoardWidth = 9,
                    BoardHeight = 9,
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Seirawan", Year = "2007", Author = "Yasser Seirawan", Name = "Seirawan Chess",
                    Description = "Each side starts with a Hawk (Archbishop) and Elephant (Chancellor) in hand. Those pieces may be placed in the vacated square immediately after a back-rank piece is moved for the first time.",
                    ParentIDs = new List<string> { "WesternChess", "Carrera" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = -1, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = -1, Name = "Hawk" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "FalconHunter", Year = "1943", Author = "Karl Schultz", Name = "Halcon Hunter Chess",
                    Description = "Each side starts with a Falcon and Hunter in hand. After a minor piece is captured, a player may use his turn to place one of those pieces anywhere on their back rank.",
                    ParentIDs = new List<string> { "WesternChess" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Falcon", Rank = -1, },
                        new ChessArmyPlacement { PieceId = "Hunter", Rank = -1, },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "AdvancingChess", Year = "1961", Author = "Vernon Parton", Name = "Advancing Chess",
                    Description = "Also know as Dunce's Chess. Pieces can only move forward. No promotion. Stalemate is a win.",
                    ParentIDs = new List<string> { "WesternChess" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 0, Name = "Forward Rook", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 1, Name = "Wooden Knight", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ForwardBishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "ForwardQueen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "ForwardKing", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "ForwardBishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 6, Name = "Forward Knight", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 7, Name = "Forward Rook", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0, PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1, PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2, PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3, PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4, PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5, PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6, PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7, PromotesTo = "" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "SemiQueenChess", Year = "1970", Author = "Vernon Parton", Name = "Semi-queen Chess",
                    Description = "Parton adds two pieces to the regular chess set, on a 10x10 board.",
                    BoardWidth = 10,
                    BoardHeight = 10,
                    ParentIDs = new List<string> { "WesternChess" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Bisharoo", Rank = 0, File = 3, Name = "Biok" },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Roobi", Rank = 0, File = 6, Name = "Roshop" },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "SemiQueenChessExtended", Year = "1961", Author = "Vernon Parton", Name = "Semi-queen Chess Extended",
                    Description = "Parton adds an extra Biok and Roshop, moving the knights to the front rank.",
                    BoardWidth = 10,
                    BoardHeight = 10,
                    ParentIDs = new List<string> { "WesternChess" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Roobi", Rank = 0, File = 1, Name = "Roshop" },
                        new ChessArmyPlacement { PieceId = "Bishroo", Rank = 0, File = 2, Name = "Biok" },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bishroo", Rank = 0, File = 7, Name = "Biok" },
                        new ChessArmyPlacement { PieceId = "Roobi", Rank = 0, File = 8, Name = "Roshop" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Damate", Year = "1961", Author = "Vernon Parton", Name = "Damate Game",
                    Description = "Parton makes Chess into a more checkers-like game.",
                    BoardWidth = 10,
                    BoardHeight = 10,
                    ParentIDs = new List<string> { "WesternChess" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rookhopper", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knightriderhopper", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishopper", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Grasshopper", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "DamateKing", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "DamateKing", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Grasshopper", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bishopper", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Knightriderhopper", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rookhopper", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "DamatePawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "DamatePawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "DamatePawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "DamatePawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "DamatePawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "DamatePawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "DamatePawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "DamatePawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "DamatePawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "DamatePawn", Rank = 1, File = 9 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "WildebeestChess", Year = "1987", Author = "R. Wayne Schmittberger", Name = "Wildebeest Chess",
                    Description = "Animal themed chess meant to add more leapers to the game. Pawns may leap orthogonally any distance as long as they land on their half of the board.",
                    BoardWidth = 11,
                    BoardHeight = 10,
                    ParentIDs = new List<string> { "WesternChess" },
                    PromotionRules = new List<PromotionRule> {
                        new PromotionRule {
                            PromotionTargetPieceIds = new List<string> { "Wildebeest", "Queen" },
                        },
                    },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Camel", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Gnu", Rank = 0, File = 4, Name = "Wildebeest"},
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 10 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 8 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 9 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 10 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Neochess", Year = "1923", Author = "Hugo Legler", Name = "Neo-chess",
                    Description = "This variant was created by Hugo Legler in 1923, replacing one of the Rooks and Knights with a Chancellor and Archbishop respectively.",
                    ParentIDs = new List<string> { "WesternChess", "Carrera" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Coronation", Year = "1920", Author = "Frank Maus", Name = "Coronation Chess",
                    Description = "Pieces start the same as standard chess, but Rooks can combine with Bishops to form a Queen, Rooks can combine with Knights to form an Empress, and Bishops can combine with Knights to form a Princess.",
                    ParentIDs = new List<string> { "WesternChess" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = -1 },
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = -1, Name = "Empress" },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = -1, Name = "Princess" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Tuttifrutti", Year = "1978", Author = "Ralph Betza and Philip Cohen", Name = "Tutti-frutti Chess",
                    Description = "",
                    ParentIDs = new List<string> { "WesternChess", "Carrera" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Chancellor", Rank = 0, File = 0, Name = "Empress" },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Amazon", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "Archbishop", Rank = 0, File = 6, Name = "Princess" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 1 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 3 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 6 },
                        new ChessArmyPlacement { PieceId = "Pawn", Rank = 1, File = 7 },
                    }
                },

                new ChessVariant
                {
                    VariantID = "DobutsuShogi",
                    Year = "2008", Author = "Madoka Kitao", 
                    Name = "Dōbutsu shōgi (Animal Chess)",
                    Description = "A childrens game for learning Shōgi. Also sold as 'Let's Catch the Lion!'. Chick (Shōgi Pawn) promotes to Hen (Gold General).",
                    BoardWidth = 3,
                    BoardHeight = 5,
                    ParentIDs = new List<string> { "Shogi" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Fers", Rank = 0, File = 0, Name = "Elephant" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 1, Name = "Lion" },
                        new ChessArmyPlacement { PieceId = "Wazir", Rank = 0, File = 2, Name = "Girafe" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 1, Name = "Chick" , PromotesTo = "GoldGeneral" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "MiniShogi",
                    Year = "1970", 
                    Name = "Mini Shōgi",
                    Author = "Shigenobu Kusumoto",
                    Description = "Captured pieces are held in hand and dropped as a turn, but cannot capture on a drop.",
                    BoardWidth = 5,
                    BoardHeight = 5,
                    ParentIDs = new List<string> { "Shogi" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 3, Name = "Kakugyo", PromotesTo = "DragonHorse" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 4, PromotesTo = "DragonKing" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 0 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "JudkinsShogi",
                    Year = "1998", 
                    Name = "Judkin's Shōgi",
                    Author = "Paul Judkins",
                    Description = "Captured pieces are held in hand and dropped as a turn, but cannot capture on a drop.",
                    BoardWidth = 6,
                    BoardHeight = 6,
                    PromotionRules = new List<PromotionRule> { new PromotionRule { PromotionRanks = new List<int> { 4, 5 } } },
                    ParentIDs = new List<string> { "Shogi" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 4, Name = "Kakugyo", PromotesTo = "DragonHorse" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 5, PromotesTo = "DragonKing" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 0 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "WhaleShogi",
                    Year = "1981",
                    Name = "Whale Shogi",
                    Author = "R. Wayne Schmittberger",
                    Description = "Whale Shogi (鯨将棋 kujira shōgi) is a modern variant of shogi. Porpoise promotes to Killer Whale (Dragon King) after capturing. Dolphins (Shogi Pawns) can move backwards like a bishop on the last rank.",
                    BoardWidth = 6,
                    BoardHeight = 6,
                    ParentIDs = new List<string> { "Shogi" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "OldMonkey", Rank = 0, File = 0, Name = "Humpback Whale" },
                        new ChessArmyPlacement { PieceId = "Hunter", Rank = 0, File = 1, Name = "Grey Whale" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 2, Name = "White Whale" },
                        new ChessArmyPlacement { PieceId = "Porpoise", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Narwhal", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "CopperGeneral", Rank = 1, File = 5, Name = "Blue Whale" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 0, Name = "Dolphin", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 1, Name = "Dolphin", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 2, Name = "Dolphin", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 3, Name = "Dolphin", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 4, Name = "Dolphin", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 5, Name = "Dolphin", PromotesTo = "" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "PaulowichWhaleShogi",
                    Year = "2005",
                    Name = "Paulowich's Whale Shogi",
                    Author = "David Paulowich",
                    Description = "Whale Shogi (鯨将棋 kujira shōgi) is a modern variant of shogi. Porpoise promotes to Killer Whale (Dragon King) after capturing. Dolphins (Shogi Pawns) can move backwards like a bishop on the last rank.",
                    BoardWidth = 7,
                    BoardHeight = 7,
                    ParentIDs = new List<string> { "WhaleShogi" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "OldMonkey", Rank = 0, File = 0, Name = "Humpback Whale" },
                        new ChessArmyPlacement { PieceId = "Hunter", Rank = 0, File = 1, Name = "Grey Whale" },
                        new ChessArmyPlacement { PieceId = "Dog", Rank = 0, File = 2, Name = "Pacific northern right whale" },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 3, Name = "White Whale" },
                        new ChessArmyPlacement { PieceId = "Porpoise", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "Narwhal", Rank = 1, File = 5 },
                        new ChessArmyPlacement { PieceId = "CopperGeneral", Rank = 1, File = 6, Name = "Blue Whale" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 0, Name = "Dolphin", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 1, Name = "Dolphin", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 2, Name = "Dolphin", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 3, Name = "Dolphin", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 4, Name = "Dolphin", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 5, Name = "Dolphin", PromotesTo = "" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 1, File = 6, Name = "Dolphin", PromotesTo = "" },
                    }
                },
                new ChessVariant
                {
                    VariantID = "HeianShogi",
                    Year = "1100", 
                    Name = "Heian Shōgi",
                    Description = "Earliest form of Shogi, based on reconstruction of the game from the Heian period of Japan.",
                    BoardWidth = 9,
                    BoardHeight = 9,
                    ParentIDs = new List<string> { "Chaturanga" },
                    PromotionRules = new List<PromotionRule> { new PromotionRule { PromotionRanks = new List<int> { 6, 7, 8 } } },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 1 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 7 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 8 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "ShoShogi",
                    Year = "1400", 
                    Name = "Sho Shōgi (Historical Small Shogi)",
                    Description = "Historical Small Shogi, played on a 9x9 board. Derived from Heian Shogi, the immediate predecessor of modern Shogi. Differs from modern Shogi by the additional Drunk Elephant piece.",
                    BoardWidth = 9,
                    BoardHeight = 9,
                    ParentIDs = new List<string> { "HeianShogi" },
                    PromotionRules = new List<PromotionRule> { new PromotionRule { PromotionRanks = new List<int> { 6, 7, 8 } } },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 1, Name = "Kakugyo", PromotesTo = "DragonHorse" },
                        new ChessArmyPlacement { PieceId = "DrunkElephant", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 7, PromotesTo = "DragonKing" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 1 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 7 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 8 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "Shogi",
                    Year = "1636", 
                    Name = "Shōgi (Japanese Chess)",
                    Description = "Japanese Chess played on a 9x9 board. Distinguishing features include drops and promotion zones.",
                    BoardWidth = 9,
                    BoardHeight = 9,
                    ParentIDs = new List<string> { "ShoShogi" },
                    PromotionRules = new List<PromotionRule> { new PromotionRule { PromotionRanks = new List<int> { 6, 7, 8 } } },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 1, Name = "Kakugyo", PromotesTo = "DragonHorse" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 7, PromotesTo = "DragonKing" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 1 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 7 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 8 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "OkisakiShogi",
                    Year = "1996",
                    Name = "Okisaki Shōgi (Queen Shōgi)",
                    Author = "Masayuki Nakayachi",
                    Description = "Okisaki shōgi 'Queen shogi' features the Western Queen and Knights.",
                    BoardWidth = 10,
                    BoardHeight = 10,
                    ParentIDs = new List<string> { "Shogi", "WesternChess" },
                    PromotionRules = new List<PromotionRule> { new PromotionRule { PromotionRanks = new List<int> { 7, 8, 9 } } },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "Knight", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 1, Name = "Kakugyō (Angle Mover)", PromotesTo = "DragonHorse" },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 1, File = 8, PromotesTo = "DragonKing" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 1 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 7 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 8 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 9 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "ChuShogi",
                    Year = "1350",
                    Name = "Chu Shōgi (Medium Shogi)",
                    Description = "Medium Shōgi, played on a 12x12 board. Derived from Dai Shōgi. Distinguishing features include drops and promotion zones.",
                    BoardWidth = 12,
                    BoardHeight = 12,
                    ParentIDs = new List<string> { "DaiShogi" },
                    PromotionRules = new List<PromotionRule> { new PromotionRule { PromotionRanks = new List<int> { 8, 9, 10, 11 } } },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "FerociousLeopard", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "CopperGeneral", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "DrunkElephant", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "FerociousLeopard", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "CopperGeneral", Rank = 0, File = 10 },
                        new ChessArmyPlacement { PieceId = "FerociousLeopard", Rank = 0, File = 11 },
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 12 },
                        new ChessArmyPlacement { PieceId = "ReverseChariot", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 2, PromotesTo = "DragonHorse" },
                        new ChessArmyPlacement { PieceId = "BlindTiger", Rank = 1, File = 4 },
                        new ChessArmyPlacement { PieceId = "Diamond", Rank = 1, File = 5, Name = "Kirin" },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 1, File = 6, Name = "Phoenix" },
                        new ChessArmyPlacement { PieceId = "BlindTiger", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 1, File = 9, PromotesTo = "DragonKing" },
                        new ChessArmyPlacement { PieceId = "ReverseChariot", Rank = 1, File = 11 },
                        new ChessArmyPlacement { PieceId = "SideMover", Rank = 2, File = 0 },
                        new ChessArmyPlacement { PieceId = "VerticalMover", Rank = 2, File = 1 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "DragonHorse", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "DragonKing", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "Lion", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "DragonKing", Rank = 2, File = 7 },
                        new ChessArmyPlacement { PieceId = "DragonHorse", Rank = 2, File = 8 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 2, File = 9, PromotesTo = "DragonKing" },
                        new ChessArmyPlacement { PieceId = "VerticalMover", Rank = 2, File = 10 },
                        new ChessArmyPlacement { PieceId = "SideMover", Rank = 2, File = 11 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 1 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 2 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 3 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 4 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 5 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 6 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 7 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 8 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 9 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 10 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 3, File = 11 },
                        new ChessArmyPlacement { PieceId = "GoBetween", Rank = 4, File = 4 },
                        new ChessArmyPlacement { PieceId = "GoBetween", Rank = 4, File = 9 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "HeianDaiShogi",
                    Year = "1120",
                    Name = "Heian Dai Shōgi (Historical Large Shogi)",
                    Description = "A historical large Shogi variant from the Heian period of Japan, originally named Dai Shōgi, now called Heian Dai Shōgi to distinguish it from the modern variant.",
                    BoardWidth = 13,
                    BoardHeight = 13,
                    ParentIDs = new List<string> { "HeianShogi" },
                    PromotionRules = new List<PromotionRule> { new PromotionRule { PromotionRanks = new List<int> { 12, 13, 14 } } },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "IronGeneral", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "CopperGeneral", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "CopperGeneral", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "IronGeneral", Rank = 0, File = 10 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 11 },
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 12 },
                        new ChessArmyPlacement { PieceId = "ReverseChariot", Rank = 1, File = 0, Name = "Free Chariot" },
                        new ChessArmyPlacement { PieceId = "FlyingDragon", Rank = 1, File = 2 },
                        new ChessArmyPlacement { PieceId = "Fes", Rank = 1, File = 5, Name = "Fierce Tiger", PromotesTo = "GoldGeneral" },
                        new ChessArmyPlacement { PieceId = "SideMover", Rank = 1, File = 7 },
                        new ChessArmyPlacement { PieceId = "Fes", Rank = 1, File = 9, Name = "Fierce Tiger", PromotesTo = "GoldGeneral" },
                        new ChessArmyPlacement { PieceId = "FlyingDragon", Rank = 1, File = 11 },
                        new ChessArmyPlacement { PieceId = "ReverseChariot", Rank = 1, File = 12, Name = "Free Chariot" },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 1 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 2 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 3 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 4 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 5 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 6 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 7 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 8 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 9 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 10 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 11 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 2, File = 12 },
                        new ChessArmyPlacement { PieceId = "GoBetween", Rank = 3, File = 6 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "DaiShogi",
                    Year = "1230",
                    Name = "Dai Shōgi (Large Shogi)",
                    Description = "Large Shōgi, played on a 15x15 board. Distinguishing features include drops and promotion zones.",
                    BoardWidth = 15,
                    BoardHeight = 15,
                    ParentIDs = new List<string> { "HeianDaiShogi" },
                    PromotionRules = new List<PromotionRule> { new PromotionRule { PromotionRanks = new List<int> { 10, 11, 12, 13, 14 } } },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 1 },
                        new ChessArmyPlacement { PieceId = "StoneGeneral", Rank = 0, File = 2 },
                        new ChessArmyPlacement { PieceId = "IronGeneral", Rank = 0, File = 3 },
                        new ChessArmyPlacement { PieceId = "CopperGeneral", Rank = 0, File = 4 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 5 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 6 },
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 7 },
                        new ChessArmyPlacement { PieceId = "GoldGeneral", Rank = 0, File = 8 },
                        new ChessArmyPlacement { PieceId = "SilverGeneral", Rank = 0, File = 9 },
                        new ChessArmyPlacement { PieceId = "CopperGeneral", Rank = 0, File = 10 },
                        new ChessArmyPlacement { PieceId = "IronGeneral", Rank = 0, File = 11 },
                        new ChessArmyPlacement { PieceId = "StoneGeneral", Rank = 0, File = 12 },
                        new ChessArmyPlacement { PieceId = "ShogiKnight", Rank = 0, File = 13 },
                        new ChessArmyPlacement { PieceId = "Lance", Rank = 0, File = 14 },
                        new ChessArmyPlacement { PieceId = "ReverseChariot", Rank = 1, File = 0 },
                        new ChessArmyPlacement { PieceId = "Fers", Rank = 1, File = 2, Name = "Cat Sword" },
                        new ChessArmyPlacement { PieceId = "FerociousLeopard", Rank = 1, File = 4, },
                        new ChessArmyPlacement { PieceId = "BlindTiger", Rank = 1, File = 6, },
                        new ChessArmyPlacement { PieceId = "DrunkElephant", Rank = 1, File = 7, },
                        new ChessArmyPlacement { PieceId = "BlindTiger", Rank = 1, File = 8, },
                        new ChessArmyPlacement { PieceId = "FerociousLeopard", Rank = 1, File = 10, },
                        new ChessArmyPlacement { PieceId = "Fers", Rank = 1, File = 12, Name = "Cat Sword" },
                        new ChessArmyPlacement { PieceId = "ReverseChariot", Rank = 1, File = 14, },
                        new ChessArmyPlacement { PieceId = "ViolentOx", Rank = 2, File = 1, },
                        new ChessArmyPlacement { PieceId = "Wazir", Rank = 2, File = 3, Name = "Angry Boar" },
                        new ChessArmyPlacement { PieceId = "EvilWolf", Rank = 2, File = 5, },
                        new ChessArmyPlacement { PieceId = "Diamond", Rank = 2, File = 6, Name = "Kirin" },
                        new ChessArmyPlacement { PieceId = "Lion", Rank = 2, File = 7, },
                        new ChessArmyPlacement { PieceId = "Waffle", Rank = 2, File = 8, Name = "Phoenix" },
                        new ChessArmyPlacement { PieceId = "EvilWolf", Rank = 2, File = 9, },
                        new ChessArmyPlacement { PieceId = "Wazir", Rank = 2, File = 11, Name = "Angry Boar" },
                        new ChessArmyPlacement { PieceId = "ViolentOx", Rank = 2, File = 13, },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 3, File = 0 },
                        new ChessArmyPlacement { PieceId = "FlyingDragon", Rank = 3, File = 1 },
                        new ChessArmyPlacement { PieceId = "SideMover", Rank = 3, File = 2 },
                        new ChessArmyPlacement { PieceId = "VerticalMover", Rank = 3, File = 3 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 3, File = 4 },
                        new ChessArmyPlacement { PieceId = "DragonHorse", Rank = 3, File = 5 },
                        new ChessArmyPlacement { PieceId = "DragonKing", Rank = 3, File = 6 },
                        new ChessArmyPlacement { PieceId = "Queen", Rank = 3, File = 7 },
                        new ChessArmyPlacement { PieceId = "DragonKing", Rank = 3, File = 8 },
                        new ChessArmyPlacement { PieceId = "DragonHorse", Rank = 3, File = 9 },
                        new ChessArmyPlacement { PieceId = "Bishop", Rank = 3, File = 10 },
                        new ChessArmyPlacement { PieceId = "VerticalMover", Rank = 3, File = 11 },
                        new ChessArmyPlacement { PieceId = "SideMover", Rank = 3, File = 12 },
                        new ChessArmyPlacement { PieceId = "FlyingDragon", Rank = 3, File = 13 },
                        new ChessArmyPlacement { PieceId = "Rook", Rank = 3, File = 14 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 1 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 2 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 3 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 4 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 5 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 6 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 7 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 8 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 9 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 10 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 11 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 12 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 13 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 4, File = 14 },
                        new ChessArmyPlacement { PieceId = "GoBetween", Rank = 5, File = 4 },
                        new ChessArmyPlacement { PieceId = "GoBetween", Rank = 5, File = 10 },
                    }
                },
                new ChessVariant
                {
                    VariantID = "ItoShogi", 
                    Year = "2007", 
                    Author = "Jonathan Rutherford", 
                    Name = "Ito Shōgi (String Shogi)",
                    Description = "Ito Shōgi (String Shogi) is a variant of Shogi that was created in 2007 by Jonathan Rutherford and revised in 2022.",
                    BoardWidth = 1,
                    BoardHeight = 31,
                    ParentIDs = new List<string> { "Shogi" },
                    Placements = new List<ChessArmyPlacement> {
                        new ChessArmyPlacement { PieceId = "King", Rank = 0, File = 0 },
                        new ChessArmyPlacement { PieceId = "FlyingSwallow", Rank = 4, File = 0 },
                        new ChessArmyPlacement { PieceId = "ItoGoose", Rank = 5, File = 0, Name = "Goose" },
                        new ChessArmyPlacement { PieceId = "Threeleaper", Rank = 7, File = 0, Name = "Heavenly Horse" },
                        new ChessArmyPlacement { PieceId = "JanggiCannon", Rank = 8, File = 0, Name = "Silver Cannon" },
                        new ChessArmyPlacement { PieceId = "TileGeneral", Rank = 11, File = 0 },
                        new ChessArmyPlacement { PieceId = "ShogiPawn", Rank = 12, File = 0 },
                    }
                },
            };

            foreach (var v in variants)
            {
                if (!context.Variants.Any(existing => existing.VariantID == v.VariantID))
                {
                    context.Variants.Add(v);
                }
            }
            context.SaveChanges();
        }
    }
}
