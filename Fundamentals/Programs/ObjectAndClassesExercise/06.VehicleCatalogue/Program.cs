using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicles> vehicles = new List<Vehicles>();
            List<int> carsHorsePower = new List<int>();
            List<int> trucksHorsePower = new List<int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }
                string typeOfVeicle = input[0];
                string model = input[1];
                string color = input[2];
                decimal horsePower = decimal.Parse(input[3]);
                Vehicles vehicle = new Vehicles(typeOfVeicle, model, color, horsePower);
                vehicles.Add(vehicle);
            }
            while (true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {

                    decimal averageHoursePowerOfCars = vehicles.Where(x => x.TypeOfVehicle == "car").Select(x => x.HorsePower).DefaultIfEmpty().Average();
                    Console.WriteLine($"Cars have average horsepower of: {averageHoursePowerOfCars:f2}.");

                    decimal averageHorsePowerOfTrucks = vehicles.Where(x => x.TypeOfVehicle == "truck").Select(x => x.HorsePower).DefaultIfEmpty().Average();
                    Console.WriteLine($"Trucks have average horsepower of: {averageHorsePowerOfTrucks:f2}.");

                    break;
                }
                if (vehicles.Find(x => x.Model == model) != null)
                {
                    Console.WriteLine(vehicles.Find(x => x.Model == model).Print());
                }
            }

        }
    }
    class Vehicles
    {
        public Vehicles(string type, string model, string color, decimal horsePower)
        {
            TypeOfVehicle = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Print()
        {
            string result = "";
            if (TypeOfVehicle == "car")
                result += $"Type: Car\n";
            else
                result += $"Type: Truck\n";
            result += $"Model: {Model}\n";
            result += $"Color: {Color}\n";
            result += $"Horsepower: {HorsePower}";
            return result;
        }
        public decimal HorsePower { get; set; }
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }

}
