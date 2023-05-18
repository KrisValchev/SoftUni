using System.Xml;

namespace _08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            ushort area=ushort.Parse(Console.ReadLine());
            Console.WriteLine($"Town {nameOfTown} has population of {population} and area {area} square km.");
        }
    }
}