using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class Idential_Twin_Test
    {
        [TestMethod]
        public void MyTestMethod()
        {
            int[] arr1 = new int[] { 1, 3, 4, 5, 3 };
            var test = AlgoFB.AlgoProblem.Algo.FindIfIdenticalTwin(arr1, arr1);
        }
    }
}
