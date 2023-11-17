using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int Power = 80;
        public Rogue(string name) : base(name, Power)
        {
        }
        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
