using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, double>> dic = new Dictionary<string, Dictionary<string, double>>();
           

            string plantName = String.Empty;
            int rating = 0;
            int count = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = input[0];
                int rarity = int.Parse(input[1]);

                if (!dic.ContainsKey(plant))
                {

                    dic.Add(plant, new Dictionary<string, double>()
                    {
                        { "rarity", rarity}
                    });
                }

            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] commands = command
                    .Split(new char[] { '-', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                string currCommand = commands[0];
                plantName = commands[1];

                if (currCommand == "Rate")
                {

                    rating = int.Parse(commands[2]);
                    if (dic.ContainsKey(plantName))
                    {
                        if (dic[plantName].ContainsKey("rating"))
                        {

                            dic[plantName]["rating"] += rating;
                        }
                        else
                        {
                            dic[plantName].Add("rating", rating);
                        }


                    }

                }
                else if (currCommand == "Update")
                {
                    int newRarity = int.Parse(commands[2]);

                    if (dic[plantName].ContainsKey("rarity"))
                    {
                        dic[plantName]["rarity"] = newRarity;
                    }
                }
                else if (currCommand == "Reset")
                {
                    if (dic[plantName].ContainsKey("rating"))
                    {
                        dic[plantName].Remove("rating");
                    }
                }

                command = Console.ReadLine();
            }
            double average = 0;
            foreach (var item in dic)
            {

            average = item.Value.Average(x => x);
            }

            var order = dic.OrderByDescending(x => x.Value["rarity"]);
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in order)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value["rarity"]}; Rating: {average}");
            }
        }
    }
}
