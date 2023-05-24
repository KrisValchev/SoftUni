namespace _02.PrintNumbersInReversedOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int[] orderOfNumbers = new int[numberCount];
            for (int i = 0; i < numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                orderOfNumbers[i] = number;
            }
            for (int i = numberCount - 1; i > 0; i--)
            {
                Console.Write(orderOfNumbers[i] + " ");
            }
            Console.WriteLine(orderOfNumbers[0]);
        }
    }
}