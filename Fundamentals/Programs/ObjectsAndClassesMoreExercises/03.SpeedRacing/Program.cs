using System;
using System.Linq;
using System.Collections.Generic;
namespace _03.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numOfCarsToTrack = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCarsToTrack; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount= double.Parse(input[1]);
                double fuelConsumptionForKilometer= double.Parse(input[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionForKilometer);
                cars.Add(car);
            }
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End") break;
                if (input[0] == "Drive")
                {
                    string model = input[1];
                    int distance = int.Parse(input[2]);
                    int index = cars.FindIndex(x => x.Model == model);
                    cars[index].Drive(distance);
                }
            }
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
    class Car
    {
        public Car(string model, double fuelAmount, double fuelPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelPerKilometer;
            TraveledDistance = 0;
        }
        public void Drive(int distance)
        {
            double fuelForDrivedDistance = distance * FuelConsumptionPerKilometer;
            if (fuelForDrivedDistance>FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
            TraveledDistance += distance;
            FuelAmount -= fuelForDrivedDistance;
            }
        }
        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TraveledDistance}";
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public int TraveledDistance { get; set; }
    }
}
