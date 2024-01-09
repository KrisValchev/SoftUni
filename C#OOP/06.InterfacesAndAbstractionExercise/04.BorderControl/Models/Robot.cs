using _04.BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BorderControl.Models
{
    public class Robot:IEnterer
    {
        private string model;

        public Robot(string model, string id)
        {
            this.model = model;
            Id = id;
        }

        public string Id { get; set; }
    }
}
