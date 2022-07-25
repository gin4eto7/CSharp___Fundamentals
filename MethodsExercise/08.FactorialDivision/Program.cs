using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{CalculateFirstFactorial(num1) / CalculateSecondFactorial(num2):f2}");
            
            


        }

        static double CalculateFirstFactorial (double num1)
        {
            double factorialFirst = 1;
            for (int i = 1; i <= num1; i++)
            {
                factorialFirst *= i;
            }
            return factorialFirst;
            
        }

        static double CalculateSecondFactorial(double num2)
        {
            double factorialSecond = 1;
            for (int i = 1; i <= num2; i++)
            {
                factorialSecond *= i;
            }
            return factorialSecond;
        }

    }
}
