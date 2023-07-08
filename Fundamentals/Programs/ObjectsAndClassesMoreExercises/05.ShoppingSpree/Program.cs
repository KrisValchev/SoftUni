using System;
using System.Linq;
using System.Collections.Generic;
namespace _05.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personAndMoney = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            for (int i = 0; i < personAndMoney.Length; i++)
            {
                string personName = personAndMoney[i].Split("=", StringSplitOptions.RemoveEmptyEntries)[0];
                double money = double.Parse(personAndMoney[i].Split("=", StringSplitOptions.RemoveEmptyEntries)[1]);
                Person person = new Person(personName, money);
                people.Add(person);
            }
            string[] productAndCost = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Product> products = new List<Product>();
            for (int i = 0; i < productAndCost.Length; i++)
            {
                string productName = productAndCost[i].Split("=", StringSplitOptions.RemoveEmptyEntries)[0];
                double cost = double.Parse(productAndCost[i].Split("=", StringSplitOptions.RemoveEmptyEntries)[1]);
                Product product = new Product(productName, cost);
                products.Add(product);

            }
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if(input[0]=="END")
                {
                    break;
                }
                Person person = people.Find(x => x.Name == input[0]);
                Product product = products.Find(x => x.Name == input[1]);
                if (people.Find(x=>x.Name==input[0]).Money>=products.Find(x=>x.Name==input[1]).Cost)
                {

                    Console.WriteLine($"{person.Name} bought {product.Name}");
                    double moneyLeft = person.Money - product.Cost;
                    person.Money = moneyLeft;
                    person.Products.Add(product);
                }
                else
                { 
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
            }
            foreach (Person person in people)
            {
                if (person.Products.Count != 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(x=>x.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }
        
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> Products { get; set; }
    }
    class Product
    {
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
