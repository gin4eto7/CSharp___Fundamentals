using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {

            //string resource = String.Empty;
            Dictionary<string, int> collect = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if(resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if(collect.ContainsKey(resource))
                {
                    collect[resource] += quantity;
                }
                else
                {
                    collect.Add(resource, quantity);
                }
            }

            foreach (var item in collect)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
