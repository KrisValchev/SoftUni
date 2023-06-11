namespace _02.GuassTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int firstIndex = 0;
            int lastIndex = 0;
            List<int> summedNumbers = new List<int>();
            while( firstIndex!=numbers.Count/2)
            {
                summedNumbers.Add(numbers[firstIndex++] + numbers[numbers.Count-firstIndex]);
                

            }
            if(numbers.Count%2!=0)
            summedNumbers.Add(numbers[firstIndex]);
            Console.WriteLine(string.Join(" ",summedNumbers));
        }
    }
}