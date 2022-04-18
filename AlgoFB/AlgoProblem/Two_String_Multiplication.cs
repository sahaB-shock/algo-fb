using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        //Not corrrect
        public static string Two_String_Multiplication(string num1, string num2)
        {
            double multi = Convert_String_To_Number(num1) * Convert_String_To_Number(num2);

            return Convert.ToString(multi);
        }

        public static double Convert_String_To_Number(string nums)
        {
            double num_1 = 0;
            for (int i = nums.Length - 1, pow = 0; i > -1; i--, pow++)
            {
                num_1 += char.GetNumericValue(nums[i]) * Math.Pow(10, pow);
            }
            return num_1;
        }
    }
}
