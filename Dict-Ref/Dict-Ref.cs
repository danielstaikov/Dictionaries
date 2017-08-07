using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            string[] inputWord;

            do
            {
                inputWord = Console.ReadLine().Split(' ').ToArray();
                if (inputWord.Length>1)
                {
                    int value = 0;
                    bool result = int.TryParse(inputWord[2], out value);
                    if (result)
                    {
                        words[inputWord[0]] = int.Parse(inputWord[2]); ;
                    }
                    else
                    {
                        if (words.ContainsKey(inputWord[2]))
                        {
                            words[inputWord[0]] = words[inputWord[2]];
                        }

                    }
                    
                }



            } while (inputWord[0]!="end");

            foreach (string key in words.Keys) 
            {
                Console.WriteLine($"{key} === {words[key]}");
            }

        }
    }
}
