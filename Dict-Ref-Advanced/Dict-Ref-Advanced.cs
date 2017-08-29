using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] inputToken = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string name = inputToken[0];
                if (IsName(inputToken[1]))
                {
                    string otherName = inputToken[1];
                    if (data.ContainsKey(otherName))
                    {
                        List<int> otherNameNumbers = data[otherName];

                        if (!data.ContainsKey(name))
                        {
                            data.Add(name, new List<int>());
                        }
                        data[name].Clear();
                        data[name].AddRange(otherNameNumbers);
                    }

                }
                else
                {
                    int[] numbers = inputToken[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse).ToArray();
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<int>());
                    }
                    data[name].AddRange(numbers);//AddRange добавя масив
                }



                input = Console.ReadLine();
            }


            foreach (KeyValuePair<string, List<int>> record in data)
            {
                string name = record.Key;
                List<int> numbers = record.Value;
                Console.WriteLine($"{name} === {string.Join(", ", numbers)}");

            }
        }
        static bool IsName(string input)
        {
            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
