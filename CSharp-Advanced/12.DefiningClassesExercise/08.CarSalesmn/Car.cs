using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesmn
{
    public class Car
    {
		private string model;
		private int weight;
		private string color;
		private Engine engine;

		public Engine Engine
		{
			get { return engine; }
			set { engine = value; }
		}

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
        public Car()
        {
            this.Weight = 0;
            this.Color = string.Empty;
        }
        public Car(string model, Engine engine): this()
        {
            this.Model = model;
            this.Engine = engine;
        }
        public override string ToString()
        {
            string weight;
            if (this.Weight == 0)
            {
                weight = "n/a";
            }
            else
            {
                weight = (this.Weight).ToString();
            }
            string color;
            if (this.Color == string.Empty)
            {
                color = "n/a";
            }
            else
            {
                color = (this.Color).ToString();
            }
            return $"{Model}:\n  {this.Engine}\n  Weight: {weight}\n  Color: {color}";
        }
    }
}
