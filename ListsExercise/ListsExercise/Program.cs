using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapcity = int.Parse(Console.ReadLine());
           
            List<string> passengers = Console.ReadLine().Split().ToList();
            while (passengers[0] != "end")
            {
                if(passengers[0] == "Add")
                {
                    int addWagon = int.Parse(passengers[1]);
                    wagons.Add(addWagon);
                }
                else 
                {
                    int addPassengers = int.Parse(passengers[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if(wagons[i] + addPassengers <= maxCapcity)
                        {
                            wagons[i] += addPassengers;
                            break;
                        }
                    }
                }
                passengers = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
