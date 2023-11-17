using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private Dictionary<string, double> types = new Dictionary<string, double>
        {
            {"meat",1.2},
            {"veggies",0.8},
            {"cheese",1.1},
            {"sauce",0.9}
        };
        private int weight;
        private string type;

        public string TypeOfTopping
        {
            get { return type; }
           private set
            {
                if (!types.ContainsKey(value.ToLower()))
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                type = value;
            }
        }

        public int Weight
        {
            get { return weight; }
           private set
            {
                if (value < 0 || value > 50)
                    throw new Exception($"{this.TypeOfTopping} weight should be in the range [1..50].");
                weight = value;
            }
        }


        public Topping(string type, int weight)
        {
            this.TypeOfTopping = type;
            this.Weight = weight;
        }
        public double CalculateCalories()
        {
            return 2 * weight * types[type.ToLower()];
        }
    }
}
