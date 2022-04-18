using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.MathProblem
{
    public static partial class MathTest
    {
        //https://www.geeksforgeeks.org/program-for-nth-fibonacci-number/

        static int iFibbCounter = 0;
        /// <summary>
        /// Calculates the NTH fibonacci number.
        /// </summary>
        /// <param name="input">The n th number fibonacci</param>
        /// <returns></returns>
        public static int Nth_Fibonacci_Number_Recursion_No_Dynamic_NO_Memorization(int n)
        {
            //0 1 1 2 3 5 8 13 21 34
            //0 1 2 3 4 5 6 7  8  9
            //0th Fibonacci is 0
            //1st Fibonacci is 1
            //9th fibanacci is 34

            /*if (input == 0)
                return 0;
            if (input == 1)
                return 1;*/

            if (n <= 1)
                return n;
            else
            {
                /*iFibbCounter++;//Not needed
                               //var test is not required
                System.Diagnostics.Debug.WriteLine($"{iFibbCounter}. n={n} → (n-1){n - 1} + (n-2){n - 2}");

                var test = Calculate_Nth_Fibonacci_Number_Recursion_No_Dynamic_or_Memorization(n - 1) + Calculate_Nth_Fibonacci_Number_Recursion_No_Dynamic_or_Memorization(n - 2);//******

                System.Diagnostics.Debug.WriteLine($"{iFibbCounter}. n={n} → (n-1){n - 1} + (n-2){n - 2}   → {test}");

                return test;//not needed*/
                #region Output Print
                /*
                1. n=7 → (n-1)6 + (n-2)5
                2. n=6 → (n-1)5 + (n-2)4
                3. n=5 → (n-1)4 + (n-2)3
                4. n=4 → (n-1)3 + (n-2)2
                5. n=3 → (n-1)2 + (n-2)1
                6. n=2 → (n-1)1 + (n-2)0
                6. n=2 → (n-1)1 + (n-2)0   → 1
                6. n=3 → (n-1)2 + (n-2)1   → 2
                7. n=2 → (n-1)1 + (n-2)0
                7. n=2 → (n-1)1 + (n-2)0   → 1
                7. n=4 → (n-1)3 + (n-2)2   → 3
                8. n=3 → (n-1)2 + (n-2)1
                9. n=2 → (n-1)1 + (n-2)0
                9. n=2 → (n-1)1 + (n-2)0   → 1
                9. n=3 → (n-1)2 + (n-2)1   → 2
                9. n=5 → (n-1)4 + (n-2)3   → 5
                10. n=4 → (n-1)3 + (n-2)2
                11. n=3 → (n-1)2 + (n-2)1
                12. n=2 → (n-1)1 + (n-2)0
                12. n=2 → (n-1)1 + (n-2)0   → 1
                12. n=3 → (n-1)2 + (n-2)1   → 2
                13. n=2 → (n-1)1 + (n-2)0
                13. n=2 → (n-1)1 + (n-2)0   → 1
                13. n=4 → (n-1)3 + (n-2)2   → 3
                13. n=6 → (n-1)5 + (n-2)4   → 8
                14. n=5 → (n-1)4 + (n-2)3
                15. n=4 → (n-1)3 + (n-2)2
                16. n=3 → (n-1)2 + (n-2)1
                17. n=2 → (n-1)1 + (n-2)0
                17. n=2 → (n-1)1 + (n-2)0   → 1
                17. n=3 → (n-1)2 + (n-2)1   → 2
                18. n=2 → (n-1)1 + (n-2)0
                18. n=2 → (n-1)1 + (n-2)0   → 1
                18. n=4 → (n-1)3 + (n-2)2   → 3
                19. n=3 → (n-1)2 + (n-2)1
                20. n=2 → (n-1)1 + (n-2)0
                20. n=2 → (n-1)1 + (n-2)0   → 1
                20. n=3 → (n-1)2 + (n-2)1   → 2
                20. n=5 → (n-1)4 + (n-2)3   → 5
                20. n=7 → (n-1)6 + (n-2)5   → 13

                 
                 */
                #endregion


                return Nth_Fibonacci_Number_Recursion_No_Dynamic_NO_Memorization(n - 1) + Nth_Fibonacci_Number_Recursion_No_Dynamic_NO_Memorization(n - 2);//******
            }

        }

        static Dictionary<int, int> storage = new Dictionary<int, int>();

        /// <summary>
        /// Calculates the NTH fibonacci number dynamic or memorization.
        /// </summary>
        /// <param name="n">a.</param>
        /// <returns></returns>
        public static int Nth_Fibonacci_Number_Dynamic_YES_Memorization(int n)
        {
            if (n <= 1)
                return n;

            if (storage.ContainsKey(n))
                return storage[n];
            else
            {
                var result = Nth_Fibonacci_Number_Dynamic_YES_Memorization(n - 1)
                            + Nth_Fibonacci_Number_Dynamic_YES_Memorization(n - 2);
                System.Diagnostics.Debug.WriteLine($"{iFibbCounter}. n={n} → (n-1){n - 1} + (n-2){n - 2}   → {result}");
                #region Output
                /*
                1. n=2 → (n-1)1 + (n-2)0   → 1
                2. n=3 → (n-1)2 + (n-2)1   → 2
                3. n=4 → (n-1)3 + (n-2)2   → 3
                4. n=5 → (n-1)4 + (n-2)3   → 5
                5. n=6 → (n-1)5 + (n-2)4   → 8
                6. n=7 → (n-1)6 + (n-2)5   → 13
                 */
                #endregion
                storage[n] = result;
                return result;
            }
        }

        public static int Nth_Fibonacci_Number_Array_Dynamic_Program(int n)
        {
            int[] memo = new int[n + 2];
            memo[0] = 0;
            memo[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2];
                System.Diagnostics.Debug.Write(memo);
            }

            return memo[n];


            #region Explnation
            /*
                 when i = 2
            [0]: 0
            [1]: 1
          i [2]: 1
            [3]: 0
            [4]: 0
            [5]: 0
            [6]: 0
            [7]: 0
            [8]: 0

                 when i = 3
            [0]: 0
            [1]: 1
            [2]: 1
          i [3]: 2* memo[i or 3 -1 ] + memo [i or 3 -2] = memo[2] + memo[1] = 1 + 1 = 2
            [4]: 0
            [5]: 0
            [6]: 0
            [7]: 0
            [8]: 0

                 when i = 4
            [0]: 0
            [1]: 1
            [2]: 1
            [3]: 2
          i [4]: 3* memo[i or 4 -1 ]+ memo[i or 4 - 2] = memo[3] + memo[2] = 2 + 1 = 3 
            [5]: 0
            [6]: 0
            [7]: 0
            [8]: 0

                 when i = 2
            [0]: 0
            [1]: 1
            [2]: 1
            [3]: 0
            [4]: 0
            [5]: 0
            [6]: 0
            [7]: 0
            [8]: 0

                 */
            #endregion
        }
        public static int Nth_Fibonacci_Number_Dynamic_Program_Space_Optimization(int n)
        {
            //we are trying to avoid the use of memo from above soltion
            int firstFibo = 0;
            int secondFibo = 1;
            int previousFibo;
            for (int i = 2; i <= n; i++)
            {
                //i = 2 | previousFibo = 0 + 1 = 1
                //i = 3 | previousFibo = 1 + 1 = 2
                previousFibo = firstFibo + secondFibo;
                //i = 2 | firstFibo = 0 → 1
                //i = 2 | firstFibo = 1 → 1
                firstFibo = secondFibo;
                //i = 2 | secondFibo = 1 → 1
                //i = 2 | secondFibo = 1 → 2
                secondFibo = previousFibo;
            }

            return secondFibo;
        }
    }

}
