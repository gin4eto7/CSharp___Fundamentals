using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double persentSabers = Math.Ceiling(countStudents * 0.10);
            double totalPriceSabers = priceOfLightsabers * (countStudents + persentSabers);
            double totalPriceRobes = priceOfRobes * countStudents;
            double totalPriceBelts = priceOfBelts * countStudents;

            for (int i = 1; i <= countStudents; i++)
            {
                if (i % 6 == 0)
                {
                    totalPriceBelts -= priceOfBelts;
                }
            }
            
            double totalPrice = totalPriceSabers + totalPriceRobes + totalPriceBelts;

            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - money:f2}lv more.");
            }
        }
    }
}
