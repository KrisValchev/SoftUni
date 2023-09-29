using System.Text;

namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Predicate<int>> predicates=new List<Predicate<int>>();
            int endRange =int.Parse(Console.ReadLine());
            HashSet<int> dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToHashSet();
            int[] numbers = Enumerable.Range(1, endRange).ToArray();
            foreach (var divider in dividers)
            {
                predicates.Add(n => n % divider == 0);
            }
            foreach (var number in numbers)
            {
                bool isDivisble = true;
                foreach (var match in predicates)
                {
                    if(!match(number))
                    {
                        isDivisble = false;
                        break;
                    }
                }
                if (isDivisble)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}