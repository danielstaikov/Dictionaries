using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Dictionaries_4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var continentsData = new Dictionary<string, Dictionary<string, string>>();
            int inputCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCnt; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continentName = input[0];
                string countryName = input[1];
                string capitalName = input[2];

                if (!continentsData.ContainsKey(continentName))
                {
                    continentsData.Add(continentName, new Dictionary<string, string>());
                }
                continentsData[continentName].Add(countryName, capitalName);

                // нещо за вършене
            }


            foreach (KeyValuePair<string, Dictionary<string, string>> record in continentsData)
            {
                string continentName = record.Key;
                Dictionary<string, string> countriesData = record.Value;
                Console.WriteLine(continentName);
                foreach (KeyValuePair<string, string> countryData in countriesData)
                {
                    string countryName = countryData.Key;
                    string capitalname = countryData.Value;
                    Console.WriteLine($"{countryName} --> {capitalname}");
                }

            }
        }
    }
}
