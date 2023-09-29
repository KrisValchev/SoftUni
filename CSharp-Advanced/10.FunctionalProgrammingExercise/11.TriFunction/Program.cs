using System.Diagnostics.CodeAnalysis;

namespace _11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> isSumSmaller = (name, sum) => name.Sum(x => x) >= sum;
            Func<string[], int, Func<string, int, bool>,string> getName=(names,sum,match)=> names.FirstOrDefault(name => match(name, sum));
            int sum =int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Console.WriteLine(getName(names,sum,isSumSmaller));

        }
    }
}