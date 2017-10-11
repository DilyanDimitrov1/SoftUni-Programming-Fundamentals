using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] secondArray = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int leftCounter = FindMaxCommons(firstArray, secondArray);

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            int rightCounter = FindMaxCommons(firstArray, secondArray);

            Console.WriteLine(Math.Max(leftCounter, rightCounter));


        }

        static int FindMaxCommons(string[] firstArray, string[] secondArray)
        {
            int length = Math.Min(firstArray.Length, secondArray.Length);
            int counter = 0;

            for (int x = 0; x < length; x++)
            {
                if (firstArray[x] == secondArray[x])
                    counter++;

                else
                {
                    break;
                }
            }//for

            return counter;



        }
    }
}
