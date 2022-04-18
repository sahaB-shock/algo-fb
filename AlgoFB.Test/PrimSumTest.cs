using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class PrimSumTest
    {
        [TestMethod]
        public void PrimSum_4()
        {
            MathProblem.MathTest.Find_Prime_Till_A_And_Sum(4);
        }

        [TestMethod]
        public void PrimSum_10()
        {
            var test = MathProblem.MathTest.Find_Prime_Till_A_And_Sum(10);
        }

    }
}
