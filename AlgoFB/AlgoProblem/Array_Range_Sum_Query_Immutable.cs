using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public class Array_Range_Sum_Query_Immutable
        {
            //Ref: https://leetcode.com/problems/range-sum-query-immutable/
            //Ref: https://www.geeksforgeeks.org/range-sum-queries-without-updates/
            int[] _nums = null;
            public Array_Range_Sum_Query_Immutable(int[] nums)
            {
                _nums = new int[nums.Length];
                _nums[0] = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    _nums[i] = _nums[i - 1] + nums[i];
                }
                //printArray(_nums);
                //nums   1, 2, 3, 4, 5, 6
                //_nums  1  3  6  10 15 21        //WOW
            }

            public int SumRange(int i, int j)
            {
                if (i == 0)
                    return _nums[j];
                return _nums[j] - _nums[i - 1];
            }
            void printArray(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                    Console.Write($"{a[i]} ");
            }
        }
    }
}
