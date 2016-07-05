using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BubbleSort
    {

        // O(n power 2) 
        public int[] BubbleSorter(int[] array)
        {
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }
            Console.WriteLine(count);
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
