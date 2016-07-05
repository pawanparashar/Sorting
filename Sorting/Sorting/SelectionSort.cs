using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class SelectionSort
    {


        // O(n power 2)
        public int[] SelectionSorter(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int indexofsmallest = min(array, i + 1, array[i]);
                if(array[i] > array[indexofsmallest])
                {
                    Swap(ref array[i], ref array[indexofsmallest]); 
                }
            }
            return array;
        }
        public int min(int[] array,int start,int number)
        {
            int index = 0;
            int min =int.MaxValue;
            while (start <array.Length)
            {
                if (array[start] < min)
                {
                    min = array[start];
                    index = start;
                }
                start++;
            }
            return index;
        }

        public void Swap(ref int a,ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

    }
}
