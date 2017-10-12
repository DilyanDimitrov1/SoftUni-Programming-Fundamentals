using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool notFound = true;
            for (int a = 0; a < input.Length; a++)
            {
                for (int b = a + 1; b < input.Length; b++)
                {
                    int sum = input[a] + input[b];
                    if (input.Contains(sum))
                    {
                        Console.WriteLine($"{input[a]} + {input[b]} == {sum}");
                        if (notFound)
                            notFound = false;
                    }
                }
            }
            if (notFound)
                Console.WriteLine("No");




        }
    }
}
