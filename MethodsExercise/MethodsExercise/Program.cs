﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    class Program
    {
        private static string Greeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return name;
        }
        
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Greeting(name);

        }
    }
}
