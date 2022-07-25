using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int j = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                for (j = i; j < numbers.Length; j++)
                {
                    var top = new int[numbers[i]];
                    if (numbers[j - 1] > numbers[j])
                    {

                        Console.Write((numbers[j - 1]) + " ");
                        break;
                    }
                    else if (numbers[i] <= numbers[j])
                    {
                        break;
                    }

                    
                }
            }
            Console.WriteLine(numbers[j]);
        }
    }
}
