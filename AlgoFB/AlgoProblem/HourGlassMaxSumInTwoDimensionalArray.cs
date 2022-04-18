using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        //public static int Hour_Glass_Max_Sum_In_Two_Dimensional_Array(int[,] arr)
        //then arr[r,c]
        //Hour Glass
        //a b c
        //  e
        //g h i
        // array should be 3 x 3    
        //Possible Hour Glass
        //= to count of possible top left cells
        //

        //Input : 
        //↓0→ 3→ 0→ 0 0
        //↓0→ 1→ 0→ 0 0
        //↓1→ 1→ 1→ 0 0
        // 0  0  2  4 4
        // 0  0  0  2 4

        //5 x 5 array
        //9 hour glasses.
        //ROW-2 * COLUMN-2
        //5-2 * 5-2
        //3 * 3
        //9
        public static int Hour_Glass_Max_Sum_In_Two_Dimensional_Array(int[][] arr)
        {
            /// int maxSum = 0;// sum could be higher negative. this wrong to set to 0
            int maxSum = int.MinValue;
            int row = arr.Length;
            int col = arr[0].Length;

            for (int r = 0; r < row - 2; r++)
            {
                for (int c = 0; c < col - 2; c++)
                {
                    var tempSum = arr[r][c] + arr[r][c + 1] + arr[r][c + 2]
                                          + arr[r + 1][c + 1]
                            + arr[r + 2][c] + arr[r + 2][c + 1] + arr[r + 2][c + 2];

                    maxSum = Math.Max(maxSum, tempSum);

                }
            }
            return maxSum;

        }
    }
}
