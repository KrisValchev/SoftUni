using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double defaultFuelConsumption = 1.25;
        public virtual double FuelConsumption { get { return defaultFuelConsumption; } }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        public virtual void Drive(double kilometers)
        {
            Fuel-=FuelConsumption*kilometers;
        }
    }
}
