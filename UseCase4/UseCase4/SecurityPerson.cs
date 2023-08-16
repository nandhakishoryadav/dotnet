using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase4
{
    internal class SecurityPerson:Manager
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public ShiftTime shiftinfo { get; set; }
        
        public ContactInformation contcat { get; set; }

        public override void Walk()
        {
            Console.WriteLine("Hi,there.My name is {0}.I am walking", Name);
        }
        public override void Work()
        {
            Console.WriteLine("Hi,there.I am working as security");
        }
        public virtual void OpenDoor()
        {
            Console.WriteLine(" I am openming the door");
        }
    }
}
