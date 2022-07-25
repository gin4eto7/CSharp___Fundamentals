using System;
using System.Text.RegularExpressions;

namespace _01MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();
        }
    }
}
