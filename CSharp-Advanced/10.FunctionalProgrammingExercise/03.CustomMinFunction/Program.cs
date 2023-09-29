namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minNumber = x => x.Min();
            Console.WriteLine(minNumber(Console.ReadLine().Split().Select(int.Parse).ToArray()));
        }
    }
}