using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"..\..\namen.txt");
            Dictionary<int, string> dict = new Dictionary<int, string>();

            foreach (string line in lines)
            {
                string[] splitnamen = line.Split();
                int key = Int32.Parse(splitnamen[1]);
                string value = splitnamen[0];

                try
                {
                    if (dict.ContainsKey(key))
                    {
                        Console.WriteLine($"De key {splitnamen[1]} (value: {value}) bestaat al!");
                    }
                    else
                    {
                        dict.Add(key, value);
                    }
                }
                catch (ArgumentException)
                {
                    dict[key] = splitnamen[1] + 1;
                }
            }

            Console.WriteLine($"Er zijn {dict.Count} namen!");

            for(int i = 1450; i <= 1470; i++)
            {
                if(dict.ContainsKey(i))
                {
                    dict.Remove(i);
                }
            }

            Console.WriteLine($"Er zijn {dict.Count} namen!");

            //Dit onderste gedeelte was extra en heb ik niet zelf gemaakt.
            Dictionary<string, int> naamDict = new Dictionary<string, int>();
            foreach(KeyValuePair<int, string> kvp in dict)
            {
                string naam = kvp.Value;
                if(naamDict.ContainsKey(naam))
                {
                    naamDict[naam]++;
                } else
                {
                    naamDict.Add(naam, 1);
                }
            }
            Console.WriteLine($"Aantal unieke namen: {naamDict.Count}");
        }
    }
}
