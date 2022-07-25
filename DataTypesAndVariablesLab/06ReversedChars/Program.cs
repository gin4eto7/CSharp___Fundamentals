using System;
using System.Collections;

namespace _06ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 3;

            Stack queue = new Stack();

            for (int i = 0; i < count; i++)
            {
                char input = char.Parse(Console.ReadLine());

                queue.Push(input);
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write(queue.Peek() + " ");
                queue.Pop();
            }
        }
    }
}
