using System.Runtime.InteropServices;

namespace _04.PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        { 
            string pizzaName= Console.ReadLine().Split()[1];
            string[] doughCharacteristics = Console.ReadLine().Split();
            string flour = doughCharacteristics[1];
            string technique = doughCharacteristics[2];
            int doughWeight = int.Parse(doughCharacteristics[3]);  
            
            try
            {
                Dough dough = new Dough(flour, technique, doughWeight);
                Pizza pizza=new Pizza(pizzaName,dough);
                string command;
                while ((command=Console.ReadLine())!="END")
                {
                    string[] toppingCharacteristics = command.Split();
                    string typeTopping = toppingCharacteristics[1];
                    int toppingWeight = int.Parse(toppingCharacteristics[2]);
                    Topping topping = new Topping(typeTopping, toppingWeight);
                    pizza.AddTopping(topping);
                }
                Console.WriteLine(pizza.CalculateTotalCalories());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}