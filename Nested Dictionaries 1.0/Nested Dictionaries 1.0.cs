using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Dictionaries_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>(); //Ако трябва да са подредени - ползваме SortedDictionary

            phoneBook.Add("Pesho", 123456);
            phoneBook.Add("Gosho", 456789);

            foreach (KeyValuePair<string, int> record in phoneBook)
            {
                string name = record.Key;
                int number = record.Value;

                Console.WriteLine($"{name}: {number}");
            }
        }
    }
}
