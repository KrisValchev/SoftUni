using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (true)
            {
            string[] courseAndStudent = Console.ReadLine().Split(" : ");
                if (courseAndStudent[0] == "end") break;
                if(!courses.ContainsKey(courseAndStudent[0]))
                {
                    courses.Add(courseAndStudent[0], new List<string>());
                    courses[courseAndStudent[0]].Add(courseAndStudent[1]);
                }
                else
                {
                    courses[courseAndStudent[0]].Add(courseAndStudent[1]);
                }
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach(string student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
