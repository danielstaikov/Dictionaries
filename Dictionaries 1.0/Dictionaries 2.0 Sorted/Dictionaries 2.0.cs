using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_2._0_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            phonebook["Pesho"] = "+15258623326";// добавя стойности в речника
            phonebook["Gosho"] = "+1312232154684";
            phonebook.Add("Maria", "+999666999");// друг начин за добавяне на стойности в речника
            bool alalabala = phonebook.ContainsKey("Gosho"); // phonebook.ContainsKey() връща булева стойност

            //Console.WriteLine(phonebook["Maria"]);

            foreach (KeyValuePair<string, string> item in phonebook)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
