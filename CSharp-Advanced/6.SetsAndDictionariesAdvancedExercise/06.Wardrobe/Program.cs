using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> colorsAndClothes = new Dictionary<string, Dictionary<string, int>>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split(" -> ");
                string color = command[0];
                string[] clothe = command[1].Split(",");
                for (int j = 0; j < clothe.Length; j++)
                {

                    if (colorsAndClothes.ContainsKey(color))
                    {
                        if (colorsAndClothes[color].ContainsKey(clothe[j]))
                        {
                            colorsAndClothes[color][clothe[j]]++;
                        }
                        else
                        {
                            colorsAndClothes[color].Add(clothe[j], 1);
                        }
                    }
                    else
                    {
                        colorsAndClothes.Add(color, new Dictionary<string, int>());
                        colorsAndClothes[color].Add(clothe[j], 1);
                    }
                }
            }
            string[] itemToSearch = Console.ReadLine().Split();
            string colorToSearch = itemToSearch[0];
            string clotheToSearch = itemToSearch[1];
            foreach (var colorAndClothe in colorsAndClothes)
            {
                Console.WriteLine($"{colorAndClothe.Key} clothes:");
                foreach (var clothe in colorAndClothe.Value)
                {
                    if (colorAndClothe.Key == colorToSearch && clothe.Key == clotheToSearch)
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                }
            }
        }
    }
}
