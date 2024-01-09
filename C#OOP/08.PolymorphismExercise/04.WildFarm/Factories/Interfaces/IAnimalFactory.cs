using _04.WildFarm.Interfaces;
using _04.WildFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Factories.Interfaces
{
    public interface IAnimalFactory
    {
        IAnimal CreateAnimal(string[] animalTokens);
    }
}
