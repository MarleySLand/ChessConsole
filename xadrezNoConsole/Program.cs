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

                tab.Placepiece(new Tower(new Position(0, 0), Colors.White, tab), new Position(0, 0));
                tab.Placepiece(new King(new Position(2, 5), Colors.Black, tab), new Position(2, 5));

                Screen.WriteTab(tab);
            } catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}