using System;
using System.Linq;

namespace _07EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOne = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 
            int[] lineTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < lineOne.Length; i++)
            {
                if(lineOne[i] == lineTwo[i])
                {
                    sum += lineOne[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
