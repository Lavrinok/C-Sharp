using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavrinok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task2: Persone Generator");
            Person[] persons = new PersonsGenerator().Generate(10);
            foreach (Person var in persons)
            {
                Console.WriteLine(var.GetpersonInfo()); 
            }

            Console.WriteLine("------------------");
            Console.WriteLine("-TASK4-");

            Console.WriteLine("Task4---------SalaryProcessor");
            new SalaryProcessor().Process(persons);
            Console.WriteLine("Task4---------AgeStatisticProcessor");
            new AgeStatisticProcessor().Process(persons);
            Console.WriteLine("Task4---------NamesProcessor");
            new NamesProcessor().Process(persons);

            Console.WriteLine("");
            Console.WriteLine("-TASK5-");
            foreach (Person var in persons)
            {
                Console.WriteLine(var.FullName + " => " + var.GetType().Name);
            }
            Console.ReadKey();
        }
    }
}
