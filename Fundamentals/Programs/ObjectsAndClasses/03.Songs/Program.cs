using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Songs> songsList = new List<Songs>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                string typelist = input[0];
                string name = input[1];
                string time = input[2];
                Songs song = new Songs(typelist, name, time);
                songsList.Add(song);
            }
            string command = Console.ReadLine();
            if(command=="all")
            {
                foreach (Songs song in songsList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Songs> filteredSongs=songsList.Where(x => x.TypeList == command).ToList();
                foreach (Songs song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
        
    }
    class Songs
    {
        public Songs(string typelist, string name, string time)
        {
            TypeList = typelist;
            Name = name;
            Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
