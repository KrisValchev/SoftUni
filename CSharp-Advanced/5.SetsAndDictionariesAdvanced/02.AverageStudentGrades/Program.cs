using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentAndGrades = new Dictionary<string, List<decimal>>();
            int numOfStudents =int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfStudents; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];
                decimal grade =decimal.Parse(command[1]);
                if(studentAndGrades.ContainsKey(name))
                {
                    studentAndGrades[name].Add(grade);
                }
                else
                {
                    studentAndGrades.Add(name, new List<decimal>{grade});
                }
            }
            foreach (var student in studentAndGrades)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ",student.Value.Select(grade=>$"{grade:f2}"))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
