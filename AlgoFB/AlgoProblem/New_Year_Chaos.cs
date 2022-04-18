using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        //Ref: https://www.hackerrank.com/challenges/new-year-chaos/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        //Sol: https://www.youtube.com/watch?v=DW6NvbuuCBU
        //Sol: https://www.youtube.com/watch?v=LszGnIL3PLQ
        public static string New_Year_Chaos_Swap(int[] A)
        {

            string result = "To Chaotic";


            #region Explanation
            //        
            //      2 - (i0 +1) = 1
            //      1 - (i1 +1) = -1        
            //      5 - (i2 +1) = 2        
            //      3 - (i3 +1) = -1        
            //      4 - (i4 +1) = -1        

            //5 1 2 3 7 8 6 4
            //4 0 1 2 6 7 5 3
            //0 1 2 3 4 5 6 7(current index)

            //<wrong Chaotic>        
            //2 5 1 3 4 Array
            //1 4 0 2 3 Original index                
            //0 1 2 3 4(current index)
            //  
            //2 - (i0 +1) = 1
            //5 - (i1 +1) = 3        
            //1 - (i2 +1) = -2        
            //3 - (i3 +1) = -1        
            //4 - (i4 +1) = -1        

            //Correct        
            //    *1 2 5 3 7 8 6 4                             
            //     0 1 4 2 6 7 5 3  Original index                           
            //     0 1 2 3 4 5 6 7 [loop index]
            //+1  *1 2 3 4 5 6 7 8 [after +1 as queue start from 1 not from 0]
            //-                           
            //Orig    0 1 2 3 4                                     
            //<Correct>                                                    
            //Final   2 1 5 3 4                                               
            //Org     1 0 4 2 3                                      
            //Cur  -  0 1 2 3 4 
            #endregion

            int swap_count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                //Final   2 1 5 3 4                                               
                //Cur  -  1 2 3 4 5 (i+1)
                //diff    
                //            WOW
                if (A[i] - (i + 1) > 2)//No more than 2 moves are allowd
                {
                    return result;
                }
                //                  WOW                WOW                    
                for (int j = Math.Max(0, (A[i] - 2)); j < i; j++)
                {
                    if (A[j] > A[i])
                    {
                        Console.WriteLine($"j {j}   i {i}  A[j] {A[j]}   A[i]{A[i]}  swap_count{swap_count}");
                        swap_count++;
                    }

                }


            }

            return Convert.ToString(swap_count);
        }
    }
}
