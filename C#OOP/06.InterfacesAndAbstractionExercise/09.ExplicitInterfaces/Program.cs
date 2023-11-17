namespace _09.ExplicitInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command=Console.ReadLine())!="End")
            {
                string[] tokens = command.Split();
                IPerson person = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));
                IResident resident=new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));
                person.GetName();
                resident.GetName();
            }
        }
    }
}