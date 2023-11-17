using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private readonly List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }
        public double Rating
        {
            get
            {
                if (players.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return Math.Round(players.Average(x => x.SkillLevel()),0);
                }
            }

        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A name should not be empty.");
                name = value;
            }
        }
        public void AddPlayer(Player player)
        {
                players.Add(player);
        }
        public void RemovePlayer(string playerName)
        {
            if (players.Exists(x => x.Name == playerName))
            {
                players.Remove(players.Find(x => x.Name == playerName));
            }
            else
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
        }
        public void ShowStats()
        {
            Console.WriteLine($"{Name} - {Rating}");
        }
    }

}
