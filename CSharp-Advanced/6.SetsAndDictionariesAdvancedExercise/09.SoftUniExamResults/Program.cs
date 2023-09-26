using System;
using System.Collections.Generic;
using System.Linq;
namespace _09.SoftUniExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> usersLanguagesAndPoints = new Dictionary<string, int>();
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();
            string command;
            while ((command = Console.ReadLine()) != "exam finished")
            {
                if (command.Split("-")[1] != "banned")
                {

                    string name = command.Split("-")[0];
                    string language = command.Split("-")[1];
                    int points = int.Parse(command.Split("-")[2]);
                    if (!usersLanguagesAndPoints.ContainsKey(name))
                    {
                        usersLanguagesAndPoints.Add(name, points);
                    }
                    else
                    {
                        if (usersLanguagesAndPoints[name] < points)
                        {
                            usersLanguagesAndPoints[name] = points;
                        }
                    }
                        AddLanguage(languageSubmissions, language);
                }
                else
                {
                    usersLanguagesAndPoints.Remove(command.Split("-")[0]);
                }
            }
            Console.WriteLine("Results:");
            foreach (var userAndPoints in usersLanguagesAndPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{userAndPoints.Key} | {userAndPoints.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var language in languageSubmissions.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }

        private static void AddLanguage(Dictionary<string, int> languageSubmissions, string language)
        {
            if (languageSubmissions.ContainsKey(language))
            {
                languageSubmissions[language]++;
            }
            else
            {
                languageSubmissions.Add(language, 1);
            }
        }
    }
}
