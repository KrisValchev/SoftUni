using _02.VehiclesExtension.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehiclesExtension.Models
{
    public abstract class Vehicle : ICarable
    {
        private double increasedConsumption;
        protected Vehicle(double fuelQuantity, double fuelConsumptionPerLiter, double tankCapacity, double increasedConsumption)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerLiter = fuelConsumptionPerLiter;
            this.increasedConsumption = increasedConsumption;
        }
        private double fuelQuantity;
        public bool IsIncreasedConsumption { get; set; }
        public double TankCapacity { get; private set; }
        public double FuelQuantity
        {
            get => fuelQuantity;
            private set
            {
                if (TankCapacity < value)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public double FuelConsumptionPerLiter { get; protected set; }

        public virtual void Drive(double distance,bool increasedConsumption=true)
        {
            double consumption=0;
            if (increasedConsumption)
            {
                consumption += this.increasedConsumption+FuelConsumptionPerLiter;
            }
            else
            {
                consumption = FuelConsumptionPerLiter;
            }
            if (consumption * distance <= FuelQuantity)
            {
                FuelQuantity -= consumption * distance;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else
            {
                throw new ArgumentException($"{GetType().Name} needs refueling");
            }
        }
        public virtual void Refuel(double quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (quantity + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }
            FuelQuantity += quantity;
        }
    }
}
