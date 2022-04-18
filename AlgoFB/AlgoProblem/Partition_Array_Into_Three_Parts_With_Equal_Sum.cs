using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static bool Partition_Array_Into_Three_Parts_With_Equal_Sum(int[] A)
        {
            //Own sol
            //Ref: https://leetcode.com/problems/partition-array-into-three-parts-with-equal-sum/

            if (A == null)
                return false;
            if (A.Length == 0)
                return false;
            if (A.Length == 1)
                return true;

            var sum = A.Sum();
            var three_part_should_be_sum = sum / 3;

            if (sum % 3 != 0)
                return false;

            //4 2  3 3  1 1 4 [True]
            //3 3  4 3  1 1 4 [False]
            //0, 2, 1, -6, 6, 7, 9, -1, 2, 0, 1 [False]
            var sum_thru = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum_thru += A[i];

                if (sum_thru == three_part_should_be_sum)
                {
                    sum_thru = 0;
                }
            }
            return sum_thru == 0;
        }
    }
}
