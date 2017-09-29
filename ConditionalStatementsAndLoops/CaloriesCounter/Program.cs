using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int x = 1; x <= n; x++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (n > 20 || ingredient.Length < 1 || ingredient.Length > 50)
                {
                    Console.WriteLine("Error");
                }

                if (ingredient == "cheese")
                {
                    calories += 500;
                }
                if (ingredient == "tomato sauce")
                {
                    calories += 150;
                }
                if (ingredient == "salami")
                {
                    calories += 600;
                }

                if (ingredient == "pepper")
                {
                    calories += 50;
                }
                else
                {
                }
            }//for

            Console.WriteLine($"Total calories: {calories}");

        }
    }
}
