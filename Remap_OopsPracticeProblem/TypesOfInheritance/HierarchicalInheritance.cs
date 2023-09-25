using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_OopsPracticeProblem.TypesOfInheritance
{
    public class HierarchicalInheritance
    {
        public string color;
        public void Animals()
        {
            Console.WriteLine("There are many types of birds");
        }
       
    }
    public class Dog : HierarchicalInheritance
    {
        public string name;
    }
    public class Cow : HierarchicalInheritance
    {
        public string name;
        public string color = "white";
    }
}
