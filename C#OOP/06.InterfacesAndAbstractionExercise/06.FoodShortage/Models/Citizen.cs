using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06.FoodShortage.Interfaces;

namespace _06.FoodShortage.Models
{
    public class Citizen : IBuyer
    {
        public string Name { get; set; }
        private int age;

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            this.age = age;
            Id = id;
            Birthdate = birthdate;
            food = 0;
        }

        public string Id { get; set; }
        public string Birthdate { get; set; }
        private int food;
        public int Food { get { return food; } }

        public void BuyFood()
        {
            food += 10;
        }
    }
}
