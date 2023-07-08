using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPairs = int.Parse(Console.ReadLine());
            var studentsAndGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < numOfPairs; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if(!studentsAndGrades.ContainsKey(name))
                {
                    studentsAndGrades.Add(name, new List<double>());
                    studentsAndGrades[name].Add(grade);
                }
                else
                {
                    studentsAndGrades[name].Add(grade);
                }
            }
            foreach (var student in studentsAndGrades)
            {
                if(student.Value.Average()>=4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}
