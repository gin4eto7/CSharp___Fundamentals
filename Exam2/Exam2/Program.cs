using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=\/])(?<name>[A-Za-z]{3,})(\1)";
            List<string> names = new List<string>();

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                var name = match.Groups["name"].Value;
                names.Add(name);
                for (int i = 0; i < name.Length; i++)
                {
                    
                    count++;
                }
            }

            Console.WriteLine("Destinations: "+ String.Join(", ", names));
            Console.WriteLine($"Travel Points: {count}");
        }
    }
}
