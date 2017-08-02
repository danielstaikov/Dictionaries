using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> words = new SortedDictionary<double, int>();

            double[] inputTokens = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < inputTokens.Length; i++)
            {
                if (!words.ContainsKey(inputTokens[i]))
                {
                    words.Add(inputTokens[i], 0);
                }
                words[inputTokens[i]]++;
            }

            foreach (double word in words.Keys)
            {
                Console.WriteLine($"{word} -> {words[word]}");
            }

        }
    }
}
