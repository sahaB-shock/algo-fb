using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        #region Explanation
        /*
 Ref: https://leetcode.com/problems/find-all-anagrams-in-a-string/
 Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.
    Strings consists of lowercase English letters only and the length of both strings s and p will not be larger than 20,100.
    The order of output does not matter.
    Example 1:
    Input:
    s: "cbaebabacd" p: "abc"
    Output:
    [0, 6]
    Explanation:
    The substring with start index = 0 is "cba", which is an anagram of "abc".
    The substring with start index = 6 is "bac", which is an anagram of "abc".
      */
        //Ref: https://www.geeksforgeeks.org/anagram-substring-search-search-permutations/
        #endregion
        public static List<int> Find_All_Anagrams_in_a_String(string main, string ana)
        {
            #region Wrong
            //if (!string.IsNullOrEmpty(ana))//TODO
            //{
            //    var subStrLen = ana.Length;
            //    var anaS = SortString(ana);

            //    for (int i = 0; i + subStrLen - 1 < main.Length; i++)
            //    {
            //        var suStr = SortString(main.Substring(i, subStrLen));
            //        Console.WriteLine(suStr);
            //        if (suStr == anaS)
            //        {
            //            index.Add(i);
            //        }
            //    }

            //} 
            #endregion
            List<int> index = new List<int>();
            if (string.IsNullOrEmpty(main) || string.IsNullOrEmpty(ana))
                return index;

            char[] mainArr = new char[256];
            char[] anaArr = new char[256];

            for (int i = 0; i < ana.Length; i++)
            {
                mainArr[main[i]]++;
                anaArr[ana[i]]++;
            }
            int pLen = ana.Length;
            int mLen = main.Length;

            for (int i = pLen; i < mLen; i++)
            {
                if (IsTwoArraySame(mainArr, anaArr))
                {
                    index.Add(i - pLen);
                }
                mainArr[main[i]]++;

                mainArr[main[i - pLen]]--;

            }
            if (IsTwoArraySame(mainArr, anaArr))
            {
                index.Add(mLen - pLen);
            }


            return index;
        }

        static bool IsTwoArraySame(char[] a, char[] b)
        {
            for (int i = 0; (i < a.Length && i < b.Length && a.Length == b.Length); i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static string SortString(string s)
        {
            var ar = s.ToCharArray();
            Array.Sort(ar);
            return new String(ar);
        }
        public static long GetAscii(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            long asci = 0;
            for (int i = 0; i < s.Length; i++)
            {
                asci += s[i];
            }
            return asci;
        }
    }
}
