using System;

namespace _09SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 1;
            for (int i = 0; i < n; i++)
            {

                
                if(counter % 2 == 1)
                {
                    sum += counter;

                    Console.WriteLine(counter);
                }
                else
                {
                    i--;
                }
                counter++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
