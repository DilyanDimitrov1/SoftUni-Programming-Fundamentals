using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            int matchCounter = 0;

            for (int x = M; x >= N; x--)
            {
                for (int y = M; y >= N; y--)
                {
                    sum = x + y;
                    counter++;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Number found! {x} + {y} = {magicNum}");
                        matchCounter++;
                        return;
                    }

                }//for
            }//for 
            if (matchCounter == 0)
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");

        }
    }
}
