using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_OopsPracticeProblem.Polymarphism
{
    internal class MethodoverLoading
    {
        public static void Addition(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine("sum of two numbers : {0}", sum);
        }
        public static void Addition(int first, int second, int third)
        {
            int sum = first + second + third;
            Console.WriteLine("sum of two numbers : {0}", sum);
        }
        public static void Addition(long first, int second, int third)
        {
            Console.WriteLine(first + second + third);
        }
        public static void Addition(int first, long second, int third)
        {
            Console.WriteLine(first + second + third);
        }
    }
}
