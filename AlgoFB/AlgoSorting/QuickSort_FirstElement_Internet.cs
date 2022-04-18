using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoSorting
{
    public static partial class SortingAlgo
    {
        static void Print(int[] ar, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{ar[i]} ");
            }
            Console.WriteLine("");
        }
        public static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)//wow
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
                Print(arr, 0, arr.Length - 1);
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
    }
}
