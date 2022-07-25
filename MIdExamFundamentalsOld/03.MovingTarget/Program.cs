using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOfTargets = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> comands = Console.ReadLine().Split().ToList();

            while (comands[0] != "End")
            {
                
                int index = int.Parse(comands[1]);
                
                
                switch (comands[0])
                {
                    case "Shoot":
                        int power = int.Parse(comands[2]);
                        if(index < sequenceOfTargets.Count && index >= 0)
                        {
                            sequenceOfTargets[index] -= power;
                            if (sequenceOfTargets[index] <= 0)
                            {
                                sequenceOfTargets.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        int value = int.Parse(comands[2]);
                        if(index >= 0 && index < comands.Count)
                        {
                            sequenceOfTargets.Insert(index, value);
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        int radius = int.Parse(comands[2]);
                        int startIndex = index - radius;
                        if (index - radius >= 0 && index + radius < sequenceOfTargets[sequenceOfTargets.Count - 1])
                        {
                            sequenceOfTargets.RemoveRange(startIndex, radius * 2 + 1);
                            
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }
                comands = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(String.Join("|", sequenceOfTargets));
            //52 74 23 44 96 110
            //Strike 2 1
        }
    }
}
