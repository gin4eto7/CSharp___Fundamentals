using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int countComands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < countComands; i++)
            {
                List<string> comands = Console.ReadLine().Split().ToList();

                if (comands.Count == 3)
                {
                    
                    if (names.Contains(comands[0]))
                    {
                        Console.WriteLine($"{comands[0]} is already in the list!");
                    }
                    else
                    {

                        names.Add(comands[0]);
                    }
                }
                else if (comands.Count == 4)
                {
                    if (names.Contains(comands[0]))
                    {
                        names.Remove(comands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{comands[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(String.Join("/n" + " ", names[i]));
            }
            
        }
    }
}
