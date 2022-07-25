using System;
using System.Collections.Generic;
using System.Linq;

namespace _07ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            String input = Console.ReadLine();

            while (input != "end")
            {

                string[] commands = input.Split(" ");
                string command = commands[0];

                if(command == "Contains")
                {
                    int num = int.Parse(commands[1]);
                    if (line.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if(command == "PrintEven")
                {
                    for (int i = 0; i < line.Count; i++)
                    {
                        if(line[i] % 2 == 0)
                        {
                            Console.Write(line[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if(command == "PrintOdd")
                {
                    for (int i = 0; i < line.Count; i++)
                    {
                        if(line[i] % 2 != 0)
                        {
                            Console.Write(line[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if(command == "GetSum")
                {
                    int sum = 0;

                    for (int i = 0; i < line.Count; i++)
                    {
                        sum += line[i];
                    }
                    Console.WriteLine(sum);
                }
                else if(command == "Filter")
                {
                    string filter = commands[1];
                    int num = int.Parse(commands[2]);

                    if(filter == "<")
                    {
                        int count = line.Count();
                        for (int i = 0; i < count; i++)
                        {
                            if(line[i] < num)
                            {
                                Console.Write(line[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if(filter == ">")
                    {
                        int count = line.Count();
                        for (int i = 0; i < count; i++)
                        {
                            if (line[i] > num)
                            {
                                Console.Write(line[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if(filter == "<=")
                    {
                        int count = line.Count();
                        for (int i = 0; i < count; i++)
                        {
                            if (line[i] <= num)
                            {
                                Console.Write(line[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if(filter == ">=")
                    {
                        int count = line.Count();
                        for (int i = 0; i < count; i++)
                        {
                            if (line[i] >= num)
                            {
                                Console.Write(line[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }



                input = Console.ReadLine();
            }
        }
    }
}
