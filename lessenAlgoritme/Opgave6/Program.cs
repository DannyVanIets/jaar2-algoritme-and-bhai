using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Geen if statement
            List<int> lijst = new List<int>();
            lijst.Add(1);
            lijst.Add(2);
            lijst.Add(3);
            lijst.Add(4);
            lijst.Add(5);
            lijst.Add(6);
            lijst.Add(7);
            lijst.Add(8);
            lijst.Add(9);
            lijst.Add(10);
            lijst.Add(11);
            lijst.Add(12);
            lijst.Add(13);
            lijst.Add(14);
            lijst.Add(15);
            lijst.Add(16);
            lijst.Add(17);
            lijst.Add(18);
            lijst.Add(19);
            int index = -2;

            Console.WriteLine("De lijst is: ");

            foreach (int d in lijst)
            {
                Console.Write($"{d} ");
                index++;
            }

            for (int i = index / 2; i > 0; i--)
            {
                lijst.RemoveAt(index);
                index = index - 2;
            }

            Console.WriteLine("De lijst is: ");

            foreach(int d in lijst)
            {
                Console.Write($"{d} ");
            }
            
            /*for (int i = index / 2; i > 0; i--)
            {
                lijst.RemoveAt(index);
                index = index - 2;
            }

            Console.WriteLine("\nDe lijst is nu: ");

            foreach (int d in lijst)
            {
                Console.Write($"{d} ");
            }*/
        }
    }
}
