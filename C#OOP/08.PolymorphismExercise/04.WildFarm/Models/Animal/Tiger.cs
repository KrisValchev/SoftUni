using _04.WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Animal
{
    public class Tiger : Feline
    {
        private const double TigerMultiplier = 1.00;
        protected override double WeightMultiplier => TigerMultiplier;
        public Tiger(string name, double weight,string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        public override ICollection<string> FoodToEat => new List<string>()
        {nameof(Meat)
        };
        public override string AskForFood()
        {
            return "ROAR!!!";
        }
    }
}
