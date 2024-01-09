using _04.WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Animal
{
    public class Dog : Mammal
    {
        private const double DogMultiplier = 0.40;
        protected override double WeightMultiplier => DogMultiplier;
        public Dog(string name, double weight,string livingRegion) : base(name, weight,livingRegion)
        {
        }
        public override ICollection<string> FoodToEat => new List<string>()
        {nameof(Meat)
        };
        public override string AskForFood()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";

        }
    }
}
