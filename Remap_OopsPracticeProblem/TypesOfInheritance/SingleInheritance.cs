using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_OopsPracticeProblem.TypesOfInheritance
{
    public class SingleInheritance
    {
        public string color;
        public  void BirdsName()
        {
            Console.WriteLine("There are many types of birds");
        }
    }
    public class Sparrow: SingleInheritance
    {
        public string name; 
    }
}
