using System;

namespace CMD_Game
{
    
    class Program
    {
        static string nomeDoJogo = "CDM Game";

        static void Main(string[] args)
        {
            Console.Title = nomeDoJogo;

            //Iniciar grid
            Grid grid = new Grid();           
            grid.Preencher();

            Option option = new Option();
            option.Escolhar();

            //-----------------------------------------------
            
            //Iniciar Heroi
            Heroi h = new Heroi();

            
        }
    }
}
