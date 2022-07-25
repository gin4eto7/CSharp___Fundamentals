using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digit = 0;
            string numbers = num.ToString();
            for (int i = 1; i <= numbers.Length ; i++)
            {
                digit += num % 10;
                num /= 10;
            }
            Console.WriteLine(digit);
        }
    }
}
