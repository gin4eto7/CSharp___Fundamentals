using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int division = 0;

            if(num % 2 == 0)
            {
                division = 2;
            }
            if(num % 3 == 0)
            {
                division = 3;
            }
            if(num % 6 == 0)
            {
                division = 6;
            }
            if(num % 7 == 0)
            {
                division = 7;
            }
            if(num % 10 == 0)
            {
                division = 10;
            }

            if(num % 2 != 0 && num % 3 != 0 && num % 6 != 0 && num % 7 != 0 && num % 10 != 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {division}");
            }
            

        }
    }
}
