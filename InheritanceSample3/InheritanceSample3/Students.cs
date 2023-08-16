using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample3
{
    internal abstract class Students:School
    {
        public int SchoolId { get; set; }
        public string GradeLevel { get; set; }

        public void Enroll()
        {
            Console.WriteLine(" Enroll in class");
        }

        public void Grades()
        {
            Console.WriteLine(" View Grades");
        }
        public abstract void SName();

    }
}
