using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_OopsPracticeProblem.Polymarphism.MethodOverriding
{
    public class Vehicle
    {
        public virtual void VehicleStarted()
        {
            Console.WriteLine("Vehicle started");
        }
    }
}
