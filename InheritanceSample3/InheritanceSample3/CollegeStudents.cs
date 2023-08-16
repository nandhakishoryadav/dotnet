using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample3
{
    internal class CollegeStudents:Students
    {
        public string Major { get; set; }
        public string Minor { get; set; }

        public void Exam()
        {
            Console.WriteLine(" Register for exams");
        }

        public void Graduation()
        {
            Console.WriteLine(" Apply for Graduation");
        }
        public override void SName()
        {
            Console.WriteLine(" My name is " + Name + ". I am a College Student");
        }
    }
}
