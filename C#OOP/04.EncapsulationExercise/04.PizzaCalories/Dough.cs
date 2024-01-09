using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private string flour;
        private string bakingTechnique;
        private int weight;
        private double flourModifier;
        private double techniqueModifier;
        public Dough(string flour,string bakingTechnique,int weight)
        {
            this.flour = flour;
            this.bakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.TechniqueModifier = techniqueModifier;
            this.FlourModifier = flourModifier;
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                if (value <= 0 || value > 200)
                    throw new Exception("Dough weight should be in the range [1..200].");
                weight = value;

            }
        }
        public double FlourModifier
        {
            get
            {
                return flourModifier;
            }
            private set
            {
                if (flour.ToLower() == "white")
                    flourModifier = 1.5;
                else if (flour.ToLower() == "wholegrain")
                    flourModifier = 1.0;
                else
                {
                    throw new Exception("Invalid type of dough.");
                }
            }
        }
        public double TechniqueModifier
        {
            get
            {
                return techniqueModifier;
            }
            private set
            {
                if (bakingTechnique.ToLower() == "crispy")
                    techniqueModifier = 0.9;
                else if (bakingTechnique.ToLower() == "homemade")
                    techniqueModifier = 1.0;
                else if (bakingTechnique.ToLower() == "chewy")
                    techniqueModifier = 1.1;
                else
                {
                    throw new Exception("Invalid type of dough.");
                }
            }
        }
        public double CalculateCalories()
        {
            return (2 * this.weight) * this.FlourModifier * this.TechniqueModifier;
        }
    }
}
