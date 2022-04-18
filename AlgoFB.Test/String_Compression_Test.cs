using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class String_Compression_Single_Space_Test
    {
        [TestMethod]
        public void Test_String_Compression_Single_Space_1()
        {
            var res = AlgoFB.AlgoProblem.Algo.String_Compression_Single_Space("aabb    xx");
            Assert.AreEqual(res, "a2b2 x2");
        }

        [TestMethod]
        public void Test_String_Compression_Single_Space_2()
        {
            var res = AlgoFB.AlgoProblem.Algo.String_Compression_Single_Space("     ");
            Assert.AreEqual(res, " ");
        }

        [TestMethod]
        public void Test_String_Compression_Single_Space_2_5()
        {
            var res = AlgoFB.AlgoProblem.Algo.String_Compression_Single_Space("     ");
            Assert.AreEqual(res, "");
        }

        [TestMethod]
        public void Test_String_Compression_Single_Space_3()
        {
            var res = AlgoFB.AlgoProblem.Algo.String_Compression_Single_Space(null);
            Assert.AreEqual(res, string.Empty);
        }

        [TestMethod]
        public void Test_String_Compression_Single_Space_4()
        {
            var res = AlgoFB.AlgoProblem.Algo.String_Compression_Single_Space("1111111222");
            Assert.AreEqual(res, "1723");
        }

        [TestMethod]
        public void Test_String_Compression_Single_Space_5()
        {
            var res = AlgoFB.AlgoProblem.Algo.String_Compression_Single_Space("1111111222  *****``");
            Assert.AreEqual(res, "1723 *5`2");
        }
    }
}
