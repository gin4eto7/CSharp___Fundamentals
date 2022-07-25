using System;
using System.Text.RegularExpressions;

namespace _02MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359)([ -])([2])(\2)([\d]{3})(\2)([0-9]{4})\b";

            string numbers = Console.ReadLine();

            MatchCollection matches = Regex.Matches(numbers, pattern);

            Console.WriteLine(String.Join(", ", matches));
        }
    }
}
