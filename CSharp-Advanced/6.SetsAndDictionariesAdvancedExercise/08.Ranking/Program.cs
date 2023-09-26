using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> usersContestsAndPoints = new Dictionary<string, Dictionary<string, int>>();
            string command;
            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] contestAndPW = command.Split(":");
                string contest = contestAndPW[0];
                string pw = contestAndPW[1];
                if (!contestAndPassword.ContainsKey(contest))
                {
                    contestAndPassword.Add(contest, pw);
                }
            }
            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string contest = command.Split("=>")[0];
                string pw = command.Split("=>")[1];
                string username = command.Split("=>")[2];
                int points = int.Parse(command.Split("=>")[3]);
                if (contestAndPassword.ContainsKey(contest))
                {
                    if (contestAndPassword[contest] == pw)
                    {
                        if (usersContestsAndPoints.ContainsKey(username) && usersContestsAndPoints[username].ContainsKey(contest))
                        {
                            if (usersContestsAndPoints[username][contest] < points)
                            {
                                usersContestsAndPoints[username][contest] = points;
                            }
                        }
                        else
                        {
                            if (!usersContestsAndPoints.ContainsKey(username))
                            {
                            usersContestsAndPoints.Add(username, new Dictionary<string, int>());
                                usersContestsAndPoints[username].Add(contest, points);
                            }
                            else
                            {
                                usersContestsAndPoints[username].Add(contest, points);
                            }
                        }
                    }
                }
            }
            int maxPoints = int.MinValue;
            string bestCandidate = "";
            foreach (var contestsAndPoints in usersContestsAndPoints)
            {
                int currentSum = 0;
                foreach (var contest in contestsAndPoints.Value)
                {
                    currentSum += contest.Value;
                }
                if (currentSum >= maxPoints)//
                {
                    maxPoints = currentSum;
                    bestCandidate = usersContestsAndPoints.Single(x=>x.Value.Values.Sum()==currentSum).Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
            Console.WriteLine("Ranking: ");
            foreach (var user in usersContestsAndPoints.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{ user.Key}");
                foreach (var contestsAndPoints in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contestsAndPoints.Key} -> {contestsAndPoints.Value}");
                }
            }
        }
    }
}
