using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    static partial class Algo
    {
        /// <summary>
        /// OneEditApart("cat", "cstx"); --i
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool OneEditApart(string s1, string s2)
        {
            //cat            ca
            if (s1.Length > s2.Length)
            {
                var sTemp = s1;//cat
                s1 = s2;//s1=ca
                s2 = sTemp;//s2=cat
            }
            //str1 always shorter

            if (s2.Length - s1.Length > 1)
                return false;

            bool saw_difference = false;

            for (int i = 0, j = 0; i < s1.Length; i++, j++)
            {
                //at            //cat
                if (s1[i] != s2[j])
                {
                    if (saw_difference)
                        return false;
                    saw_difference = true;
                    if (s2.Length > s1.Length)
                    {
                        //--i;
                        i--;
                    }
                }



            }

            return saw_difference || s1.Length != s2.Length;
        }
    }
}
