using xadrezNoConsole.Entities.Tabuleiro;
using xadrezNoConsole.Entities.Chess;

namespace xadrezNoConsole.Entities
{
    class Screen
    {
        public static void WriteTab(Tab tab)
        {
            for (int i = 0; i < tab.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Columns; j++)
                {
                    if (tab.FindPiece(i, j) == null)
                    {
                        Console.Write("- ");
                    } else
                    {
                        PrintPiece(tab.FindPiece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static ChessPosition ReadPiece()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new ChessPosition(column, row);
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Enums.Colors.White)
            {
                Console.Write(piece);
            } else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}
