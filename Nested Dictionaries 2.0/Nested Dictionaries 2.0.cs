using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Dictionaries_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, List<int>>(); // използваме var за да спестим многото писане при дефиниране на променливата

            phoneBook.Add("Pesho", new List<int> { 123456, 665987 });
            phoneBook.Add("Gosho", new List<int> { 456789, 9998521 });

            foreach (KeyValuePair<string,List<int>> record in phoneBook)
            {
                string name = record.Key;
                List<int> numbers = record.Value;

                Console.WriteLine($"{name}: {string.Join(", ", numbers)}");
            }
        }
    }
}
