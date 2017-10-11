using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] thisArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = thisArray.Length / 4;

            int[] leftSide = thisArray.Take(k).ToArray();
            int[] middleSide = thisArray.Skip(k).Take(2 * k).ToArray();
            int[] rightSide = thisArray.Skip(3 * k).Take(k).ToArray();


            Array.Reverse(leftSide);
            Array.Reverse(rightSide);

            int[] result = new int[k * 2];

            for (int x = 0; x < k; x++)
            {
                result[x] = middleSide[x] + leftSide[x];

                result[x + k] = middleSide[x + k] + rightSide[x];
            }//for

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
