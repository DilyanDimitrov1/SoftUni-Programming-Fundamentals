using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        private static int GetMax(int a, int b, int c)
        {
            int max = 0;
            if (a > b && a > c)
                max = a;
            else if (b > a && b > c)
                max = b;
            else
                max = c;

            return max;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = GetMax(a, b, c);
            Console.WriteLine(max);


        }
    }
}
