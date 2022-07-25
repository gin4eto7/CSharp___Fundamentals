
namespace _08._Company_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> finalBook = new Dictionary<string, List<string>>();

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {

                if (input.Contains("|"))
                {
                    string[] command = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = command[0];
                    string forceUser = command[1];

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>() { forceUser });
                    }
                    else
                    {

                        forceBook[forceSide].Add(forceUser);
                    }

                }
                else if (input.Contains("->"))
                {
                    string[] command = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = command[1];
                    string forceUser = command[0];

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>() { forceUser });
                    }
                    else
                    {
                        foreach (var kvp in forceBook)
                        {
                            if (kvp.Value.Contains(forceUser))
                            {
                                kvp.Value.Remove(forceUser);
                            }
                        }
                        forceBook[forceSide].Add(forceUser);
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

            }
            foreach (var itemOn in forceBook)
            {
                
                finalBook = forceBook.Where(itemOn => itemOn.Value.Count > 0).ToDictionary(a => a.Key, b => b.Value);
            }
            foreach (var item in finalBook.OrderBy(x => x.Key))
            {
                

                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var us in item.Value.OrderBy(i => i))
                {
                    Console.WriteLine($"! {us}");
                }

            }

        }
    }
}