using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";
            string input = String.Empty;
            string name = String.Empty;

            double totalPrice = 0;
            double priceOfProduct = 0;
            List<string> names = new List<string>();

            while ((input = Console.ReadLine()) != "Purchase")
            {

                MatchCollection matches = Regex.Matches(input, pattern);
                if (matches.Count >= 1)
                {
                    string[] info = input.Split(new char[] { '<', '>', '!' }, StringSplitOptions.RemoveEmptyEntries);

                    name = info[0];
                    double price = double.Parse(info[1]);
                    double quantity = double.Parse(info[2]);


                    priceOfProduct = price * quantity;
                    totalPrice += priceOfProduct;

                    names.Add(name);
                }

            }
            Console.WriteLine("Bought furniture:");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");

        }
    }
}
