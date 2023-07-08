using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "buy") break;
                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                if (!products.Exists(x=>x.Name==name))
                {
                    products.Add(new Product(name,price, quantity));
                }
                else
                {
                    products.Find(x => x.Name == name).Price = price;
                    products.Find(x => x.Name == name).Quantity += quantity;
                }
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} -> {product.Quantity*product.Price:f2}");
            }
        }
    }
    class Product
    {
        public Product(string name,double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
