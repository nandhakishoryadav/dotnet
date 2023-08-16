using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample3
{
    internal  class HighSchoolTeacher:Teachers
    {
        
        public string SubjectTaught { get; set; }

        public void Lesson()
        {
            Console.WriteLine(" Create Lesson Plans");
        }

        public override void Schedule()
        {
            Console.WriteLine(" Schedule Parent Teacher Conferences");
        }

        public override void Tname()
        {
            Console.WriteLine(" My name is " + Name + ". I am a HighSchool Teacher");
        }
    }
}
