namespace EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (true)
            {
                int number = int.Parse(input);
                if (Math.Abs(number) % 2 == 0)
                {
                    Console.WriteLine("The number is: " + Math.Abs(number));
                    break;
                }
                else Console.WriteLine("Please write an even number.");
                input = Console.ReadLine();
            }
        }
    }
}