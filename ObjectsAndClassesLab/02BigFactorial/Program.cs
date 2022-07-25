using System;
using System.Numerics;

namespace _02BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            BigFactor.PrintBigFactorial(num);
        }
    }

    public class BigFactor
    {
        public static void PrintBigFactorial(int num)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;

            }

            Console.WriteLine(sum);
        }
    }
}

