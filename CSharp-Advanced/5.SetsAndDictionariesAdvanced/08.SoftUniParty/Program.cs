using System;
using System.Linq;
using System.Collections.Generic;
namespace _08.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string guest;
            HashSet<string> guests = new HashSet<string>();
            while ((guest = Console.ReadLine()) != "PARTY")
            {
                guests.Add(guest);
            }
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                guests.Remove(command);
            }
            Console.WriteLine(guests.Count);
            foreach (var person in guests.OrderByDescending(n=>char.IsDigit(n[0])))
            {
                Console.WriteLine(person);
            }

        }
    }
}
