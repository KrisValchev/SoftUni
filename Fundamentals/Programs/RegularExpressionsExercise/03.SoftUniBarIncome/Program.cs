using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternName = @"%(?<name>[A-Z][a-z]+)%";
            string patternProduct = @"<(?<product>\w+)>";
            string patternCount = @"[|](?<count>\d+)[|]";
            string patternPrice = @"(?<price>\d+(\.\d+)?)[$]";
            Regex regexName = new Regex(patternName);
            Regex regexProduct = new Regex(patternProduct);
            Regex regexCount = new Regex(patternCount);
            Regex regexPrice = new Regex(patternPrice);
            double totalIncome = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift") break;

                Match validProdut = regexProduct.Match(input);
                Match validName = regexName.Match(input);
                Match validCount = regexCount.Match(input);
                Match validPrice = regexPrice.Match(input);
                
                if(validProdut.Success&& validName.Success&& validCount.Success&& validPrice.Success)
                {
                   string name = validName.Groups["name"].Value;
                   string product = validProdut.Groups["product"].Value;
                   int count =int.Parse( validCount.Groups["count"].Value);
                    double pricePerOne =double.Parse( validPrice.Groups["price"].Value);
                   double price = count * pricePerOne;
                    totalIncome += price;
                    Order order = new Order(name, product, price);
                    Console.WriteLine($"{order.Name}: {order.ProductName} - {order.Price:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
    class Order
    {
       public string Name { get; set; }
       public string ProductName { get; set; }
       public double Price { get; set; }
        public Order(string name, string productName,double price)
        {
            Name = name;
            ProductName = productName;
            Price = price;
        }
    }
}
