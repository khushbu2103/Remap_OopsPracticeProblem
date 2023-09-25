using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_OopsPracticeProblem.TypesOfInheritance
{
    internal class MultilevelInheritance
    {
        public void AnimalSound()
        {
            Console.WriteLine("Animal sound");
        }
    }
    class Dogs : MultilevelInheritance
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    class Cat : Dogs
    {
        public void Guard()
        {
            Console.WriteLine("Meow...");
        }
    }
}
