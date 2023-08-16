using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample3
{
    internal abstract class Teachers:School
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; }

        public void VSchedule()
        {
            Console.WriteLine(" View Schedule");
        }

        public void EnterGrade()
        {
            Console.WriteLine(" Enter Grades");
        }

        public abstract void Schedule();
        public abstract void Tname();
    }
}
