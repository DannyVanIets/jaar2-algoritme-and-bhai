using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeLes5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 6
            HashSet<int> SetA = new HashSet<int>();
            HashSet<int> SetB = new HashSet<int>();
            HashSet<int> SetC = new HashSet<int>();
            //SetA.Add(); Element toewijzen
            //SetA.Contains(); element aanwezig

            //SetA.IntersectWith(); doorsnede/intersect
            //SetA.UnionWith(); vereniging
            //SetA.ExceptWith(); verschil

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    SetA.Add(i);
                }

                if (i % 10 == 8)
                {
                    SetB.Add(i);
                }

                if (i % 7 == 0)
                {
                    SetC.Add(i);
                }
            }

            Console.WriteLine($"Opdracht 1");
            for (int i = 0; i <= 100; i++)
            {
                if (SetA.Contains(i))
                {
                    Console.Write($"{i}     ");
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Opdracht 2");
            for (int i = 0; i <= 100; i++)
            {
                if (SetB.Contains(i))
                {
                    Console.Write($"{i}     ");
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Opdracht 3");
            for (int i = 0; i <= 100; i++)
            {
                if (SetC.Contains(i))
                {
                    Console.Write($"{i}     ");
                }
            }
            Console.WriteLine($"");

            Console.WriteLine($"Oefening 7");
            Console.WriteLine($"Opdracht 1");

            HashSet<int> SetD = new HashSet<int>(SetA);

            SetD.IntersectWith(SetB);
            SetD.IntersectWith(SetC);

            foreach (int i in SetD)
            {
                Console.Write($"{i}     ");
            }
            Console.WriteLine();

            Console.WriteLine($"Opdracht 2");
            foreach (int i in SetA)
            {
                if (i % 10 != 8)
                {
                    Console.Write($"{i}     ");
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Opdracht 3");
            SetB.UnionWith(SetC);
            foreach (int i in SetB)
            {
                Console.Write($"{i}     ");
            }
            Console.WriteLine();

            Console.WriteLine($"Opdracht 4");
            HashSet<int> SetE = new HashSet<int>();
            for (int i = 0; i <= 100; i++)
            {
                SetE.Add(i);
                SetE.ExceptWith(SetA);
                SetE.ExceptWith(SetB);
                SetE.ExceptWith(SetC);
            }

            foreach (int i in SetE)
            {
                Console.Write($"{i}     ");
            }
            Console.WriteLine();
        }
    }
}
