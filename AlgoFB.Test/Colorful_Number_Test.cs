using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class Colorful_Number_Test
    {
        
        [TestMethod]
        public void Colorfull_Number_Test_Valid_3245()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number(3245);
            Assert.AreEqual(color, 1);
        }

        [TestMethod]
        public void Colorfull_Number_Test_InValid_123()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number(123);
            Assert.AreEqual(color, 0);
        }

        [TestMethod]
        public void Colorfull_Number_Test_Base_Case_12()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number(12);
            Assert.AreEqual(color, 0);
        }

        [TestMethod]
        public void Colorfull_Number_Test_Base_Invalid_252()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number(252);
            Assert.AreEqual(color, 0);
        }

        [TestMethod]
        public void Colorfull_Number_Test_Base_Invalid_99()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number(99);
            Assert.AreEqual(color, 0);
        }
        [TestMethod]
        public void Colorfull_Number_Test_Base_Invalid_233()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number(233);
            Assert.AreEqual(color, 0);
        }






        [TestMethod]
        public void X_Colorfull_Number_Faster__Test_Valid_3245()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number_Fastest(3245);
            Assert.AreEqual(color, 1);
        }

        [TestMethod]
        public void X_Colorfull_Number_Faster__Test_InValid_123()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number_Fastest(123);
            Assert.AreEqual(color, 0);
        }

        [TestMethod]
        public void X_Colorfull_Number_Faster__Test_Base_Case_12()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number_Fastest(12);
            Assert.AreEqual(color, 0);
        }

        [TestMethod]
        public void X_Colorfull_Number_Faster__Test_Base_Invalid_252()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number_Fastest(252);
            Assert.AreEqual(color, 0);
        }

        [TestMethod]
        public void X_Colorfull_Number_Faster__Test_Base_Invalid_99()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number_Fastest(99);
            Assert.AreEqual(color, 0);
        }
        [TestMethod]
        public void X_Colorfull_Number_Faster__Test_Base_Invalid_233()
        {
            var color = AlgoFB.AlgoProblem.Algo.Colorful_Number_Fastest(233);
            Assert.AreEqual(color, 0);
        }
    }
}
