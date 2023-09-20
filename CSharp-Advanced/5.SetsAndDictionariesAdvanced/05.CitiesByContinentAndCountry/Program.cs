using System;
using System.Linq;
using System.Collections.Generic;
namespace _05.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentCountriesAndCities = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < number; i++)
            {
                string[] continentCountryAndCity = Console.ReadLine().Split(" ");
                string continent = continentCountryAndCity[0];
                string country = continentCountryAndCity[1];
                string city = continentCountryAndCity[2];
                if (continentCountriesAndCities.ContainsKey(continent))
                {
                    if (continentCountriesAndCities[continent].ContainsKey(country))
                    {
                        continentCountriesAndCities[continent][country].Add(city);
                    }
                    else
                    {
                        continentCountriesAndCities[continent].Add(country, new List<string> { city });
                    }
                }
                else
                {
                    continentCountriesAndCities.Add(continent, new Dictionary<string, List<string>>());
                    continentCountriesAndCities[continent].Add(country, new List<string> { city });
                }
            }
            foreach (var entry in continentCountriesAndCities)
            {
                Console.WriteLine(entry.Key + ":");
                foreach (var country in entry.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }

    }
}
