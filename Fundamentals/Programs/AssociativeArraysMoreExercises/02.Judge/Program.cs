using System;
using System.Linq;
using System.Collections.Generic;
namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contestStats = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individualInfo = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "no more time") break;
                string  user = input[0];
                string contestName = input[1];
                int points = int.Parse(input[2]);
                if(!contestStats.ContainsKey(contestName))
                {
                    contestStats.Add(contestName,new Dictionary<string, int>());
                    contestStats[contestName].Add(user, points);

                }
                else
                {
                    if(contestStats[contestName].ContainsKey(user))
                    {
                        if(contestStats[contestName][user]<points)
                        {
                            contestStats[contestName][user] = points;
                            individualInfo[user] = points;
                            continue;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        contestStats[contestName].Add(user, points);
                    }
                }

                if(individualInfo.ContainsKey(user))
                {
                    individualInfo[user] += points;
                }
                else
                {
                    individualInfo.Add(user, points);
                }
            }
            foreach (var contest in contestStats)
            {
                Console.WriteLine($"{ contest.Key}: { contest.Value.Count} participants");
                int position = 1;
                    Console.WriteLine(string.Join("\n",contest.Value
                        .OrderByDescending(x=>x.Value)
                        .ThenBy(x=>x.Key)
                        .Select(x=>$"{position++}. {x.Key} <::> {x.Value}")));
            }
            Console.WriteLine("Individual standings:");
            int positionOfParticipant = 1;
            Console.WriteLine(string.Join("\n",individualInfo
                .OrderByDescending(x=>x.Value)
                .ThenBy(x=>x.Key)
                .Select(x=>$"{positionOfParticipant++}. {x.Key} -> {x.Value}")));
        }
    }
}
