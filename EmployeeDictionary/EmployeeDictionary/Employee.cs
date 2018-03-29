using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return ID.ToString() + ": " + FirstName + " " + LastName;
        }
    }
}
