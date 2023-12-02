using xadrezNoConsole.Entities;
using xadrezNoConsole.Entities.Tabuleiro;

namespace xadrezNoConsole
{
    class Program
    {
        static void Main(string[] Args)
        {
            Tab tab = new Tab(8, 8);

            Screen.WriteTab(tab);
        }
    }
}