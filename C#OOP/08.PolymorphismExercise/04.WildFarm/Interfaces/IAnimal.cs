using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }
        public ICollection<string> FoodToEat { get; }
        public void Eat(IFood food);
        public  string AskForFood();
    }
}
