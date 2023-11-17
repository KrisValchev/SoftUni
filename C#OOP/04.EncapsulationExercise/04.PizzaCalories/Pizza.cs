using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;
        public Pizza(string name,Dough dough)
        {
            this.Name = name;
            this.Dough= dough;
            this.toppings=new List<Topping>();
        }
        public Dough Dough
        {
            get { return dough; }
           private set { dough = value; }
        }
        public List<Topping> Toppings
        {
            get { return toppings; }
           private set { toppings = value; }
        }

        public double TotalCalories
        {
            get { return Dough.CalculateCalories() + Toppings.Sum(x => x.CalculateCalories()); }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if(value.Length<1|| value.Length>15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        public void AddTopping(Topping topping)
        {
            if(toppings.Count==10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }
        public string CalculateTotalCalories()
        {
           
            return $"{this.Name} - {TotalCalories:f2} Calories.";
        }
    }
}
