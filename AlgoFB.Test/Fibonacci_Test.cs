using AlgoFB.MathProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class Fibonacci_Test
    {
        [TestMethod]
        public void Fibonacci_Nth_Test()
        {
            var nthFib = MathTest.Nth_Fibonacci_Number_Recursion_No_Dynamic_NO_Memorization(7);
            Assert.AreEqual(nthFib, 13);
        }

        [TestMethod]
        public void Fibonacci_Nth_Test_Recursion_DynamicP_Memorization()
        {
            var nthFib = MathTest.Nth_Fibonacci_Number_Dynamic_YES_Memorization(7);
            Assert.AreEqual(nthFib, 13);
        }


        [TestMethod]
        public void Fibonacci_Nth_Test_Array_DynamicP_Memorization()
        {
            var nthFib = MathTest.Nth_Fibonacci_Number_Array_Dynamic_Program(7);
            Assert.AreEqual(nthFib, 13);
        }

        [TestMethod]
        public void Nth_Fibonacci_Number_Dynamic_Program_Space_Optimization()
        {
            var nthFib = MathTest.Nth_Fibonacci_Number_Dynamic_Program_Space_Optimization(7);
            Assert.AreEqual(nthFib, 13);
        }
    }
}
