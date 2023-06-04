namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basE = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(basE,power));
        }
        static double Power(double basE,int power)
        {
            double multiply = 1;
            for (int i = 0; i < power; i++)
            {
                multiply = multiply* basE;
            }
            return multiply;
        }
    }
}