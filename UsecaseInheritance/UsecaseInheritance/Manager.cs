using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsecaseInheritance
{
    internal class Manager
    {
        public string Name { get; set; }    
        public int Age { get; set; }
        public string Gender { get; set; }
        public int salary { get; set; }
        public Store storeinfo { get; set; }
        public ContactInformation contact { get; set; }
        

        public virtual void Walk()
        {
            Console.WriteLine("Hi there.My name is {0}.I am Walking ", Name);
        }

        public virtual void Work()
        {
            Console.WriteLine("Hi there.I am managing the store");
        }

        public void Supervise()
        {
            Console.WriteLine("I am supervising");
        }
    }
}
