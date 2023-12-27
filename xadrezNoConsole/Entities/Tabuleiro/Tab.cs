namespace xadrezNoConsole.Entities.Tabuleiro
{
    class Tab
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] _tab;

        public Tab(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            _tab = new Piece [Lines, Columns];
        }

        public Piece FindPiece(int lines, int columns)
        {
            return _tab[lines, columns];
        }

        public Piece FindPiece(Position pos)
        {
            return _tab[pos.Line, pos.Column];
        }

        public bool DoesPieceExist(Position pos)
        {
            TestPosition(pos);
            return FindPiece(pos) != null;
        }

        public bool IsPositionValid(Position pos)
        {
            if (pos.Line < 0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void TestPosition(Position pos)
        {
            if (!IsPositionValid(pos))
            {
                throw new TabuleiroException("The position you typed is invalid.");
            }
        }

        public void Placepiece(Piece p, Position pos)
        {
            if (DoesPieceExist(pos))
            {
                throw new TabuleiroException("There is already a piece in this position!");
            }
            _tab[pos.Line, pos.Column] = p;
            p.Position = pos;
        }

        public Piece RemovePiece(Position pos)
        {
            if (FindPiece(pos) == null)
            {
                return null;
            }
            Piece aux = FindPiece(pos);
            aux.Position = null;
            _tab[pos.Line, pos.Column] = null;
            return aux;
        }
    }
}
