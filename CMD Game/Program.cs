using System;

namespace CMD_Game
{
    
    class Program
    {
        static string nomeDoJogo = "CDM Game";

        static void Main(string[] args)
        {
            Console.Title = nomeDoJogo;

            //Iniciar Heroi
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

            Option option = new Option();
            option.Escolhar();

            //-----------------------------------------------
            
            

            
        }
    }
}
