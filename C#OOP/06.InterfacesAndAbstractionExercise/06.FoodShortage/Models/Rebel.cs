using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06.FoodShortage.Interfaces;

namespace _06.FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        public string Name { get; set; }
        private int age;
        private string group;
        private int food;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            this.age = age;
            this.group = group;
            food = 0;
        }

        public int Food { get { return food; } }

        public void BuyFood()
        {
            food += 5;
        }
    }
}
