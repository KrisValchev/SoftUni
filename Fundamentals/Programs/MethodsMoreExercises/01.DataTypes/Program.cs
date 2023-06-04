using System.ComponentModel.Design;

namespace _01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int") DoSomethingDependingOnTheDataType(int.Parse(Console.ReadLine()));
            else if (input == "real") DoSomethingDependingOnTheDataType(double.Parse(Console.ReadLine()));
            else DoSomethingDependingOnTheDataType(Console.ReadLine());

        }
        static void DoSomethingDependingOnTheDataType(int number)
        {
            Console.WriteLine(number*2);
        }
        static void DoSomethingDependingOnTheDataType(double number)
        {
            Console.WriteLine($"{number * 1.5:f2}");
        }
        static void DoSomethingDependingOnTheDataType(string text)
        {
            Console.WriteLine("$"+text+"$");
        }

    }
}