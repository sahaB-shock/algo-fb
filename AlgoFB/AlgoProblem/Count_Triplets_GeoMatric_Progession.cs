using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        //Count_Triplets_GeoMatric_Progession
        public static long CountTriplets_Count_Triplets_GeoMatric_Progession(List<long> arr, long r)
        {

            //Ref: https://www.youtube.com/watch?v=tBFZMaWP0W8
            // https://www.hackerrank.com/challenges/count-triplets-1/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
            long count = 0;
            Dictionary<long, long> right = new Dictionary<long, long>();
            Dictionary<long, long> left = new Dictionary<long, long>();


            foreach (var item in arr)
            {
                if (!right.ContainsKey(item))
                    right.Add(item, 1);
                else
                    right[item] += 1;
            }

            for (int i = 0; i < arr.Count; i++)
            {
                long rC = 0;
                long lC = 0;
                var midTerm = arr[i];
                //Decrease count of occurence of midTerm od arr[i] from right
                if (right.ContainsKey(midTerm))
                {
                    right[midTerm] -= 1;
                }

                if (left.ContainsKey(midTerm / r) && midTerm % r == 0)
                {
                    lC = left[midTerm / r];
                }

                if (right.ContainsKey(midTerm * r))
                {
                    rC = right[midTerm * r];
                }

                count += (lC * rC);

                //Add to left, what I removed from right
                if (!left.ContainsKey(midTerm))
                {
                    left.Add(midTerm, 1);
                }
                else
                {
                    left[midTerm] += 1;
                }
            }

            return count;
        }
    }
}
