namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string reversedInput = String.Empty;
            for (int i = input.Length-1; i >=0; i--)
            {
                reversedInput += input[i];
            }
            Console.WriteLine(reversedInput);
        }
    }
}