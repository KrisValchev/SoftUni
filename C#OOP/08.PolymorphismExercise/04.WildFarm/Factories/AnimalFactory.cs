using _04.WildFarm.Factories.Interfaces;
using _04.WildFarm.Interfaces;
using _04.WildFarm.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string[] animalTokens)
        {
            switch(animalTokens[0])
            {
                case "Hen":
                    return new Hen(animalTokens[1], double.Parse(animalTokens[2]),double.Parse(animalTokens[3]));
                case "Owl":
                    return new Owl(animalTokens[1], double.Parse(animalTokens[2]), double.Parse(animalTokens[3]));
                case "Mouse":
                    return new Mouse(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3]);
                case "Dog":
                    return new Dog(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3]);
                case "Cat":
                    return new Cat(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3], animalTokens[4]);
                case "Tiger":
                    return new Tiger(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3], animalTokens[4]);
                default:
                    throw new ArgumentException("Invalid type of animal!");
            }
        }
    }
}
