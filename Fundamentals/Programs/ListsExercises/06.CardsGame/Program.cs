using System.Collections.Generic;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToList();
            List<int> deck2 = Console.ReadLine()
                         .Split()
                         .Select(int.Parse)
                         .ToList();
            int winingCard = 0;
            int losingCard = 0;
            while(true)
            {
                if (deck1[0] > deck2[0])
                {
                    winingCard = deck1[0];
                    losingCard = deck2[0];
                    deck1.Remove(deck1[0]);
                    deck2.Remove(deck2[0]);
                    deck1.Add(winingCard);
                    deck1.Add(losingCard);
                }
                else if(deck1[0] < deck2[0])
                {
                    winingCard = deck2[0];
                    losingCard = deck1[0];
                    deck2.Remove(deck2[0]);
                    deck1.Remove(deck1[0]);
                    deck2.Add(winingCard);
                    deck2.Add(losingCard);
                }
                else
                {
                    deck2.Remove(deck2[0]);
                    deck1.Remove(deck1[0]);
                }
                if (deck1.Count == 0 || deck2.Count == 0) break;
            }
            if(deck1.Count==0) 
                Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");
            else
                Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");

        }
    }
}