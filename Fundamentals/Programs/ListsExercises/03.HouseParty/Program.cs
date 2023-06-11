using System.Xml.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> names= new List<string>();
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[2] == "not")
                {
                    if (names.Contains(input[0])==false)
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                    else
                        names.Remove(input[0]);
                }
                else
                {
                    if (names.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                        names.Add(input[0]);
                }
            }
            for (int i = 0; i < names.Count; i++)
            {

                Console.WriteLine(names[i]);
            }
        }
    }
}