using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeLes3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;

            if ((x & 1) == 0)
            {
                Console.WriteLine("Getal is even");
            }
            else
            {
                Console.WriteLine("Getal is oneven");
            }

            if ((x & 0x80000000) == 0)
            {
                Console.WriteLine("Getal is positief");
            }
            else
            {
                Console.WriteLine("Getal is negatief");
            }

            char y = 'H';
            y = (char)(y | 32);
            Console.WriteLine(y); //Wordt een kleine letter

            y = (char)(y & ~32);
            Console.WriteLine(y); // Wordt weer een hoofdletter

            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            bool maakHoofdLetter = true;

            char b;
            char spatie = ' ';

            for (int i = 0; chars.Length > i; i++)
            {
                if (i == 0)
                {
                    chars[i] = (char)(chars[i] & ~32);
                }

                if (chars[i] == spatie)
                {
                    maakHoofdLetter = true;

                }
                else if (maakHoofdLetter)
                {
                    if (chars[i] >= 'a' && chars[i] <= 'z')
                    {
                        chars[i] = (char)(chars[i] & ~32);
                        maakHoofdLetter = false;
                    }
                }
            }

            Console.Write(chars);
            Console.WriteLine();

            for (int i = 0; chars.Length > i; i++)
            {
                if (i == 0)
                {
                    chars[i] = (char)(chars[i] | 32);
                }
                else if (chars[i] == spatie)
                {
                    i++;
                    chars[i] = (char)(chars[i] | 32);
                }
                else
                {
                    chars[i] = (char)(chars[i] & ~32);
                }
            }

            Console.Write(chars);
            Console.WriteLine();
        }
    }
}
