namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double totalSpent = 0;
            while (true)
            {
                double priceOfGame = 0;
                string game = Console.ReadLine();
                if (game == "Game Time") break;
                if (game == "OutFall 4") priceOfGame = 39.99;
                if (game == "CS: OG") priceOfGame = 15.99;
                if (game == "Zplinter Zell") priceOfGame = 19.99;
                if (game == "Honored 2") priceOfGame = 59.99;
                if (game == "RoverWatch") priceOfGame = 29.99;
                if (game == "RoverWatch Origins Edition") priceOfGame = 39.99;
                if (priceOfGame == 0)
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                if (priceOfGame <= balance)
                {
                    balance -= priceOfGame;
                    totalSpent += priceOfGame;
                    if (balance > 0)
                    {
                        Console.WriteLine($"Bought {game}");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else Console.WriteLine("Too Expensive"); 
            }
            Console.Write($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
        }
    }
}