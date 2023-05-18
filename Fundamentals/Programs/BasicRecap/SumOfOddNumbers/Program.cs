namespace SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int odd = 1;
            for (int i = 1; i <= n; i ++)
            {
                sum += odd;
                Console.WriteLine(odd);
                 odd = odd +2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}