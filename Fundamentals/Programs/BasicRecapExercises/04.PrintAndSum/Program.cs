namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                sum += i;
                if (i == endNumber)
                {
                    Console.WriteLine(i);
                    break;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}