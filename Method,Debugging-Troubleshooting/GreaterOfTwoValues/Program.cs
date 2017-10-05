using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            {
                if (type == "int")
                {
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    var max = GetMax(first, second);
                    Console.WriteLine(max);
                }

                else if(type == "char")
                {
                    char first = char.Parse(Console.ReadLine());
                    char second =char.Parse(Console.ReadLine());
                    var max = GetMax(first, second);
                    Console.WriteLine(max);
                }
                else if(type == "string")
                {
                    string first = Console.ReadLine();
                    string second =Console.ReadLine();
                    var max = GetMax(first, second);
                    Console.WriteLine(max);

                }
            } 
        }

        static int GetMax(int first,int second)
        {
           int max=  Math.Max(first, second);
            return max;
            Console.WriteLine(max);
        }
        static char GetMax(char first, char second)
        {
            char larger = ' ';
            if (first > second)
                larger = first;
            else 
                larger =  second;

            return larger;
        }
        static string GetMax(string first, string second)
        {
            string larger = null;
            if (first.CompareTo(second) >= 0)
                larger = first;
            else
                larger =  second;

            return larger;
        }


    }
}
