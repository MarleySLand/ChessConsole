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
        private bool CanMove(Position pos)
        {
            Piece p = Tab.FindPiece(pos);
            return p == null || p.Color != Color;
        }

        public override bool[,] PossibleMovements()
        {
            Position pos = new Position(0, 0);
            bool[,] mat = new bool[Tab.Lines, Tab.Columns];

            //up
            pos.MovePosition(Position.Line - 1, Position.Column);
            while (Tab.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if (Tab.DoesPieceExist(pos) && Tab.FindPiece(pos).Color != Color)
                {
                    break;
                }
                pos.Line--;
            }
            //down
            pos.MovePosition(Position.Line + 1, Position.Column);
            while (Tab.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if (Tab.DoesPieceExist(pos) && Tab.FindPiece(pos).Color != Color)
                {
                    break;
                }
                pos.Line++;
            }
            //right
            pos.MovePosition(Position.Line, Position.Column + 1);
            while (Tab.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if (Tab.DoesPieceExist(pos) && Tab.FindPiece(pos).Color != Color)
                {
                    break;
                }
                pos.Column++;
            }
            //left
            pos.MovePosition(Position.Line, Position.Column - 1);
            while (Tab.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
                if (Tab.DoesPieceExist(pos) && Tab.FindPiece(pos).Color != Color)
                {
                    break;
                }
                pos.Column--;
            }
            return mat;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
