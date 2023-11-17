using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Animal
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            WingSize = wingSize;
        }
        public double WingSize { get; private set; }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
