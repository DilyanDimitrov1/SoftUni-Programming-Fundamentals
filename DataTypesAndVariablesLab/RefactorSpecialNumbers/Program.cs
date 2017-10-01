using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool magicNum = false;
            int sum = 0;
            for (int x = 1; x <= n; x++)
            {
                while (x > 0)
                {
                     sum += x % 10;
                     x = x / 10;
                }//while
                magicNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{x} -> {magicNum}");
            }//for

        }
    }
}
