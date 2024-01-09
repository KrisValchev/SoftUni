﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Fish : MainDish
    {
        public Fish(string name, decimal price) : base(name, price, Grams)
        {

        }
        private const double Grams = 22;
    }
}
