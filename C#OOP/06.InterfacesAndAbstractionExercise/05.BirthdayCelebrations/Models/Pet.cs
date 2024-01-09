using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BirthdayCelebrations.Models
{
    public class Pet : IBirthable
    {
        private string name;

        public Pet(string name, string birthdate)
        {
            this.name = name;
            Birthdate = birthdate;
        }

        public string Birthdate { get; set; }
    }
}
