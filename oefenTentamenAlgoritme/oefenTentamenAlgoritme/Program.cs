using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenTentamenAlgoritme
{
    class Program
    {
        static void Main(string[] args)
        {
            Opgave1();
            Opgave2();
        }

        static public void Opgave1()
        {
            Random random = new Random();
            int[] getallen = new int[200];

            for (int i = 0; i < 200; i++)
            {
                getallen[i] = random.Next(0, 2);
            }

            int x = 0;
            foreach (int getal in getallen)
            {
                if (x < getallen.Length / 2 + 1 && getal == 1)
                {
                    getallen[x] = 0;
                }
                else if (x > getallen.Length / 2 && getal == 0)
                {
                    getallen[x] = 1;
                }
                Console.WriteLine(getallen[x]);
                x++;
            }
        }

        static public void Opgave2()
        {
            Random random2 = new Random();
            int[] getallen2 = new int[61];
            int grootsteGetal = 0;
            int grootsteGetalPositie = 0;

            for (int i = 0; i < 61; i++)
            {
                int randomGetal = random2.Next(41, 100);
                getallen2[i] = randomGetal;

                if (randomGetal > grootsteGetal)
                {
                    grootsteGetal = randomGetal;
                    grootsteGetalPositie = i;
                }
                Console.WriteLine($"Waarde {getallen2[i]} en positie {i}");
            }

            Console.WriteLine($"Grootste getal is {grootsteGetal} en de positie is {grootsteGetalPositie}");
        }
    }
}
