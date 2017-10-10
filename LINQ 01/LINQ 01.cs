using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] inputs = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                inputs[i] = int.Parse(Console.ReadLine());
            }

            int sumNumbers = inputs.Sum();
            int minNumbers = inputs.Min();
            int maxNumbers = inputs.Max();
            double avgNumbers = inputs.Average();

            Console.WriteLine($"Sum = {sumNumbers}");
            Console.WriteLine($"Min = {minNumbers}");
            Console.WriteLine($"Max = {maxNumbers}");
            Console.WriteLine($"Average = {avgNumbers}");

        }
    }
}
