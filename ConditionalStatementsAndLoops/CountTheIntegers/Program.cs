﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;


            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());
                    counter += 1;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);
            }

        }
    }
}
