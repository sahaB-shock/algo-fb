using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoSorting
{
    public static partial class SortingAlgo
    {
        /*
         
        The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and putting it at the beginning. The algorithm maintains two subarrays in a given array.

        1) The subarray which is already sorted.
        2) Remaining subarray which is unsorted.

        In every iteration of selection sort, the minimum element (considering ascending order) from the unsorted subarray is picked and moved to the sorted subarray.



        Following example explains the above steps:



        arr[] = 64 25 12 22 11

        // Find the minimum element in arr[0...4]
        // and place it at beginning
        11← 25 12 22 64

        // Find the minimum element in arr[1...4]
        // and place it at beginning of arr[1...4]
        11 12← 25 22 64

        // Find the minimum element in arr[2...4]
        // and place it at beginning of arr[2...4]
        11 12 22← 25 64

        // Find the minimum element in arr[3...4]
        // and place it at beginning of arr[3...4]
        11 12 22 25← 64     
         */
        public static void Sorting_Selection_ON2(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minNumberIndex = i;

                for (int j = i + 1; j < arr.Length; j++)//WOW
                {
                    if (arr[j] < arr[minNumberIndex])
                    {
                        minNumberIndex = j;
                    }

                }
                if (arr[minNumberIndex] < arr[i])//WOW
                {
                    Swap(arr, i, minNumberIndex);
                }
            }
            /*
             static void Sorting_Selection_On2(int[] a)
                {
                    //8 5 6 3 1
                    //find the miinimum between 5 elements (8 5 6 3 1) nand bring 1 in 0 → 1 <8 5 6 3>
                    //find the miinimum between right 4 elements (1 <8 5 6 3>) nand bring 3 in 1 → 1 3 <8 5 6>
                    int len = a.Length;
        
                    for(int i = 0; i < len; i++)
                    {
                        for(int j = 0; j < len; j++)
                        {
                            if(a[i] < a[j])
                            {
                                var tmp = a[j];
                                a[j] = a[i];
                                a[i] = tmp;
                    
                            }
                        }
            
                    }
                }
             */
            //return arr;
        }



    }
}
