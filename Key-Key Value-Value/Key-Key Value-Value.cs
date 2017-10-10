using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Key_Value_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            string masterKey = Console.ReadLine();
            string masterValue = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> input = new Dictionary<string, List<string>>();
            for (int i = 0; i < N; i++)
            {
                string inputString = Console.ReadLine();
                string[] inputToken = inputString.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                string inputKey = inputToken[0];
                string[] inputValue = inputToken[1].Split(';');
                if (inputKey.ToUpper().Contains(masterKey.ToUpper()))
                {
                    if (!input.ContainsKey(inputKey))
                    {
                        input.Add(inputKey, new List<string>());
                    }
                    foreach (string item in inputValue)
                    {
                        if (item.Contains(masterValue))
                        {
                            input[inputKey].Add(item);

                        }
                    } 
                }                
            }
            foreach (KeyValuePair<string,List<string>> item in input)
            {


                    string name = item.Key;
                    List<string> record = item.Value;
                    Console.WriteLine($"{name}:");
                    foreach (var single in record)
                {
                    Console.WriteLine($"-{single}");
                }
               

            }
        }
    }
}
