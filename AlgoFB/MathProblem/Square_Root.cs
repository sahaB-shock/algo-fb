using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.MathProblem
{
    public static partial class MathTest 
    {
        public static int Square_Root(long N)
        {
            if (N == 0 || N == 1)
                return (int)N;
            long start = 0;
            long end = N;
            while (end >= start)
            {
                //1 2 3 4 5 6 7 8 9
                var mid = start + (end - start )/ 2;
                if (mid * mid ==N)
                    return (int)mid;

                if (mid * mid > N)
                {
                    //left
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return (int)end;
        }

    }
}
