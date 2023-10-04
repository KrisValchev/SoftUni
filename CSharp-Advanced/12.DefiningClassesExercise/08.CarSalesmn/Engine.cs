using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesmn
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Engine()
        {
            this.Displacement = 0;
            this.Efficiency = string.Empty;
        }
        public Engine(string model,int power):this()
        {
            this.Model = model;
            this.Power = power;
        }
        public override string ToString()
        {
            string displacement;
            if (this.Displacement == 0)
            {
                displacement = "n/a";
            }
            else
            {
                displacement = (this.Displacement).ToString();
            }
            string efficiency;
            if (this.Efficiency == string.Empty)
            {
                efficiency = "n/a";
            }
            else
            {
                efficiency = (this.Efficiency).ToString();
            }
            return $"{Model}:\n    Power: {Power}\n    Displacement: {displacement}\n    Efficiency: {efficiency}";
        }
    }
}
