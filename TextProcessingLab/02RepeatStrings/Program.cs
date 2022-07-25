using System;

namespace _02RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            
            for (int i = 0; i < words.Length; i++)
            {
                int count = words[i].Length;
                for (int j = 0; j < count; j++)
                {
                    Console.Write(words[i]);
                }
            }
        }
    }
}
