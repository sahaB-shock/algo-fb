using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        /*
        Ref: https://algorithms.tutorialhorizon.com/colorful-numbers/
        Facebook sol: https://github.com/lolapriego/coursework/blob/master/topic4_hashmaps/ColorfulNumber.java
        Interviewbit Problem: https://www.interviewbit.com/problems/colorful-number/

        When in a given number, product of every digit of a sub-sequence are different.   
            

        Given Number : 3245
        Output : Colorful
        Number 3245 can be broken into parts like 3 2 4 5 32 24 45 324 245.
        this number is a colorful number, since product of every digit of a sub-sequence are different.
        That is, 3 2 4 5 (3*2)=6 (2*4)=8 (4*5)=20, (3*2*4)= 24 (2*4*5)= 40

        Given Number : 326
        Output : Not Colorful.
        326 is not a colorful number as it generates 3 2 6 (3*2)=6 (2*6)=12.
        */
        public static int Colorful_Number(int number)
        {
            // First let's create a collection of all the digits that we need to evaluate
            // the product of.
            // In order to do this, I am going to put each of the digits in
            // an array
            int mod = 0;
            int remaining = number;
            List<int> digits = new List<int>();

            while (remaining > 0)
            {
                mod = remaining % 10;
                if (digits.Contains(mod))
                {
                    // this is to handle 99 or 233 as Not colorful number
                    return 0;
                }
                digits.Add(mod);
                remaining = remaining / 10;
            }

            // Now we want to iterate it in such a way that 1st we look at it individually.
            // Then by pairs, then by group of 3 ... up until digits.size().
            // Each time we will add it to a set.
            // Warning they are sorted in a reverse way, so we start iterating from
            // the end.
            HashSet<int> uniqueSumSubSequence = new HashSet<int>();
            int iGrouping = 1;
            while (iGrouping <= digits.Count)
            {
                for (int i = 0; i < digits.Count - 1; i++)
                {
                    if (i < digits.Count - iGrouping)
                    {

                        var sum = digits.Skip(i).Take(iGrouping + 1).Aggregate((x, y) => x * y);
                        if (!uniqueSumSubSequence.Contains(sum))
                        {
                            uniqueSumSubSequence.Add(sum);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (iGrouping == digits.Count)
                    {
                        //This is to handle 12 as no colorful number
                        if (uniqueSumSubSequence.Contains(digits[i]))
                        {
                            return 0;
                        }
                    }
                }


                //while 
                iGrouping++;
            }

            return 1;
        }

        /// <summary>
        /// Colorfuls the number fastest.
        /// </summary>
        /// <param name="given_number">a.</param>
        /// <returns></returns>
        public static int Colorful_Number_Fastest(int given_number)
        {
            //A = 3245
            //A = 5423
            var numberDetails = new HashSet<int>();
            var numberList = new List<int>();
            var result = 1;
            #region InterviewBit Code
            //var result = 1;
            //while (A > 0)
            //{
            //    var digit = A % 10;
            //    A = A / 10;
            //    numberList.Add(digit);
            //}

            //for (int i = 0; i < numberList.Count; i++)
            //{

            //    var number = numberList[i];
            //    if (numberDetails.Contains(number))
            //    {
            //        result = 0;
            //        break;
            //    }
            //    numberDetails.Add(number);
            //    for (int j = i + 1; j < numberList.Count; j++)
            //    {
            //        number = number * numberList[j];

            //        if (numberDetails.Contains(number))
            //        {
            //            result = 0;
            //            break;
            //        }
            //        numberDetails.Add(number);
            //    }
            //} 
            #endregion

            HashSet<int> uniqueProduct = new HashSet<int>();
            List<int> digits = new List<int>();
            var mod = 0;
            var remaining = given_number;
            while (remaining > 0)
            {
                mod = remaining % 10;
                if (uniqueProduct.Contains(mod))
                {
                    return 0;
                }
                uniqueProduct.Add(mod);


                digits.Add(mod);
                remaining = remaining / 10;
            }
            //i 0 → 5
            for (int i = 0; i < digits.Count; i++)
            {
                var product = digits[i];//5
                //i+1 (j) = 1 → 4
                for (int j = i + 1; j < digits.Count; j++)
                // j 1(4) j 2(2) j 3(3)
                {
                    product = product * digits[j];
                    if (uniqueProduct.Contains(product))
                    {
                        return 0;
                    }
                    uniqueProduct.Add(product);


                }
            }

            return result;
        }
    }
} 
