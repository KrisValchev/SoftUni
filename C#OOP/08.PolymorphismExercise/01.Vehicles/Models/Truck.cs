using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Vehicles.Interface;

namespace _01.Vehicles.Models
{
    public class Truck : ICarable
    {
        public Truck(double fuelQuantity, double fuelConsumptionPerLiter)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerLiter = fuelConsumptionPerLiter + 1.6;
        }
        public double FuelQuantity { get; private set; }

        public double FuelConsumptionPerLiter { get; private set; }

        public void Drive(double distance)
        {
            if (FuelConsumptionPerLiter * distance < FuelQuantity)
            {
                FuelQuantity -= FuelConsumptionPerLiter * distance;
                Console.WriteLine($"{nameof(Truck)} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{nameof(Truck)} needs refueling");
            }
        }
        public void Refuel(double quantity)
        {
            FuelQuantity += quantity * 0.95;
        }
    }
}
