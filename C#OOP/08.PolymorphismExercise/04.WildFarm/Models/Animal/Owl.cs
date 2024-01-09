using _04.WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Animal
{
    public class Owl : Bird
    {
        private const double OwlMultiplier = 0.25;
        protected override double WeightMultiplier => OwlMultiplier;
        public Owl(string name, double weight, double wingSize) : base(name, weight,wingSize)
        {
        }
        public override ICollection<string> FoodToEat => new List<string>()
        {nameof(Meat)
        };


        public override string AskForFood()
        {
            return "Hoot Hoot";
        }
    }
}
