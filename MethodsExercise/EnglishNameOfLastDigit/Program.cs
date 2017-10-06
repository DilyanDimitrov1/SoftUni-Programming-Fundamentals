using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfLastDigit
{
    class Program
    {


       

        static void Main(string[] args)
        {
            long digit = long.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigit(Math.Abs(digit)));

        }


        static string GetLastDigit(long digit)
        {
            long lastDigit = digit % 10;
            string numberName = null;

            if (lastDigit == 1)
                numberName = "one";
            else if (lastDigit == 2)
                numberName = "two";
            else if (lastDigit == 3)
                numberName = "three";
            else if (lastDigit == 4)
                numberName = "four";
            else if (lastDigit == 5)
                numberName = "five";
            else if (lastDigit == 6)
                numberName = "six";
            else if (lastDigit == 7)
                numberName = "seven";
            else if (lastDigit == 8)
                numberName = "eight";
            else if (lastDigit == 9)
                numberName = "nine";
            else if (lastDigit == 0)
                numberName = "zero";


            return numberName;
        }
    }
}
