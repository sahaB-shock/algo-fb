using System;

namespace AlgoFB.AlgoSorting
{
    public static partial class SortingAlgo
    {
        public static int Sorting_3_Insertion_Sort_Left_Shift_Count(int[] arr)
        {
            shift = 0;
            Insertion_Sort_Shift_Count_Advance_Analysis(arr);
            return shift;
        }

        private static int shift = 0;

        private static void Insertion_Sort_Shift_Count_Advance_Analysis(int[] arr)
        {
            if (arr.Length == 1)
                return;//WOW

            int mid = arr.Length / 2;
            int[] left_array = new int[mid];
            int[] right_array = new int[arr.Length - mid];


            /*for (int i = 0; i < mid; i++)
            {
                left_array[i] = arr[i];
            }*/
            Array.Copy(arr, 0, left_array, 0, left_array.Length);

            /*
            for (int i = mid; i < arr.Length; i++)
            {
                right_array[i - mid] = arr[i];
            }*/
            Array.Copy(arr, mid, right_array, 0, right_array.Length);//WOW

            Insertion_Sort_Shift_Count_Advance_Analysis(left_array);
            Insertion_Sort_Shift_Count_Advance_Analysis(right_array);
            Merge_Two_Sorted_Array_Retrun_LeftShift(left_array, right_array, arr);
        }

        private static void Merge_Two_Sorted_Array_Retrun_LeftShift(int[] left_array, int[] right_array, int[] mainArray)
        {
            int left_len = left_array.Length;
            int right_len = right_array.Length;

            int iL = 0;
            int iR = 0;
            int iMain = 0;

            while (iL < left_len && iR < right_len)
            {
                if (left_array[iL] <= right_array[iR])
                {
                    mainArray[iMain] = left_array[iL];
                    iL++;
                }
                else
                {
                    mainArray[iMain] = right_array[iR];
                    iR++;
                    shift += left_len - iL;//WOW
                }
                iMain++;
            }

            while (iL < left_len)
            {
                mainArray[iMain] = left_array[iL];
                iL++;
                iMain++;
            }

            while (iR < right_len)
            {
                mainArray[iMain] = right_array[iR];
                iR++;
                iMain++;
            }

            /*
             		int[] rest;
		int restIndex;
		if (leftIndex >= left.length) {
			// The left array has been use up...
			rest = right;
			restIndex = rightIndex;
		} else {
			// The right array has been used up...
			rest = left;
			restIndex = leftIndex;
		}

		// Copy the rest of whichever array (left or right) was
		// not used up.
		for (int i = restIndex; i < rest.length; i++) {
			whole[wholeIndex] = rest[i];
			wholeIndex++;
		}
             */
        }
    }
}