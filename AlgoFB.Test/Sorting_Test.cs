using AlgoFB.AlgoSorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class Sorting_Test
    {
        [TestMethod]
        public void Test_MergeSort()
        {
            var u = new int[] { 5, 8, 3, 1, 7, 9, 2 };
            MergeSort(u);
            var u2 = new int[] { 5, 8, 3, 1, 7, 9, 2 };
            SortingAlgo.Sorting_Merge_ONlogN(u2);
        }
        static void MergeSort(int[] ar)
        {
            if (ar?.Length == 1)
                return;

            int mid = ar.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[ar.Length - mid];

            Array.Copy(ar, 0, left, 0, left.Length);
            Array.Copy(ar, mid, right, 0, right.Length);
            MergeSort(left);
            MergeSort(right);

            MergeThem(left, right, ar);
        }

        static void MergeThem(int[] left, int[] right, int[] mainArray)
        {
            int iL = 0;
            int iR = 0;
            int iMain = 0;

            while (iL < left.Length && iR < right.Length)
            {
                if (left[iL] < right[iR])
                {
                    mainArray[iMain] = left[iL];
                    iL++;
                }
                else
                {
                    mainArray[iMain] = right[iR];
                    iR++;
                    //shiftCount = left.Length - iL;
                }
                iMain++;
            }//end while
            while (iL < left.Length)
            {
                mainArray[iMain] = left[iL];
                iL++;
                iMain++;
            }
            while (iR < right.Length)
            {
                mainArray[iMain] = right[iR];
                iR++;
                iMain++;
            }
        }
    }
}
