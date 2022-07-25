using System;
using System.Collections.Generic;

namespace _02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            

            Dictionary<string, int> dicWords = new Dictionary<string, int>();

            foreach (var item in words)
            {

                string lowerCase = item.ToLower();
                if (!dicWords.ContainsKey(lowerCase))
                {
                    dicWords.Add(lowerCase, 1);
                }
                else
                {
                    dicWords[lowerCase]++;
                }
            }

            foreach (var item in dicWords)
            {
                if(item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
