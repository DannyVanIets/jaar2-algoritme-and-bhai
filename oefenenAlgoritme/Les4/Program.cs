using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Oefening1(Console.ReadLine()));
            Oefening3();
        }

        static public void Oefening3()
        {
            string[] lines = System.IO.File.ReadAllLines(@"..\..\namen.txt");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            foreach (string values in lines)
            {
                string[] split = values.Split();
                int key = Int32.Parse(split[1]);
                string naam = split[0];

                try
                {
                    if (dictionary.ContainsKey(key))
                    {
                        Console.WriteLine($"De key {key} met de naam {naam} bestaat al!");
                    }
                    else
                    {
                        dictionary.Add(key, naam);
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Argument Exception error!");
                }
            }

            Console.WriteLine($"Dictionary bestaat uit {dictionary.Count()}");

            for(int i = 1450; i <= 1470; i++)
            {
                if (dictionary.ContainsKey(i))
                {
                    dictionary.Remove(i);
                }
            }

            Console.WriteLine($"Dictionary bestaat nu uit {dictionary.Count()}");
        }

        static string Oefening1(string ingevoerdeTekst)
        {
            Stack<char> stack = new Stack<char>();

            if (ingevoerdeTekst.Length != 0)
            {
                foreach (char ch in ingevoerdeTekst)
                {
                    if (ch == '(')
                    {
                        stack.Push(ch);
                    }
                    else if (ch == ')' & stack.Count == 0)
                    {
                        return "Er is een ) te veel!";
                    }
                    else if (ch == ')')
                    {
                        stack.Pop();
                    }
                }
                return "Alles in orde!";
            }
            return "Er is niks ingevoerd!";
        }
    }
}
