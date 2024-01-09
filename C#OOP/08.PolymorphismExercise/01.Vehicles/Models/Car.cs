using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Vehicles.Interface;

namespace _01.Vehicles.Models
{
    public class Car : ICarable
    {
        public Car(double fuelQuantity, double fuelConsumptionPerLiter)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerLiter = fuelConsumptionPerLiter + 0.9;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumptionPerLiter { get; private set; }

        public void Drive(double distance)
        {
            if (FuelConsumptionPerLiter * distance < FuelQuantity)
            {
                FuelQuantity -= FuelConsumptionPerLiter * distance;
                Console.WriteLine($"{nameof(Car)} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{nameof(Car)} needs refueling");
            }
        }
        public void Refuel(double quantity)
        {
            FuelQuantity += quantity;
        }
    }
}
