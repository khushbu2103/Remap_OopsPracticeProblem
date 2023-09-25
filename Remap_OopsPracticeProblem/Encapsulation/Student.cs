using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_OopsPracticeProblem.Encapsulation
{
    internal class Student
    {
        private string StudentName;

        //properies
        public string Name
        {
            //get accessor
            get { return StudentName; }

            //set accessor
            set { StudentName = value; }
        }
    }
}
