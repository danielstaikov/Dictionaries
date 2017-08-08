using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            string[] inputWord;
            string inputString;

            do
            {
                inputString = Console.ReadLine();
                inputWord = inputString.Split(' ').ToArray();


                if (inputWord.Length > 2)
                {
                    int value = int.Parse(inputWord[2]);

                    if (inputWord[0] == "stock")
                    {
                        if (words.ContainsKey(inputWord[1]))
                        {
                            words[inputWord[1]] = words[inputWord[1]] + value;
                        }
                        else
                        {
                            words[inputWord[1]] = value;
                        }
                        
                    }
                    else 
                    {
                        if (words.ContainsKey(inputWord[1]))
                        {
                            if (words[inputWord[1]]>0)
                            {
                                words[inputWord[1]] = words[inputWord[1]] - value;
                            }
                            else
                            {
                                Console.WriteLine($"{inputWord[1]} out of stock");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine($"{inputWord[1]} doesn't exist");
                        }
                    }
                }

            } while (inputString != "exam time");

            foreach (string key in words.Keys)
            {
                if (words[key]>0)
                {
                    Console.WriteLine($"{key} -> {words[key]}");
                }
            }
        }
    }
}
