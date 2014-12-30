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
            SimpleMathExpession mathExpression = new SimpleMathExpession("12+13");
            Assert.IsTrue(mathExpression.IsCorrect());
        }

        [TestMethod]
        public void IsCorrectMinus()
        {
            SimpleMathExpession mathExpression = new SimpleMathExpession("12-13");
            Assert.IsTrue(mathExpression.IsCorrect());
        }

        [TestMethod]
        public void IsCorrectMultiply()
        {
            SimpleMathExpession mathExpression = new SimpleMathExpession("12*13");
            Assert.IsTrue(mathExpression.IsCorrect());
        }

        [TestMethod]
        public void IsCorrectDevide()
        {
            SimpleMathExpession mathExpression = new SimpleMathExpession("12/13");
            Assert.IsTrue(mathExpression.IsCorrect());
        }

        [TestMethod]
        public void IsCorrectMultiOperation()
        {
            SimpleMathExpession mathExpression = new SimpleMathExpession("12+13-12");
            Assert.IsTrue(mathExpression.IsCorrect());
        }

        [TestMethod]
        public void IsCorrectWrongMultiOperation()
        {
            SimpleMathExpession mathExpression = new SimpleMathExpession("12++13-12");
            Assert.IsFalse(mathExpression.IsCorrect());
        }

        [TestMethod]
        public void IsCorrectWrongExpression()
        {
            SimpleMathExpession mathExpression = new SimpleMathExpession("12+");
            Assert.IsFalse(mathExpression.IsCorrect());
        }

        [TestMethod]
        public void IsCorrectWord()
        {
            SimpleMathExpession mathExpression = new SimpleMathExpession("Hello");
            Assert.IsFalse(mathExpression.IsCorrect());
        }
    }
}
