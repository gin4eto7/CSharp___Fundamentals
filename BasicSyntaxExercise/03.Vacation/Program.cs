using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal groupOfPeople = decimal.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            decimal priceOfDay = 0.0m;
            decimal priceOfGroup = 0.0m;

            switch(typeOfGroup)
            {
                case "Students":
                    if(day == "Friday")
                    {
                        priceOfDay = 8.45m;
                    }
                    else if (day == "Saturday")
                    {
                        priceOfDay = 9.80m;
                    }
                    else if (day == "Sunday")
                    {
                        priceOfDay = 10.46m;
                    }
                    break;

                case "Business":
                    if (day == "Friday")
                    {
                        priceOfDay = 10.90m;
                    }
                    else if (day == "Saturday")
                    {
                        priceOfDay = 15.60m;
                    }
                    else if (day == "Sunday")
                    {
                        priceOfDay = 16.0m;
                    }
                    break;

                case "Regular":
                    if (day == "Friday")
                    {
                        priceOfDay = 15.0m;
                    }
                    else if (day == "Saturday")
                    {
                        priceOfDay = 20.0m;
                    }
                    else if (day == "Sunday")
                    {
                        priceOfDay = 22.50m;
                    }
                    break;
                default:
                    break;
    
            }
            priceOfGroup = groupOfPeople * priceOfDay;

            if (typeOfGroup == "Students" && groupOfPeople >= 30.0m)
            {
                priceOfGroup -= (priceOfGroup * 0.15m);
            }
            else if (typeOfGroup == "Business" && groupOfPeople >= 100.0m)
            {
                priceOfGroup -= (priceOfDay * 10);
            }
            else if (typeOfGroup == "Regular" && (groupOfPeople >= 10.0m && groupOfPeople <= 20.0m))
            {
                priceOfGroup -= priceOfGroup * 0.05m;
            }
            Console.WriteLine($"Total price: {priceOfGroup:f2}");
            
        }
    }
}
