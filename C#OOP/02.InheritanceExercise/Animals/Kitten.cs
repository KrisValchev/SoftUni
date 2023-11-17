using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten:Cat
    {
        public Kitten(string name, int age) : base(name, age, Gender)
        {

        }
        private const string Gender = "Female";
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
