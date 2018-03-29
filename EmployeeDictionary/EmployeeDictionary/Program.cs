using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Dictionary<int, Employee>();

            employees.Add(101,
                new Employee { ID = 101, FirstName = "Jesse", LastName = "Pinkman" });
            employees.Add(102,
                new Employee { ID = 102, FirstName = "George", LastName = "Washington" });
            employees.Add(103,
                new Employee { ID = 103, FirstName = "Mark", LastName = "Smith" });


            Console.WriteLine(employees[101]);
            Console.WriteLine(employees[102]);
            Console.WriteLine(employees[103]);
            Console.Read();
        }
    }
}
