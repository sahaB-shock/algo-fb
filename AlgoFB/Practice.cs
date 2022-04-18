using AlgoFB.AlgoSorting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB
{
    public static class Practice
    {
        public static void Quick_Sort(int[] A, int start, int end)
        {

            if (start < end)
            {
                var pivot_index = Pivot_Index(A, start, end);
                Quick_Sort(A, start, pivot_index - 1);
                Quick_Sort(A, pivot_index + 1, end);
            }
        }

        static int Pivot_Index(int[] arr, int start, int end)
        {/*
            int pivot_value = arr[start];//0
            int pivot_index = start + 1;

            for (int i = pivot_index; i <= end; i++)
            {
                if (arr[i] <= pivot_value)
                {
                    SortingAlgo.Swap(arr, i, pivot_index);
                    pivot_index++;
                }
            }
            SortingAlgo.Swap(arr, start, pivot_index - 1);//WOW

            return pivot_index;
            */
            int pivot_value = arr[end];
            int pivot_index = start;//WOW
            //int pivot_index = start - 1;//WOW
            for (int i = 0; i <= end - 1; i++)
            {
                if (arr[i] <= pivot_value)
                {
                    SortingAlgo.Swap(arr, i, pivot_index);
                    pivot_index++;
                }
            }
            SortingAlgo.Swap(arr, pivot_index, end);
            return pivot_index + 1;
        }
        public static void Anagrams_In_SubArray(string s)
        {//https://www.hackerrank.com/challenges/sherlock-and-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
            Dictionary<string, int> dic = new Dictionary<string, int>();
            
            int count_ana = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //All substring  WOW
                //All    WOW     WOW
                for (int j = 1; j + i - 1 < s.Length; j++)
                {
                    var subStr = s.Substring(i, j);
                    subStr = SortString(subStr);
                    Console.WriteLine(subStr);

                    if (!dic.ContainsKey(subStr))
                    {
                        dic.Add(subStr, 1);
                    }
                    else
                    {
                        dic[subStr] += 1;
                    }

                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine(item.Value);
                //Possible anagram: 
                //WOW//frequence * (frequence -1)/2
                //Console.WriteLine($"key {item.Key} value {item.Value}" );
                count_ana += item.Value * (item.Value - 1) / 2;
                Console.WriteLine($"item value {item.Value * (item.Value - 1) / 2}");
            }

            Console.WriteLine(count_ana);
        }
        public static string Check_Magazine_Word_Ransome_Easy(string magazineStr, string noteStr)
        {
            var magazine = magazineStr.Split(' ');
            var note = noteStr.Split(' ');
            if (magazine?.Length == 0)
                return "No";

            if (note?.Length > magazine?.Length)
                return "No";

            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                if (!dic.ContainsKey(magazine[i]))
                {
                    dic.Add(magazine[i], 1);
                }
                else
                {
                    dic[magazine[i]] += 1;
                }
            }

            for (int i = 0; i < note.Length; i++)
            {
                if (dic.ContainsKey(note[i]))
                {
                    if (dic[note[i]] <= 0)
                        return "No";
                    dic[note[i]] -= 1;//TODO

                }
                if (!dic.ContainsKey(note[i]))
                {
                    return "No";
                }
            }
            return "Yes";
        }
        /// <summary>
        /// Selections the sort move minimum at beginning.
        /// </summary>
        /// <param name="A">a.</param>
        /// <returns>Swap Count</returns>
        public static int Selection_Sort_Move_Min_At_Beginning(int[] A)
        {
            int swap_Count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                var min_value_index = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[min_value_index])
                    {
                        min_value_index = j;
                    }
                }
                if (A[min_value_index] < A[i])
                {
                    AlgoSorting.SortingAlgo.Swap(A, min_value_index, i);
                    swap_Count++;
                }

            }
            return swap_Count;
        }

        /// <summary>
        /// Bubbles the sort move largest to end. Keep swapping next to each other element till largest reaches at end
        /// </summary>
        /// <param name="A">a.</param>
        /// <returns>Swap Count</returns>
        public static int Bubble_Sort_Move_Largest_To_End(int[] A)
        {
            int swapCount = 0;
            for (int i = 0; i < A.Length; i++)
            {
                var val_to_swap = A[i];

                for (int j = i + 1; j <= A.Length - i - 1; j++)
                {
                    if (A[j] < A[j - 1])
                    {
                        AlgoSorting.SortingAlgo.Swap(A, j, i);
                        swapCount++;
                    }
                }
            }

            return swapCount;
        }

        static string SortString(string s)
        {
            var sArr = s.ToCharArray();
            Array.Sort(sArr);
            return new string(sArr);

        }

        public static List<string> Get_All_Possible_SubString(string s = "abcdef")
        {
            List<string> lst = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j + i - 1 < s.Length; j++)
                {
                    lst.Add(s.Substring(i, s.Length - i - j));
                }
            }
            return lst;
        }
    }
}
