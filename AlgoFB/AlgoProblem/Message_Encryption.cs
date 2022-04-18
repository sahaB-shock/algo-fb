using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        //https://www.hackerrank.com/challenges/encryption/problem
        public static string Message_Encryption(string s)
        {
            string result = "";
            s = s.Replace(" ", "");
            int row = (int)Math.Floor(Math.Sqrt(s.Length));
            int col = (int)Math.Ceiling(Math.Sqrt(s.Length));
            Console.Write($"row {row} col {col}");
            StringBuilder sb = new StringBuilder();
            //sb.Append(s[0]);
            for (int i = 0; i <= row; i++)
            {
                for (int j = i; j < s.Length; j += col)
                {
                    sb.Append(s[j]);
                }
                sb.Append(" ");
                Console.Write(sb.ToString());
            }

            return result;

        }
    }
}
