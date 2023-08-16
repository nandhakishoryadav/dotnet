using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usecasesample2
{
    internal class Bird:Mamals
    {
        public int EggSize { get; set; }
        public string FeatherColor { get; set; }
        

       
        public  override void Feature()
        {
            Console.WriteLine(" The bird can fly.");
        }

    }
}
