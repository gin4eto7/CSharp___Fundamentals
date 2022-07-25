using System;

namespace _11MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int times = 10;

            if(num2 > times)
            {
                Console.WriteLine($"{num1} X {num2} = {num1 * num2}");

            }
            else
            {
                for (int i = num2; i <= times; i++)
                {
                    Console.WriteLine($"{num1} X {i} = {num1 * i}");
                }
            }

            
        }
    }
}
