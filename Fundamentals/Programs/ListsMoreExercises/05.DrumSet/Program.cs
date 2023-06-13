using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _05.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            float budget = float.Parse(Console.ReadLine());
            List<int> qualities = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> initialQualities = new List<int>();
            for (int i = 0; i < qualities.Count; i++)
            {
                initialQualities.Add(qualities[i]);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Hit it again, Gabsy!")
                {
                    Console.WriteLine(string.Join(" ", qualities));
                    Console.WriteLine($"Gabsy has {budget:f2}lv.");
                    break;
                }
                int hitPower = int.Parse(input);

                for (int i = 0; i < qualities.Count; i++)
                {
                    
                    qualities[i] = qualities[i] - hitPower;
                    if (qualities[i] <= 0)
                    {
                        qualities[i] = initialQualities[i];
                        if (budget - initialQualities[i] * 3 <= 0)
                        {
                            qualities.RemoveAt(i);
                            initialQualities.RemoveAt(i);
                            i--;
                        }
                        else budget -= initialQualities[i] * 3;
                    }
                }
            }
        }
    }
}
