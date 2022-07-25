using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();

            foreach (var item in numbers)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1);
                }
                else
                {
                    dic[item] += 1;
                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
