using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase4
{
    internal class Manager
    {
        public string Name { get; set; }    
        public int  Age { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public Store Storeinfo { get; set; }
        public ContactInformation contcat { get; set; }
        
        public virtual void Walk()
        {
            Console.WriteLine("Hi,there.My name is {0}.I am working", Name);
        }
        public virtual void Work()
        {
            Console.WriteLine("Hi,there.I am mangaing the store");
        }
        public virtual void Supervise()
        {
            Console.WriteLine(" I am supervising");
        }


    }
}
