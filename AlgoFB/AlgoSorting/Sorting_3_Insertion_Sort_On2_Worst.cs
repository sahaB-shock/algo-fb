using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoSorting
{
    public static partial class SortingAlgo
    {
        public static void Sorting_Insertion_Sort_On2_Worst(int[] arr)
        {
            //0 1 2 3 4
            //8 7 6 5 4
            //  ↑
            //  1 start loop
            /*
             
             Outer Loop
             target         7    
             target index   1
                inner loop 8 > 7
                7 8 6 5 4
             
             */
            int len = arr.Length;
            for (int i = 1/*  WOW */; i < len; i++)
            {
                var targetValue = arr[i];
                var targetIndex = i;
                //                                      **
                while (targetIndex > 0 && arr[targetIndex - 1]/***/ > targetValue)
                {
                //                                 **
                    arr[targetIndex] = arr[targetIndex - 1];
                    targetIndex--;
                }
                arr[targetIndex] = targetValue;
            }
        }
    }
}
