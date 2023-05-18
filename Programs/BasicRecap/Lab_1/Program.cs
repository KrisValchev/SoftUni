using System;
namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameStudent = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade= double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {nameStudent}, Age: { age}, Grade: {averageGrade:f2}");
        }
    }
}