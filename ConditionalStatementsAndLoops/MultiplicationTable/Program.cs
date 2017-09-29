using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine($"{num} X {x} = {num * x}");
            }
        }
    }
}
