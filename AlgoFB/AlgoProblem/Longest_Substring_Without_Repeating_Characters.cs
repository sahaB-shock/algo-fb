using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static int Longest_Substring_Without_Repeating_Characters(string s)
        {
            HashSet<char> hsChar = new HashSet<char>();
            int start_pointer = 0;
            int moving_pointer = 0;
            int max_unique_substring = 0;
            if (string.IsNullOrEmpty(s))
                return max_unique_substring;
            //pwwkew
            while (moving_pointer < s.Length)
            {
                if (!hsChar.Contains(s[moving_pointer]))
                {
                    hsChar.Add(s[moving_pointer]);
                    moving_pointer++;
                    max_unique_substring = Math.Max(max_unique_substring, hsChar.Count);
                }
                else
                {
                    hsChar.Remove(s[start_pointer]);
                    start_pointer++;
                }
            }

            return max_unique_substring;
        }
    }
}
