using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(5);
            set.Add(10);
            set.Add(3);
            set.Add(20);
            set.Add(11);

            set.Remove(5); // вариант за промяна на елемент - триеш и после добавяш нов
            set.Add(30);


            foreach (var number in set)
            {
                Console.WriteLine(number);
            }
        }
    }
}
