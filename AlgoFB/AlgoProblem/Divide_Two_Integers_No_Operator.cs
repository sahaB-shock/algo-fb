using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        /// <summary>
        /// Divides the two integers no operator timed out.
        /// </summary>
        /// <param name="dividend">The dividend.</param>
        /// <param name="divisor">The divisor.</param>
        /// <returns></returns>
        /// LeetCode: https://leetcode.com/problems/divide-two-integers/
        public static int Divide_Two_Integers_No_Operator_Timed_Out(int dividend, int divisor)
        {
            int res = 0;
            int isNegative = 1;
            if (dividend < 1)
            {
                isNegative *= -1;
            }
            if (divisor < 1)
            {
                isNegative *= -1;
            }
            uint dividend2 = (uint)Math.Abs((double)dividend);
            uint divisor2 = (uint)Math.Abs((double)divisor);


            if (divisor2 == 1)
            {
                if (dividend == int.MinValue && isNegative != -1)
                {
                    dividend2 -= 1;
                }
                return (int)(dividend2 * isNegative);
            }
            while (dividend2 >= divisor2)
            {
                dividend2 = dividend2 - divisor2;
                res++;
            }
            Console.WriteLine(dividend);
            return res * isNegative;
        }
    }
}
