using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(input, 2).ToUpper();
            string hexadecimal = Convert.ToString(input, 16).ToUpper();

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);

        }
    }
}
