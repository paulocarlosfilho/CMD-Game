using System;

namespace CMD_Game
{
    
    class Program
    {
        static string nomeDoJogo = "CDM Game";

        static void Main(string[] args)
        {
            Console.Title = nomeDoJogo;

            //----------------------------------------------
            //Iniciar HeroiD
            Heroi heroi = new Heroi();
            heroi.Nome = "Hero";
            heroi.Damage = 1;
            heroi.Score = 0;
            heroi.Vida = 25;
            heroi.AparecerHeroi();


            //----------------------------------------------

            //Iniciar grid
            Grid grid = new Grid();           
            grid.Preencher();

            //----------------------------------------------

            // Movimentação do Heroi
            while (true)
            {
                var up = Convert.ToString(Console.ReadKey());

                if (up == "w")
                {
                 
                }
                else if (up == "s")
                {

                }
                else if (up == "a")
                {

                }
                else if (up == "d")
                {

                }
                else
                {
                    return;
                }

            //----------------------------------------------
                Option option = new Option();
            option.Escolhar();

            //-----------------------------------------------
            
            

            
        }
    }
}
