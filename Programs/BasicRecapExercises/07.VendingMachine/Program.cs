namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 0;
            string command = Console.ReadLine();
            while (command != "Start")
            {
                double coins = double.Parse(command);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    money += coins;
                }
                else Console.WriteLine($"Cannot accept {coins}");
                command = Console.ReadLine();
            }
            while (true)
            {
                double pricePerProduct = 0;
                command = Console.ReadLine();
                if (command == "End") break;
                switch (command)
                {
                    case "Nuts":
                        pricePerProduct = 2; break;
                    case "Water":
                        pricePerProduct = 0.7; break;
                    case "Crisps":
                        pricePerProduct = 1.5; break;
                    case "Soda":
                        pricePerProduct = 0.8; break;
                    case "Coke":
                        pricePerProduct = 1; break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                        
                }
                if (pricePerProduct == 0) continue;
                if (pricePerProduct <= money)
                {
                    money -= pricePerProduct;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                else Console.WriteLine("Sorry, not enough money");
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}