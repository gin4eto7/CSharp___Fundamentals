using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
                
            Dictionary<char, int> sort = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if(symbol == ' ')
                {
                    continue;
                }

                if(sort.ContainsKey(symbol))
                {
                    sort[symbol]++;
                }
                else
                {
                    sort.Add(symbol, 1);
                }
            }

            foreach (var item in sort)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
