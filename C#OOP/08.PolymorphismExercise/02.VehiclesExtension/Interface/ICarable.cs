using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehiclesExtension.Interface
{
    public interface ICarable
    {
        public void Drive(double distance, bool isIncreasedConsumption = true);
        public void Refuel(double quantity);
    }
}
