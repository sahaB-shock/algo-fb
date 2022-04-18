using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoSorting
{
    public static partial class SortingAlgo
    {
        /// <summary>
        /// Binaries the search in sorted 1 d array.
        /// </summary>
        /// <param name="sorted_array">The sorted array.</param>
        /// <param name="target_to_search">the index of searched integer</param>
        /// <returns></returns>
        public static int Binary_Search_In_Sorted_1D_Array(int[] sorted_array, int target_to_search, int leftPointer, int rightPointer)
        {
            //1,2,3,4,5,6,7,8,9,10,12,14,57,89
            //
            // test case injection : Starts
            int[] sampleArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 57, 89 };
            if (sorted_array == null || sorted_array.Length == 0)
            {
                sorted_array = sampleArray;
            }
            // test case injection : Ends
            //





            if (rightPointer >= leftPointer)//WOW >=
            {
                int mid = leftPointer + (rightPointer - leftPointer) / 2;//WOW leftpointer + 

                if (sorted_array[mid] == target_to_search)
                {
                    return mid;
                }
                else
                {
                    if (target_to_search < sorted_array[mid])
                    {
                        //Search Left
                        return Binary_Search_In_Sorted_1D_Array(sorted_array, target_to_search, leftPointer, mid - 1);
                    }
                    else if (target_to_search > sorted_array[mid])
                    {
                        //Search right
                        return Binary_Search_In_Sorted_1D_Array(sorted_array, target_to_search, mid + 1, rightPointer);

                    }
                }
            }

            return -1;
        }


        public static int Binary_Search_In_Sorted_Array_Non_Recursive(int[] nums, int start, int end, int target)
        {
            while (end >= start)
            {
                var mid = start + ((end - start) / 2);
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] > target)
                {
                    //Left
                    end = mid - 1;
                }
                else
                {
                    //Right
                    start = mid + 1;
                }

            }
            return -1;
        }
    }
}
