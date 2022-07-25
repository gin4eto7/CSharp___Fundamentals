using System;
using System.Linq;

namespace _06EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    oddSum += numbers[i];
                }
                else
                {
                    evenSum += numbers[i];
                }
            }

            int totalSum = oddSum - evenSum;

            Console.WriteLine(totalSum);
        }
    }
}
