using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Raiding.Interfaces;
using _03.Raiding.Models;

namespace _03.Raiding.Factory
{
    public class HeroFactory : IHeroFactory
    {
        public IHero CreateHero(string type, string name)
        {
            switch (type)
            {
                case "Druid":
                    return new Druid(name);
                case "Warrior":
                    return new Warrior(name);
                case "Paladin":
                    return new Paladin(name);
                case "Rogue":
                    return new Rogue(name);
                default:
                    throw new ArgumentException("Invalid hero!");
            }

        }
    }
}
