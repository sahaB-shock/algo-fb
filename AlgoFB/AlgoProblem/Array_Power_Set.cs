using System;
using System.Collections.Generic;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static List<List<T>> Array_Power_Set<T>(T[] arr)
        {
            //ref: https://www.geeksforgeeks.org/finding-all-subsets-of-a-given-set-in-java/
            //video: https://www.youtube.com/watch?v=8xQXq5JLhEY
            //The total number of subsets of any given set is equal to 2^ (no. of elements in the set)
            List<List<T>> combinations = new List<List<T>>();
            var n = arr.Length;
            var test = (1 << n);
            var combination = Math.Pow(2, n);
            for (int i = 0; i < combination; i++)
            {
                Console.WriteLine("{ ");
                List<T> subSet = new List<T>();
                for (int j = 0; j < n; j++)
                {
                    // (1<<j) is a number with jth bit 1
                    // so when we 'and' them with the
                    // subset number we get which numbers
                    // are present in the subset and which
                    // are not
                    if ((i & (1 << j)) > 0)
                    {
                        Console.Write(arr[j] + " ");
                        subSet.Add(arr[j]);
                    }
                }
                Console.WriteLine(" }");
                combinations.Add(subSet);
            }

            return null;
        }
    }
}