using AlgoFB.DataStructure;
using System.Collections.Generic;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        //Ref: https://www.geeksforgeeks.org/check-for-balanced-parentheses-in-an-expression/
        static bool IsCounterPart(char a, char b)
        {
            if ((a == '(' && b == ')'))
            {
                return true;
            }
            if ((a == '{' && b == '}'))
            {
                return true;
            }
            if ((a == '[' && b == ']'))
            {
                return true;
            }

            return false;
        }
        public static string Balanace_Brackets_Stacks(string s)
        {
            if (s.Length % 2 != 0 || string.IsNullOrEmpty(s))
                return "NO";

            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                //[[({}())]]

                if (stack.Count > 0 && IsCounterPart(stack.Peek(), s[i]))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            if (stack.Count == 0)
                return "YES";
            else
                return "NO";
        }
    }
}