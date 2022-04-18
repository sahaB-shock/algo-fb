using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoSorting
{
    public static partial class SortingAlgo
    {

        public static void Sorting_Bubble_Sort_On2_at_Worst__DESC(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
        }
        public static void Sorting_Bubble_Sort_On2_Optimized(int[] arr)
        {
            //8 5 6 3 1
            //8 vs 5 → swap 5 8 631
            //8 vs 6 → swap 56 8 31
            //8 vs 3 → swap 563 8 1
            //8 vs 1 → swap 5631 8
            //--Pushed most big number in last
            //repeat above steps for 5 → Starts with 5631 8
            //5 vs 6 →  No swap → 5631 8
            //5 vs 3 → swap 36 5 1 8
            //5 vs 1 → swap 36 1 5 8
            //repeate for 3
            var swap = false;//////////////////////Optimization
            for (int i = 0; i < arr.Length; i++)
            {
                swap = false;//////////////////////Optimization//WOW
                for (int j = 0; j < arr.Length - i - 1; j++)//WOW
                {
                    if (arr[j + 1] < arr[j])//WOW
                    {
                        var tmp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tmp;

                        swap = true;//////////////////////Optimization
                    }
                }

                if (swap == false)//////////////////////Optimization
                {
                    break;
                }
            }

        }
    }
}
