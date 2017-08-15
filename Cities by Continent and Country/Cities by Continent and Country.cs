using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var continentsData = new Dictionary<string,Dictionary<string,List<string>>>();

            int inputCntr = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCntr; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');
                string continent = inputTokens[0];
                string country = inputTokens[1];
                string city = inputTokens[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData.Add(continent, new Dictionary<string,List<string>>());

                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent].Add(country, new List<string>());
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
                    List<string> cites = countryData.Value;

                    Console.WriteLine($"  {country} -> {string.Join(", ", cites)}");
                }
                
            }
        }
    }
}
