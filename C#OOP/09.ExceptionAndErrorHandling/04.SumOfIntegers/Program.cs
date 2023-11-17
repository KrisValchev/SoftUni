using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace _04.SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int totalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    int number = int.Parse(numbers[i]);
                    totalSum += number;

                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{numbers[i]}' is in wrong format!"
);
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{numbers[i]}' is out of range!"
);
                }
                finally
                {
                    Console.WriteLine($"Element '{numbers[i]}' processed - current sum: {totalSum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {totalSum}"
);
        }
    }
}