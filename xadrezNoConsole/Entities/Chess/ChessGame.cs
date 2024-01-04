using xadrezNoConsole.Enums;
using xadrezNoConsole.Entities.Tabuleiro;

namespace xadrezNoConsole.Entities.Chess

{
    class ChessGame
    {
        public Tab Tab { get; private set; }
        private int _turn;
        private Colors _firstMove;
        public bool Ended { get; set; }

        public ChessGame()
        {
            Tab = new Tab(8, 8);
            _turn = 1;
            _firstMove = Colors.White;
            PlacePieces();
        }

        public void MovementExe(Position origin, Position destiny)
        {
            Piece p = Tab.RemovePiece(origin);
            p.MovementsIncrement();
            Piece catchedPiece = Tab.RemovePiece(destiny);
            Tab.Placepiece(p, destiny);
        }

        private void PlacePieces()
        {
            Tab.Placepiece(new King(new ChessPosition('d', 1).ToPosition(), Colors.White, Tab), new ChessPosition('d', 1).ToPosition());
            Tab.Placepiece(new King(new ChessPosition('e', 8).ToPosition(), Colors.Black, Tab), new ChessPosition('e', 8).ToPosition());
            Tab.Placepiece(new Tower(new ChessPosition('a', 1).ToPosition(), Colors.White, Tab), new ChessPosition('a', 1).ToPosition());
            Tab.Placepiece(new Tower(new ChessPosition('a', 8).ToPosition(), Colors.White, Tab), new ChessPosition('h', 1).ToPosition());
            Tab.Placepiece(new Tower(new ChessPosition('a', 1).ToPosition(), Colors.Black, Tab), new ChessPosition('a', 8).ToPosition());
            Tab.Placepiece(new Tower(new ChessPosition('a', 1).ToPosition(), Colors.Black, Tab), new ChessPosition('h', 8).ToPosition());
        }
    }
}
