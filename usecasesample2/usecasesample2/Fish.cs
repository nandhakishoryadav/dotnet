using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usecasesample2
{
    internal class Fish:Mamals
    {
        public string FishType { get; set; }
        
        public override void Feature()
        {

            Console.WriteLine(" The fish can swim.");
        
        }
    }
}
