using System;

namespace _10MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int times = 10;

            for (int i = 1; i <= times; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}
