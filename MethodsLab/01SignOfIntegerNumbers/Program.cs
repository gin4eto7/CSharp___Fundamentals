using System;

namespace _01SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintResult(num);
        }

        private static void PrintResult (int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if(num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if(num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
