using System.Runtime.ExceptionServices;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fistrLineNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondLineNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < fistrLineNumbers.Length; i++)
            {
                if (fistrLineNumbers[i] == secondLineNumbers[i])
                {
                    sum += fistrLineNumbers[i];
                    continue;
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}