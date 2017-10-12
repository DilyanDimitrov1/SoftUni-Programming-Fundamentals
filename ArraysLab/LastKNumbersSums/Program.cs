using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
           int k = int.Parse(Console.ReadLine());

            long [] arr = new long[n];
            arr[0] = 1;
                 
            for (int x = 1; x < n; x++)
            {
                long sum = 0;
                for (int y = x - 1; y >= 0 && y >= x - k; y--)
                {
                    sum += arr[y];
                }
                arr[x] = sum;
            }
            Console.WriteLine(String.Join(" ", arr));
            
        }
    }
}
