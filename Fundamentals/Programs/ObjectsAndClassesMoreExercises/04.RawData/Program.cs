using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo);
                cars.Add(car);
            }
            string chooseCargoType = Console.ReadLine();
            if (chooseCargoType == "fragile")
            {            
                
                foreach (Car car in cars.Where(x => x.Cargo.CargoType == "fragile" && x.Cargo.CargoWeight < 1000))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (chooseCargoType == "flamable")
            {
                foreach (Car car in cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower >250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoType = cargoType;
            CargoWeight = cargoWeight;
        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
