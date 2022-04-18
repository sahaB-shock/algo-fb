using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.MathProblem
{
    public static partial class MathTest
    {
        /// <summary>
        /// Finds all factors a number.
        /// </summary>
        /// <param name="intValue">The int value.</param>
        /// <returns></returns>
        static List<int> Find_All_Factors_A_Number(int intValue)
        {
            List<int> factors = new List<int>();

            //Imp: Math.Sqrt(intValue)
            for (int i = 1; i <= Math.Sqrt(intValue); i++)
            {
                if (intValue % i == 0)
                {
                    factors.Add(i);
                    factors.Add(intValue / i);
                }

            }

            return factors;
        }
    }
}
