namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            string lineOfCharacters = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                
                lineOfCharacters += Convert.ToChar(i) + " ";
            }
            Console.WriteLine(lineOfCharacters.Trim());
        }
    }
}