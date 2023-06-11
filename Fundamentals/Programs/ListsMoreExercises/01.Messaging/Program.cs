namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            string message = Console.ReadLine();
            for (int i = 0; i < numbers.Count; i++)
            {

            }
        }
        static int CalculateTheSumOfDigit(List<int> list, int index)
        {
           int sum = 0;
            while (list[index] != 0)
            {
                sum += list[index] % 10;
                list[index] /= 10;
            }
        }
    }
}