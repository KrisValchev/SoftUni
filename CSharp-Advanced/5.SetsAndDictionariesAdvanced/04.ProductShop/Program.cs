using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary < string,Dictionary<string, double>> shopsAndProducts = new Dictionary<string, Dictionary<string, double>>();
            while ((command=Console.ReadLine())!="Revision")
            {
                string[] shopAndProduct = command.Split(", ");
                string shop = shopAndProduct[0];
                string product = shopAndProduct[1];
                double price = double.Parse(shopAndProduct[2]);
                if(shopsAndProducts.ContainsKey(shop))
                {
                    shopsAndProducts[shop].Add(product,price);
                }
                else
                {
                    shopsAndProducts.Add(shop, new Dictionary<string, double>());
                    shopsAndProducts[shop].Add(product, price);
                }
            }
            foreach (var shop in shopsAndProducts.OrderBy(x=>x.Key))
            {
                Console.WriteLine(shop.Key+"->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
