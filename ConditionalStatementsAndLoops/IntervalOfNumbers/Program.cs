using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int smaller = Math.Min(num1, num2);
            int larger = Math.Max(num1, num2);

            for (int x = smaller; x <= larger; x++)
            {
                Console.WriteLine(x);
            }

        }
    }
}
