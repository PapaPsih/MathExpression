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
            SimpleMathExpession mathExpression = new SimpleMathExpession("12+13");
            Assert.AreEqual(25, mathExpression.Result());
        }

        [TestMethod]
        public void ResultMinus()
        {
            SimpleMathExpession mathExpression = new SimpleMathExpession("12-13");
            Assert.AreEqual(-1, mathExpression.Result());
        }

        [TestMethod]
        public void ResultMultiply()
        {
            SimpleMathExpession mathExpression = new SimpleMathExpession("12*11");
            Assert.AreEqual(132, mathExpression.Result());
        }

        [TestMethod]
        public void ResultDevide()
        {
            SimpleMathExpession mathExpression = new SimpleMathExpession("26/13");
            Assert.AreEqual(2, mathExpression.Result());
        }

        [TestMethod]
        public void ResultMultiOperation()
        {
            SimpleMathExpession mathExpression = new SimpleMathExpession("12+13-12");
            Assert.AreEqual(13, mathExpression.Result());
        }
    }
}
