using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> words = new SortedDictionary<string, double>();
            string[] inputWord;

            do
            {
                inputWord = Console.ReadLine().Split(' ').ToArray();

                  if (inputWord.Length > 1)
                {
                    double value = 0;
                    if (double.TryParse(inputWord[2], out value))
                    {
                        words[inputWord[0]] = value;
                    }
                    else
                    {
                            words[inputWord[2]] = double.Parse(inputWord[0]);
                    }

                }



            } while (inputWord[0] != "Over");

            foreach (string key in words.Keys)
            {
                Console.WriteLine($"{key} -> {words[key]}");
            }

        }
    }
}
