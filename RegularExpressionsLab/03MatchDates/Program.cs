﻿using System;
using System.Text.RegularExpressions;

namespace _03MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([\.\-\/])(?<month>[A-Za-z]{3})\1(?<year>\d{4})\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
