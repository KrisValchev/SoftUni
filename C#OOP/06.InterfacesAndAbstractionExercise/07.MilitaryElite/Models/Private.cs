using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07.MilitaryElite.Models
{
    public  class Private : Soldier,IPrivate
    {
        public Private(int id, string firstName, string lastName,decimal salary):base(id,firstName,lastName)
        {
           Salary = salary;
        }

        public  int Id { get ; set ; }
        public  string FirstName { get ; set ; }
        public  string LastName { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return base.ToString()+$" Salary: {Salary:f2}" ;
        }
    }
}
