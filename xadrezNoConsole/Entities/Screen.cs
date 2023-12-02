using xadrezNoConsole.Entities.Tabuleiro;

namespace xadrezNoConsole.Entities
{
    class Screen
    {
        public static void WriteTab(Tab tab)
        {
            for (int i = 0; i < tab.Lines; i++)
            {
                for (int j = 0; j < tab.Columns; j++)
                {
                    if (tab.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    } else
                    {
                        Console.Write(tab.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
