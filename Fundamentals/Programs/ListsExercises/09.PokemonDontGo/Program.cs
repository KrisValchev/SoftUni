using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> removedElements = new List<int>();
            int removedElementIndex = 0;
            while (distances.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    removedElements.Add(distances[0]);
                    distances[0] = distances[distances.Count - 1];
                }
                else if (index > distances.Count - 1)
                {
                    removedElements.Add(distances[distances.Count - 1]);
                    distances[distances.Count - 1] = distances[0];
                }
                else
                {
                    removedElements.Add(distances[index]);
                    distances.RemoveAt(index);
                }
                for (int i = 0; i < distances.Count; i++)
                {
                    if (distances[i] <= removedElements[removedElementIndex])
                        distances[i] += removedElements[removedElementIndex];
                    else
                        distances[i] -= removedElements[removedElementIndex];
                }
                removedElementIndex++;
            }
            Console.WriteLine(removedElements.Sum());
        }
    }
}
