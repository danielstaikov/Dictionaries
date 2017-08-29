using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();
            int inputCntr = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCntr; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(new string[] {" -> "},StringSplitOptions.RemoveEmptyEntries);
                string color = inputTokens[0];
                string[] clothes = inputTokens[1].Split(',');

                if (!data.ContainsKey(color))
                {
                    data.Add(color, new Dictionary<string, int>());
                }


                foreach (string cloth in clothes)
                {
                    Dictionary<string, int> clothesDb = data[color];
                    if (!clothesDb.ContainsKey(cloth))
                    {
                        clothesDb.Add(cloth, 0);
                    }
                    clothesDb[cloth]++;
                }

            }

            string[] searchTokens = Console.ReadLine().Split(' ');
            string searchColor = searchTokens[0];
            string searchCloth = searchTokens[1];


            foreach (KeyValuePair<string, Dictionary<string, int>> colorData in data)
            {
                string color = colorData.Key;
                Dictionary<string, int> clothesData = colorData.Value;

                Console.WriteLine($"{color} clothes:");
                foreach (KeyValuePair<string, int> clothData in clothesData)
                {
                    string cloth = clothData.Key;
                    int quantity = clothData.Value;
                    Console.Write($"* {cloth} - {quantity}");

                    if (color == searchColor && cloth== searchCloth)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();

                }

            }

        }
    }
}
