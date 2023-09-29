namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> printNames = x => Console.WriteLine("Sir "+ x);
            foreach (var name in Console.ReadLine().Split())
            {
                printNames(name);
            }
        }
    }
}