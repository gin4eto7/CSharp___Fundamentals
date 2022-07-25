using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger maxSnowball = 0;
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue >= maxSnowball)
                {
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality = snowballQuality;
                    maxSnowball = snowballValue;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxSnowball} ({maxQuality})");




        }
    }
}
