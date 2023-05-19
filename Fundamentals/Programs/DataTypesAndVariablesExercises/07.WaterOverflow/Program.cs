using System.Diagnostics;
using System.Security.AccessControl;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int litersInTheTank = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (litersInTheTank+liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                litersInTheTank += liters;
            }
            Console.WriteLine(litersInTheTank);

        }
    }
}