using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int countOfTeams = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] command = Console.ReadLine().Split("-");
                string creator = command[0];
                string teamName = command[1];
                Team team = new Team(teamName, creator);
                if (teams.Select(x => x.Name).Contains(team.Name))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Select(x => x.Creator).Contains(team.Creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
            while (true)
            {
                string[] input = Console.ReadLine().Split("->");
                if (input[0] == "end of assignment")
                {
                    break;
                }
                string member = input[0];
                string teamName = input[1];
                if (teams.Select(x => x.Name).Contains(teamName))
                {
                    if (teams.Select(x => x.Members).Any(x => x.Contains(member) || teams.Select(x => x.Creator).Contains(member)))
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    }
                    else teams.Find(x => x.Name == teamName).Members.Add(member);
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            }
            List<Team> teamsToDisband = teams.OrderBy(x => x.Name).Where(x => x.Members.Count == 0).ToList();
            List<Team> fullTeams = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).Where(x => x.Members.Count > 0).ToList();
            foreach (Team team in fullTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string currentMember in team.Members.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {currentMember}");
                }
            }
            Console.WriteLine("Teams to disband:");

            foreach (Team disbandedTeam in teamsToDisband)
            {
                Console.WriteLine(disbandedTeam.Name);
            }

        }
    }
    class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
