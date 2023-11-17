using _04.WildFarm.Factories.Interfaces;
using _04.WildFarm.Interfaces;
using _04.WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Factories
{
    public class FoodFactory : IFoodFactory
    {
        public IFood CreateFood(string typeOfFood,int quantity)
        {
           switch(typeOfFood)
            {
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Fruit":
                    return new Fruit(quantity);
                case "Meat":
                    return new Meat(quantity);
                case "Seeds":
                    return new Seeds(quantity);
                default:
                    throw new ArgumentException("Invalid type of food!");
            }
        }
    }
}
