using System;
using System.Collections.Generic;
using System.Linq;

namespace _06StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] info = input.Split(" ");

                string serialNumber = info[0];
                string item = info[1];
                int itemQuantity = int.Parse(info[2]);
                double itemPrice = double.Parse(info[3]);

                Item itemItem = new Item();

                itemItem.Name = item;
                itemItem.Price = itemPrice;

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.Item = itemItem;
                box.Quantity = itemQuantity;
                box.PriceForBox = PriceForBox(box.Quantity, itemItem.Price);

                boxes.Add(box);


                input = Console.ReadLine();
            }
            PrintInfo(boxes);
        }

        public static void PrintInfo(List<Box> boxes)
        {
            List<Box> orderedBox = boxes.OrderByDescending(b => b.PriceForBox).ToList();
            foreach (var box in orderedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }

        public static double PriceForBox(int quantity, double price)
        {
            double totalPice = quantity * price;
            return totalPice;
        }
    }

    public class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public double PriceForBox { get; set; }
    }

    public class Item
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
