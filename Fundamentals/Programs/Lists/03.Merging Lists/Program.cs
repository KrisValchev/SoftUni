namespace _03.Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            List<int> numbers2 = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            int smallestListEnd = 0;
            bool firstIsBiggerThanSecond = false;
            if (numbers.Count > numbers2.Count)
            {
                smallestListEnd = numbers2.Count;
                firstIsBiggerThanSecond = true;
            }
            else
            {
                smallestListEnd = numbers.Count;
            }
            List<int> combinedNumbers = new List<int>();
            for (int i = 0; i < smallestListEnd; i++)
            {
                combinedNumbers.Add(numbers[i]);
                combinedNumbers.Add(numbers2[i]);
            }
            if (firstIsBiggerThanSecond)
            {
                for (int i = smallestListEnd; i < numbers.Count; i++)
                {
                    combinedNumbers.Add(numbers[i]);
                }
            }
            else
            {
                for (int i = smallestListEnd; i < numbers2.Count; i++)
                {
                    combinedNumbers.Add(numbers2[i]);
                }
            }
            Console.WriteLine(  string.Join(" ",combinedNumbers));
        }
    }
}