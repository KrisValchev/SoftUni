namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] usernameLetters = username.ToCharArray();
            Array.Reverse(usernameLetters);
            string password = String.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            for (int i = 1; i <= 4; i++)
            {
                string input = Console.ReadLine();
                if (input != password)
                {
                    if (i!=4) Console.WriteLine("Incorrect password. Try again.");
                    else Console.WriteLine($"User {username} blocked!");
                }
                else if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}