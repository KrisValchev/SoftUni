using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> songsOrder = new Queue<string>(songs);
            while (songsOrder.Count > 0)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[0] == "Play")
                {
                    songsOrder.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    command.RemoveAt(0);
                    string song = string.Join(" ", command);
                    //if it is a array we can skip the first index by doing this command.Skip(1)
                    if (songsOrder.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songsOrder.Enqueue(song);
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ",songsOrder));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
