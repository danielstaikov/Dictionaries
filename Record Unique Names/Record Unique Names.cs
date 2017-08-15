using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int inputCntr = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCntr; i++)
            {
                string name = Console.ReadLine();

                if (!names.Contains(name))
                {
                    names.Add(name);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,names));// или "\n" (нов ред) но може да не работи на всякъде
        }
    }
}
