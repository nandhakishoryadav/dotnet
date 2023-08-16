using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsecaseStatic
{
    internal class SnacksVendingMachine
    {

        public static int Inventory = 200;

        public int SnacksBought { get; set; }

        public int SnacksRefilled { get; set; }


        public void Buysnacks()
        {
            Console.WriteLine(" The snacks Bought is {0} ", this.SnacksBought);
        }

        public void Refilltheinventory()
        {
            Console.WriteLine(" The snacks Refilled is {0} ", this.SnacksRefilled);
        }

        public void Checktheremaininginventory()
        {
            Inventory= Inventory - SnacksBought + SnacksRefilled;
            
            Console.WriteLine(" The snacks Remaining is {0} ",Inventory);
        }
    }
}


