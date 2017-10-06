using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            GetPrimes(num1, num2);
       
        }
        static void GetPrimes(int num1, int num2)
        {
            if (num1 < 2)
            {
                num1 = 2;
            }
            bool firstPrime = true; 
            for(int isPrime = num1; isPrime <= num2; isPrime++)
            {
                bool Prime = true; 
                for(int numinside = 2; numinside <= Math.Sqrt(isPrime); numinside++)
                {
                    if(isPrime % numinside == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
                if(Prime == true && firstPrime == true)
                {
                    Console.Write(isPrime);
                    firstPrime = false;
                }
                else if (Prime)
                {
                    Console.Write(", ");
                    Console.Write(isPrime);
                }

            }
            Console.WriteLine();
        }//GetPrimes- returns all primes within given range 


    }
}
