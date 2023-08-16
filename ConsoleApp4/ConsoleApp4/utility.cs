using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class utility
    {
        public T Add<T>(T a, T b)
        {
            return(dynamic)a + (dynamic)b;
        }

        public void DisplayListContents(List<int>listOfInt)
        {
            foreach(var item in listOfInt)
            {
                Console.WriteLine(item);
            }
        }
        public void DisplayListContents(List<double>listOfDouble) 
        {
            foreach (var item in listOfDouble) 
            { 
                Console.WriteLine(item);
            }
        }

        public void DisplayListContents<T>(List<T>list)
        {
            foreach (var item in list) 
            {
            Console.WriteLine(item);
            }
        }
    }
}
