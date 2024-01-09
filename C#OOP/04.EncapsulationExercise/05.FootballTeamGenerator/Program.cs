namespace _05.FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                    string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (tokens[0])
                    {
                        case "Team":
                            Team team = new Team(tokens[1]);
                            teams.Add(team);
                            break;
                        case "Add":
                            
                            if (teams.Exists(x => x.Name == tokens[1]))
                            {
                                Player player = new Player(tokens[2],
                  int.Parse(tokens[3]),
                   int.Parse(tokens[4]),
                   int.Parse(tokens[5]),
                   int.Parse(tokens[6]),
                   int.Parse(tokens[7]));
                                teams.Find(x => x.Name == tokens[1]).AddPlayer(player);
                            }
                            else
                            {
                                throw new ArgumentException($"Team {tokens[1]} does not exist.");
                            }
                            break;
                        case "Remove":
                            if (teams.Exists(x => x.Name == tokens[1]))
                            {
                                teams.Find(x => x.Name == tokens[1]).RemovePlayer(tokens[2]);
                            }
                            else
                            {
                                throw new ArgumentException($"Team {tokens[1]} does not exist.");
                            }
                            break;
                        case "Rating":
                            if (teams.Exists(x => x.Name == tokens[1]))
                            {
                                teams.Find(x => x.Name == tokens[1]).ShowStats();
                            }
                            else
                            {
                                throw new ArgumentException($"Team {tokens[1]} does not exist.");
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
