using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_OopsPracticeProblem
{
    abstract class TypesOfMethod
    {
        // Pure virtual method
        public abstract void DoSomething();
    }

    // Virtual method
    public class A
    {
        public virtual int Calculate(int a, int b)
        {
            return a + b;
        }
    }
    // Extension method
    public static class ExtensionMethods
    {
        public static string UppercaseFirstLetter(this string value)
        {
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }

        // Instance method
        public class PropertyUtil
        {
            public void DoSomething()
            {
                Console.WriteLine("Instance method");
            }
        }

        // Static method
        public class PropertyUtil2
        {
            public static void DoSomething()
            {
                Console.WriteLine("Static method");
            }

            
        }
    }

}
