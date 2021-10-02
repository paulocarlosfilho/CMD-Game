using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_Game
{
    public class Heroi
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Score { get; set; }
        public int Damage { get; set; }

        public void AparecerHeroi()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"{Nome} HP: {Vida} {Nome} Demage: {Damage} {Nome} Score: {Score}");
            Console.WriteLine("=========================================");
        }

        public void mover()
        {

        }
    }
}
