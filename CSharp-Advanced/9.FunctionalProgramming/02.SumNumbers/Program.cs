using System.Threading.Channels;

namespace _02.SumNumbers
{
    internal class Program
    {
        static Action<int[]> numbers = x => Console.WriteLine(x.Length + "\n" + x.Sum());
        static void Main(string[] args)
        {
            numbers(Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray());
        }
    }
}