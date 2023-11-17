using _03.Raiding.Factory;
using _03.Raiding.Interfaces;

namespace _03.Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int validHeroes = 0;
            int heroes = int.Parse(Console.ReadLine());
            List<IHero> raidGroup = new List<IHero>();
            IHeroFactory factory=new HeroFactory();
            while (validHeroes != heroes)
            {
                string name =Console.ReadLine();
                string type =Console.ReadLine();
                try
                {
                    IHero hero=factory.CreateHero(type, name);
                    raidGroup.Add(hero);
                    validHeroes++;
                } 
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            int bossPower =int.Parse(Console.ReadLine());
            int powerOfHeroes = raidGroup.Sum(x => x.Power);
            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
            }
            if(powerOfHeroes>=bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}