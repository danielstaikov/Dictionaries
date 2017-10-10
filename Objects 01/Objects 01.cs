using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Object birthday = new { day = 11, month = 12, year = 1996 }; //анонимен обект
            Console.WriteLine(birthday);
        }
    }
}
