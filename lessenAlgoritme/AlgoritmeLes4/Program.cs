using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeLes4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "-----";
            Console.WriteLine($"{text}{ Haakjes(text)}");
        }

        static string Haakjes(string txt)
        {
            if(txt.Length == 0)
            {
                return "Er staat niks in de meegegeven string!";
            }

            Stack<char> stack = new Stack<char>();
            foreach (char ch in txt)
            {
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' && stack.Count == 0)
                {
                    return " Er is een ) te veel!";
                }
                else if (ch == ')')
                {
                    stack.Pop();
                }
            }

            if (stack.Count > 0)
            {
                return " De stack heeft te veel ( !";
            }

            return " Alles is goed met deze!";
        }
    }
}
