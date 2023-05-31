namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] encryptedString = new int[lines];
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    char letter = input[j];
                    if ("aeiouAEIOU".IndexOf(letter) >= 0)
                    {
                        sum += letter * input.Length;
                    }
                    else
                    {
                        sum += letter / input.Length;
                    }
                }
                encryptedString[i] = sum;
            }
            int comparison = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = i; j < lines; j++)
                {
                    if (encryptedString[i] > encryptedString[j])
                    {
                        comparison = encryptedString[j];
                        encryptedString[j] = encryptedString[i];
                        encryptedString[i] = comparison;
                    }

                }
            }
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine(encryptedString[i]);
            }
        }
    }
}