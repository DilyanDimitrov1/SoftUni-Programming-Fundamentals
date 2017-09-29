using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int healthLost = maxHealth - currentHealth;
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            int energyLost = maxEnergy - currentEnergy;

            if (currentHealth > maxHealth || currentEnergy > maxEnergy)
            {
                Console.WriteLine("How the hell did you do that");
            }

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: |");
            Console.Write(new string('|', currentHealth));
            Console.Write(new string('.', healthLost));
            Console.Write('|');
            Console.WriteLine();

            Console.Write("Energy: |");
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', energyLost));
            Console.Write('|');
            Console.WriteLine();

        }
    }
}
