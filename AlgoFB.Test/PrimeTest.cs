using AlgoFB.MathProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoFB.Test
{
    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void VerifyPrime_41()
        {
            int devisor;
            Assert.AreEqual(AlgoFB.MathProblem.MathTest.VerifyPrime(41, out devisor), true);
        }

        [TestMethod]
        public void VerifyPrime_1()
        {
            int devisor;
            Assert.AreEqual(AlgoFB.MathProblem.MathTest.VerifyPrime(1, out devisor), true);
        }

        [TestMethod]
        public void VerifyPrime_4()
        {
            int devisor;
            Assert.AreEqual(AlgoFB.MathProblem.MathTest.VerifyPrime(4, out devisor), false);
        }

        [TestMethod]
        public void VerifyPrime_1001()
        {
            int devisor;
            Assert.AreEqual(AlgoFB.MathProblem.MathTest.VerifyPrime(1001, out devisor), false);
        }


        [TestMethod]
        public void VerifyPrime_36()
        {
            int devisor;
            
            Assert.AreEqual(AlgoFB.MathProblem.MathTest.VerifyPrime(36, out devisor), false);
        }

        [TestMethod]
        public void VerifyPrime_2()
        {
            int devisor;
            Assert.AreEqual(AlgoFB.MathProblem.MathTest.VerifyPrime(2, out devisor), true);
        }

        [TestMethod]
        public void Find_Primes()
        {
            var test = MathTest.GetAllPrime_Sieve_of_Eratosthenes(15);
        }
    }
}
