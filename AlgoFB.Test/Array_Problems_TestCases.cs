using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class Array_Problems_TestCases
    {
        [TestMethod]
        public void Test_Array_Power_Set()
        {
            AlgoFB.AlgoProblem.Algo.Array_Power_Set<int>(new int[] { 1, 2, 3, 4 });
        }
    }
}
