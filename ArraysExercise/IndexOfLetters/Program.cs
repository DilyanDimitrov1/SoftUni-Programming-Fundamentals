using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z'
            };

            string input = Console.ReadLine();

            for (int x = 0; x < input.Length; x++)
            {
                for (int y = 0; y < alphabet.Length; y++)
                {
                    if(input[x].ToString().Contains(alphabet[y]))
                        Console.WriteLine($"{input[x]} -> {x}");
                }
            }

        }
    }
}
