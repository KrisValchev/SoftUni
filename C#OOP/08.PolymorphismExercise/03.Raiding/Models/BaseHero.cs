using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Raiding.Interfaces;

namespace _03.Raiding.Models
{
    public abstract class BaseHero : IHero
    {

        protected BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name { get; private set; }
        public int Power { get; private set; }
        public abstract string CastAbility();

    }
}
