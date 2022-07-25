using System;

namespace _05SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int newNum = i;
                int sum = 0;
                while(newNum > 0)
                {
                    

                    sum += newNum % 10;
                    newNum /= 10;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;


                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
