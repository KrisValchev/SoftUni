namespace _10.MultyplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(number),GetSumOfOddDigits(number)));
        }
        static int GetSumOfEvenDigits(int number)
        {
            string numberInString = Math.Abs(number).ToString();
            int sumOfEvenDigits = 0;
            for (int i = 0; i < numberInString.Length; i++)
            {
                if (numberInString[i] % 2 == 0) sumOfEvenDigits +=int.Parse(numberInString[i].ToString());
            }
            return sumOfEvenDigits;
        }
        static int GetSumOfOddDigits(int number)
        {
            string numberInString = Math.Abs(number).ToString();
            int sumOfOddDigits = 0;
            for (int i = 0; i < numberInString.Length; i++)
            {
                if (numberInString[i] % 2 != 0) sumOfOddDigits += int.Parse(numberInString[i].ToString());
            }
            return sumOfOddDigits;
        }
        static int GetMultipleOfEvenAndOdds(int sum1,int sum2)
        {
            return sum1 * sum2;
        }
    }
}