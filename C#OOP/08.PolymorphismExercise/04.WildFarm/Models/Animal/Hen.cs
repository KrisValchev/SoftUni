using _04.WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _04.WildFarm.Models.Animal
{
    public class Hen : Bird
    {
        private const double HenMultiplier = 0.35;
        protected override double WeightMultiplier => HenMultiplier;
        public Hen(string name, double weight, double wingSize) : base(name, weight,wingSize)
        {
        }
        public override ICollection<string> FoodToEat => new List<string>()
        {nameof(Vegetable),nameof(Fruit),nameof(Meat),nameof(Seeds)
        };

       

        public override string AskForFood()
        {
            return "Cluck";
        }
    }
}
