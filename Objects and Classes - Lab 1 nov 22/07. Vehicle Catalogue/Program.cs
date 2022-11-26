using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //create a Vehicle catalog, which contains only Trucks and Cars
            //{type}/{brand}/{model}/{horse power / weight}
            //Car/Audi/A3/110

            Catalog catalog = new Catalog();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split('/', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end")
                {
                    break;
                }

                if (input[0] == "Truck")
                {
                    Truck truck = new Truck(input[1], input[2], int.Parse(input[3]));
                    catalog.Trucks.Add(truck);
                }
                else if (input[0] == "Car")
                {
                    Car car = new Car(input[1], input[2], int.Parse(input[3]));
                    catalog.Cars.Add(car);
                }
            }

            if (catalog.Cars.Any())
            {
                Console.WriteLine("Cars:");
            }
            foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (catalog.Trucks.Any())
            {
                Console.WriteLine("Trucks:");
            }
            foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
