using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {

        /// <summary>
        /// Reverses the array with for and two counters
        /// </summary>
        /// <param name="ar">The array.</param>
        /// <returns></returns>
        public static int[] ReverseArray(int[] ar)
        {

            for (int i = 0, j = ar.Length - 1; i < ar.Length / 2; i++, j--)
            {
                int currentItem = ar[i];
                ar[i] = ar[j];
                ar[j] = currentItem;
                //below is redundant 
                if (j <= i)
                    break;
            }

            return ar;
        }



        /// <summary>
        /// Reverses the array with while loop
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        static void ReverseArray(int[] arr, int start, int end)
        {
            int temp;

            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
