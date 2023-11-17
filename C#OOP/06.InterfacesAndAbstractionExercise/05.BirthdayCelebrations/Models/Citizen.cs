using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.BirthdayCelebrations.Models;
using Birthday.Interfaces;

namespace Birthday.Models
{
    public class Citizen : IEnterer,IBirthable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id ,string birthdate)
        {
            this.name = name;
            this.age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Id { get; set; }
        public string Birthdate { get; set; }
    }
}
