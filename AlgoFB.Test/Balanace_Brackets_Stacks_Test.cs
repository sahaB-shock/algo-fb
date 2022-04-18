using AlgoFB.AlgoProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class Balanace_Brackets_Stacks_Test
    {
        [TestMethod]
        public void Balanace_Brackets_Stacks_Test_No()
        {
            Algo.Balanace_Brackets_Stacks(@"{{)[](}}");
        }
    }
}
