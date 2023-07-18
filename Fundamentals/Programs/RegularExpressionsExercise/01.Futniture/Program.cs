using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _01.Futniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> boughtFurnitures = new List<string>();
            double totalPrice = 0;
            string pattern = @"\B>>(?<name>[[A-Za-z]+)<<(?<price>\d+(.\d+)?)\!(?<count>[0-9]+)";
            Regex regex = new Regex(pattern);
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Purchase") break;
                double price = 0;
                int count = 0;
                Match validCommand = regex.Match(command);
                if(validCommand.Success)
                {
                    
                    boughtFurnitures.Add(validCommand.Groups["name"].Value);
                    price = double.Parse(validCommand.Groups["price"].Value);
                    count = int.Parse(validCommand.Groups["count"].Value);
                    totalPrice += price * count;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var furniture in boughtFurnitures)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
