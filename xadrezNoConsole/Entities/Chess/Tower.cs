using xadrezNoConsole.Entities.Tabuleiro;
using xadrezNoConsole.Enums;

namespace xadrezNoConsole.Entities.Chess
{
    class Tower : Piece
    {
        public Tower(Position position, Colors color, Tab tab)
            : base(position, color, tab)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
