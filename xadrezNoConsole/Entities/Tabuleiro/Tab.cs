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

        public Piece piece(int lines, int columns)
        {
            return _tab[lines, columns];
        }
    }
}
