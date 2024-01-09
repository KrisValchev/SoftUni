using _02.VehiclesExtension.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        private const double IncreasedConsumption = 1.4;
        public Bus(double fuelQuantity, double fuelConsumptionPerLiter, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerLiter, tankCapacity,IncreasedConsumption)
        {
        }
    }
}
