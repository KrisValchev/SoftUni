using _04.BorderControl.Interfaces;
using _04.BorderControl.Models;

namespace _04.BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           List<IEnterer> enterers = new List<IEnterer>();
            string command;
            while ((command=Console.ReadLine())!="End")
            {
                string[] tokens = command.Split();
                if(tokens.Length==3)
                {
                    IEnterer enterer = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    enterers.Add(enterer);
                }
                else
                {
                    IEnterer enterer = new Robot(tokens[0],tokens[1]);
                    enterers.Add(enterer);
                }
            }
            string lastFakeNumbers =Console.ReadLine();
            foreach (var enterer in enterers.Where(x=>x.Id.Substring(x.Id.Length-lastFakeNumbers.Length)==lastFakeNumbers).ToList())
            {
                Console.WriteLine(enterer.Id);
            }
        }
    }
}