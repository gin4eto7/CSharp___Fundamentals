using System;

namespace _05._AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            SumTheNumbers(num1, num2, num3);
            
        }

        static void SumTheNumbers (int num1, int num2, int num3)
        {
            int sum = num1 + num2;
            SubtractTheNumbers(sum, num3);
        }

        static void SubtractTheNumbers (int sum, int num3)
        {
            int subSum = sum - num3;
            Console.WriteLine(subSum);
        }
    }
}
