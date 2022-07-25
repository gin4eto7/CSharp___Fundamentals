using System;
using System.Collections.Generic;
using System.Linq;

namespace _02GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int count = numers.Count;
            for (int i = 0; i < count / 2; i++)
            {
                numers[i] = numers[i] + numers[numers.Count - 1];

                numers.RemoveAt(numers.Count - 1);
            }

            Console.WriteLine(String.Join(" ", numers));
        }
    }
}
