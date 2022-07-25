using System;
using System.Collections.Generic;
using System.Linq;

namespace RetakeExamFund
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, string>> info = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, Dictionary<string, string>> temp = new Dictionary<string, Dictionary<string, string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //Fur Elise|Beethoven|A Minor
                string[] input = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                if (!info.ContainsKey(piece))
                {
                    info.Add(piece, new Dictionary<string, string>()
                    {
                        { "composer", composer},
                        {"key", key }
                    });

                }
            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] commands = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string currCommand = commands[0];
                string piece = commands[1];
                if (currCommand == "Add")
                {

                    string composer = commands[2];
                    string key = commands[3];

                    if (!info.ContainsKey(piece))
                    {
                        info.Add(piece, new Dictionary<string, string>()
                    {
                        { "composer", composer},
                        {"key", key }
                    });

                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if(currCommand == "Remove")
                {
                    if(info.ContainsKey(piece))
                    {
                        info.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (currCommand == "ChangeKey")
                {
                    string newKey = commands[2];

                    if (info.ContainsKey(piece))
                    {
                        info[piece].Remove("key");
                        info[piece].Add("key", newKey);
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
            
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var comp in info.OrderBy(x => x.Key).ThenBy(n => n.Value["composer"]))
            {
                Console.WriteLine($"{comp.Key} -> Composer: {comp.Value["composer"]}, Key: {comp.Value["key"]}");
            }
        }
    }
}
