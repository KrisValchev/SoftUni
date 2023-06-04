namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height= int.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(width,height));
        }
        static double RectangleArea(double width,double height)
        {
            return width * height;
        }
    }
}