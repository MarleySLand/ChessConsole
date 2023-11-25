using xadrezNoConsole.Enums;

namespace xadrezNoConsole.Entities.Tabuleiro
{
    class Piece
    {
        public Position Position { get; set; }
        public Colors Color { get; protected set; }
        public Tab Tab { get; protected set; }
        public int MovementsQuantity { get; protected set; }

        public Piece(Position position, Colors color, Tab tab, int movementsQuantity)
        {
            Position = position;
            Color = color;
            MovementsQuantity = movementsQuantity;
            Tab = tab;
        }
    }
}
