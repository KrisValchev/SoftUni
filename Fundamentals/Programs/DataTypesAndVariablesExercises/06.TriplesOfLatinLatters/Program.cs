namespace _06.TriplesOfLatinLatters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string firstLetter = ((char)('a' + i)).ToString();
                for (int j = 0; j < n; j++)
                {
                    string secondLetter = ((char)('a' + j)).ToString();
                    for (int k = 0; k < n; k++)
                    {
                    string thirdLetter = ((char)('a' + k)).ToString();
                        Console.WriteLine(firstLetter+secondLetter+thirdLetter);
                    }
                }
            }
        }
    }
}