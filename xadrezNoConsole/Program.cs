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
            Tab tab = new Tab(8, 8);

            // queens
            tab.Placepiece(new Queen(new Position(0, 3), Colors.Black, tab), new Position(0, 3));
            tab.Placepiece(new Queen(new Position(7, 4), Colors.Black, tab), new Position(7, 4));

            // kings
            tab.Placepiece(new King(new Position(0, 4), Colors.Black, tab), new Position(0,4));
            tab.Placepiece(new King(new Position(7, 3), Colors.Black, tab), new Position(7, 3));

            // towers
            tab.Placepiece(new Tower(new Position(0, 0), Colors.Black, tab), new Position(0, 0));
            tab.Placepiece(new Tower(new Position(0, 7), Colors.Black, tab), new Position(0, 7));
            tab.Placepiece(new Tower(new Position(7, 0), Colors.Black, tab), new Position(7, 0));
            tab.Placepiece(new Tower(new Position(7, 7), Colors.Black, tab), new Position(7, 7));

            Screen.WriteTab(tab);
        }
    }
}