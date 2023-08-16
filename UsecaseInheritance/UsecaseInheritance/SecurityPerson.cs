using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsecaseInheritance
{
    internal class SecurityPerson:Manager
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public ShiftTime shift { get; set; }
        public ContactInformation contact { get; set; }


        public override void Walk()
        {
            Console.WriteLine("Hi there.My name is {0}.I am Walking", Name);
        }
        public override void Work()
        {
            Console.WriteLine("Hi there.I am working as securty");
        }
        public  void OpenDoor()
        {
            Console.WriteLine("I open the door and greet customers");
        }
    }
}
