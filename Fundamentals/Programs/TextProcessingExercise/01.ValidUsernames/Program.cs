using System;
using System.Text;
using System.Collections.Generic;
namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            List<string> validUsernames = new List<string>();
            for (int i = 0; i < usernames.Length; i++)
            {
                bool containsOtherSymbol = false;
                if (usernames[i].Length > 3 && usernames[i].Length < 16)
                {
                    for (int j = 0; j < usernames[i].Length; j++)
                    {
                        if(!char.IsDigit(usernames[i][j]) && !char.IsLetter(usernames[i][j]) && usernames[i][j]!='-' && usernames[i][j]!='_')
                        {
                            containsOtherSymbol = true;
                            break;
                        }
                    }
                    if (containsOtherSymbol) continue;
                    else
                    {
                        validUsernames.Add(usernames[i]);
                    }
                }
            }
            Console.WriteLine(string.Join("\n",validUsernames));
        }
    }
}
