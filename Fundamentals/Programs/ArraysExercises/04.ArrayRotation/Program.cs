namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                int currentNumber = 0;
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    currentNumber = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = currentNumber;
                }
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine(numbers[numbers.Length - 1]);

        }
    }
}