using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        /// <summary>
        /// Sprials the two dimensional array clock wise.
        /// </summary>
        /// <param name="array_2d">The array 2d.</param>
        /// <returns></returns>
        public static int[] Sprial_Two_Dimensional_Array_ClockWise(int[][] array_2d)
        {
            int[][] sampleArray = null;
            if (array_2d == null || array_2d.Length == 0)
            {
                sampleArray = new int[][] { new int[] { 1, 2, 3, 4},
                                            new int[] { 5, 6, 7, 8},
                                            new int[] { 9, 10 ,11, 12 }
                                          };
            }
            array_2d = sampleArray;
            /*
             3x4 Array
                 0 1 2 3 


              L→ ++         -- ←R
           T↓++   0 → 1 2 3 4  1

                  1 → 5 6 7 8  3

                  2 → 9 5 6 7  5

           B↑--   3 → 3 4 6 6  8


             output:  1  2  3  10  20  30  9  8  7  4  5  6 
             indices  00 01 02 03  13  23  22 21 20 10 11 12 

            */

            /* THIS SOLUTION ONLY WORKS ROWS and COLUMNS are SAME in 2D Array 3x3 or 5x5*/
            /*
            Left → Right
            Top ↓ Bottom
            Right ← Left
            Bottom ↑ Top

            4 Directions
            → 0 Left to Right
            ↓ 1 Top to Bottom
            ← 2 Left to Right
            ↑ 3 Bottom to Left

            */
            
            List<int> output = new List<int>();
            
            var rows = array_2d.Length;
            var colums = array_2d[0].Length;
            int top = 0;
            int bottom = rows - 1;//3

            int left = 0;
            int right = colums - 1;//3
            int dir = 0;
            //0  L → R
            //1  T ↓ B
            //2  L ← R
            //3  T ↑ B

            var iCounter = 0;//No Need
            while (left <= right && top <= bottom)
            {
                // L → R
                if (dir == 0)
                {
                    for (int i = left; i <= right; i++)
                    {
                        var val = array_2d[top][i];
                        output.Add(val);

                        iCounter++; //No Need
                    }
                    top++;//top =1
                    dir++;
                }
                // T ↓ B
                else if (dir == 1)
                {
                    for (int d = top; d <= bottom; d++)
                    {
                        var val = array_2d[d][right];
                        output.Add(val);

                        iCounter++; //No Need
                    }
                    right--;//right =2
                    dir++;
                }
                // L ← R
                else if (dir == 2)
                {
                    for (int l = right; l >= left; l--)
                    {
                        var val = array_2d[bottom][l];
                        output.Add(val);

                        iCounter++; //No Need
                    }
                    bottom--;
                    dir++;
                }
                //T ↑ B
                else if (dir == 3)
                {
                    for (int l = bottom; l >= top; l--)
                    {
                        var val = array_2d[l][left];
                        output.Add(val);

                        iCounter++; //No Need

                    }
                    left++;
                    dir++;
                }
                System.Diagnostics.Debug.WriteLine($"iCounte{++iCounter} | dir:{dir}");
                dir = dir % 4;
            }



            return output.ToArray();
        }


        public static int[,] Sprial_Two_Dimension_Array_ForGivenNumber(int n)
        {
            int[,] arr = new int[n, n];
            /*
             input = 3
                123
                894
                765

                input = 4
                T→           
                 01 02 03 04 ↓
                 12 13 14 05
                 11 16 15 06
                 10 09 08 07 
                 ↑           ←


                input = 8
                1  2   3  4  5  6  7  8
                28 29 30 31 32 33 34  9
                27 48 49 50 51 52 35 10
                26 47 60 61 62 53 36 11
                25 46 59 64 63 54 37 12
                24 45 58 57 56 55 38 13
                23 44 43 42 41 40 39 14
                22 21 20 19 18 17 16 15

             */

            return arr;
        }
    }
}
