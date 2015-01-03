using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathExpression;

namespace MathExpressionTests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            PriorityConverter convert = new PriorityConverter(@"1+2*3");
            Assert.AreEqual("1+(2*3)", convert.Result());
        }
    }
}
