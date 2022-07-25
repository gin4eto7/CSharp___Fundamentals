using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTopInt(num);
        }
        static bool IfDivisibleBy8 (int num)
        {
            int digitSum = 0;
            while (num > 0)
            {
                digitSum += num % 10;
                num /= 10;
            }
            if(digitSum % 8 == 0)
            {
                return true;
            }
            return false;
        }

        static bool IfOddDigit(int num)
        {
            while (num > 0)
            {
                if ((num % 10) % 2 == 1)
                {
                    return true;
                }
                num /= 10;
            }

            return false;
        }

        static void PrintTopInt (int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (IfDivisibleBy8(i) && IfOddDigit(i))
                    Console.WriteLine(i);
            }
        }
    }
}
