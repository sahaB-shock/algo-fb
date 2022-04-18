using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoFB.DataStructure
{
    public static class TwoDimensionalArray
    {

        public static int[] ZigZagTowDimensionalArray(int[][] two_dimentional_array)
        {
            List<int> spiralArray = new List<int>();
            int[][] sampleArray = null;
            if (two_dimentional_array == null || two_dimentional_array.Length == 0)
            {
                sampleArray = new int[][] { new int[] { 1, 2, 3 },
                                            new int[] { 4, 5, 6 },
                                            new int[] { 7, 8, 9 },
                                            new int[] { 7, 8, 9 }
                                          };
            }
            two_dimentional_array = sampleArray;
            var rows = two_dimentional_array.Length;
            var colums = two_dimentional_array[0].Length;
            //int[][] equivalent of List<List<int>>
            //var two_dimentional_array = new List<List<int>>();
            //var test = two_dimentional_array.Select(x => x.ToArray()).ToArray();
            for (int i = 0; i < two_dimentional_array.Length; i++)
            {
                //var indesideArray = two_dimentional_array[i];
                for (int j = 0, rJ = two_dimentional_array[i].Length - 1;
                    j < two_dimentional_array[i].Length; j++, rJ--)
                {
                    if (i % 2 == 0)
                    {
                        //Console.WriteLine($" i → {i} | j → {j} → {two_dimentional_array[i][j]}");
                        spiralArray.Add(two_dimentional_array[i][j]);
                    }
                    else
                    {
                        //Console.WriteLine($" i → {i} | rJ → {rJ} → {two_dimentional_array[i][rJ]}");
                        spiralArray.Add(two_dimentional_array[i][rJ]);
                    }

                }
            }

            return spiralArray.ToArray();
        }
    }
}

