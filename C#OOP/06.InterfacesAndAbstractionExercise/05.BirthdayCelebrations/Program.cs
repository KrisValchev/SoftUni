using _05.BirthdayCelebrations.Models;
using Birthday.Interfaces;
using Birthday.Models;

namespace _05.BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> humansAndPets = new List<IBirthable>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();
                if (tokens.Length == 5)
                {
                    IBirthable citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                    humansAndPets.Add(citizen);
                }
                else if (tokens[0]=="Pet") 
                {
                    IBirthable pet = new Pet(tokens[1], tokens[2]);
                    humansAndPets.Add(pet);
                }
            }
            string year = Console.ReadLine();
            foreach (var creature in humansAndPets.Where(x =>x.Birthdate.Split('/').Last()== year).ToList())
            {
                Console.WriteLine(creature.Birthdate);
            }
        }
    }
}