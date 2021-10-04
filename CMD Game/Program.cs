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

                //Inserindo BOSS
                Boss boss = new Boss();
                boss.Nome = "B";

                //-----------------------------------------------

                //Inserindo Monsros
                Monster m1 = new Monster();
                Monster m2 = new Monster();
                Monster m3 = new Monster();
                Monster m4 = new Monster();
                Monster m5 = new Monster();
                Monster m6 = new Monster();

                m1.Nome = "M";
                m2.Nome = "M";
                m3.Nome = "M";
                m4.Nome = "M";
                m5.Nome = "M";
                m6.Nome = "M";

                //-------------------------------------------------

                //Inserindo Poções
                Pocao p1 = new Pocao();
                Pocao p2 = new Pocao();
                Pocao p3 = new Pocao();
                Pocao p4 = new Pocao();
                Pocao p5 = new Pocao();
                Pocao p6 = new Pocao();
                Pocao p7 = new Pocao();
                Pocao p8 = new Pocao();

                p1.Nome = "P";
                p2.Nome = "P";
                p3.Nome = "P";
                p4.Nome = "P";
                p5.Nome = "P";
                p6.Nome = "P";
                p7.Nome = "P";
                p8.Nome = "P";

                //--------------------------------------------------

                //Inserindo Weapon

                Weapon w = new Weapon();

                w.Nome = "W";
                

                //--------------------------------------------------
            }
        }
    }
}
