using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_OopsPracticeProblem.Polymarphism.MethodOverriding
{
    public class Car:Vehicle
    {
       
        public override void VehicleStarted()
        {
            Console.WriteLine("Vehicle is car");
        }

    }
}
