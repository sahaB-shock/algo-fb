using System;
using System.Collections.Generic;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {

        public static int LengthOfLongestSubstring_Optimized(string s)
        {
            int max_len_unique_substring = 0;
            if (string.IsNullOrEmpty(s))
                return max_len_unique_substring;

            HashSet<char> ht = new HashSet<char>();
            // p w w k e w
            //   ↑(i)
            // ↑(j)

            int i = 0;//second pointer
            int j = 0;//first pointer 
            while (j < s.Length)
            {
                if (!ht.Contains(s[j]))
                {
                    ht.Add(s[j]);
                    j++;
                    max_len_unique_substring = Math.Max(max_len_unique_substring, ht.Count);
                }
                else
                {
                    ht.Remove(s[i]);
                    i++;
                }

            }

            return max_len_unique_substring;

        }

        /// <summary>Longest Substring Without Repeating Characters</summary>
        /// <param name="s">The sring</param>
        /// <returns></returns>
        //public static int LengthOfLongestSubstring(string s)
        //{
        //    /*
        //    Example 1:
        //    Input: "abcabcbb"
        //    Output: 3
        //    Explanation: The answer is "abc", with the length of 3.

        //    Example 2:
        //    Input: "bbbbb"
        //    Output: 1
        //    Explanation: The answer is "b", with the length of 1.

        //    Example 3:
        //    Input: "pwwkew"
        //    Output: 3
        //    Explanation: The answer is "wke", with the length of 3.
        //    Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

        //    */

        //    //brute force :: Starts
        //    int maxLenghtOfUniquesCharSubstring = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int j = i + 1; j < s.Length; j++)
        //        {
        //            if (UniqueSubString(s, i, j))
        //            {
        //                maxLenghtOfUniquesCharSubstring = Math.Max(maxLenghtOfUniquesCharSubstring, j - i);
        //            }
        //        }
        //    }
        //    //brute force :: Ends



        //    return maxLenghtOfUniquesCharSubstring;
        //}

        //public static bool UniqueSubString(string s, int start, int end)
        //{
        //    bool isUnique = true;
        //    HashSet<char> ht = new HashSet<char>();
        //    for (int a = start; a < end; a++)
        //    {
        //        if (!ht.Contains(s[a]))
        //        {
        //            ht.Add(s[a]);
        //        }
        //        else
        //        {
        //            isUnique = false;
        //        }
        //    }

        //    return isUnique;
        //}
    }
}