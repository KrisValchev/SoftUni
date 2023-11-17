using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.BorderControl.Interfaces;

namespace _04.BorderControl.Models
{
    public class Citizen : IEnterer
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            Id = id;
        }

        public string Id { get; set; }

    }
}
