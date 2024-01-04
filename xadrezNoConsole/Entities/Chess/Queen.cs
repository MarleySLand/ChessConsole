using xadrezNoConsole.Entities.Tabuleiro;
using xadrezNoConsole.Enums;

namespace xadrezNoConsole.Entities.Chess
{
    class Queen : Piece
    {
        public Queen(Position position, Colors color, Tab tab)
            : base(position, color, tab)
        {
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] mat = new bool[Tab.Lines, Tab.Columns];
            return mat;
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
