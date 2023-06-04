 namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string number = Console.ReadLine();
                if (number == "END") break;
                Console.WriteLine(IsItPalindrome(number).ToString().ToLower());
            }
        }
        static bool IsItPalindrome(string number)
        {
            bool palindrome = false;
            int lastDigit = number.Length - 1;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == number[lastDigit--])
                {
                    palindrome = true;
                }
                else
                {
                   return palindrome = false;
                }
            }
            return palindrome;
        }
    }
}