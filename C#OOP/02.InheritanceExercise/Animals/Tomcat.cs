using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat:Cat
    {
        public Tomcat(string name, int age) : base(name, age, Gender)
        {

        }
        private const string Gender = "Male";
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
