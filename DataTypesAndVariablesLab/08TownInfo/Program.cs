﻿using System;

namespace _08TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            String town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}
