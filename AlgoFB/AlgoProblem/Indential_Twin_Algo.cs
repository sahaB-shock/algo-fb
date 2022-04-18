using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static int[] FindIfIdenticalTwin(int[] ar1, int[] ar2)
        {
            List<int> similar = new List<int>();
            Dictionary<int, long> dic = new Dictionary<int, long>();
            for (int i = 0; i < ar1.Length; i++)
            {
                if (dic.ContainsKey(ar1[i]))
                {
                    dic[ar1[i]] += 1;
                }
                else
                {
                    dic.Add(ar1[i], 1);
                }
            }

            return null;
        }
    }
}
