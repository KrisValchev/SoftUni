using _04.WildFarm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Models.Animal
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }
        protected abstract double WeightMultiplier{get;}
        public abstract ICollection<string> FoodToEat { get; }
        public void Eat(IFood food)
        {
            Weight += WeightMultiplier * food.Quantity;
            FoodEaten += food.Quantity;
        }

        public abstract string AskForFood();
    }
}
