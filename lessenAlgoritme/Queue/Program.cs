using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = Console.ReadLine();
            Queue(tekst);
            QueueOneStack(tekst);
            QueueStacks(tekst);
        }

        static void Queue(string txt)
        {
            Queue<char> queue1 = new Queue<char>();
            Queue<char> queue2 = new Queue<char>();

            foreach(char ch in txt)
            {
                queue1.Enqueue(ch);
            }

            while (queue1.Count > 0)
            {
                queue2.Enqueue(queue1.Dequeue());
            }
            Console.Write("Met alleen queue's: ");
            while (queue2.Count > 0)
            {
                Console.Write(queue2.Dequeue());
            }
            Console.WriteLine();
        }

        static void QueueOneStack(string txt)
        {
            Stack<char> queue1 = new Stack<char>();
            Queue<char> queue2 = new Queue<char>();

            foreach (char ch in txt)
            {
                queue1.Push(ch);
            }

            while (queue1.Count > 0)
            {
                queue2.Enqueue(queue1.Pop());
            }
            Console.Write("Met een queue en een stack: ");
            while (queue2.Count > 0)
            {
                Console.Write(queue2.Dequeue());
            }
            Console.WriteLine();
        }

        static void QueueStacks(string txt)
        {
            Stack<char> queue1 = new Stack<char>();
            Stack<char> queue2 = new Stack<char>();

            foreach (char ch in txt)
            {
                queue1.Push(ch);
            }

            while (queue1.Count > 0)
            {
                queue2.Push(queue1.Pop());
            }
            Console.Write("Met alleen stacks: ");
            while (queue2.Count > 0)
            {
                Console.Write(queue2.Pop());
            }
            Console.WriteLine();
        }
    }
}
