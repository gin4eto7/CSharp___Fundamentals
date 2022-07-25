using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Z]*[a-z]*[@$#]*(?<planet>[A-Z][a-z]+)[\d]?:(?<population>[\d]+)[!\->]?(?<attac>[A,D])[!\->]*(?<soldier>[\d]+)[A-Z]*";
            string charCode = "[SsTtRrAa]";

            int count = int.Parse(Console.ReadLine());

            Dictionary<string, int> attacList = new Dictionary<string, int>();
            Dictionary<string, int> destroyList = new Dictionary<string, int>();
            string attac = String.Empty;
            int countAttac = 0;
            int countDestroy = 0;

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                MatchCollection match = Regex.Matches(input, charCode);

                int countWord = match.Count;
                string decription = String.Empty;



                foreach (var item in input)
                {
                    decription += (char)(item - countWord);
                }

                MatchCollection matchEnd = Regex.Matches(decription, pattern);

                foreach (Match name in matchEnd)
                {

                    string planet = name.Groups["planet"].Value;
                    int population = int.Parse(name.Groups["population"].Value);
                    attac = name.Groups["attac"].Value;
                    int soldier = int.Parse(name.Groups["soldier"].Value);

                    

                    if(attac == "A")
                    {
                        countAttac = 1;

                        if (!attacList.ContainsKey(planet))
                        {
                            attacList.Add(planet, countAttac);
                        }
                        else
                        {
                            attacList[planet] += countAttac;
                        }
                    }
                    else if(attac == "D")
                    {
                        countDestroy = 1;
                        if (!destroyList.ContainsKey(planet))
                        {
                            destroyList.Add(planet, countDestroy);
                        }
                        else
                        {
                            destroyList[planet] += countDestroy;
                        }
                    }

                }

                
            }

            Console.WriteLine($"Attacked planets: {attacList.Count}");
            foreach (var planets in attacList.OrderByDescending(x => x.Key))
            {
                Console.WriteLine($"-> {planets.Key}");
            }

            Console.WriteLine($"Destroyed planets: {destroyList.Count}");
            foreach (var planets in destroyList.OrderBy(x => x.Key))
            {
                Console.WriteLine($"-> {planets.Key}");
            }
            
        }
    }
}
