using System;
using System.Collections.Generic;
using System.Linq;

namespace _05RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nubers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int count = nubers.Count;

            for (int i = 0; i < count; i++)
            {
               
                    nubers.RemoveAll(n => n < 0);
                
            }

            nubers.Reverse();
            if(nubers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", nubers));
            }

            
        }
    }
}
