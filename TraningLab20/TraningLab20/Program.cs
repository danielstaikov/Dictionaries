using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraningLab20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double l = Math.Floor(length / 1.2);
            double w = Math.Floor((width - 1) / 0.7);

            double result = (l * w) - 3;
            Console.WriteLine(result);
        }
    }
}
