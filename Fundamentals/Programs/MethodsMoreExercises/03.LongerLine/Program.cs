namespace _03.LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double line1 = Line(x1, y1, x2, y2);
            double line2 = Line(x3, y3, x4, y4);
            if (line1 >= line2)
            {

                double distanceFromCenterX1Y1 = DistanceFromCenter(x1, y1);
                double distanceFromCenterX2Y2 = DistanceFromCenter(x2, y2);
                if (distanceFromCenterX1Y1 <= distanceFromCenterX2Y2)
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                else
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else if (line1 < line2)
            {
                double distanceFromCenterX1Y1 = DistanceFromCenter(x3, y3);
                double distanceFromCenterX2Y2 = DistanceFromCenter(x4, y4);
                if (distanceFromCenterX1Y1 <= distanceFromCenterX2Y2)
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                else
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");

            }

        }
        static double DistanceFromCenter(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
        static double Line(double x1, double y1, double x2, double y2)
        {
            return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
        }
    }
}