using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> info = new Dictionary<string, int>();

            string[] names = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string patternName = "[A-Za-z]";
                string patternKm = @"\d";


                MatchCollection matchName = Regex.Matches(input, patternName);
                MatchCollection matchKm = Regex.Matches(input, patternKm);

                string name = String.Concat(matchName);
                int km = matchKm.Select(x => int.Parse(x.Value)).Sum();

                if(names.Contains(name))
                {
                    if(!(info.ContainsKey(name)))
                    {
                        info.Add(name, km);
                    }
                    else
                    {
                        info[name] += km;
                    }
                }


            }

            var sort = info.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            Console.WriteLine($"1st place: {sort[0]}");
            Console.WriteLine($"2nd place: {sort[1]}");
            Console.WriteLine($"3rd place: {sort[2]}");

            
        }
    }
}
