namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(MiddleCharacter(s));
        }
        static string MiddleCharacter(string s)
        {
            string middleCharacter = "";
            if (s.Length % 2 != 0)
                return middleCharacter = s[s.Length / 2].ToString();
            else
                return middleCharacter = s[s.Length / 2-1].ToString() + s[s.Length / 2].ToString();
        }
    }
}