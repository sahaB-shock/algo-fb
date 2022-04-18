using AlgoFB.AlgoProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class StringToIntConvertionTest
    {
        [TestMethod]
        public void String_int_Word_Trail()
        {
            var i = Algo.StringToIntegerConversion("4193 with words");
        }
        [TestMethod]
        public void String_int_Word_Negative_Max()
        {
            var i = Algo.StringToIntegerConversion("-91283472332");
        }
    }
}
