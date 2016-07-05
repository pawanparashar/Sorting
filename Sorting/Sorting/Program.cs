using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] array = { 14,33,27,35,16};

            QuickSort QS = new QuickSort();
            var result = QS.QuickSorter(array,0,array.Length-1);


        }
    }
}
