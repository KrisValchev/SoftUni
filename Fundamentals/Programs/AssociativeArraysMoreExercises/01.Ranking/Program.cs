using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestAndPasswords = new Dictionary<string, string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(":");
                if (input[0] == "end of contests") break;
                string contestName = input[0];
                string pw = input[1];
                contestAndPasswords.Add(contestName, pw);
            }
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split("=>");
                if (input[0] == "end of submissions") break;
                string contestName = input[0];
                string pw = input[1];
                string username = input[2];
                int points = int.Parse(input[3]);
                if (contestAndPasswords.ContainsKey(contestName) && contestAndPasswords.ContainsValue(pw))
                {

                    if (users.ContainsKey(username) && users[username].ContainsKey(contestName))
                    {
                        if (points > users[username][contestName])
                        {
                            users[username][contestName] = points;
                        }
                    }
                    else if (users.ContainsKey(username))
                    {
                        users[username].Add(contestName, points);
                    }
                    else
                    {
                        users.Add(username, new Dictionary<string, int>());
                        users[username].Add(contestName, points);

                    }
                }
            }
            string bestUser = "";
            int bestPoints = 0;
            foreach (var user in users)
            {
                if (user.Value.Values.Sum() > bestPoints)
                {
                    bestPoints = user.Value.Values.Sum();
                    bestUser = user.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (var user in users)
            {
                Console.WriteLine(user.Key);
                Console.WriteLine(String.Join("\n", user.Value
                                              .OrderByDescending(x => x.Value)
                                              .Select(y => $"#  {y.Key} -> {y.Value}")));

            }
        }
    }
}
