using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> thisList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                switch (input[0])
                {
                    case "Delete":
                       for (int x = 0; x < thisList.Count; x++)
                       {
                           if(thisList[x] == int.Parse(input[1]));
                           thisList.Remove(int.Parse(input[1]));


                       }

                        break;

                    case "Insert":
                        thisList.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        break;
                    case "Odd":
                        foreach (int num in thisList)
                        {
                            if (num % 2 != 0)
                                Console.Write($"{num} ");
                        }
                        return;

                    case "Even":
                        foreach (int num in thisList)
                        {
                            if (num % 2 == 0)
                                Console.Write($"{num} ");


                        }
                        return;
                }//switch

            }//while

        }
    }
}
