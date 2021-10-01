using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_Game
{
    public class Grid
    {
        string[,] grid = new string[20, 20];

        public void Preencher()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                   Console.Write($"O ");
                }
                Console.WriteLine();
            }
        }

    }
}
