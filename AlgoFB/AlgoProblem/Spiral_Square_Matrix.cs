using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo 
    {
        public static int[][] GenerateMatrix(int n)
        {
            int[][] o = new int[n][];
            for (int i = 0; i < o.Length; i++)
            {
                o[i] = new int[n];
            }

            int left = 0;
            int right = n - 1;
            int top = 0;
            int bottom = n - 1;
            int dir = 0;
            int val = 1;
            while (left <= right && top <= bottom)
            {
                if (dir == 0)
                {
                    for (int i = left; i <= right; i++)
                    {
                        o[top][i] = val;
                        val++;
                    }
                    dir++;
                    top++;
                }
                if (dir == 1)//↓
                {
                    for (int i = top; i <= bottom; i++)
                    {
                        o[i][right] = val;
                        val++;
                    }
                    right--;
                    dir++;
                }
                if (dir == 2)//←
                {
                    for (int i = right; i >= left; i--)
                    {
                        o[bottom][i] = val;
                        val++;
                    }
                    dir++;
                    bottom--;
                }
                if (dir == 3)//↑
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        o[i][left] = val;
                        val++;
                    }
                    left++;
                    dir++;
                }
                dir = dir % 4;
            }

            return o;
        }
    }
}
