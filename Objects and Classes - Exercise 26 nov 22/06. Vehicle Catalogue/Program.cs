using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            //{typeOfVehicle} {model} {color} {horsepower}
            List<Vehicle> vehicleList = new List<Vehicle>();

            while (true)
            {
                string[] vehicleInfo = Console.ReadLine()
                    .Split();

                if (vehicleInfo[0] == "End")
                {
                    break;
                }

                string typeOfVehicle = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int horsepower = int.Parse(vehicleInfo[3]);

                Vehicle currVehicle = new Vehicle(typeOfVehicle, model, color, horsepower);
                vehicleList.Add(currVehicle);
            }

            string input;
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicleList.Find(x => x.Model == input));
            }

            List<Vehicle> onlyCarsList = vehicleList.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucksList = vehicleList.Where(x => x.Type == "truck").ToList();
            double carsHP = 0;
            double trucksHP = 0;

            foreach (Vehicle car in onlyCarsList)
            {
                carsHP += car.Horsepower;
            }

            foreach (Vehicle truck in onlyTrucksList)
            {
                trucksHP += truck.Horsepower;
            }

            double avgCarHP = carsHP / onlyCarsList.Count;
            double avgTruckHP = trucksHP / onlyTrucksList.Count;

            //double avgCarHp = vehiclesList.Where(v => v.Type == "Car")
            //                              .Select(v => v.HorsePower)
            //                              .Average();

            //double avgTruckHp = vehiclesList.Where(v => v.Type == "Truck")
            //                                .Select(v => v.HorsePower)
            //                                .Average();

            if (onlyCarsList.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {avgCarHP:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucksList.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {avgTruckHP:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                $"Model: {this.Model}{Environment.NewLine}" +
                                $"Color: {this.Color}{Environment.NewLine}" +
                                $"Horsepower: {this.Horsepower}";

            return vehicleStr;
        }
    }
}
