using System;
using System.Collections.Generic;
using System.Linq;

namespace _06ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(" ");
                if(command[0] == "Add")
                {
                    int num = int.Parse(command[1]);
                    line.Add(num);
                }
                else if(command[0] == "Remove")
                {
                    int num = int.Parse(command[1]);
                    line.RemoveAll(n => n == num);
                }
                else if(command[0] == "RemoveAt")
                {
                    int index = int.Parse(command[1]);
                    line.RemoveAt(index);
                }
                else if(command[0] == "Insert")
                {
                    int num = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    line.Insert(index, num);
                }


                    input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", line));
        }
    }
}
