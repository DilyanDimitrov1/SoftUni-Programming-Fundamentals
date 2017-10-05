using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {

        private static int GetEvensAndOdds(int n)
        {
            int SumOdds = GetSumOfOdds(n);
            int sumEvens = GetSumOfEvens(n);

            return sumEvens * SumOdds;

        }
        private static int GetSumOfEvens(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                    sum += lastDigit;

                n /= 10; 
            }//while
            return sum; 

        }//sum of evens 
        private static int GetSumOfOdds(int n)
        {
            int sum = 0; 
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                    sum += lastDigit;

                n /= 10; 
            }//while
            return sum; 

        }//sum of odds

        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            int EvensAndOdds = GetEvensAndOdds(n);
            Console.WriteLine(EvensAndOdds);


        }


    }
}
