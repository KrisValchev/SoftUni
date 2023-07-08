using System;
using System.Linq;
using System.Collections.Generic;
namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Dictionary<string, string> typeAndCoordinates = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "find") break;
                string result = "";
                int index = 0;
                for (int i = 0; i < input.Length; i++)
                { 
                    if (index == keys.Length)
                    {
                        index = 0;
                    }
                    result += ((char)(input[i] - keys[index++])).ToString();

                }
                string type = result.Substring(result.IndexOf('&') + 1, result.LastIndexOf('&') - result.IndexOf('&') - 1);
                string coordinates = result.Substring(result.IndexOf('<') + 1, result.IndexOf('>') - result.IndexOf('<') - 1);
                typeAndCoordinates.Add(type, coordinates);
            }
            foreach (var message in typeAndCoordinates)
            {
                Console.WriteLine($"Found {message.Key} at {message.Value}");
            }
        }
    }
}
