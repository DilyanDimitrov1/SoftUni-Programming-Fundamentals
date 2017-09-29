using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int commandNumber = 0;

            while (true)
            {
                if (command != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {command}.");
                    commandNumber += 1;
                    command = Console.ReadLine();

                }
                else
                {
                    break;
                }
            }//while
            Console.WriteLine($"Preparing cake with {commandNumber} ingredients.");

        }
    }
}
