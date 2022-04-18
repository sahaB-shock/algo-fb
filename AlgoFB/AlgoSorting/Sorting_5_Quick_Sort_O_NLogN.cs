using System;
using System.Collections.Generic;

namespace AlgoFB.AlgoSorting
{
    public static partial class SortingAlgo
    {
        /// <summary>
        /// Sortings the quick sort o n log n.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="partition_by_last_or_first_element">The partition by last or first element. 0 for first, 1 for last</param>
        public static void Sorting_Quick_Sort_O_NLogN(int[] arr, int partition_by_last_or_first_element = 0)
        {
            Quick_Sort(arr, 0, arr.Length - 1, partition_by_last_or_first_element);
        }

        private static void Quick_Sort(int[] arr, int start, int end, int partition_by_last_or_first_element = 0)
        {
            //if (start >= end)
            //    return;
            /*if (start < end)
            {

                int partition_inedx;
                if (partition_by_last_or_first_element == 0)
                    partition_inedx = Partition_By_First_Element_As_Pivot(arr, start, end);
                else
                    partition_inedx = Partition_By_Last_Element_As_Pivot(arr, start, end);
                if (partition_inedx > 1)
                {
                    Quick_Sort(arr, start, partition_inedx - 1);
                }
                if (partition_inedx + 1 < end)
                {
                    Quick_Sort(arr, partition_inedx + 1, end);
                }
                
                //if (partition_inedx > 0)
                Print(arr, start, end);
            }
            */
            /*Quick Sort 2 Print sorted left and right*/

            if (start < end)
            {
                int pivotIdx = Partition_By_Last_Element_As_Pivot(arr, start, end);
                Quick_Sort(arr, start, pivotIdx - 1);
                Quick_Sort(arr, pivotIdx + 1, end);
                //print(ar, start, end);
                Print(arr, 0, arr.Length - 1);
            }

        }



        private static int Parition_by_First_Element_Pivot_No_In_Place_QuicSort_2_Hacker_Rank(int[] ar, int start, int end)
        {
            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();

            int pivot = ar[start];
            for (int i = start + 1; i <= end; ++i)
            {
                if (ar[i] > pivot)
                {
                    rightList.Add(ar[i]);
                }
                else
                {
                    leftList.Add(ar[i]);
                }
            }
            int idx = start;
            for (int i = 0; i < leftList.Count; i++)
            {
                ar[idx++] = leftList[i];
            }
            ar[idx] = pivot;
            int pivotIdx = idx++;
            for (int i = 0; i < rightList.Count; i++)
            {
                ar[idx++] = rightList[i];
            }
            return pivotIdx;
        }



        private static int Partition_By_First_Element_As_Pivot(int[] arr, int start, int end)
        {
            #region Explanation
            //-13, 68, -43, -71, -39, -10
            //-13 is pivot value
            //0+1 is pivot index

            //-13, 68, -43, -71, -39, -10
            //-13  -43  68  -71  -39  -10
            //-13  -43 -71  68  -39  -10
            //-13  -43 -71 -39  68  -10
            // swap -39 and -13
            //-13  -43 -71 -39  68  -10
            //-39  -43 -71 -13  68  -10 
            #endregion
            int pivot_value = arr[start];//0
            int pivot_index = start + 1;

            for (int i = pivot_index; i < end; i++)
            {
                if (arr[i] <= pivot_value)
                {
                    Swap(arr, i, pivot_index);
                    pivot_index++;
                }
            }
            Swap(arr, start, pivot_index - 1);//WOW

            return pivot_index;
        }
        private static int Partition_By_Last_Element_As_Pivot(int[] arr, int start, int end)
        {
            #region Explanation
            // -13, 68, -43, -71, -39, -10  
            // -10 is pivot value  
            // -13  68  -43  -71  -39  -10
            // -13 -43  68   -71  -39  -10        
            // -13 -43 -71   68  -39  -10        
            // -13 -43 -71  -39   68  -10        
            // final swap with pivot
            // -13 -43 -71  -39   -10  68 
            #endregion
            int pivot_value = arr[end];
            int pivot_index = start - 1;//WOW
            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot_value)
                {
                    pivot_index++;
                    Swap(arr, i, pivot_index);
                }
            }
            Swap(arr, pivot_index + 1, end);
            return pivot_index + 1;
        }

    }
}