using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    internal abstract class Person
    {
        public string Name { get; set; }    
        public int Age { get; set; }
        public string Gender { get; set; }
        public ContactInformation contact { get; set; }

        public abstract void Walk();
        public abstract void Work();


    }
}
