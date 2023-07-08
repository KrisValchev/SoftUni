using System;
using System.Linq;
using System.Collections.Generic;
namespace _03.MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> tier = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> ", " vs " }, StringSplitOptions.None);
                if (input[0] == "Season end") break;
                if (input.Length == 3) AddPlayer(tier, input[0], input[1], int.Parse(input[2]));
                else Duel(tier, input[0], input[1]);

            }
            foreach (var player in tier.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                Console.WriteLine(string.Join("\n", player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(x => $"- {x.Key} <::> {x.Value}")));
            }
        }
        static void AddPlayer(Dictionary<string, Dictionary<string, int>> tier, string player, string position, int skill)
        {
            if (!tier.ContainsKey(player))
            {
                tier.Add(player, new Dictionary<string, int>());
            }
            if (!tier[player].ContainsKey(position))
            {
                tier[player].Add(position, skill);
            }
            if (tier[player][position] < skill)
            {
                tier[player][position] = skill;
            }

        }
        static void Duel(Dictionary<string, Dictionary<string, int>> tier, string player1, string player2)
        {
            bool player1Win = false;
            bool player2Win = false;
            if (tier.Keys.Contains(player1) && tier.Keys.Contains(player2))
            {
                foreach (var plr1 in tier[player1])
                {
                    if (tier[player2].ContainsKey(plr1.Key))
                    {
                        if (tier[player2].Values.Sum() < tier[player1].Values.Sum())
                        {
                            player1Win = true;
                        }
                        else
                        {
                            player2Win = true;
                        }
                    }
                }
            }
            if (player1Win) tier.Remove(player2);
            else if (player2Win) tier.Remove(player1);
        }
    }
}
