using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.VehiclesExtension.Interface;

namespace _02.VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private const double IncreasedConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumptionPerLiter,double tankCapacity):base(fuelQuantity,fuelConsumptionPerLiter,tankCapacity, IncreasedConsumption)
        {

        }

        public override void Refuel(double quantity)
        {
            if (quantity + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }
           base.Refuel(quantity*0.95);
        }
    }
}
