using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles.Interface
{
    public interface ICarable
    {
        public double FuelQuantity { get; }
        public double FuelConsumptionPerLiter { get; }
        public void Drive(double distance);
        public void Refuel(double quantity);
    }
}
