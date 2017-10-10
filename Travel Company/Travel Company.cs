using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> cities = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> transport = new Dictionary<string, int>();

            while (input!="ready")
            {
                string[] inputToken = input.Split(':');
                string city = inputToken[0];
                string[] travelMetods = inputToken[1].Split(',');

                for (int i = 0; i < travelMetods.Length; i++)
                {
                    string[] transportToken = travelMetods[i].Split('-');
                    string transportKind = transportToken[0];
                    string accomodationTrasport = transportToken[1];
                    Console.WriteLine($"Transport {transportKind} have {accomodationTrasport} seats ");

                }



              // if (!cities.ContainsKey(city))
              // {
              //     cities.Add(city, new Dictionary<string, int>());
              // }
              // cities[city].Clear();
              // //cities[city].Add(travelMetods);
                input = Console.ReadLine();
            }
        }
    }
}
