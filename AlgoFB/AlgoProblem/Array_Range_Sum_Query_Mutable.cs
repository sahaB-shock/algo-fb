using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {

        public class Array_Range_Sum_Query_Mutable_Sqrt_Decomposition
        {
            private int[] _nums;
            private int[] block_sum;
            private int len;
            public Array_Range_Sum_Query_Mutable_Sqrt_Decomposition(int[] nums)
            {
                _nums = nums;
                double sqrt = Math.Sqrt(nums.Length);
                len = (int)Math.Ceiling(nums.Length / sqrt);
                block_sum = new int[len];
                for (int i = 0; i < _nums.Length; i++)
                {
                    block_sum[i / len] = block_sum[i / len] + _nums[i];
                }
            }

        }
    }
}