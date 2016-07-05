using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class QuickSort
    {
        public int[] QuickSorter(int[] array,int low, int high)
        {
            int pivot;
            if(high > low)
            {
                pivot = Parition(array, low, high);
                QuickSorter(array, low, pivot - 1);
                QuickSorter(array, pivot + 1, high);
            }

            return array;

        }

        public int Parition(int[] A,int low,int high)
        {
            int left, right, pivot_items = A[low];
            left = low;
            right = high;
            while (left< right)
            {

                while (A[left] <=pivot_items)
                {
                    left++;
                }
                while(A[right]> pivot_items)
                {
                    right--;
                }
                if (left < right)
                {
                    Swap(ref A[left], ref A[right]);
                }

               

            }

            A[low] = A[right];
            A[right] = pivot_items;
            return right;


        }

        public void Swap(ref int a,ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

    }
}
