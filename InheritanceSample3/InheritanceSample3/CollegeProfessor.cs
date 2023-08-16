using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample3
{
    internal class CollegeProfessor:Teachers
    {
        public string Publications { get; set; }
        public string ReasearchAreas { get; set; }

        public void Grants()
        {
            Console.WriteLine(" Apply for Grants");
        }

        public override void Schedule()
        {
            Console.WriteLine(" Schedule office hours");
        }

        public override void Tname()
        {
            Console.WriteLine(" My name is " + Name + ". I am a College Professor");
        }
    }
}
