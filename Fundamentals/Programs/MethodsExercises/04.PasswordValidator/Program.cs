using System.Diagnostics.CodeAnalysis;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static bool validChars = false;
        static bool validConsist = true;
        static bool valid2Digits = false;
        static void Main(string[] args)
        {
            string pw = Console.ReadLine();
            DoesItContainTheNeededCharacters(pw);
            DoesItContainsOnlyLettersAndDigits(pw);
            DoesItHaveAtLeast2Digits(pw);
            if (valid2Digits && validChars && validConsist)
                Console.WriteLine("Password is valid");
        }
        static void DoesItContainTheNeededCharacters(string password)
        {
            if (password.Length < 6 || password.Length > 10)
                Console.WriteLine("Password must be between 6 and 10 characters");
            else validChars = true;

        }
        static void DoesItContainsOnlyLettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 48 && password[i] <= 57) || (password[i] >= 65 && password[i] <= 90) || (password[i] >= 97 && password[i] <= 122))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    validConsist = false ;
                    break;
                }
            }
            
        }
        static void DoesItHaveAtLeast2Digits(string password)
        {
            int sum = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 48 && password[i] <= 57))
                {
                    sum++;
                }

            }
            if (sum < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else valid2Digits = true;
        }
    }
}