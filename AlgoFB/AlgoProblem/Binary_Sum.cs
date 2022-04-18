using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {

        public static string Binary_Sum(string a, string b)
        {

            // Initialize result 
            string result = "";

            // Initialize digit sum 
            int s = 0;

            // Traverse both strings starting  
            // from last characters 
            int i = a.Length - 1, j = b.Length - 1;
            while (i >= 0 || j >= 0 || s == 1)//WOW
            {

                // Compute sum of last  
                // digits and carry 
                //                '1' - '0'
                // ASCII           49 - 48
                s += ((i >= 0) ? a[i] - '0' : 0); //WOW work with ASCII value
                s += ((j >= 0) ? b[j] - '0' : 0);

                // If current digit sum is  
                // 1 or 3, add 1 to result
                //                             
                //              1%2 + '0'              
                //              1   + 48
                //                  49
                //                  '1'
                result = (char)(s % 2 + '0') + result;//WOW

                // Compute carry 
                s = s / 2;

                // Move to next digits 
                i--; j--;
            }
            return result;
        }
    }
}
