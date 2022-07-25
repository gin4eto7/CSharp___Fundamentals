using System;
using System.Linq;

namespace _08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] sum = new int[num.Length - 1];


            while (num.Length > 1)
            {
                
                
                for (int i = 0; i < num.Length - 1; i++)
                {
                    sum[i] = num[i] + num[i + 1];
                }
                num = sum;
                sum = new int[sum.Length - 1];
            }

            Console.WriteLine(String.Join(" ", num));
        }
    }
}
