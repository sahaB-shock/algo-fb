using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class Message_Decode_Test
    {
        [TestMethod]
        public void Message_Decode_Test_Only_Recursion()
        {
            var test = AlgoFB.AlgoProblem.Algo.NumDecodings("10");
        }
    }
}
