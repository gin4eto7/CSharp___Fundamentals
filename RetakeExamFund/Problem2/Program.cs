using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#]?[|]?)(?<name>[A-Za-z]+|[A-Za-z]+ [A-Za-z]*)(\1)(?<date>[\d]{2}\/[\d]{2}\/[\d]{2})(\1)(?<calories>[\d]+)(\1)";
            List<string> foods = new List<string>();
            int sum = 0;
            int totalDys = 0;
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                foods.Add(match.Groups["name"].Value);
                string date = match.Groups["date"].Value;
                sum += int.Parse((match.Groups["calories"]).Value);
            }
            totalDys = sum / 2000;

            Console.WriteLine($"You have food to last you for: {totalDys} days!");

            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups["name"]}, Best before: {item.Groups["date"]}, Nutrition: {item.Groups["calories"]}");
            }
        }
    }
}
