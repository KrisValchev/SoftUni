using System;
using System.Linq;
using System.Collections.Generic;
namespace _05.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dragonTypeAndName = new Dictionary<string, List<string>>();
            List<Dragon> dragons = new List<Dragon>();
            int numOfDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfDragons; i++)
            {
                string[] input = Console.ReadLine().Split();
                string type = input[0];
                string name = input[1];
                double damage = 0;
                double health = 0;
                double armor = 0;
                if (input[2] == "null") { damage = 45; }
                else { damage = int.Parse(input[2]); }
                if (input[3] == "null") { health = 250; }
                else { health = int.Parse(input[3]); }
                if (input[4] == "null") { armor = 10; }
                else { armor = int.Parse(input[4]); }

                if (dragonTypeAndName.ContainsKey(type) && dragonTypeAndName[type].Contains(name))
                {
                    Dragon dragon = dragons.Find(x => x.Name == name && x.Type == type);
                    dragon.Damage = damage;
                    dragon.Health = health;
                    dragon.Armor = armor;
                }
                else
                {
                    Dragon dragon = new Dragon(type, name, damage, health, armor);
                    dragons.Add(dragon);
                    if (dragonTypeAndName.ContainsKey(type))
                    {
                        dragonTypeAndName[type].Add(name);
                    }
                    else
                    {
                        dragonTypeAndName.Add(type, new List<string>());
                        dragonTypeAndName[type].Add(name);
                    }
                }
            }
            foreach (var dragon in dragonTypeAndName)
            {
                Console.WriteLine($"{dragon.Key}::({dragons.FindAll(x => x.Type == dragon.Key).Average(x => x.Damage):f2}/{dragons.FindAll(x => x.Type == dragon.Key).Average(x => x.Health):f2}/{dragons.FindAll(x => x.Type == dragon.Key).Average(x => x.Armor):f2})");
                foreach (var nameOfDragon in dragon.Value.OrderBy(x => x))
                {
                    List<Dragon> newListOfDragons= dragons.Where(x => x.Type == dragon.Key).ToList();
                    Console.WriteLine($"-{nameOfDragon} -> damage: {newListOfDragons.Find(x => x.Name == nameOfDragon).Damage}, health: {newListOfDragons.Find(x => x.Name == nameOfDragon).Health}, armor: { newListOfDragons.Find(x => x.Name == nameOfDragon).Armor}");
                }
            }
        }
    }
    class Dragon
    {
        public Dragon(string type, string name, double damage, double health, double armor)
        {
            Type = type;
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
    }
}
