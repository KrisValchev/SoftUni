﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const  double defaultFuelConsumption= 10;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            
        }
        public override double FuelConsumption { get { return defaultFuelConsumption ; }  }
    }
}
