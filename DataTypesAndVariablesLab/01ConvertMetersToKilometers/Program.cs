using System;

namespace _01ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meter = int.Parse(Console.ReadLine());

            float km = meter / 1000.0f;

            Console.WriteLine($"{km:f2}");
        }
    }
}
