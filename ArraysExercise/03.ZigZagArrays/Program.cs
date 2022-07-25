using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstLine = new int[n];
            int[] secondLine = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < array.Length; j++)
                {
                    if (i % 2 == 0)
                    {
                        firstLine[i] = array[0];
                        secondLine[i] = array[1];
                    }
                    else
                    {
                        firstLine[i] = array[1];
                        secondLine[i] = array[0];
                    }
                }
            }
            Console.WriteLine(string.Join(' ', firstLine));
            Console.WriteLine(string.Join(' ', secondLine));
        }
    }
}
