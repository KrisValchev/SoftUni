namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int members = int.Parse(Console.ReadLine());
            List<Person> people=new List<Person>();
            for (int i = 0; i < members; i++)
            {
                string[] personAndAge = Console.ReadLine().Split();
                string name = personAndAge[0];
                int age = int.Parse(personAndAge[1]);
                Person person = new Person(age, name);
                people.Add(person);
            }
            List<Person> PeopleWithAgeAbove30 = people.Where(x => x.Age > 30).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, PeopleWithAgeAbove30.OrderBy(x=>x.Name)));
        }
    }
}