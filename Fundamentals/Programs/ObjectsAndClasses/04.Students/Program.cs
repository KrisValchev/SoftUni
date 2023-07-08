using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if(command[0]=="end")
                {
                    string town = Console.ReadLine();
                List<Students> filteredList = students.Where(x=>x.HomeTown==town).ToList();
                    foreach (Students filteredStudent in filteredList)
                    {
                        Console.WriteLine($"{filteredStudent.FirstName} {filteredStudent.LastName} is {filteredStudent.Age} years old.");
                    }
                    break;
                }
                string firstName = command[0];
                string lastName = command[1];
                string age = command[2];
                string homeTown = command[3];
                Students student = new Students(firstName, lastName, age, homeTown);
                students.Add(student);
            }
        }
    }
    class Students
    {
        public Students(string firstName, string lastName, string age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeTown { get; set; }
        public string Age { get; set; }
    }
}
