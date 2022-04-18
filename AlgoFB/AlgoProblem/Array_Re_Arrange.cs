using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static void Array_Re_Arrange(int[] A)
        {

            /*                                                          
                10 2 3 9 5 6            1 2 3           9 10                             
                0  1 2 3 4 5          0 1 2 3 4 5 6 7 8 9 10 
                A[A[i]] = A[i]
                A[10] = A[0]
                A[2] = A[1]
                A[3] = A[2]                                                     
                A[9] = A[3]     

                1 0 
                0 1
                A[1] = A[0]
                A[0] = A[1]
             */

            var size = A.Length;

            int[] temp = new int[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = A[A[i]];
            }



            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] + (A[A[i]] % size) * size;//WOW
            }
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] / size;//WOW
            }
        }
    }
}
