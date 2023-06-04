namespace _05.AddAndSubtract
{
    internal class Program
    {
        static int resault = 0;
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Resault(num1,num2,num3));
        }
        static int Resault(int num1, int num2,int num3)
        {
           return resault=num1+num2-num3;
        }
    }
}