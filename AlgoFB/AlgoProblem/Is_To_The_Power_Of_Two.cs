using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static bool Is_To_The_Power_Of_Two(int n)
        {
            var val1 = Math.Ceiling(Math.Log(n) / Math.Log(2));
            var val2 = Math.Floor(Math.Log(n) / Math.Log(2));

            return val1 == val2;
        }
        public static bool Is_To_The_Power_Of_Two_Iterative(int n)
        {
            while (n != 1)
            {
                if (n % 2 != 0)
                    return false;
                n = n / 2;
            }

            return true;
        }

    }
}
