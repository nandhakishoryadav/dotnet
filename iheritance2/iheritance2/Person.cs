using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iheritance2
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }        
        public string Gender { get; set; }
        public ContactInformation conatct { get; set; }


        public  void Walk()
        {
            Console.WriteLine("Hi there My name is {0}.I am walking", Name);
        }
        public abstract void Work();

    }
}
