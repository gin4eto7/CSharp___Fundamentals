using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"!([A-Z][a-z]{2,})!:([\[])(?<encrypt>[A-Za-z]{8,})([\]])";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {


                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match math = regex.Match(input);
                List<int> output = new List<int>();

                if (math.Success)
                {
                    string encrypt = math.Groups["encrypt"].Value;
                    string command = math.Groups["1"].Value;
                    for (int j = 0; j < encrypt.Length; j++)
                    {
                        output.Add(encrypt[j]);
                    }
                    Console.Write($"{command}: ");
                    foreach (var digit in output)
                    {
                        Console.Write($"{digit} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"The message is invalid");
                }
            }
        }
    }
}
