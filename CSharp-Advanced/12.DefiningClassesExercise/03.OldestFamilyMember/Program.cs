namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int members = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < members; i++)
            {
                string[] personAndAge = Console.ReadLine().Split();
                string name = personAndAge[0];
                int age = int.Parse(personAndAge[1]);
                Person person = new Person(age, name);
                family.AddMember(person);
            }
            Console.WriteLine(family.GetOldestMember());
        }
    }
}