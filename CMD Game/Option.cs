using System;

namespace CMD_Game
{
    public class Option
    {

        /*Fiz essa porque as coisas escrita nessa parte podem mudar
         * dependendo das ações executadas*/
        public void Escolhar()
        {
            //Tem uma forma de faça o espaçamento de outro jeito
            //Existe uma maneira de relacionar cada comando desse com um número
            Console.Write("[A] to move left.    ");
            Console.WriteLine("[D] to move right.");
            Console.Write("[W] to move up.      ");
            Console.WriteLine("[S] to move down.");
            Console.WriteLine("[SPACE] to attack");
        }
    }
}