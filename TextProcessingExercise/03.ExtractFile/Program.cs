using System;
using System.Collections.Generic;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);

            string[] file = line[line.Length- 1].Split(".");

            string name = file[0];
            string extension = file[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
