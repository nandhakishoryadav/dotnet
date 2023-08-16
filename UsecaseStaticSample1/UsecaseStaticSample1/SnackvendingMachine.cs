using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsecaseStaticSample1
{
    internal class SnackvendingMachine
    {
        public int SnacksBought { get; set; }
        public int SnackRefilled { get; set; }

        public static int Inventory = 200;


        public void BuySnacks()
        {
            Console.WriteLine(" Buys {0} packet of chips", this.SnacksBought);
        }

        public void CheckRemainingInventory()
        {
            Inventory = Inventory + this.SnackRefilled - this.SnacksBought;
            Console.WriteLine(" {0} packet of chips is remaining", Inventory);
        }

        public void RefillInventory()
        {
            Console.WriteLine(" Refills {0} packet of chips", this.SnackRefilled);
        }
    }
}

