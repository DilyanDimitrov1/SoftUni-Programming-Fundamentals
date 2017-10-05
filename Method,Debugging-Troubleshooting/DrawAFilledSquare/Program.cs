using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FrameRow(n);
            MiddleRow(n);
            FrameRow(n);

        }

        static void FrameRow(int length)
        {
            Console.WriteLine(new string('-', length * 2));
        }

        static void MiddleRow(int length)
        {
            for (int i = 0; i < length - 2; i++)
            {
                Console.Write('-');
                for (int j = 1; j < length; j++)
                {
                    Console.Write("\\/");
                }
                Console.Write('-');
                Console.WriteLine();
            }
        }
    }
}
