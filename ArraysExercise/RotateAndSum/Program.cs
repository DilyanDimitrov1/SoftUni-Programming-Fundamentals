using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            int numberOfRotations = int.Parse(Console.ReadLine());

            int[] rotatedSum = new int[array.Length];

            for (int a = 0; a < numberOfRotations; a++)
            {
                int[] rotatedArray= new int[array.Length];
                rotatedArray[0] = array[array.Length - 1];

                for (int b = 1; b < array.Length; b++)
                    rotatedArray[b] = array[b - 1];

                for (int b = 0; b < array.Length; b++)
                    rotatedSum[b] += rotatedArray[b];

                array = rotatedArray;
            }
            Console.WriteLine(string.Join(" ", rotatedSum));

        }


    }
}
