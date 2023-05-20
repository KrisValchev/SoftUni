namespace _04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int number = 2; number <= range; number++)
            {
                bool isItPrime = true;
                for (int numberToDivide = 2; numberToDivide < number; numberToDivide++)
                {
                    if (number % numberToDivide == 0)
                    {
                        isItPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isItPrime.ToString().ToLower()}");
            }
        }
    }
}