using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        /*
         
        function power( a, n )
        if (n = 0) 
        return(1)

        x = power(a,n/2)

        if (n is even) 
        return(x*x)
        else 
        return(a*x*x)
             */
        public static double Math_Pow_Algo_Not_Optimized(double number, int to_the_power)
        {
            if (number == 0)
                return 1;
            if (to_the_power == 0)
                return 1;
            if (to_the_power == 1)
                return number;

            bool isNegative = false;
            if (to_the_power < 0)
            {
                isNegative = true;
                to_the_power = (-1) * to_the_power;
            }
            int i = 1;
            double pow = number;
            while (i < to_the_power)
            {
                pow *= number;
                i++;
            }

            if (isNegative)
            {
                return (double)(1 / pow);
            }
            else
            {
                return pow;
            }
        }
        /*
         
        function power( a, n )
        if (n = 0) 
        return(1)

        x = power(a,n/2)

        if (n is even) 
        return(x*x)
        else 
        return(a*x*x)
             */
        public static double Math_Pow_Algo_Optimized(double number, int to_the_power)
        {
            if (to_the_power == 0)
                return 1;

            /*bool isNegative = false;
            if (to_the_power < 0)
            {
                isNegative = true;
                to_the_power = (-1) * to_the_power;
            }*/

            var result = Math_Pow_Algo_Optimized(number, (to_the_power / 2));

            if (to_the_power % 2 == 0)
            {
                return result * result;
            }
            else
            { 
                return number * result * result;
            }
        }
    }
}

