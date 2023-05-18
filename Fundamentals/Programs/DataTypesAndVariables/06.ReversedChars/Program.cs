namespace _06.ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lines="";
            for (int i = 0; i < 3; i++)
            {
                string character= Console.ReadLine();
                lines = " "+character + lines;
            }
            Console.WriteLine(lines.Trim());
        }
    }
}