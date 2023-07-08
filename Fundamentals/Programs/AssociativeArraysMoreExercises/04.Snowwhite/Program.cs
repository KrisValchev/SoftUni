using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> hatAndPhysics = new Dictionary<string, int>();
            List<Dwarf> dwarves = new List<Dwarf>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" <:> ");
                if (input[0] == "Once upon a time") break;
                string dwarfName = input[0];
                string dwarfHatColor = input[1];
                int dwarfPhysics = int.Parse(input[2]);
                if (dwarves.Exists(x => x.Name == dwarfName))
                {
                    if (dwarves.Find(x => x.Name == dwarfName).HatColor == dwarfHatColor)
                    {
                        if (dwarves.Find(x => x.Name == dwarfName).Physics < dwarfPhysics)
                        {
                            dwarves.Find(x => x.Name == dwarfName).Physics = dwarfPhysics;
                        }
                    }
                    else
                    {
                        if (!hatAndPhysics.ContainsKey(dwarfHatColor))
                        {
                            hatAndPhysics.Add(dwarfHatColor, 0);
                        }
                        else
                        {
                            hatAndPhysics[dwarfHatColor]++;
                        }
                        Dwarf dwarf = new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics);
                        dwarves.Add(dwarf);
                    }
                }
                else
                {
                    if (!hatAndPhysics.ContainsKey(dwarfHatColor))
                    {
                        hatAndPhysics.Add(dwarfHatColor, 0);
                    }
                    else
                    {
                        hatAndPhysics[dwarfHatColor]++;
                    }
                    Dwarf dwarf = new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics);
                    dwarves.Add(dwarf);

                }
            }
            foreach (var dwarf in dwarves.OrderByDescending(x => x.Physics).ThenByDescending(x => hatAndPhysics[x.HatColor]))
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
    class Dwarf
    {
        public Dwarf(string name, string hatColor, int physics)
        {
            Name = name;
            HatColor = hatColor;
            Physics = physics;
        }
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }

    }

}
