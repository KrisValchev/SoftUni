namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            DivideFactorials(number1, number2);
        }
        static void DivideFactorials(int n1, int n2)
        {
            double fac1 = 1;
            double fac2 = 1;
            for (int i = 1; i <= n1; i++)
            {
                fac1 *= i;
            }
            for (int i = 1; i <= n2; i++)
            {
                fac2 *= i;
            }
            Console.WriteLine($"{fac1 / fac2:f2}");
        }
    }
}