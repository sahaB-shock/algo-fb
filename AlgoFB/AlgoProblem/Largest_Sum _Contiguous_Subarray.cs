using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static int MaxSubArray_Largest_Sum_Contiguous_Subarray(int[] nums)
        {
            int max_sum = int.MinValue;
            int max_sum_i = 0;
            int start = 0, end = 0, s = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                max_sum_i += nums[i];
                //Console.WriteLine($"i({i}) {max_sum_i}");
                if (max_sum_i > max_sum)
                {
                    //Console.WriteLine(max_sum);
                    max_sum = max_sum_i;
                    //Console.WriteLine(max_sum);
                    start = s;
                    end = i;
                }
                if (max_sum_i < 0)//WOW
                {
                    max_sum_i = 0;
                    s = i + 1;//The momment I find sum less than 
                    Console.WriteLine($"i({i}) {max_sum_i}");
                }
            }
            Console.WriteLine($"start{start}, end{end}");
            return max_sum;
        }
    }
}
