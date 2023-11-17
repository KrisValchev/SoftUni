using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "Beast!")
            {
                string type = command;
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (type)
                    {
                        case "Dog":
                            Dog dog = new Dog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            PrintAnimal(type, dog);
                            break;
                        case "Frog":
                            Frog frog = new Frog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            PrintAnimal(type, frog);
                            break;
                        case "Cat":
                            Cat cat = new Cat(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            PrintAnimal(type, cat);
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(tokens[0], int.Parse(tokens[1]));
                            PrintAnimal(type, kitten);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(tokens[0], int.Parse(tokens[1]));
                            PrintAnimal(type, tomcat);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static void PrintAnimal<T>(string animalType, T animal) where T : Animal
        {
            Console.WriteLine(animalType);
            Console.WriteLine(animal);
        }
    }
}
