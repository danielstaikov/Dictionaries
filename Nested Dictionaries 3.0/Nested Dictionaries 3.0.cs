using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Dictionaries_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, List<int>>();
            int inputCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCnt; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int number = int.Parse(input[1]);

                if (!phoneBook.ContainsKey(name)) // проверява дали записа го няма в системата и го създава
                {
                    phoneBook.Add(name, new List<int>());
                }

                phoneBook[name].Add(number); // добавям към списъка phoneBook[name] някаква стойност number
                // нещо за вършене
            }


            foreach (KeyValuePair<string, List<int>> record in phoneBook)
            {
                string name = record.Key;
                List<int> numbers = record.Value;

                Console.WriteLine($"{name}: {string.Join(", ", numbers)}");
            }
        }
    }
}
