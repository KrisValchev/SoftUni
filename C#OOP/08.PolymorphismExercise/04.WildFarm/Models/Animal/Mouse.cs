using _04.WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Animal
{
    public class Mouse : Mammal
    {
        private const double MouseMultiplier = 0.10;
        protected override double WeightMultiplier => MouseMultiplier;
        public Mouse(string name, double weight, string livingRegion) : base(name, weight,livingRegion)
        {
        }
        public override ICollection<string> FoodToEat => new List<string>()
        {nameof(Vegetable),nameof(Fruit)
        };
        public override string AskForFood()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";

        }
    }
}
