using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            SmallestOfThreeNumbers(num1, num2, num3);
        }

        static void SmallestOfThreeNumbers (int num1, int num2, int num3)
        {
            int smallestNum = Math.Min(Math.Min(num1, num2),num3);
            Console.WriteLine(smallestNum);
        }
    }
}
