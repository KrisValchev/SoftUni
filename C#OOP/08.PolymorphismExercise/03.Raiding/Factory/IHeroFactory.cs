using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Raiding.Interfaces;

namespace _03.Raiding.Factory
{
    public interface IHeroFactory
    {
        IHero CreateHero(string type, string name);
    }
}
