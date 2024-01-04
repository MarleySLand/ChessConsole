using xadrezNoConsole.Entities;
using xadrezNoConsole.Entities.Tabuleiro;
using xadrezNoConsole.Entities.Chess;
using xadrezNoConsole.Enums;

namespace xadrezNoConsole
{
    class Program
    {
        static void Main(string[] Args)
        {
            try
            {

                ChessGame chessgame = new ChessGame();

                while (!chessgame.Ended) {

                    Console.Clear();
                    Screen.WriteTab(chessgame.Tab);
                    Console.WriteLine();
                    Console.Write("Origin: ");
                    Position origin = Screen.ReadPiece().ToPosition();

                    bool[,] possiblePositions = chessgame.Tab.FindPiece(origin).PossibleMovements();

                    Console.Clear();
                    Screen.WriteTab(chessgame.Tab, possiblePositions);

                    Console.WriteLine();
                    Console.Write("Destiny: ");
                    Position destiny = Screen.ReadPiece().ToPosition();

                    chessgame.MovementExe(origin, destiny);
                }
                
            } catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}