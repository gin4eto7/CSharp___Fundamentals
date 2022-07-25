using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringNumbers = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            List<int> numbers = new List<int>();
            foreach (var item in stringNumbers)
            {
                numbers.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
