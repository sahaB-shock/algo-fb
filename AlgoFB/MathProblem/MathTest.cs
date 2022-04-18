using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoFB.MathProblem
{
    public static partial class MathTest
    {

        /// <summary>
        /// Finds the prime till a and sum.
        /// </summary>
        /// <param name="A">a.</param>
        /// <returns></returns>
        public static List<int> Find_Prime_Till_A_And_Sum(int A)
        {
            //1 is not prime

            //4   2,2 
            //10  3, 7 → 1,2,3... | 10, 10,9,7,6
            //14  1, 13 →1,2..... | 13

            List<int> twoPrimes = new List<int>();
            var allPrimes = GetAllPrimes(A);
            for (int i = 0, j = allPrimes.Count - 1; j > -1 && i < allPrimes.Count; i++, j--)
            {
                if (allPrimes[i] + allPrimes[j] == A)
                {
                    twoPrimes = new List<int>() { allPrimes[i], allPrimes[j] };
                }
            }


            return twoPrimes;
        }
        /// <summary>
        /// Verifies the prime.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public static bool VerifyPrime(int number, out int divisor)
        {            //1 not prime.
            //2 prime, 1,2
            //3 prime 1,3
            //11 prime 
            //13 prime
            //40 not prime.. 2
            //39 not prime.. 3
            //81 not prime √81 = 9
            //36 not prime √81 = 6

            //as soon as I reach by the √ sqrt of Number, if it's not prime it should be divided by √81 (or 9)

            //11*11 = 121 till 1 to 11 loop
            var isPrime = true;
            divisor = 1;///Not needed
            if (number / Math.Round(Math.Sqrt(number)) == Math.Round(Math.Sqrt(number)))
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    divisor = i;///Not needed
                    isPrime = false;
                    break;
                }

            }
            return isPrime;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number > i && number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> GetAllPrimes(int number)
        {
            List<int> primes = new List<int>();

            for (int i = 2; i <= number - 1; i++)
            {

                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        public static int[] GetAllPrime_Sieve_of_Eratosthenes(int number)
        {
            int[] primes = new int[number + 1];
            for (int i = 0; i <= number; i++)
            {
                primes[i] = 1;
            }
            primes[0] = 0;//number is 0 
            primes[1] = 0;//number is 1

            for (int i = 2; i <= number; i++)
            {
                if (primes[i] == 1)
                {
                    for (int j = 2; (i * j) <= number; i++)
                    {
                        primes[i * j] = 0;
                    }

                }
            }
            //Time complexcity O(n log log n) + O(n)


            return primes;
        }


    }
}
