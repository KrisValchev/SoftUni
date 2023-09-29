namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lowerAndUpperBounds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lowerBound = lowerAndUpperBounds[0];
            int upperBound = lowerAndUpperBounds[1];
            string command = Console.ReadLine();
            Predicate<int> match;
            if (command == "odd")
                match = x => x % 2 != 0;
            else
                match = x => x % 2 == 0;
            List<int> numbers = new List<int>();
            for (int i = lowerBound; i <= upperBound; i++)
            {
                if(match(i))
                {
                    numbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}