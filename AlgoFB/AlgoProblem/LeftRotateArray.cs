using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        //0,1,2,3,4
        //1,2,3,4,5
        //1     //2,3,4,5,1 → ar[last] = ar[0] at the same time, push to left all items
        //2     //3,4,5,1,2 → ar[last] = ar[0] at the same time, push to left all items

        /*for(int i=0; i < ar.Length; i++)
        {
            var lastItem = ar[ar.Length - 1];
            ar[ar.Length -1]  = ar[i];
            ar[0] = ar[i+1]//ar[0] = ar[1];//2
            
            ar[1] = ar[2];//3
            ar[2] = ar[3];//4
                       
            ar[3] = lastItem;//5
        }*/
        /// <summary>
        /// Lefts the rotate.THIS WILL WORK, IF moveCount is LESS than ARRAY SIZE.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="moveCount">The move count.</param>
        /// <returns></returns>
        public static int[] LeftRotate(int[] arr, int moveCount)
        {
            var array_size = arr.Length;
            int[] rotated_array = new int[array_size];
            int i = 0;
            int rotate_index = moveCount;

            while (rotate_index < array_size)
            {
                rotated_array[i] = arr[rotate_index];
                i++;
                rotate_index++;
            }//3 4 5 0 0 for 1 2 3 4 5 

            rotate_index = 0;
            while (rotate_index < moveCount)
            {
                rotated_array[i] = arr[rotate_index];
                i++;
                rotate_index++;
            }// 3,4,5 <1,2>  for 1 2 3 4 5


            return rotated_array;
        }
        public static int[] LeftRotate_Optimized(int[] arr, int arrayLength, int moveCount)
        {


            #region Explanation
            //1 2 3 4 5 6
            //0 1 2 3 4 5

            //2 Rotation
            //  //3 4 5 6 1 2
            //  //2 3 4 5 0 1
            //O/p 0 1 2 3 4 5
            //move count 2
            //length 6

            //mod = moveCount % length
            //mod = 2 % 6 = 2

            //(i(0)+2(mod))% 6(length) = 2
            //(i(1)+2(mod))% 6(length) = 3
            //(i(2)+2(mod))% 6(length) = 4
            //(i(3)+2(mod))% 6(length) = 5
            //(i(4)+2(mod))% 6(length) = 0
            //(i(5)+2(mod))% 6(length) = 1

            //2%6 = 2
            // = 3
            // = 4
            // = 5
            // = 0
            // = 1

            //move 3
            //length 6
            //  //4 5 6 1 2 3
            //  //3 4 5 0 1 2
            //O/p 0 1 2 3 4 5
            //mod = moveCount % length
            //mod = 3 % 6 = 3

            //(i(0)+3(mod))% 6(length) = 3
            //(i(1)+3(mod))% 6(length) = 4
            //(i(2)+3(mod))% 6(length) = 5
            //(i(3)+3(mod))% 6(length) = 0
            //(i(4)+3(mod))% 6(length) = 1
            //(i(5)+3(mod))% 6(length) = 2 
            #endregion
            int[] outputArray = new int[arrayLength];

            if (moveCount > 0)
            {
                int mod = moveCount % arrayLength;

                for (int i = 0; i < arrayLength; i++)
                {
                    var newIndex = (i + mod) % arrayLength;
                    outputArray[i] = arr[newIndex];
                }

            }

            return outputArray;
        }
    }
}
