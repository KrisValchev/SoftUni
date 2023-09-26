using System;
using System.Collections.Generic;
using System.Linq;
namespace _10.ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> forceSidesAndForceUsers = new Dictionary<string, HashSet<string>>();
            string input;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {

                if (input.Contains("|"))
                {
                    string[] command = input.Split(" | ");
                    string forceSide = command[0];
                    string forceUser = command[1];
                    if (!forceSidesAndForceUsers.Values.Any(x => x.Contains(forceUser)))
                    {
                        if (forceSidesAndForceUsers.ContainsKey(forceSide))
                        {
                            forceSidesAndForceUsers[forceSide].Add(forceUser);
                        }
                        else
                        {
                            forceSidesAndForceUsers.Add(forceSide, new HashSet<string> { forceUser });
                        }
                    }
                }
                else
                {
                    string[] command = input.Split(" -> ");
                    string forceSide = command[1];
                    string forceUser = command[0];
                    foreach (var sideAndUser in forceSidesAndForceUsers)
                    {
                        if(sideAndUser.Value.Contains(forceUser))
                        {
                            sideAndUser.Value.Remove(forceUser);
                            break;
                        }
                    }
                    if (!forceSidesAndForceUsers.ContainsKey(forceSide))
                    {
                        forceSidesAndForceUsers.Add(forceSide, new HashSet<string> { forceUser });
                    }
                    else
                    {
                        forceSidesAndForceUsers[forceSide].Add(forceUser);
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }
            foreach (var forceSideAndUsers in forceSidesAndForceUsers.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                if (forceSideAndUsers.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {forceSideAndUsers.Key}, Members: {forceSideAndUsers.Value.Count}");

                    foreach (var user in forceSideAndUsers.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
