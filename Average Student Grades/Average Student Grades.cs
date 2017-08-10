using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsData = new Dictionary<string, List<double>>();

            int inputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputs; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');
                string name = inputTokens[0];
                double grade = double.Parse(inputTokens[1]);

                if (!studentsData.ContainsKey(name))
                {
                    studentsData.Add(name, new List<double>());
                }

                List<double> studentsGrades = studentsData[name];
                studentsGrades.Add(grade);
                //studentsData[name].Add(grade) върши същата работа като горните два реда. 

            }

            foreach (KeyValuePair<string, List<double>> studentData in studentsData)
            {
                string name = studentData.Key;
                List<double> grades = studentData.Value;
                double avg = grades.Average(); //част от Linq библиотеката. Обхожда списъка и дава срредна стойност.
                Console.Write($"{name} -> ");
                foreach (double grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {avg:f2})");
               // Console.WriteLine($"{name} -> {string.Join(" ",grades)} (avg: {avg:f2})");
            }
        }
    }
}
