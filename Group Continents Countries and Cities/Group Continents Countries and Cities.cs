using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Continents_Countries_and_Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            int inputCntr = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCntr; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');
                string continent = inputTokens[0];
                string country = inputTokens[1];
                string city = inputTokens[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData.Add(continent, new SortedDictionary<string, SortedSet<string>>());

                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent].Add(country, new SortedSet<string>());
                }

                continentsData[continent][country].Add(city);

            }
            foreach (var continentData in continentsData)
            {
                string continent = continentData.Key;
                var countresData = continentData.Value;

                Console.WriteLine($"{continent}:");

                foreach (var countryData in countresData)
                {
                    string country = countryData.Key;
                    SortedSet<string> cites = countryData.Value;

                    Console.WriteLine($"  {country} -> {string.Join(", ", cites)}");
                }

            }
        }
    }
}
