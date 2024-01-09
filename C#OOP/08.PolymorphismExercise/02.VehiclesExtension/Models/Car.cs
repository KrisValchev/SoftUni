using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.VehiclesExtension.Interface;

namespace _02.VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private const double IncreasedConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumptionPerLiter, double tankCapacity):base(fuelQuantity,fuelConsumptionPerLiter,tankCapacity, IncreasedConsumption)
        {
        }
        

    }
}
