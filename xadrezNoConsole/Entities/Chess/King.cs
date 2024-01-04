using xadrezNoConsole.Entities.Tabuleiro;
using xadrezNoConsole.Enums;

namespace xadrezNoConsole.Entities.Chess
{
    class King : Piece
    {
        public King(Position position, Colors color, Tab tab) 
            : base(position, color, tab)
        {
        }

        private bool CanMove(Position pos)
        {
            Piece p = Tab.FindPiece(pos);
            return p == null || p.Color != Color;
        }

        public override bool[,] PossibleMovements()
        {
            bool[,] mat = new bool[Tab.Lines, Tab.Columns];

            Position pos = new Position(0, 0);

            // Up
            pos.MovePosition(Position.Line - 1, Position.Column);
            if (Tab.IsPositionValid(pos) && CanMove(pos)) {
                mat[pos.Line, pos.Column] = true;
            }
            // Northeast
            pos.MovePosition(Position.Line - 1, Position .Column + 1);
            if (Tab.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // East
            pos.MovePosition(Position.Line, Position.Column + 1);
            if (Tab.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // Southeast
            pos.MovePosition(Position.Line + 1, Position.Column + 1);
            if (Tab.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // Down
            pos.MovePosition(Position.Line + 1, Position.Column);
            if (Tab.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // Southwest
            pos.MovePosition(Position.Line + 1, Position.Column - 1);
            if (Tab.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // West
            pos.MovePosition(Position.Line, Position.Column - 1);
            if (Tab.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
            // Northwest
            pos.MovePosition(Position.Line - 1, Position.Column - 1);
            if (Tab.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            return mat;
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
