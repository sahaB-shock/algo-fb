using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static double Find_The_Median_Of_Sorted_Array(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 && nums2.Length == 0)
                return 0;


            int[] mergedArray = new int[nums1.Length + nums2.Length];
            var len = mergedArray.Length;

            for (int i = 0; i < nums1.Length; i++)
                mergedArray[i] = nums1[i];

            for (int i = 0; i < nums2.Length; i++)
                mergedArray[i + (nums1.Length)] = nums2[i];

            Array.Sort(mergedArray);
            double median = 0;
            if (len % 2 == 0)
            {
                //var leftIndex = (len/2) -1 ;//10/2 = 5 then -1 = 4
                //var rightIndex = (len/2)  ;//10/2 = 5 then 5
                median = ((double)(mergedArray[(len / 2) - 1] + mergedArray[(len / 2)]) /  (double)2);
            }
            else
            {
                median = mergedArray[len / 2];
            }
            return median;
        }
    }
}
