using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usecasesample2
{
    internal abstract class Mamals
    {
        public string Name { get; set; }  
        public double Price { get; set; }
       

        public void Pname()
        {
            Console.WriteLine(" The pet name is " + Name);
        }
        public abstract void Feature();
       

    }
}
