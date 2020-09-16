using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenenAlgoritme
{
    class Program
    {
        static void Main(string[] args)
        {
            //oefening2();
            //opgave4();
            //opgave5();
            opgave6();
        }

        static public void opgave6()
        {
            List<int> lijst = new List<int>();

            Console.WriteLine("Lijst voor verwijdering: ");
            for (int i = 0; i < 21; i++)
            {
                lijst.Add(i);
                Console.Write($"{i}   ");
            }

            Console.WriteLine();
            Console.WriteLine("Lijst na verwijdering van de even posities getallen: ");
            for (int i = 0; i < lijst.Count() - 1; i++)
            {
                if(lijst[i] % 2 == 0)
                {
                    lijst.RemoveAt(i);
                }
                Console.Write($"{lijst[i]}   ");
            }
            Console.WriteLine();
        }

        static public void opgave5()
        {
            List<int> lijst = new List<int>();

            Console.Write("Voer een getal in: ");
            string regel = Console.ReadLine();
            int getal = int.Parse(regel);

            while (getal != 0)
            {
                if (getal > 0)
                {
                    for (int i = 0; i < getal; i++)
                    {
                        lijst.Add(getal);
                    }
                    Console.WriteLine($"Getal {getal} is {getal} aantal keer toegevoegd!");
                }
                else if (getal < 0)
                {
                    for (int i = 0; i > getal; i--)
                    {
                        lijst.RemoveAt(lijst.Count() - 1);
                    }
                    Console.WriteLine($"De laatste {getal} getallen zijn weggehaald.");
                }

                Console.Write("Voer een getal in: ");
                regel = Console.ReadLine();
                getal = int.Parse(regel);
            }

            Console.WriteLine();
            foreach (int i in lijst)
            {
                Console.Write($"{i}   ");
            }

            Console.WriteLine();
            Console.WriteLine($"In totaal zijn er {lijst.Count()} getallen.");
            Console.WriteLine($"De laatste waarde is: {lijst[lijst.Count() - 1]}.");
        }

        static public void opgave4()
        {
            List<int> lijst = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                lijst.Add(i);
            }

            double som = 0;

            foreach (int num in lijst)
            {
                som += num;
            }

            Console.WriteLine($"Gemiddelde is {som / lijst.Count}");

            for (int index = 9; index >= 0; index--)
            {
                Console.Write($" {lijst[index]} ");
            }
        }

        static public void oefening2()
        {
            Random random = new Random();
            int maxAantal = 60;
            int grootsteGetal = 0;
            int[] postieveGetallen = new int[maxAantal];

            for (int i = 0; i < maxAantal; i++)
            {
                postieveGetallen[i] = random.Next(0, 100);
            }

            foreach (int i in postieveGetallen)
            {
                Console.WriteLine(i);
                if (i > grootsteGetal)
                {
                    grootsteGetal = i;
                }
            }

            Console.WriteLine($"Grootste getal: {grootsteGetal}");
        }
    }
}
