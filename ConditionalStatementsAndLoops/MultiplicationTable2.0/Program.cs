using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            if (x > 10)
            {
                Console.WriteLine($"{num} X {x} = {num * x}");
            }//if
            else
            {
                for (x = x; x <= 10; x++)
                {

                    Console.WriteLine($"{num} X {x} = {num * x}");
                }
            }//else

        }
    }
}
