using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        //ref https://www.hackerrank.com/challenges/ctci-making-anagrams/problem
        //Strings: Making Anagrams
        /*Complete the makeAnagram function in the editor below. 
         * It must return an integer representing the minimum total characters that 
         * must be deleted to make the strings anagrams.
         */
        public static int Two_Word_Anagram_Deletion_Count(string a, string b)
        {
            int[] chars = new int[26];
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                chars[a[i] - 'a']++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                chars[b[i] - 'a']--;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                count += Math.Abs(chars[i]);
            }
            return count;
        }
    }
}
