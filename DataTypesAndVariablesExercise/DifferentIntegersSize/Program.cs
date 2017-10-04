using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();

            try
            {
                long num = long.Parse(N);
                sbyte sbyteMax = sbyte.MaxValue;
                sbyte sbyteMin = sbyte.MinValue;

                byte byteMax = byte.MaxValue;
                byte byteMin = byte.MinValue;

                short shortMin = short.MinValue;
                short shortMax = short.MaxValue;

                ushort ushortMax = ushort.MaxValue;
                ushort ushortMin = ushort.MinValue;

                int intMax = int.MaxValue;
                int intMin = int.MinValue;

                uint uintMax = uint.MaxValue;
                uint uintMin = uint.MinValue;

                long longMax = long.MaxValue;
                long longMin = long.MinValue;

                Console.WriteLine($"{num} can fit in:");

                if(sbyteMin <= num && num <= sbyteMax)
                {
                    Console.WriteLine("* sbyte");
                }
                if (byteMin <= num && num <= byteMax)
                {
                    Console.WriteLine("* byte");
                }
                if (shortMin <= num && num <= shortMax)
                {
                    Console.WriteLine("* short");
                }

                if (ushortMin <= num && num <= ushortMax)
                {
                    Console.WriteLine("* ushort");
                }
                if (intMin <= num && num <= intMax)
                {
                    Console.WriteLine("* int");
                }
                if (uintMin <= num && num <= uintMax)
                {
                    Console.WriteLine("* uint");
                }
                if (longMin <= num && num <= longMax)
                {
                    Console.WriteLine("* long");
                }
            }
            catch
            {
                Console.WriteLine($"{N} can't fit in any type ");
            }
        }
    }
}





