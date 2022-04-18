using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoSorting
{
    public static partial class SortingAlgo
    {
        public static void Swap(int[] arr, int i, int j)
        {
            var tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

    }
}
