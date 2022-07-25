using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> line2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            if(line1.Count > line2.Count)
            {
                for (int i = 0; i < line1.Count; i++)
                {
                    resultList.Add(line1[i]);
                    if(line2.Count > i)
                    {
                        resultList.Add(line2[i]);
                    }
                    
                }
            }
            else
            {
                for (int i = 0; i < line2.Count; i++)
                {
                    
                    if (line1.Count > i)
                    {
                        resultList.Add(line1[i]);
                    }
                    resultList.Add(line2[i]);

                }
            }

            Console.WriteLine(String.Join(" ", resultList));

        }
    }
}
