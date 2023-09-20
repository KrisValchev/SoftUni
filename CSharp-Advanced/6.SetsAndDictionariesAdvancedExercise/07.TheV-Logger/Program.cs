using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary< string,HashSet<string>>> vloggerAndFollowers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            
            string input;
            while ((input=Console.ReadLine())!="Statistics")
            {
                string[] command = input.Split();
                if(command[1]=="followed")
                {
                string nameVlogger = command[2];
                string nameFollower = command[0];
                    if (vloggerAndFollowers.ContainsKey(nameVlogger) && vloggerAndFollowers.ContainsKey(nameFollower))
                    {
                        if(nameFollower!=nameVlogger)
                        {
                            vloggerAndFollowers[nameVlogger]["followers"].Add(nameFollower);
                            vloggerAndFollowers[nameFollower]["following"].Add(nameVlogger);
                        }
                    }
                }
                else if(command[1] == "joined")
                {
                string nameVlogger = command[0];
                    if(!vloggerAndFollowers.ContainsKey(nameVlogger))
                    {
                        vloggerAndFollowers.Add(nameVlogger,new Dictionary<string, HashSet<string>>());
                        vloggerAndFollowers[nameVlogger].Add("followers", new HashSet<string> ());
                        vloggerAndFollowers[nameVlogger].Add("following", new HashSet<string>());
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vloggerAndFollowers.Count} vloggers in its logs.");
            int index = 0;
            foreach (var vlogger in vloggerAndFollowers.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{++index}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
                if(index==1 && vlogger.Value["followers"].Count!=0)
                {  
                    foreach (var follower in vlogger.Value["followers"].OrderBy(x=>x))
                    {
                        Console.WriteLine("*  "+ follower);
                    }
                }
            }
        }
    }
}
