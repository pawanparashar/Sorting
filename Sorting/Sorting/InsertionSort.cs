using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class InsertionSort
    {
        //O(n power 2) 

        public int[] InsertionSorter(int[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                array = Sorter(array, i);
            }
            return array;

        }

        public int[] Sorter(int[] array,int number)
        {
            for(int i = number; i > 0; i--)
            {
                if(array[i] < array[i - 1])
                {
                    Swap(ref array[i], ref array[i - 1]);
                }
            }
            return array;
        }

        public void Swap(ref int a,ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }


    }
}
