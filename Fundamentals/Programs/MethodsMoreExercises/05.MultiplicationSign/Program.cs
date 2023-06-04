namespace _05.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int[] numbers = { num1, num2, num3 };
            Console.WriteLine(MultiplicationSign(numbers));
        }
        static string MultiplicationSign(int[] array)
        {
            int countOfNegative = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0) return "zero";
                if (array[i] < 0) countOfNegative++;
            }
            if (countOfNegative % 2 == 0) return "positive";
            else return "negative";
        }
    }
}