using System.Runtime.InteropServices;

namespace _02.CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double distanceFromCenterX1Y1 = DistanceFromCenter(x1, y1);
            double distanceFromCenterX2Y2 = DistanceFromCenter(x2, y2);

            if(distanceFromCenterX1Y1<=distanceFromCenterX2Y2)
                Console.WriteLine($"({x1}, {y1})");
            else
                Console.WriteLine($"({x2}, {y2})");
            
            

        }
        static double DistanceFromCenter(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}