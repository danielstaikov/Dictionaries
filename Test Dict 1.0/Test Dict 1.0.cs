using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Dict_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
          var  postLikes = new Dictionary<string, int>();
            string input = Console.ReadLine();

            postLikes.Add(input, 0);

            postLikes[input]++;

            foreach (KeyValuePair<string,int> item in postLikes)
            {
                Console.WriteLine($" {item}");
            }

          

        }
    }
}
