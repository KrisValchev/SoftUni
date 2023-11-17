using _06.FoodShortage.Interfaces;
using _06.FoodShortage.Models;

namespace _06.FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();
            int totalAmount = 0;
            for (int i = 0; i < lines; i++)
            {

                string[] tokens = Console.ReadLine().Split();
                if (tokens.Length == 4)
                {
                    IBuyer citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                    buyers.Add(citizen);
                }
                else
                {
                    IBuyer rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    buyers.Add(rebel);
                }

            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string name = command;
                if(buyers.Exists(x=>x.Name== name))
                {
                   buyers.Find(x => x.Name == name).BuyFood();
                }
            }
            Console.WriteLine(buyers.Sum(x=>x.Food));
        }
    }
}