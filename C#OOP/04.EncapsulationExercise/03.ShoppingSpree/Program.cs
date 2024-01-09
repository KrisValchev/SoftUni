using System.Diagnostics.Metrics;
using System.Linq.Expressions;

namespace _03.ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
                List<Person> people = new List<Person>();
                List<Product> products = new List<Product>();
            try
            {
                string[] personAndMoney = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < personAndMoney.Length; i++)
                {
                    string name = personAndMoney[i].Split('=', StringSplitOptions.RemoveEmptyEntries)[0];
                    decimal money = decimal.Parse(personAndMoney[i].Split('=', StringSplitOptions.RemoveEmptyEntries)[1]);
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                string[] productAndCost = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < productAndCost.Length; i++)
                {
                    string name = productAndCost[i].Split('=', StringSplitOptions.RemoveEmptyEntries)[0];
                    decimal cost = decimal.Parse(productAndCost[i].Split('=', StringSplitOptions.RemoveEmptyEntries)[1]);
                    Product product = new Product(name, cost);
                    products.Add(product);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string personName = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
                string productName = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                people.Find(x => x.Name == personName).BuyProduct(products.Find(x => x.Name == productName));
            }
            foreach (var person in people)
            {
                if (person.BagOfProducts.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }


        }
    }
}