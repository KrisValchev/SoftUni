using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int countOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfStudents; i++)
            {
                string[] commmand = Console.ReadLine().Split();
                string firstName = commmand[0];
                string lastName = commmand[1];
                double grade = double.Parse(commmand[2]);
                Student student = new Student(firstName,lastName,grade);
                students.Add(student);
            }
            foreach (Student student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    class Student
    {
        public Student(string firstName,string secondName, double grade)
        {
            FirstName = firstName;
            LastName = secondName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
