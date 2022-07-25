using System;

namespace _08MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(Power(num, power));
        }

        static double Power (double num, double power)
        {
            double total = Math.Pow(num, power);

            return total;
        }
    }
}
