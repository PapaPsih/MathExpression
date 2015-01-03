using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expression;

namespace MathExpressionTests
{
    [TestClass]
    public class SimpleExpressionResult
    {
        [TestMethod]
        public void ResultPlus()
        {
            SimpleMathExpression mathExpression = new SimpleMathExpression("12+13");
            Assert.AreEqual(25, mathExpression.Result());
        }

        [TestMethod]
        public void ResultMinus()
        {
            SimpleMathExpression mathExpression = new SimpleMathExpression("12-13");
            Assert.AreEqual(-1, mathExpression.Result());
        }

        [TestMethod]
        public void ResultMultiply()
        {
            SimpleMathExpression mathExpression = new SimpleMathExpression("12*11");
            Assert.AreEqual(132, mathExpression.Result());
        }

        [TestMethod]
        public void ResultDevide()
        {
            SimpleMathExpression mathExpression = new SimpleMathExpression("26/13");
            Assert.AreEqual(2, mathExpression.Result());
        }

        [TestMethod]
        public void ResultMultiOperation()
        {
            SimpleMathExpression mathExpression = new SimpleMathExpression("12+13-12");
            Assert.AreEqual(13, mathExpression.Result());
        }

       // [TestMethod]
        public void ResultPreorityTest()
        {
            SimpleMathExpression mathExpression = new SimpleMathExpression("12+6*2-6/3");
            Assert.AreEqual(22, mathExpression.Result());
        }
    }
}
