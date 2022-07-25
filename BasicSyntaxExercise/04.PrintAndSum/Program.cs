using System;

namespace _04.PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStart = int.Parse(Console.ReadLine());
            int numFinal = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = numStart; i <= numFinal; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
