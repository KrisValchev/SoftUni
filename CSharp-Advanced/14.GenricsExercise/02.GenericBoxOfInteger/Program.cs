namespace _02.GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                Box<int> text = new Box<int>(int.Parse(input));
                Console.WriteLine(text);
            }
        }
    }
}