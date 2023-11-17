using _04.WildFarm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Food
{
    public abstract class Food : IFood
    {
        public int Quantity { get; private set; }

        protected Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
