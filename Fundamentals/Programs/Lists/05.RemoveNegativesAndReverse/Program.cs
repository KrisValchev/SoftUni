namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            list.Reverse();
            if (list.Count > 0)
                Console.WriteLine(string.Join(" ", list));
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}