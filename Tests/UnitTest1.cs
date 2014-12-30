using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expression;

namespace MathExpressionTests
{
    [TestClass]
    public class CorrectExpression
    {
        [TestMethod]
        public void IsCorrectPlus()
        {
            Boolean correct = true;
            try
            {
                SimpleMathExpression mathExpression = new SimpleMathExpression("12+13");
            }
            catch
            {
                correct = false;
            }
            Assert.IsTrue(correct);
        }

        [TestMethod]
        public void IsCorrectMultiply()
        {
            Boolean correct = true;
            try
            {
                SimpleMathExpression mathExpression = new SimpleMathExpression("12*13");
            }
            catch
            {
                correct = false;
            }
            Assert.IsTrue(correct);
        }

        [TestMethod]
        public void IsCorrectMultiOperation()
        {
            Boolean correct = true;
            try
            {
                SimpleMathExpression mathExpression = new SimpleMathExpression("12+13-12");
            }
            catch
            {
                correct = false;
            }
            Assert.IsTrue(correct);
        }

        [TestMethod]
        public void IsCorrectWrongMultiOperation()
        {
            Boolean correct = true;
            try
            {
                SimpleMathExpression mathExpression = new SimpleMathExpression("12++13-12");
            }
            catch
            {
                correct = false;
            }
            Assert.IsFalse(correct);
        }

        [TestMethod]
        public void IsCorrectWrongExpression()
        {
            Boolean correct = true;
            try
            {
                SimpleMathExpression mathExpression = new SimpleMathExpression("12+");
            }
            catch
            {
                correct = false;
            }
            Assert.IsFalse(correct);
        }

        [TestMethod]
        public void IsCorrectWord()
        {
            Boolean correct = true;
            try
            {
                SimpleMathExpression mathExpression = new SimpleMathExpression("Hello");
            }
            catch
            {
                correct = false;
            }
            Assert.IsFalse(correct);
        }
    }
}
