using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, double[]> info = new Dictionary<string, double[]>();

            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "buy")
                {
                    break;
                }
                string product = commands[0];
                double price = double.Parse(commands[1]);
                int quantity = int.Parse(commands[2]);

                if (!info.ContainsKey(product))
                {
                    info.Add(product, new double[2]);
                }

                info[product][0] = price;
                info[product][1] += quantity;


            }
            foreach (var item in info)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }
        }
    }
}
