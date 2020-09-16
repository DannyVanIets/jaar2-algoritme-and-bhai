using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5
{
    class Program
    {
        static HashSet<int> hashsetEvenGetallen = new HashSet<int>();
        static HashSet<int> hashsetAlle8Getallen = new HashSet<int>();
        static HashSet<int> hashsetAlle7Deelvouden = new HashSet<int>();

        static void Main(string[] args)
        {
            Oefening6();
            Oefening7();
        }

        static public void Oefening6()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    hashsetEvenGetallen.Add(i);
                }

                if (i % 10 == 8 || i >= 80 && i < 90)
                {
                    hashsetAlle8Getallen.Add(i);
                }

                if (i % 7 == 0)
                {
                    hashsetAlle7Deelvouden.Add(i);
                }
            }

            Console.WriteLine($"Aantal even getallen: {hashsetEvenGetallen.Count()}");
            foreach (int i in hashsetEvenGetallen)
            {
                Console.Write($"{i}   ");
            }
            Console.WriteLine();

            Console.WriteLine($"Aantal getallen met 8 erin: {hashsetAlle8Getallen.Count()}");
            foreach (int i in hashsetAlle8Getallen)
            {
                Console.Write($"{i}   ");
            }
            Console.WriteLine();

            Console.WriteLine($"Aantal 7 deelvouden getallen: {hashsetAlle7Deelvouden.Count()}");
            foreach (int i in hashsetAlle7Deelvouden)
            {
                Console.Write($"{i}   ");
            }
            Console.WriteLine();
        }

        static public void Oefening7()
        {
            Console.WriteLine("Getallen die in elke set voorkomen: ");
            foreach (int i in hashsetEvenGetallen)
            {
                if(hashsetAlle8Getallen.Contains(i) && hashsetAlle7Deelvouden.Contains(i))
                {
                    Console.Write($"{i}   ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Even getallen die niet het cijfer 8 erin hebben: ");
            foreach (int i in hashsetEvenGetallen)
            {
                if (!hashsetAlle8Getallen.Contains(i))
                {
                    Console.Write($"{i}   ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Even getallen met 8 erin en/of deelbaar door 7: ");
            foreach (int i in hashsetEvenGetallen)
            {
                if (hashsetAlle8Getallen.Contains(i) || hashsetAlle7Deelvouden.Contains(i))
                {
                    Console.Write($"{i}   ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Deze getallen zitten in geen enkele set: ");
            for (int i = 0; i < 100; i++)
            {
                if(!hashsetEvenGetallen.Contains(i) && !hashsetAlle8Getallen.Contains(i) && !hashsetAlle7Deelvouden.Contains(i))
                {
                    Console.Write($"{i}   ");
                }
            }
            Console.WriteLine();
        }
    }
}
