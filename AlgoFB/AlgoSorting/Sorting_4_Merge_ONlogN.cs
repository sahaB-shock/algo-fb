using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoSorting
{
    public static partial class SortingAlgo
    {
        public static void Sorting_Merge_ONlogN(int[] arr)
        {
            int len = arr.Length;
            //base condition//
            //*****************************//
            if (len == 1)
                return;//WOW
            //*****************************//


            int mid = len / 2;
            int[] left_array = new int[mid];
            int[] right_array = new int[len - mid];

            for (int i = 0; i <= mid - 1; i++)
            {
                left_array[i] = arr[i];
            }
            //for (int i = mid; i <= len - 1; i++)
            //{
            //    right_array[i - mid] = arr[i];
            //}
            for (int i = 0; i < len - mid; i++)
            {
                right_array[i] = arr[mid + i];
            }

            Sorting_Merge_ONlogN(left_array);
            Sorting_Merge_ONlogN(right_array);

            //Important 
            Merge_Two_Sorted_Array(left_array, right_array, arr);
        }

        public static void Merge_Two_Sorted_Array(int[] left_Array, int[] right_Array, int[] mainArray)
        {
            int left_len = left_Array.Length;
            int right_len = right_Array.Length;
            //int[] newArray = new int[left_len + right_len];

            int iL = 0, iR = 0, iNew = 0;
            while (iL < left_len && iR < right_len)
            {
                if (left_Array[iL] <= right_Array[iR])
                {
                    mainArray[iNew] = left_Array[iL];
                    iL++;
                    iNew++;
                }
                else//left_Array[iL] < right_Array[iR]
                {
                    mainArray[iNew] = right_Array[iR];
                    iR++;
                    iNew++;
                }
            }
            while (iL < left_len)
            {
                mainArray[iNew] = left_Array[iL];
                iL++;
                iNew++;
            }

            while (iR < right_len)
            {
                mainArray[iNew] = right_Array[iR];
                iR++;
                iNew++;
            }
        }
    }
}
