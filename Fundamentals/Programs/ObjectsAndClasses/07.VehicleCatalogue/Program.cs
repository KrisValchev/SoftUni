using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (true)
            {
                string[] input = Console.ReadLine().Split("/");
                if (input[0] == "end")
                {

                    Catalog catalog = new Catalog(trucks, cars);
                   catalog.Cars= catalog.Cars.OrderBy(x => x.Brand).ToList();
                   catalog.Trucks= catalog.Trucks.OrderBy(x => x.Brand).ToList();
                    if (catalog.Cars.Count != 0)
                    {
                        Console.WriteLine("Cars:");
                        foreach (Car car in catalog.Cars)
                        {
                            Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                        }
                    }
                    if (catalog.Trucks.Count != 0)
                    {
                        Console.WriteLine("Trucks:");
                        foreach (Truck truck in catalog.Trucks)
                        {
                            Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                        }
                    }
                    break;
                }
                string model = input[2];
                string brand = input[1];
                if (input[0] == "Car")
                {
                    int horsePower = int.Parse(input[3]);
                    Car car = new Car(brand, model, horsePower);
                    cars.Add(car);
                }
                else
                {
                    int weight = int.Parse(input[3]);
                    Truck truck = new Truck(brand, model, weight);
                    trucks.Add(truck);
                }
            }
        }
    }
    class Truck
    {

        public Truck(string brand, string model, int wieght)
        {
            Brand = brand;
            Model = model;
            Weight = wieght;
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
        public Catalog(List<Truck> trucks, List<Car> cars)
        {
            Trucks = trucks;
            Cars = cars;
        }
        public List<Truck> Trucks { set; get; }
        public List<Car> Cars { set; get; }
    }
}
