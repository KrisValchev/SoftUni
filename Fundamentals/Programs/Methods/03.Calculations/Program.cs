namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string function = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            switch (function)
            {
                case "add":
                    Console.WriteLine(Add(number1, number2));
                    break;
                case "multiply":
                    Console.WriteLine(Multiply(number1, number2));
                    break;
                case "subtract":
                    Console.WriteLine(Subtract(number1, number2));
                    break;
                case "divide":
                    Console.WriteLine(Divide(number1, number2));
                    break;
            }
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}