using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_OopsPracticeProblem.Absraction
{
    internal class PartTimeEmployee:Employee
    {
        
        public override double GetSalary()
        {
            Console.WriteLine("salary :" + 50000);
            return 50000.345;
        }
    }
}
