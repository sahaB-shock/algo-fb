using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        /// <summary>
        /// Designers the PDF viewer.
        /// </summary>
        /// <param name="h">The h.</param>
        /// <param name="word">The word.</param>
        /// <returns></returns>
        public static int DesignerPdfViewer(int[] h, string word)
        {
            int maxHeight = h[((int)word[0] - 96) - 1];
            for (int i = 0; i < word.Length; i++)
            {
                int height = h[((int)word[i] - 96) -1]; //a-96 to z-122 
                if (height > maxHeight)
                {
                    maxHeight = height;
                }
            }
            return maxHeight * word.Length;
        }
    }
}
