using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsecaseStatic
{
    internal class People:SnacksVendingMachine
    {
        public string Name { get; set; }
        public int Age { get; set; }    
        public string Job { get; set; }

        public void Pname()
        {
            Console.WriteLine(" The Snacksvending Machine  is visited By  {0} ",Name);
        }
    }
}


