namespace _01.ConvertMetersToKilometres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(double)meters/1000:f2}");
        }
    }
}