using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample3
{
    internal class HighSchollStudents:Students
    {
        public int Gpa { get; set; }
        public string ExtraCaricularActivities { get; set; }

        public void Transcript()
        {
            Console.WriteLine(" Request a transcript");
        }

        public void Letters()
        {
            Console.WriteLine(" Get Recomendation letters");
        }

        public override void SName()
        {
            Console.WriteLine(" My name is " + Name + ". I am a HighSchool Student");
        }
    }
}
