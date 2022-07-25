using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            int totalWoter = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                int quantityOfWoter = int.Parse(Console.ReadLine());

                if (totalWoter + quantityOfWoter > 255)
                {

                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {

                    totalWoter += quantityOfWoter;
                }

            }
            Console.WriteLine(totalWoter);
        }
    }
}
