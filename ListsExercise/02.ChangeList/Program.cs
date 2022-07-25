using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> input = Console.ReadLine().Split().ToList();
            while (input[0] != "end")
            {
                int number = int.Parse(input[1]);
                if (input[0] == "Delete")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        nums.Remove(number);

                    }

                }
                else if (input[0] == "Insert")
                {

                        int posicion = int.Parse(input[2]);
                        nums.Insert(posicion, number);

                    
                }
                input = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
