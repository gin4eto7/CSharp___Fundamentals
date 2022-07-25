using System;
using System.Collections.Generic;
using System.Linq;

namespace _07VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            
            Catalog catalog = new Catalog();
            catalog.Car = new List<Car>();
            catalog.Truck = new List<Truck>();

            while (input != "end")
            {
                string[] info = input.Split("/");

                string type = info[0];
                string brand = info[1];
                string model = info[2];
                int powerOrWeight = int.Parse(info[3]);

                

                if (type == "Truck")
                {
                    Truck truck = new Truck();

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = powerOrWeight;

                    catalog.Truck.Add(truck);

                }
                else
                {
                    Car car = new Car();

                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = powerOrWeight;

                    catalog.Car.Add(car);
                }


                

                input = Console.ReadLine();
            }

            if (catalog.Car.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Car.OrderBy(c => c.Brand))
                {

                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
                
            if(catalog.Truck.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Truck.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            

        }

      
    }

    public class Catalog
    {
        public List<Truck> Truck { get; set; }

        public List<Car> Car { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    public class Truck
    {
        public  string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }
}
