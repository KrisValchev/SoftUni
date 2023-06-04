namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            Console.WriteLine(CharactersInRange(symbol1,symbol2));
        }
        static string CharactersInRange(char starting, char ending)
        {
            string line = "";
            if(ending<starting)
            {
                for (int i = ending+1; i < starting; i++)
                {
                    line +=(char)i+" ";
                }
            }
            else
            {
                for (int i = starting+1; i < ending; i++)
                {
                    line += (char)i+" ";
                }
            }
            return line.Trim();
        }
    }
}