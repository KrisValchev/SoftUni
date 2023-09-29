namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nameLenght =int.Parse(Console.ReadLine());
            Predicate<string> isEqualOrLess = x => x.Length <= nameLenght;
            Console.WriteLine(string.Join("\n",Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Where(x=>isEqualOrLess(x))));
        }
    }
}