using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        /// <summary>Finds the first index in sentence.</summary>
        /// <param name="sentence">The sentence.</param>
        /// <param name="word">The word.</param>
        /// <returns></returns>
        ///     //Babinsahasah
        ///     //     sah sah
        ///     //012345
        ///     //5 is answer
        public static int FindFirstIndexInSentence(string sentence, string word)
        {
            int index = -1;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == word[0])
                {
                    for (int j = 1; j < word.Length; j++)
                    {
                        if (sentence[i + j] == word[j])
                        {
                            index = i;
                        }
                        else
                        {
                            index = -1;
                            break;
                        }
                    }
                }

                if (index > -1)
                    break;
            }

            return index;
        }
    }
}
