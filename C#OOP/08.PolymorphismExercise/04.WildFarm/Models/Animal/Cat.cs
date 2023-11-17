using _04.WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Animal
{
    public class Cat : Feline
    {
        private const double CatMultiplier = 0.30;
        protected override double WeightMultiplier => CatMultiplier;
        public Cat(string name, double weight,string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        public override ICollection<string> FoodToEat => new List<string>()
        {nameof(Vegetable),nameof(Meat)
        };
        public override string AskForFood()
        {
            return "Meow";
        }
    }
}
