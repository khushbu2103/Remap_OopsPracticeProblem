using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_OopsPracticeProblem.Absraction
{
    public abstract class Employee
    {
        public abstract  double GetSalary();
        public void EmployeeDetails()
        {
            Console.WriteLine("Employee details ");
        }
    }
}
