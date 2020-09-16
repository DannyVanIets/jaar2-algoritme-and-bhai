using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer een getal in: ");
            string regel = Console.ReadLine();
            int getal = int.Parse(regel);
            Console.WriteLine();

            List<int> lijst = new List<int>();
            int aantal = 0;
            int index = -1;

            while (getal != 0)
            {
                if (getal > 0)
                {
                    for (int i = 0; i < getal; i++)
                    {
                        lijst.Add(getal);
                        aantal++;
                        index++;
                    }
                    Console.WriteLine($"Getal {getal} is {aantal} keer toegevoegd! Max index is {index}");
                    aantal = 0;
                }
                else if (getal < 0)
                {
                    for (int i = 0; i > getal; i--)
                    {
                        lijst.RemoveAt(index);
                        aantal++;
                        index--;
                    }
                    Console.WriteLine($"De laatste {aantal} getallen zijn verwijderd!");
                    aantal = 0;
                }
                Console.Write("Voer een getal in: ");
                regel = Console.ReadLine();
                getal = int.Parse(regel);
            }

            Console.WriteLine($"Applicatie stopt ermee! Laatste getal is {lijst[index]} " +
                $"en het aantal elementen is {index + 1}! Hieronder zit u alle toegevoegde elementen:");

            foreach (int d in lijst)
            {
                Console.Write($"{d} ");
            }
            Console.WriteLine();
        }
    }
}
