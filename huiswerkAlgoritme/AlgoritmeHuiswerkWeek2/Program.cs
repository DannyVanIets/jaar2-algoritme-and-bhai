using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeHuiswerkWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowestNumber = 999;
            int i = 0;
            int j = 0;
            string vanuit = "Onbekend";
            string naar = "Onbekend";

            int[,] reistijden = new int[6, 6] { { 0, 50, 135, 120, 65, 65 },
                                                { 50, 0, 140, 75, 20, 70 },
                                                { 135, 140, 0, 220, 170, 75 },
                                                { 120, 75, 220, 0, 55, 145 },
                                                { 65, 20, 170, 55, 0, 90 },
                                                { 65, 70, 75, 145, 90, 0 } };
            
            while (i < 6 && j < 6)
            {
                if (reistijden[j, i] < lowestNumber && reistijden[j, i] != 0)
                {
                    lowestNumber = reistijden[j, i];

                    if (i == 0)
                    {
                        naar = "Arnhem";
                    }
                    else if (i == 1)
                    {
                        naar = "Amersfoort";
                    }
                    else if (i == 2)
                    {
                        naar = "Assen";
                    }
                    else if (i == 3)
                    {
                        naar = "Rotterdam";
                    }
                    else if (i == 4)
                    {
                        naar = "Utrecht";
                    }
                    else if (i == 5)
                    {
                        naar = "Zwolle";
                    }
                }

                i++;

                if (i >= 6)
                {
                    if (j == 0)
                    {
                        vanuit = "Arnhem";
                    }
                    else if (j == 1)
                    {
                        vanuit = "Amersfoort";
                    }
                    else if (j == 2)
                    {
                        vanuit = "Assen";
                    }
                    else if (j == 3)
                    {
                        vanuit = "Rotterdam";
                    }
                    else if (j == 4)
                    {
                        vanuit = "Utrecht";
                    }
                    else if (j == 5)
                    {
                        vanuit = "Zwolle";
                    }
                    Console.WriteLine($"De kortste reistijd is {lowestNumber}km vanuit {vanuit} naar {naar}.");

                    j++;
                    i = 0;
                    lowestNumber = 999;
                }
            }
        }
    }
}
