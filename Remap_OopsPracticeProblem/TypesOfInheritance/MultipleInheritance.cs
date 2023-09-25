using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_OopsPracticeProblem.TypesOfInheritance
{
    internal class MultipleInheritance
    {
        
    }
    interface IWalkable
    {
        void Walk();
    }

    interface ISwimmable
    {
        void Swim();
    }

    class Human : IWalkable, ISwimmable
    {
        public void Walk()
        {
            Console.WriteLine("Walking...");
        }

        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }
}
