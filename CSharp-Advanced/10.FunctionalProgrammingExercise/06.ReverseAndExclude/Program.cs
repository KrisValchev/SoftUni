namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Reverse(numbers);
            int divisbleNumber =int.Parse(Console.ReadLine());
            Predicate<int> isDivisible = x => x % divisbleNumber != 0;
            Console.WriteLine(string.Join(" ", numbers.Where(x=>isDivisible(x)).ToArray()));
        }
    }
}