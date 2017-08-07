using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> words = new Dictionary<char, int>();

            char[] inputTokens = Console.ReadLine().ToCharArray();

            for (int i = 0; i < inputTokens.Length; i++)
            {
                if (!words.ContainsKey(inputTokens[i]))
                {
                    words.Add(inputTokens[i], 0);
                }
                words[inputTokens[i]]++;
            }

            foreach (char word in words.Keys)
            {
                Console.WriteLine($"{word} -> {words[word]}");
            }
        }
    }
}
