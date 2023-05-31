namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[numbersCount];
            int sum = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbersArray[i] = number;
                sum += number;
            }
            for (int i = 0; i < numbersArray.Length-1; i++)
            {
                Console.Write(numbersArray[i] + " ");
            }
            Console.WriteLine(numbersArray[numbersArray.Length-1]);
            Console.WriteLine(sum);
        }
    }
}