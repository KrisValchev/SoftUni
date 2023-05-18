namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfDigits = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 0;
            bool isItSpecial = false;
            for (int number = 1; number <= numOfDigits; number++)
            {
                currentNumber = number;
                while (number > 0)
                {
                    sum += number % 10;
                    number= number / 10;
                }
                isItSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber,isItSpecial);
                sum = 0;
                number = currentNumber;
            }

        }
    }
}