using System;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static long RepeatedString(string s, long n)
        {
            #region Info
            // String is abcac
            // n is 10
            // so string is: abcac abcac
            // val 1: n(10)/abcac(5) = 2; Need to find 2
            // val 2:in abcac how many a: 2
            // answer: 4

            //E.g.  2
            // 10 Leters
            // aba
            // aba aba aba a
            // answer: 7

            //Bruteforce
            /*
            var str = s;
            var length = s.Length;
            while(length <= 10)
            {
                str += str;
                length+=length;
            }
            str = str.Substring(0,Convert.ToInt32(n));
            then for loop and count a
            */ 
            #endregion
            int a = 0;
            int sLength = s.Length;
            if (!string.IsNullOrEmpty(s))
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'a')
                    {
                        a++;
                    }
                }
            }
            var occuranceEven = n / sLength;
            var finalCount = occuranceEven * a;
            var mod = n % sLength;
            a = 0;
            if (!string.IsNullOrEmpty(s))
            {
                for (int i = 0; i < mod; i++)
                {
                    if (s[i] == 'a')
                    {
                        a++;
                    }
                }
            }

            finalCount += a;

            return finalCount;
        }
    }
}