using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuiswerkAlgoritmeLes1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht 2 Math.Floor
            double d1 = 86.45;
            double d2 = -34.90;

            Console.WriteLine(Math.Truncate(d1));
            Console.WriteLine(Math.Truncate(d2));

            Console.WriteLine(Math.Floor(d1));
            Console.WriteLine(Math.Floor(d2));
        }
    }
}
