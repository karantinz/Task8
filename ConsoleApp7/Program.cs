using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "exit";
            string userInput;

            Console.WriteLine("Вы вошли в систему, чтобы выйти введите exit");

            while (true)
            {
                Console.WriteLine("Ждёте");
                userInput = Convert.ToString(Console.ReadLine());

                if (userInput == exit)
                {
                    Console.WriteLine("Вы вышли");
                    break;
                }
            }
        }
    }
}
