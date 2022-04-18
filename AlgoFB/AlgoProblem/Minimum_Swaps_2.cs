using System;
using System.Collections.Generic;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        #region Explanation

        /*
            You are given an unordered array consisting of consecutive integers ∈ [1, 2, 3, ..., n] without any duplicates.

            Take a closer look. What's in there that your solution is not using?

            There's nothing in your implementation that benefits from integers being consecutive, without any duplicates. That is, it's not benefitting from this constraint on the input:

            1 ≤arr[i] ≤ n

            //WOW//In other words, the input consists of the numbers 1,2,3,...,n, shuffled. Given such input, you can produce a correct ordering in O(n). And as such, maybe sorting is not needed here after all.

            This is still just a hint, without directly answering how to compute the minimum number of swaps. But this observation must surely be part of the implementation.

            (I suggest to stop reading here and try to come up with an algorithm that uses the above observation and implement a passing solution. Continue reading only if you need hints.)

            Alternative algorithm
            Consider this algorithm:

            Build an array of indexes of the values in the input: indexes[arr[i] - 1] = i;.
            Iterate over the input array, and when arr[i] != i + 1, then swap arr[i] with arr[indexes[i]], and update the index of the original value of arr[i].
            For example, for [7, 1, 3, 2, 4, 5, 6], the content of indexes would be [1, 3, 2, 4, 5, 6, 0] (indexes[7 - 1] = 0; indexes[1 - 1] = 1; indexes[3 - 1] = 2; ....

            Then, the content of arr and indexes will go through these changes:

            i       = 0; 7 != 1 so swap it with 1 (the element that belongs here)
            arr     = [7, 1, 3, 2, 4, 5, 6]
            indexes = [1, 3, 2, 4, 5, 6, 0]

            i       = 1; 7 != 2 so swap it with 2 (the element that belongs here)
            arr     = [1, 7, 3, 2, 4, 5, 6]
            indexes = [1, 3, 2, 4, 5, 6, 1]

            i       = 2; 3 == 3 so no swap
            arr     = [1, 2, 3, 7, 4, 5, 6]
            indexes = [1, 3, 2, 4, 5, 6, 3]

            i       = 3; 7 != 4 so swap it with 4 (the element that belongs here)
            arr     = [1, 2, 3, 4, 7, 5, 6]
            indexes = [1, 3, 2, 4, 5, 6, 4]
            And so on, two more swaps (total 5) and 7 reaches the end.

            Bugs in questions
            I don't recall ever finding a bug in an online puzzle (and that should always be the very last thought on your mind), but this puzzle has one. The 3rd sample input [1, 3, 5, 2, 4, 6, 8] (Testcase 14) violates the constraint 1≤arr[i]≤n. The 8 should be replaced with 7. I worked around that by doing this when building indexes:

            if (arr[i] > N) arr[i] = N;
        */

        #endregion Explanation

        public static int Minimum_Swaps_2_Wrong(int[] arr)
        {
            //arr array
            //2  3  4  1  5
            //indexes array
            //0  1  2  3  4
            //indexes[ar[iaka0]-1] = iaka0
            //indexes[2-1] = 0;
            //indexes[1] = 0
            //indexs[ar[iaks1] - 1] = iaka
            //indexes[3-1] = 1

            //indexes
            //3  0  1  2  4

            //arr
            //1  2  3  4  5

            int minSwapCount = 0;
            int[] indexes = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                indexes[arr[i] - 1] = i;
            }
            //print(indexes);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != i + 1)
                {
                    minSwapCount++;
                    AlgoSorting.SortingAlgo.Swap(arr, i, arr[indexes[i]]);
                    indexes[arr[i]] = i;
                    //i =0
                    //indexs[i] = 3
                    //2  3  4  1  5 to 1* 3  4 2* 5

                    //i = 1
                    //indesx[1] = 0

                    Console.WriteLine($"i {i}");
                    //indexes[ar[i]]
                    
                }
            }

            return minSwapCount;
        }
        //ref: https://www.youtube.com/watch?v=J9ikRMK8Yhs
        public static int Minimum_Swap_Count_Map(int[] arr)
        {
            int swap = 0;
            bool[] visited = new bool[arr.Length + 1];
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 1; i < visited.Length; i++)
            {
                dic.Add(i, arr[i - 1]);
            }
            for (int k = 1; k < dic.Count; k++)
            {
                int nextNode = 0;
                if (visited[k] == false)
                {
                    visited[k] = true;
                    if (dic[k] == k)
                    {
                        continue;
                    }
                    else
                    {
                        int c = dic[k];
                        while (!visited[c])
                        {
                            visited[c] = true;
                            nextNode = dic[c];
                            c = nextNode;
                            ++swap;

                        }
                        
                    }
                }
            }



            return swap;
        }
    }
}