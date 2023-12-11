using xadrezNoConsole.Enums;

namespace xadrezNoConsole.Entities.Tabuleiro
{
    class Piece
    {
        public Position Position { get; set; }
        public Colors Color { get; protected set; }
        public Tab Tab { get; protected set; }
        public int MovementsQuantity { get; protected set; }

        public Piece(Position position, Colors color, Tab tab)
        {
            Position = position;
            Color = color;
            Tab = tab;
        }
    }
}
