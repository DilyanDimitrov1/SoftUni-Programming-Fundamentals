using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int counter = 0; 


            int difference = int.Parse(Console.ReadLine());

            foreach (int num in sequence)
            {
                foreach (int numm in sequence)
                {
                    if (num - numm == difference)
                        counter++;
                }//foreach
            }//foreach


            Console.WriteLine(counter);

        }
    }
}
