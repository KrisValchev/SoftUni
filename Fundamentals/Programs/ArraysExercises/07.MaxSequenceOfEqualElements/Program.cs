namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countOfEqualElements = 0;
            string sequenceOfEqualElements = string.Empty;
            for (int i = numbers.Length-1; i >=0; i--)
            {
            int currentcountOfEqualElements = 0;
            string currentsequenceOfEqualElements = string.Empty;
                for (int j = i; j >= 0; j--)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentcountOfEqualElements++;
                        currentsequenceOfEqualElements += numbers[i] + " ";
                    }
                    else break;
                }
              if(currentcountOfEqualElements>=countOfEqualElements)
                {
                    countOfEqualElements = currentcountOfEqualElements;
                    sequenceOfEqualElements = currentsequenceOfEqualElements;
                }
            }
            Console.WriteLine(sequenceOfEqualElements.Trim());
        }
    }
}