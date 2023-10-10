using System.Threading.Channels;

namespace _01.GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number =int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string input =Console.ReadLine();
                Box<string> text = new Box<string>(input);
                Console.WriteLine(text);
            }
        }
    }
}