using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_Game
{
    public class Grid
    {
        static string[,] grid = new string[20, 20]
        {
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},
            {"O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ","O ",},

        };

        static string heroi = "H ";
        static int heroiLinha = 0;
        static int heroiColuna = 0;
        static string destino = "D";
        static int destinoLinha = 19;
        static int destinoColuna = 19;
        static string boss = "B";


        public void Preencher()
        {
            grid[17, 14] = boss;
            grid[0, 0] = heroi;
            grid[19, 19] = destino;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(grid[i, j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("========================================");
        }

        public void Escolhar()
            {
                string comando = Console.ReadLine().ToUpper();
                //ToUpper = converte as letras para maiusculo

                //Possiveis resultados dos comandos
                if (comando == "[A] to move left.    ")
                {
                    if (grid[heroiLinha, heroiColuna - 1] != " ")
                    {
                        grid[heroiLinha, heroiColuna] = "O ";
                        heroiLinha--;
                    }
                }
                else if (comando == "[D] to move right.")
                {
                    if (grid[heroiLinha, heroiColuna + 1] != " ")
                    {
                        grid[heroiLinha, heroiColuna] = "O ";
                        heroiLinha++;
                    }
                }
                else if (comando == "[W] to move up.      ")
                {
                    if (grid[heroiLinha - 1, heroiColuna] != " ")
                    {
                        grid[heroiLinha, heroiColuna] = "O ";
                        heroiLinha--;
                    }

                }
                else if (comando == "[S] to move down.")
                {
                    if (grid[heroiLinha + 1, heroiColuna] != " ")
                    {
                        grid[heroiLinha, heroiColuna] = "O ";
                        heroiLinha++;
                        Console.Write("Tecla S precionada");
                    }
                }
                else if (comando == "[SPACE] to attack")
                {

                }

                grid[heroiLinha, heroiColuna] = heroi;
        }

    }
}
