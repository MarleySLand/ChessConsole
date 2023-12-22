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

                Tab tab = new Tab(8, 8);

                ChessPosition chsPos = new ChessPosition('c', 7);

                Console.WriteLine(chsPos);
                Console.WriteLine(chsPos.ToPosition());

                Screen.WriteTab(tab);
            } catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}