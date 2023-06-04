namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine(  Calculate(number1,@operator,number2));
        }
        static double Calculate(double a, string @operator, double b)
        {
            switch(@operator)
            {
                case "*":
                    return a * b;
                case "+":
                    return a + b;
                case "/":
                    return a / b;
                case "-":
                    return a - b;
            }
            return 0;
        }
    }
}