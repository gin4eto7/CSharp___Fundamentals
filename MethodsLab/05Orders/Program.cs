using System;

namespace _05Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            PrintTotalPrice(product, count);
        }

        static void PrintTotalPrice(string product, int count)
        {

            double price = 0.0;
            if (product == "coffee")
            {
               price = 1.50;
            }
            else if(product == "water")
            {
                price = 1.00;
            }
            else if(product == "coke")
            {
                price = 1.40;
            }
            else if(product == "snacks")
            {
                price = 2.00;
            }

            double total = price * count;
            Console.WriteLine($"{total:f2}");
        }
    }
}
