using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> players = new Queue<string>(Console.ReadLine().Split());
            int tosses = int.Parse(Console.ReadLine());
            int toss = 1;
            while (players.Count != 1)
            {
                players.Enqueue(players.Peek());
                players.Dequeue();
                toss++;
                if (toss == tosses)
                {
                    Console.WriteLine($"Removed {players.Peek()}");
                    players.Dequeue();
                    toss = 1;
                }
                
            }
            Console.WriteLine($"Last is {players.Peek()}");

        }
    }
}
