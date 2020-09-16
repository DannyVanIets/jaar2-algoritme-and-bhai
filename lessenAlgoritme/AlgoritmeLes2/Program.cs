using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeLes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 50;
            int min = maxNumber;
            int minJustBarely = maxNumber;

            int aantal = 0;
            int aantalBarely = 0;
            int optellen = 1;

            int[] numbers = new int[maxNumber];
            Random rnd = new Random();

            for (int i = 0; i < maxNumber; i++)
            {
                int j = rnd.Next(1, 100);
                numbers[i] = j;
            }

            foreach(int i in numbers)
            {
                Console.WriteLine($"{i} plaats: {optellen}");

                if (i == min)
                {
                    aantal++;
                }
                else if (i < min)
                {
                    aantalBarely = aantal;
                    aantal = 1;
                    min = i;
                }

                if(i < minJustBarely && i != min)
                {
                    minJustBarely = i;
                }
                else if (minJustBarely == i)
                {
                    aantalBarely++;
                }
                optellen++;
            }
            Console.WriteLine($"Kleinste getal {min} en komt {aantal} keer voor.");
            Console.WriteLine($"Kleinste getal {minJustBarely} en komt {aantalBarely} keer voor.");
        }
    }
}
