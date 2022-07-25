using System;
using System.Numerics;

namespace _03ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            BigInteger sum = new BigInteger();

            for (int i = 0; i < count; i++)
            {
                var num = BigInteger.Parse(Console.ReadLine());

                sum += num;
            }

            Console.WriteLine(sum);

        }
    }
}
