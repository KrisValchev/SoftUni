using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace _05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[]{',', ' '},StringSplitOptions.RemoveEmptyEntries);
            List<Demon> demons = new List<Demon>();
            for (int i = 0; i < input.Length; i++)
            {
              
               int health=Health(input[i]);
                double damage = Damage(input[i]);
                Demon demon = new Demon(input[i], health, damage);
                demons.Add(demon);
            }
            foreach (var demon in demons.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{demon.Name} - { demon.Health} health, { demon.Damage:f2} damage ");
            }
        }
        static int Health(string demon)
        {
            string patternHealth = @"(?<health>[^\d+\-\*\/\.])";
            Regex regexHealth = new Regex(patternHealth);
            MatchCollection matchedHealth = regexHealth.Matches(demon);
            int health = 0;
            foreach (Match match in matchedHealth)
            {
                health += match.Groups["health"].Value[0];
            }
            return health;
        }
        static double Damage(string demon)
        {
            string patternDamage = @"(?<damage>[+\-]?(\d+([.]\d+)?))";
            string patternAction = @"(?<action>[*\/])";
            Regex regexDamage = new Regex(patternDamage);
            Regex regexAction = new Regex(patternAction);
            MatchCollection matchedDamage = regexDamage.Matches(demon);
            MatchCollection matchedAction = regexAction.Matches(demon);
            double damage = 0;
            foreach (Match match in matchedDamage)
            {
                damage += double.Parse(match.Groups["damage"].Value);
            }
            foreach (Match match in matchedAction)
            {
                if(match.Groups["action"].Value=="/")
                {
                    damage /= 2;
                }
                else
                {
                    damage *= 2;
                }
            }
            return damage;
        }
    }
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
        public Demon(string name, int health, double damage)
        {
            Health = health;
            Name = name;
            Damage = damage;
        }
    }
}
