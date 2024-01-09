using _04.WildFarm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Factories.Interfaces
{
    public interface IFoodFactory
    {
        IFood CreateFood(string typeOfFood,int quantity);
    }
}
