namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToList();
            int[] power=Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == power[0])
                {
                    for (int j = 0; j < power[1]; j++)
                    {
                        if (numbers.IndexOf(power[0]) - 1 >= 0)
                        {
                            numbers.RemoveAt(numbers.IndexOf(power[0]) - 1);
                        }
                        if (numbers.IndexOf(power[0]) + 1 <= numbers.Count - 1)
                        {
                            numbers.RemoveAt(numbers.IndexOf(power[0]) + 1);
                        }
                    }
                numbers.Remove(power[0]);
                    i -= 1;
                }
            }
            
            Console.WriteLine(numbers.Sum());

        }
    }
}