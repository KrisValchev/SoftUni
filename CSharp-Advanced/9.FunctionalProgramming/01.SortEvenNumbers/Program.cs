namespace _01.SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> EvenNumbers = x => x % 2 == 0;
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(", ",numbers.Where(EvenNumbers).ToArray().OrderBy(x=>x)));
        }
    }
}