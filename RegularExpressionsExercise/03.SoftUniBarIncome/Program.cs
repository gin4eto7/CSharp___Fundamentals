using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        private static int name;

        static void Main(string[] args)
        {

            string input = String.Empty;
            double totalPriceProduct = 0;
            double total = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$";

                MatchCollection match = Regex.Matches(input, pattern);

                foreach (Match item in match)
                {
                    string name = item.Groups["name"].Value;
                    string product = item.Groups["product"].Value;
                    int count = int.Parse(item.Groups["count"].Value);
                    double price = double.Parse(item.Groups["price"].Value);

                    totalPriceProduct = count * price;

                Console.WriteLine($"{name}: {product} - {totalPriceProduct:f2}");

                }
                    total += totalPriceProduct;
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
