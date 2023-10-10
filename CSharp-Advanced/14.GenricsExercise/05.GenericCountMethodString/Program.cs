using System.ComponentModel;

namespace _05.GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }
            Console.WriteLine(box.CountOfElementGreaterThan(Console.ReadLine()));
        }
    }
}