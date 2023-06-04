namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            switch (product)
            {
                case "coffee":
                    PriceOfCoffee(quantity);
                    break;
                case "water":
                    PriceOfWater(quantity);
                    break;
                case "coke":
                    PriceOfCoke(quantity);
                    break;
                case "snacks":
                    PriceOfSnacks(quantity);
                    break;
            }
        }
        static void PriceOfCoffee(int quantity)
        {
            Console.WriteLine($"{quantity*1.50:f2}");
        }
        static void PriceOfWater(int quantity)
        {
            Console.WriteLine($"{quantity * 1.0:f2}");
        }
        static void PriceOfCoke(int quantity)
        {
            Console.WriteLine($"{quantity * 1.40:f2}");
        }
        static void PriceOfSnacks(int quantity)
        {
            Console.WriteLine($"{quantity * 2.0:f2}");
        }
    }
}