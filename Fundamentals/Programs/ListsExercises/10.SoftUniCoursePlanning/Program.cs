using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine()
               .Split(", ")
               .ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Split(":");
                if (command[0] == "course start")
                {
                    for (int i = 0; i < courses.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{courses[i]}");
                    }
                    break;
                }
                switch (command[0])
                {
                    case "Add":
                        AddLesson(courses, command[1]);
                        break;
                    case "Insert":
                        int index = int.Parse(command[2]);
                        Insert(courses, command[1], index);
                        break;
                    case "Remove":
                        Remove(courses, command[1]);
                        break;
                    case "Swap":
                        Swap(courses, command[1], command[2]);
                        break;
                    case "Exercise":
                        Exercise(courses, command[1]);
                        break;
                }
            }
        }
        static List<string> AddLesson(List<string> list, string title)
        {
            if (!list.Contains(title))
            {
                list.Add(title);
            }
            return list;
        }
        static List<string> Insert(List<string> list, string title, int index)
        {
            if (!list.Contains(title))
            {
                list.Insert(index, title);
            }
            return list;
        }
        static List<string> Remove(List<string> list, string title)
        {
            if (list.Contains(title))
            {
                list.Remove(title);
                if (list.Contains(title + "-Exercise"))
                {
                    list.Remove(title + "-Exercise");
                }
            }
            return list;
        }
        static List<string> Swap(List<string> list, string title1, string title2)
        {
            if (list.Contains(title1) && list.Contains(title2))
            {
                if (list.IndexOf(title1) < list.IndexOf(title2))
                {
                    list[list.IndexOf(title1)] = title2;
                    list[list.LastIndexOf(title2)] = title1;
                }
                else
                {
                    list[list.LastIndexOf(title1)] = title2;
                    list[list.IndexOf(title2)] = title1;
                }
                if (list.Contains(title1 + "-Exercise"))
                {
                    list.Remove(title1 + "-Exercise");
                    list.Insert(list.IndexOf(title1) + 1, title1 + "-Exercise");
                }
                if (list.Contains(title2 + "-Exercise"))
                {
                    list.Remove(title2 + "-Exercise");
                    list.Insert(list.IndexOf(title2) + 1, title2 + "-Exercise");
                }
            }
            return list;
        }
        static List<string> Exercise(List<string> list, string lessonTitle)
        {
            if (list.Contains(lessonTitle) && !list.Contains(lessonTitle + "-Exercise"))
            {
                list.Insert(list.IndexOf(lessonTitle) + 1, lessonTitle + "-Exercise");
            }
            else if (list.Contains(lessonTitle) == false)
            {
                list.Add(lessonTitle);
                list.Add(lessonTitle + "-Exercise");
            }
            return list;
        }
    }
}
