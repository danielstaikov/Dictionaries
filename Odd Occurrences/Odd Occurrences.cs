using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string,int>();

            string[] inputTokens = Console.ReadLine().ToLower().Split(' ');

            for (int i = 0; i < inputTokens.Length; i++)
            {
                if (!words.ContainsKey(inputTokens[i]))
                {
                    words.Add(inputTokens[i], 0);
                }
                words[inputTokens[i]]++;
            }

            List<string> result = new List<string>();


            foreach (KeyValuePair<string, int> word in words)
            {
                if (word.Value % 2 == 1)
                {
                    result.Add(word.Key); 
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
