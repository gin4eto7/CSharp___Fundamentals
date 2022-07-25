using System;
using System.Numerics;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int startingYield = int.Parse(Console.ReadLine());
            
            int days = 0;
            int totalYield = 0;

            if(startingYield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(totalYield);
            }
            else
            {
                while (startingYield >= 100)
                {
                        totalYield += startingYield - 26;
                        startingYield -= 10;
                        days++;
                }
            totalYield -= 26;
            
            Console.WriteLine(days);
            Console.WriteLine(totalYield);
            }


        }
    }
}
