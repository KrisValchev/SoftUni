
namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(CountOfVowels(input));
        }
        static int CountOfVowels(string input)
        {
            int sum = 0;
            for (int j = 0; j < input.Length; j++)
            {
                char letter = input[j];
                if ("aeiouAEIOU".IndexOf(letter) >= 0)
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}