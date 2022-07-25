using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            if(numbers.Count <= 1)
            {
                Console.WriteLine("No");
                return;
            }
            double average = numbers.Average();

            List<int> top = new List<int>();
            List<int> big = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {

                if(numbers[i] > average)
                {
                    top.Add(numbers[i]);

                }
                
            }

            for (int i = 0; i < 5; i++)
            {
                int max = int.MinValue;
                int index = 0;
                if (big.Count < top.Count)
                {
                    for (int j = 0; j < top.Count; j++)
                    {
                        if (max < top[j])
                        {
                            max = top[j];
                            index = j;

                        }
                    }
                    big.Add(max);
                    top[index] = int.MinValue;
                    
                }
            }
            Console.WriteLine(String.Join(" ", big));

        }
    }
}
