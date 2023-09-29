namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isUppercaseLetter = x => char.IsUpper(x[0]);
            Console.WriteLine(string.Join("\n",Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Where(isUppercaseLetter).ToArray()));
        }
    }
}