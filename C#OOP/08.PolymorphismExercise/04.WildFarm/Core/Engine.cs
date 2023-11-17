using _04.WildFarm.Factories;
using _04.WildFarm.Factories.Interfaces;
using _04.WildFarm.Interfaces;
using _04.WildFarm.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            int line = 0;
            string command;
            IAnimalFactory animalfactory = new AnimalFactory();
            IFoodFactory foodfactory = new FoodFactory();
            List<IAnimal> animals = new List<IAnimal>();
            while ((command = Console.ReadLine()) != "End")
            {
                if (line % 2 == 0)
                {
                    IAnimal animal = animalfactory.CreateAnimal(command.Split(" ", StringSplitOptions.RemoveEmptyEntries));
                    animals.Add(animal);
                }
                else
                {
                    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    IFood food = foodfactory.CreateFood(tokens[0], int.Parse(tokens[1]));
                    IAnimal animal = animals[line / 2];
                    Console.WriteLine(animal.AskForFood());
                    if (animal.FoodToEat.Contains(food.GetType().Name))
                    {
                        animal.Eat(food);
                    }
                    else
                    {
                        Console.WriteLine($"{animal.GetType().Name} does not eat {food.GetType().Name}!");
                    }
                }
                line++;
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
