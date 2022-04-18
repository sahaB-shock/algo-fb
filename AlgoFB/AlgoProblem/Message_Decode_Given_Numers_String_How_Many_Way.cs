using System;
using System.Linq;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static int NumDecodings(string A)
        {
            if (A[0] == '0')
                return 0;
            return Decode(A, A.Length);
        }

        private static int Decode(string A, int n)
        {
            if (n < 2)
                return 1;
            
            int[] dp = new int[n+1];
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                if (A[i - 1] > '0')
                {
                    dp[i] = dp[i - 1];
                }

                if (A[i - 2] == '1' || (A[i - 2] == '2' && A[i - 1] < '7'))
                {
                    dp[i] += dp[i - 2];
                }
            }

            return dp[n];
        }
        public static int Message_Decode_Given_Numers_String_How_Many_Way(string numericString)
        {
            return Help_To_Find_DecodeMessages(numericString.ToCharArray(), numericString.Length);
            //a b c d ......... z
            //1 2 3 4 ......... 26

            //Given 12
            //1. a b
            //2. l
            //Ans 2 way

            //Given 212
            //2(a) 1(b) 2(a)
            //21(m) 2(b)
            //2(b)  12(l)
            //Ans 3 way

            //Given 012
            //No letter with 0 or 01

            //2789
            //No two number as 27 is greater than 26.
            //Only option to go with 2 | 7 | 8 | 9

            //                           >>>>>>>>>>>>>>>
            //decode(abcde)  = decode(e) + decode(abcd) -- 1. by 1 numbers
            //               += decode(de) + decode(abc) -- 2. by 2 numbers




        }

        //1.                                            "1234"                     0
        private static int Help_To_Find_DecodeMessages(char[] numericString, int startPositionToFindWay)
        {
            if (startPositionToFindWay == 0 || startPositionToFindWay == 1)
                return 1;
            //1stcall         4                            4
            //2ndCall         4                            3
            
            
            //First call it should 0:
            //2nd call it should be 1:
            if (numericString[numericString.Length - startPositionToFindWay] == '0')
                /*|| !char.IsDigit(numericString[numericString.Length - startPositionToFindWay])*/
                return 0;
            
            var numWays = Help_To_Find_DecodeMessages(numericString, startPositionToFindWay - 1);

            if (
                    (numericString[startPositionToFindWay - 2] == '1'  || (numericString[startPositionToFindWay - 2] == '2')
                      && 
                      numericString[startPositionToFindWay - 1] < '7')
               )
            {
                numWays += Help_To_Find_DecodeMessages(numericString, startPositionToFindWay - 2);
            }
            return numWays;
        }
    }
}